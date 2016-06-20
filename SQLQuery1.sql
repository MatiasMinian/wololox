-- Selecciona la base de datos
use GD1C2016

--Crea schema

BEGIN TRANSACTION

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'WOLOLOX')
EXEC sys.sp_executesql N'CREATE SCHEMA [WOLOLOX] AUTHORIZATION [gd]'

COMMIT

--Drop de tablas

if object_id('WOLOLOX.clientes') is not null
  drop table WOLOLOX.clientes;

if object_id('WOLOLOX.empresas') is not null
  drop table WOLOLOX.empresas;
  
if object_id('WOLOLOX.roles_usuarios') is not null
  drop table WOLOLOX.roles_usuarios;

if object_id('WOLOLOX.funcionalidades_roles') is not null
  drop table WOLOLOX.funcionalidades_roles;

if object_id('WOLOLOX.funcionalidades') is not null
  drop table WOLOLOX.funcionalidades;

if object_id('WOLOLOX.roles') is not null
  drop table WOLOLOX.roles;

if object_id('WOLOLOX.publicaciones_rubros') is not null
  drop table WOLOLOX.publicaciones_rubros;
  
if object_id('WOLOLOX.rubros') is not null
  drop table WOLOLOX.rubros;
 
if object_id('WOLOLOX.ofertas') is not null
  drop table WOLOLOX.ofertas;
  
if object_id('WOLOLOX.item_factura') is not null
  drop table WOLOLOX.item_factura;
  
if object_id('WOLOLOX.calificaciones') is not null
  drop table WOLOLOX.calificaciones;

if object_id('WOLOLOX.facturas') is not null
  drop table WOLOLOX.facturas;
  
if object_id('WOLOLOX.compras') is not null
  drop table WOLOLOX.compras;

if object_id('WOLOLOX.publicaciones') is not null
  drop table WOLOLOX.publicaciones;
  
if object_id('WOLOLOX.estados') is not null
  drop table WOLOLOX.estados;

if object_id('WOLOLOX.visibilidades') is not null
  drop table WOLOLOX.visibilidades;
  
if object_id('WOLOLOX.usuarios') is not null
  drop table WOLOLOX.usuarios;
  
if object_id('WOLOLOX.direcciones') is not null
  drop table WOLOLOX.direcciones;
  

--Creaci�n de tablas


create table WOLOLOX.direcciones(
id numeric(18,0) IDENTITY PRIMARY KEY,
calle nvarchar(100),
numero numeric(19,0),
piso numeric(18,0),
departamento nvarchar(50),
localidad nvarchar(100),
cod_postal nvarchar(50),
ciudad nvarchar(100)
) 

create table WOLOLOX.usuarios(
id_usuario numeric(18,0) IDENTITY PRIMARY KEY,
nombre_usuario nvarchar(25) UNIQUE,
contrase�a nvarchar(25),
intentos_login numeric(1,0) DEFAULT 0,
mail nvarchar(50),
telefono nvarchar(50),
id_direccion numeric(18,0) REFERENCES WOLOLOX.direcciones,
fecha_creacion datetime,
habilitado bit
)

create table WOLOLOX.roles(
id numeric(2,0) IDENTITY PRIMARY KEY,
nombre nvarchar(50),
estado bit
)

create table WOLOLOX.clientes(
id_usuario numeric(18,0) REFERENCES WOLOLOX.usuarios IDENTITY PRIMARY KEY,
dni numeric(18,0),
nombre nvarchar(255),
apellido nvarchar(255),
id_rol numeric(2,0) REFERENCES WOLOLOX.roles,
fecha_nacimiento datetime
)

create table WOLOLOX.rubros(
codigo numeric(18,0) IDENTITY PRIMARY KEY,
descripcion_corta nvarchar(20),
descripcion_larga nvarchar(255)
)

create table WOLOLOX.empresas(
id_usuario numeric(18,0) REFERENCES WOLOLOX.usuarios IDENTITY PRIMARY KEY,
razon_social nvarchar(255) UNIQUE,
cuit nvarchar(50),
nombre_contacto nvarchar(100),
cod_rubro numeric(18,0) REFERENCES WOLOLOX.rubros,
reputacion numeric(3,2)
)

create table WOLOLOX.roles_usuarios(
id_rol numeric(2,0) REFERENCES WOLOLOX.roles,
id_usuario numeric(18,0) REFERENCES WOLOLOX.usuarios
)

create table WOLOLOX.funcionalidades(
id numeric(2,0) IDENTITY PRIMARY KEY,
nombre nvarchar(50)
)

create table WOLOLOX.funcionalidades_roles(
id_funcionalidad numeric(2,0) REFERENCES WOLOLOX.funcionalidades,
id_rol numeric(2,0) REFERENCES WOLOLOX.roles
)

create table WOLOLOX.estados(
id_estado numeric(18,0) IDENTITY PRIMARY KEY,
descripcion_estado nvarchar(255)
)

create table WOLOLOX.visibilidades(
codigo numeric(18,0) IDENTITY PRIMARY KEY,
descripcion nvarchar(255),
porc_envio numeric(18,0),
porc_producto numeric(18,0),
porc_publicacion numeric(18,0),
costo numeric(18,0),
habilitada BIT DEFAULT 1
)

create table WOLOLOX.publicaciones(
codigo numeric(18,0) IDENTITY PRIMARY KEY,
id_usuario numeric(18,0) REFERENCES WOLOLOX.usuarios,
id_estado numeric(18,0) REFERENCES WOLOLOX.estados,
cod_visibilidad numeric(18,0) REFERENCES WOLOLOX.visibilidades,
fecha_inicio datetime,
fecha_vencimiento datetime,
descripcion nvarchar (255),
stock numeric(18,0),
precio numeric(18,0),
tipo nvarchar(255)
)

create table WOLOLOX.publicaciones_rubros(
cod_publicacion numeric(18,0) REFERENCES WOLOLOX.publicaciones,
cod_rubro numeric(18,0) REFERENCES WOLOLOX.rubros
)

create table WOLOLOX.ofertas(
codigo numeric(18,0) IDENTITY PRIMARY KEY,
id_usuario numeric(18,0) REFERENCES WOLOLOX.usuarios,
cod_publicacion numeric(18,0) REFERENCES WOLOLOX.publicaciones,
fecha datetime,
monto numeric(18,2)
)

create table WOLOLOX.compras(
id_compra numeric(18,0) IDENTITY PRIMARY KEY,
cantidad numeric(18,0),
fecha datetime,
cod_publicacion numeric(18,0) REFERENCES WOLOLOX.publicaciones,
id_usuario numeric(18,0) REFERENCES WOLOLOX.usuarios
)


create table WOLOLOX.facturas(
nro_fact numeric(18,0) PRIMARY KEY,
tipo nvarchar(1),
id_compra numeric(18,0) REFERENCES WOLOLOX.compras,
id_publicacion numeric(18,0) REFERENCES WOLOLOX.publicaciones,
fecha datetime,
total numeric(18,2),
forma_pago nvarchar(255)
)

create table WOLOLOX.item_factura(
id_item numeric(18,0) IDENTITY PRIMARY KEY,
nro_fact numeric(18,0) REFERENCES WOLOLOX.facturas,
tipo_fact nvarchar(1),
monto numeric(18,2),
descripcion nvarchar(255),
cantidad numeric(18,0)
)

create table WOLOLOX.calificaciones(
id_calificacion numeric(18,0) IDENTITY PRIMARY KEY,
cod_compra numeric(18,0) REFERENCES WOLOLOX.compras,
estrellas numeric(18,0),
detalle nvarchar(255)
)


--Migraciones

insert into WOLOLOX.clientes (dni,apellido,nombre,fecha_nacimiento)
select distinct Publ_Cli_Dni, Publ_Cli_Apeliido,Publ_Cli_Nombre,Publ_Cli_Fecha_Nac from gd_esquema.Maestra;

insert into WOLOLOX.usuarios (mail)
select distinct Publ_Cli_Mail from gd_esquema.Maestra;

insert into WOLOLOX.usuarios (mail,fecha_creacion)
select distinct Publ_Empresa_Mail,Publ_Empresa_Fecha_Creacion from gd_esquema.Maestra;

insert into WOLOLOX.direcciones(calle,numero,piso,departamento,cod_postal)
select distinct Cli_Dom_Calle, Cli_Nro_Calle,Cli_Piso,Cli_Depto,Cli_Cod_Postal from gd_esquema.Maestra;

insert into WOLOLOX.direcciones(calle,numero,piso,departamento,cod_postal)
select distinct Publ_Empresa_Dom_Calle, Publ_Empresa_Nro_Calle,Publ_Empresa_Piso,Publ_Empresa_Depto,Publ_Empresa_Cod_Postal from gd_esquema.Maestra;

insert into WOLOLOX.empresas(razon_social,cuit)
select distinct Publ_Empresa_Razon_Social,Publ_Empresa_Cuit from gd_esquema.Maestra;

insert into WOLOLOX.publicaciones(codigo,descripcion,precio,stock,tipo,cod_visibilidad)
select distinct Publicacion_Cod,Publicacion_Descripcion,Publicacion_Precio,Publicacion_Stock,Publicacion_Tipo,Publicacion_Visibilidad_Cod from gd_esquema.Maestra;

insert into WOLOLOX.estados(fecha_inicio,fecha_vencimiento)
select distinct Publicacion_Fecha,Publicacion_Fecha_Venc from gd_esquema.Maestra;

insert into WOLOLOX.rubros(descripcion_larga)
select distinct Publicacion_Rubro_Descripcion from gd_esquema.Maestra;

insert into WOLOLOX.publicaciones_rubros(cod_publicacion)
select distinct Publicacion_Cod from gd_esquema.Maestra;

insert into WOLOLOX.visibilidades(codigo,descripcion,porc_publicacion,costo)
select distinct Publicacion_Visibilidad_Cod,Publicacion_Visibilidad_Desc,Publicacion_Visibilidad_Porcentaje,Publicacion_Visibilidad_Precio from gd_esquema.Maestra;

insert into WOLOLOX.compras(cantidad,fecha,cod_publicacion)
select distinct Compra_Cantidad,Compra_Fecha,Publicacion_Cod from gd_esquema.Maestra;

insert into WOLOLOX.ofertas(fecha,monto,cod_publicacion)
select distinct Oferta_Fecha,Oferta_Monto,Publicacion_Cod from gd_esquema.Maestra;

insert into WOLOLOX.calificaciones(id_calificacion,estrellas,detalle)
select distinct Calificacion_Codigo,Calificacion_Cant_Estrellas,Calificacion_Descripcion from gd_esquema.Maestra;

insert into WOLOLOX.item_factura(cantidad,monto,nro_fact)
select distinct Item_Factura_Cantidad,Item_Factura_Monto,Factura_Nro from gd_esquema.Maestra;

insert into WOLOLOX.facturas(nro_fact,fecha,total,forma_pago,id_publicacion)
select distinct Factura_Nro,Factura_Fecha,Factura_Total,Forma_Pago_Desc,Publicacion_Cod from gd_esquema.Maestra;

--Triggers y Procedures


--Visibilidad

IF OBJECT_ID('WOLOLOX.CrearVisibilidad') IS NOT NULL
    DROP PROCEDURE WOLOLOX.CrearVisibilidad;
GO
CREATE PROCEDURE WOLOLOX.CrearVisibilidad(@descripcion nvarchar(255),@porc_envio numeric(18,0),@porc_producto numeric(18,0),@porc_publicacion numeric(18,0),@costo numeric(18,0))
AS
     
    INSERT INTO WOLOLOX.visibilidades(descripcion,porc_envio,porc_producto,porc_publicacion,costo)
	VALUES	(@descripcion,@porc_envio,@porc_producto,@porc_publicacion,@costo)
GO

/* Deshabilita la visibilidad para que no pueda ser elegida en publicaciones */

IF OBJECT_ID('WOLOLOX.EliminarVisibilidad') IS NOT NULL
    DROP PROCEDURE WOLOLOX.EliminarVisibilidad;
GO
CREATE PROCEDURE WOLOLOX.EliminarVisibilidad(@codigo numeric(18,0))
AS

    UPDATE WOLOLOX.visibilidades
	SET habilitada = 0
	WHERE @codigo = codigo
GO


IF OBJECT_ID('WOLOLOX.ModificarVisibilidad') IS NOT NULL
    DROP PROCEDURE WOLOLOX.ModificarVisibilidad;
GO
CREATE PROCEDURE WOLOLOX.ModificarVisibilidad(@codigo numeric(18,0),@descripcion nvarchar(255),@porc_envio numeric(18,0),@porc_producto numeric(18,0),@porc_publicacion numeric(18,0),@costo numeric(18,0))
AS

    UPDATE WOLOLOX.visibilidades
	SET   descripcion = @descripcion,porc_envio = @porc_envio, porc_producto = @porc_producto, porc_publicacion = @porc_publicacion, costo = @costo
	WHERE @codigo = codigo
GO


IF OBJECT_ID('WOLOLOX.BusquedaPorDescripcion') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BusquedaPorDescripcion;
GO
CREATE PROCEDURE WOLOLOX.BusquedaPorDescripcion(@descripcionIngresada nvarchar(255))
AS
    SELECT codigo,descripcion,porc_envio,porc_producto,porc_publicacion,costo,habilitada FROM WOLOLOX.visibilidades
	WHERE descripcion LIKE '%'+@descripcionIngresada+'%' AND habilitada = 1
GO

IF OBJECT_ID('WOLOLOX.BusquedaPorCostos') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BusquedaPorCostos;
GO
CREATE PROCEDURE WOLOLOX.BusquedaPorCostos(@costoMinimo numeric(18,0),@costoMaximo numeric(18,0))
AS
    SELECT codigo,descripcion,porc_envio,porc_producto,porc_publicacion,costo,habilitada FROM WOLOLOX.visibilidades
	WHERE (costo>=@costoMinimo AND costo<=@costoMaximo) AND habilitada = 1
GO


IF OBJECT_ID('WOLOLOX.BusquedaPorDescripcionYcostos') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BusquedaPorDescripcionYcostos;
GO
CREATE PROCEDURE WOLOLOX.BusquedaPorDescripcionYcostos(@descripcionIngresada nvarchar(255),@costoMinimo numeric(18,0),@costoMaximo numeric(18,0))
AS
    SELECT codigo,descripcion,porc_envio,porc_producto,porc_publicacion,costo,habilitada FROM WOLOLOX.visibilidades
	WHERE descripcion LIKE '%'+@descripcionIngresada+'%' AND (costo>=@costoMinimo AND costo<=@costoMaximo) AND habilitada = 1
	
GO

--Login

CREATE PROCEDURE WOLOLOX.login(@UserName nvarchar(50), @Password nvarchar(25))
AS
DECLARE @estado int

if exists(select * from WOLOLOX.usuarios where nombre_usuario=@UserName and contrase�a=@Password and habilitado=1)
	   set @estado=1
else if exists (select * from WOLOLOX.usuarios where nombre_usuario=@UserName and habilitado=0)
       set @estado=2
else
	   set @estado=0
	   update WOLOLOX.usuarios
	   set intentos_login = intentos_login + 1
	   where nombre_usuario=@UserName
select @estado

GO

--consulta de ID

IF OBJECT_ID('WOLOLOX.consultaID') IS NOT NULL
   DROP PROCEDURE WOLOLOX.consultaID;

GO

CREATE PROCEDURE WOLOLOX.consultaID(@user nvarchar(50))
AS
SELECT id_usuario FROM WOLOLOX.usuarios
WHERE @user = nombre_usuario

GO

--Calificaciones

IF OBJECT_ID('WOLOLOX.BuscarPublicacionesAcalificar') IS NOT NULL
   DROP PROCEDURE WOLOLOX.BuscarPublicacionesAcalificar;
GO
CREATE PROCEDURE WOLOLOX.BuscarPublicacionesAcalificar(@id_usuario numeric(18,0))
AS
  
SELECT comprasAcalificar.id_compra,comprasAcalificar.descripcion,comprasAcalificar.tipo,comprasAcalificar.precio,comprasAcalificar.cantidad,comprasAcalificar.id_usuario,usuarios.nombre_usuario
FROM (SELECT compras.id_compra,publicaciones.descripcion,publicaciones.tipo,publicaciones.precio,compras.cantidad,publicaciones.id_usuario
      FROM WOLOLOX.usuarios INNER JOIN WOLOLOX.compras 
	  ON compras.id_usuario = usuarios.id_usuario 
	  INNER JOIN WOLOLOX.publicaciones
	  ON compras.cod_publicacion = publicaciones.codigo 
	  WHERE @id_usuario = usuarios.id_usuario AND (compras.id_compra NOT IN (SELECT calificaciones.cod_compra FROM WOLOLOX.calificaciones)))
	  AS comprasAcalificar ,WOLOLOX.usuarios
WHERE usuarios.id_usuario = comprasAcalificar.id_usuario

GO

IF OBJECT_ID('WOLOLOX.comprasOrdenadasPorEstrellas') IS NOT NULL
   DROP PROCEDURE WOLOLOX.comprasOrdenadasPorEstrellas;
GO
CREATE PROCEDURE WOLOLOX.comprasOrdenadasPorEstrellas(@id_usuario numeric(18,0))
AS
  
    SELECT id_compra,cantidad,fecha,descripcion,estrellas,usuarios.nombre_usuario
  FROM WOLOLOX.compras
  INNER JOIN WOLOLOX.publicaciones
  ON compras.cod_publicacion = publicaciones.codigo
  INNER JOIN WOLOLOX.calificaciones
  ON compras.id_compra = calificaciones.cod_compra
  INNER JOIN WOLOLOX.usuarios
  ON publicaciones.id_usuario = usuarios.id_usuario
  WHERE compras.id_usuario = @id_usuario
  ORDER BY estrellas ASC
   
GO

IF OBJECT_ID('WOLOLOX.ultimas5comprasCalificadas') IS NOT NULL
   DROP PROCEDURE WOLOLOX.ultimas5comprasCalificadas;
GO
CREATE PROCEDURE WOLOLOX.ultimas5comprasCalificadas(@id_usuario numeric(18,0))
AS
  
    SELECT TOP 5 id_compra,cantidad,fecha,descripcion,estrellas,usuarios.nombre_usuario
  FROM WOLOLOX.compras
  INNER JOIN WOLOLOX.publicaciones
  ON compras.cod_publicacion = publicaciones.codigo
  INNER JOIN WOLOLOX.calificaciones
  ON compras.id_compra = calificaciones.cod_compra
  INNER JOIN WOLOLOX.usuarios
  ON publicaciones.id_usuario = usuarios.id_usuario
  WHERE compras.id_usuario = @id_usuario
  ORDER BY id_calificacion DESC
   
--Comprar/Ofertar

GO

IF OBJECT_ID('WOLOLOX.buscarPublicacionPorDescripcion') IS NOT NULL
   DROP PROCEDURE WOLOLOX.buscarPublicacionesPorDescripcion;
GO

CREATE PROCEDURE WOLOLOX.buscarPublicacionesPorDescripcion(@descripcion nvarchar(255),@id numeric(18,0))
AS

SELECT publicaciones.codigo,publicaciones.descripcion,precio,stock,tipo,visibilidades.descripcion,nombre_usuario
FROM WOLOLOX.publicaciones
INNER JOIN WOLOLOX.usuarios
ON publicaciones.id_usuario = usuarios.id_usuario
INNER JOIN visibilidades
ON publicaciones.cod_visibilidad = visibilidades.codigo
INNER JOIN WOLOLOX.estados
ON publicaciones.id_estado = estados.id_estado
WHERE publicaciones.descripcion LIKE '%'+@descripcion+'%' AND estados.descripcion_estado = 'Activa' AND @id <> publicaciones.id_usuario
ORDER BY visibilidades.costo DESC

GO

IF OBJECT_ID('WOLOLOX.buscarPublicacionesPorRubros') IS NOT NULL
   DROP PROCEDURE WOLOLOX.buscarPublicacionesPorRubros;
GO

CREATE PROCEDURE WOLOLOX.buscarPublicacionesPorRubros(@rubro nvarchar(20),@id numeric(18,0))
AS
  SELECT publicaciones.codigo,publicaciones.descripcion,precio,stock,tipo,visibilidades.descripcion,nombre_usuario
FROM WOLOLOX.publicaciones
INNER JOIN WOLOLOX.usuarios
ON publicaciones.id_usuario = usuarios.id_usuario
INNER JOIN visibilidades
ON publicaciones.cod_visibilidad = visibilidades.codigo
INNER JOIN WOLOLOX.estados
ON publicaciones.id_estado = estados.id_estado
INNER JOIN WOLOLOX.publicaciones_rubros
ON publicaciones.codigo = publicaciones_rubros.cod_publicacion
INNER JOIN WOLOLOX.rubros
ON rubros.codigo = publicaciones_rubros.cod_rubro

WHERE rubros.descripcion_corta = @rubro AND estados.descripcion_estado = 'Activa' AND @id <> publicaciones.id_usuario
ORDER BY visibilidades.costo DESC

GO

IF OBJECT_ID('WOLOLOX.buscarPublicacionesPorRubrosYdescripcion') IS NOT NULL
   DROP PROCEDURE WOLOLOX.buscarPublicacionesPorRubrosYdescripcion;
GO

CREATE PROCEDURE WOLOLOX.buscarPublicacionesPorRubrosYdescripcion(@rubro nvarchar(20),@descripcion nvarchar(255),@id numeric(18,0))
AS
  SELECT publicaciones.codigo,publicaciones.descripcion,precio,stock,tipo,visibilidades.descripcion,nombre_usuario
FROM WOLOLOX.publicaciones
INNER JOIN WOLOLOX.usuarios
ON publicaciones.id_usuario = usuarios.id_usuario
INNER JOIN WOLOLOX.visibilidades
ON publicaciones.cod_visibilidad = visibilidades.codigo
INNER JOIN WOLOLOX.estados
ON publicaciones.id_estado = estados.id_estado
INNER JOIN WOLOLOX.publicaciones_rubros
ON publicaciones.codigo = publicaciones_rubros.cod_publicacion
INNER JOIN WOLOLOX.rubros
ON rubros.codigo = publicaciones_rubros.cod_rubro
WHERE rubros.descripcion_corta = @rubro AND estados.descripcion_estado = 'Activa' AND publicaciones.descripcion LIKE '%'+@descripcion+'%' AND @id <> publicaciones.id_usuario
ORDER BY visibilidades.costo DESC

GO

--Historial cliente

IF OBJECT_ID('WOLOLOX.busquedaDeComprasYsubastas') IS NOT NULL
   DROP PROCEDURE WOLOLOX.busquedaDeComprasYsubastas;
GO
  CREATE PROCEDURE WOLOLOX.busquedaDeComprasYsubastas(@id numeric(18,0))
AS

(SELECT compras.id_compra AS codigo,publicaciones.descripcion,compras.cantidad,publicaciones.precio,publicaciones.tipo,compras.fecha,calificaciones.estrellas,usuarios.nombre_usuario
FROM WOLOLOX.compras
INNER JOIN WOLOLOX.publicaciones
ON compras.cod_publicacion = publicaciones.codigo
INNER JOIN WOLOLOX.calificaciones
ON calificaciones.cod_compra = compras.id_compra
INNER JOIN WOLOLOX.usuarios
ON publicaciones.id_usuario = usuarios.id_usuario
WHERE compras.id_usuario = @id
UNION
SELECT DISTINCT ofertas.codigo,publicaciones.descripcion,publicaciones.stock,ofertas.monto,publicaciones.tipo,ofertas.fecha,null,usuarios.nombre_usuario
FROM WOLOLOX.ofertas
INNER JOIN WOLOLOX.publicaciones
ON publicaciones.codigo = ofertas.cod_publicacion
INNER JOIN WOLOLOX.usuarios
ON usuarios.id_usuario = publicaciones.id_usuario
WHERE ofertas.id_usuario = @id)
ORDER BY publicaciones.tipo ASC

GO
IF OBJECT_ID('WOLOLOX.cantidadDePublicacionesUsuario') IS NOT NULL
   DROP PROCEDURE WOLOLOX.cantidadDePublicacionesUsuario;
GO
  CREATE PROCEDURE WOLOLOX.cantidadDePublicacionesUsuario(@idUser numeric(18,0))
AS
DECLARE @cantidadCompras int

set @cantidadCompras = (SELECT COUNT(*) FROM WOLOLOX.publicaciones WHERE publicaciones.id_usuario = @idUser)

SELECT @cantidadCompras
GO

IF OBJECT_ID('WOLOLOX.consultaIDpublIngresada') IS NOT NULL
   DROP PROCEDURE WOLOLOX.consultaIDpublIngresada;
GO
  CREATE PROCEDURE WOLOLOX.consultaIDpublIngresada
AS
DECLARE @id int
set @id =(SELECT TOP 1 publicaciones.codigo FROM WOLOLOX.publicaciones ORDER BY publicaciones.codigo DESC)
SELECT @id


GO
IF OBJECT_ID('WOLOLOX.consultaIDrubro') IS NOT NULL
   DROP PROCEDURE WOLOLOX.consultaIDrubro;
GO
  CREATE PROCEDURE WOLOLOX.consultaIDrubro(@rubro nvarchar(20))
AS
DECLARE @idrubro int
set @idrubro = (SELECT rubros.codigo FROM WOLOLOX.rubros WHERE rubros.descripcion_corta = @rubro)
SELECT @idrubro

GO

IF OBJECT_ID('WOLOLOX.consultaIDvisibilidad') IS NOT NULL
   DROP PROCEDURE WOLOLOX.consultaIDvisibilidad;
GO
  CREATE PROCEDURE WOLOLOX.consultaIDvisibilidad(@visi nvarchar(255))
AS
DECLARE @idvisi int
set @idvisi=(SELECT visibilidades.codigo FROM WOLOLOX.visibilidades WHERE visibilidades.descripcion = @visi)
SELECT @idvisi


GO
IF OBJECT_ID('WOLOLOX.consultaIDestado') IS NOT NULL
   DROP PROCEDURE WOLOLOX.consultaIDestado;
GO
  CREATE PROCEDURE WOLOLOX.consultaIDestado(@estado nvarchar(255))
AS
DECLARE @idestado int
SET @idestado =(SELECT estados.id_estado FROM WOLOLOX.estados WHERE estados.descripcion_estado = @estado)

SELECT @idestado

GO
IF OBJECT_ID('WOLOLOX.consultaIDestado') IS NOT NULL
   DROP PROCEDURE WOLOLOX.consultaIDestado;
GO
  CREATE PROCEDURE WOLOLOX.consultaIDestado(@estado nvarchar(255))
AS
DECLARE @idestado int
SET @idestado =(SELECT estados.id_estado FROM WOLOLOX.estados WHERE estados.descripcion_estado = @estado)

SELECT @idestado


GO
----Listado estad�stico

IF OBJECT_ID('WOLOLOX.vendedoresProductosNoVendidos1Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresProductosNoVendidos1Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresProductosNoVendidos1Trimestre(@anio nvarchar(4) ,@visi nvarchar(255))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(publicaciones.stock) AS cant_no_vendidos FROM WOLOLOX.publicaciones 
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario 
INNER JOIN WOLOLOX.visibilidades ON visibilidades.codigo = publicaciones.cod_visibilidad
AND visibilidades.descripcion = @visi 
AND publicaciones.fecha_inicio BETWEEN @anio+'/1/1' AND @anio+'/3/31'
AND publicaciones.fecha_vencimiento BETWEEN @anio+'/1/1' AND @anio+'/3/31'
AND publicaciones.codigo NOT IN (SELECT compras.cod_publicacion FROM WOLOLOX.compras
WHERE compras.fecha BETWEEN @anio+'/1/1' AND @anio+'/3/31')
GROUP BY usuarios.nombre_usuario
ORDER BY cant_no_vendidos DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresProductosNoVendidos2Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresProductosNoVendidos2Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresProductosNoVendidos2Trimestre(@anio nvarchar(4) ,@visi nvarchar(255))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(publicaciones.stock) AS cant_no_vendidos FROM WOLOLOX.publicaciones 
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario 
INNER JOIN WOLOLOX.visibilidades ON visibilidades.codigo = publicaciones.cod_visibilidad 
AND visibilidades.descripcion = @visi 
AND publicaciones.fecha_inicio BETWEEN @anio+'/4/1' AND @anio+'/6/30'
AND publicaciones.fecha_vencimiento BETWEEN @anio+'/4/1' AND @anio+'/6/30'
AND publicaciones.codigo NOT IN (SELECT compras.cod_publicacion FROM WOLOLOX.compras
WHERE compras.fecha BETWEEN @anio+'/4/1' AND @anio+'/6/30')
GROUP BY usuarios.nombre_usuario
ORDER BY cant_no_vendidos DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresProductosNoVendidos3Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresProductosNoVendidos3Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresProductosNoVendidos3Trimestre(@anio nvarchar(4) ,@visi nvarchar(255))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(publicaciones.stock) AS cant_no_vendidos FROM WOLOLOX.publicaciones 
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario 
INNER JOIN WOLOLOX.visibilidades ON visibilidades.codigo = publicaciones.cod_visibilidad 
AND visibilidades.descripcion = @visi 
AND publicaciones.fecha_inicio BETWEEN @anio+'/7/1' AND @anio+'/9/30'
AND publicaciones.fecha_vencimiento BETWEEN @anio+'/7/1' AND @anio+'/9/30'
AND publicaciones.codigo NOT IN (SELECT compras.cod_publicacion FROM WOLOLOX.compras
WHERE compras.fecha BETWEEN @anio+'/7/1' AND @anio+'/9/30')
GROUP BY usuarios.nombre_usuario
ORDER BY cant_no_vendidos DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresProductosNoVendidos4Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresProductosNoVendidos4Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresProductosNoVendidos4Trimestre(@anio nvarchar(4) ,@visi nvarchar(255))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(publicaciones.stock) AS cant_no_vendidos FROM WOLOLOX.publicaciones 
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario 
INNER JOIN WOLOLOX.visibilidades ON visibilidades.codigo = publicaciones.cod_visibilidad
AND visibilidades.descripcion = @visi 
AND publicaciones.fecha_inicio BETWEEN @anio+'/10/1' AND @anio+'/12/31'
AND publicaciones.fecha_vencimiento BETWEEN @anio+'/10/1' AND @anio+'/12/31'
AND publicaciones.codigo NOT IN (SELECT compras.cod_publicacion FROM WOLOLOX.compras
WHERE compras.fecha BETWEEN @anio+'/10/1' AND @anio+'/12/31')
GROUP BY usuarios.nombre_usuario
ORDER BY cant_no_vendidos DESC

GO

IF OBJECT_ID('WOLOLOX.clienteMayorCantCompras1Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.clienteMayorCantCompras1Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.clienteMayorCantCompras1Trimestre(@anio nvarchar(4) ,@rubro nvarchar(20))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(compras.cantidad) AS cant_compras FROM WOLOLOX.compras
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = compras.id_usuario
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = compras.cod_publicacion
INNER JOIN WOLOLOX.publicaciones_rubros ON publicaciones_rubros.cod_publicacion = publicaciones.codigo
INNER JOIN WOLOLOX.rubros ON publicaciones_rubros.cod_rubro = rubros.codigo
WHERE compras.fecha BETWEEN @anio+'/1/1' AND @anio+'/3/31' AND rubros.descripcion_corta = @rubro
GROUP BY usuarios.nombre_usuario
ORDER BY cant_compras DESC

GO

IF OBJECT_ID('WOLOLOX.clienteMayorCantCompras2Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.clienteMayorCantCompras2Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.clienteMayorCantCompras2Trimestre(@anio nvarchar(4) ,@rubro nvarchar(20))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(compras.cantidad) AS cant_compras FROM WOLOLOX.compras
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = compras.id_usuario
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = compras.cod_publicacion
INNER JOIN WOLOLOX.publicaciones_rubros ON publicaciones_rubros.cod_publicacion = publicaciones.codigo
INNER JOIN WOLOLOX.rubros ON publicaciones_rubros.cod_rubro = rubros.codigo
WHERE compras.fecha BETWEEN @anio+'/4/1' AND @anio+'/6/30' AND rubros.descripcion_corta = @rubro
GROUP BY usuarios.nombre_usuario
ORDER BY cant_compras DESC

GO

IF OBJECT_ID('WOLOLOX.clienteMayorCantCompras3Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.clienteMayorCantCompras3Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.clienteMayorCantCompras3Trimestre(@anio nvarchar(4) ,@rubro nvarchar(20))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(compras.cantidad) AS cant_compras FROM WOLOLOX.compras
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = compras.id_usuario
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = compras.cod_publicacion
INNER JOIN WOLOLOX.publicaciones_rubros ON publicaciones_rubros.cod_publicacion = publicaciones.codigo
INNER JOIN WOLOLOX.rubros ON publicaciones_rubros.cod_rubro = rubros.codigo
WHERE compras.fecha BETWEEN @anio+'/7/1' AND @anio+'/9/30' AND rubros.descripcion_corta = @rubro
GROUP BY usuarios.nombre_usuario
ORDER BY cant_compras DESC

GO

IF OBJECT_ID('WOLOLOX.clienteMayorCantCompras4Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.clienteMayorCantCompras4Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.clienteMayorCantCompras4Trimestre(@anio nvarchar(4) ,@rubro nvarchar(20))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(compras.cantidad) AS cant_compras FROM WOLOLOX.compras
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = compras.id_usuario
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = compras.cod_publicacion
INNER JOIN WOLOLOX.publicaciones_rubros ON publicaciones_rubros.cod_publicacion = publicaciones.codigo
INNER JOIN WOLOLOX.rubros ON publicaciones_rubros.cod_rubro = rubros.codigo
WHERE compras.fecha BETWEEN @anio+'/10/1' AND @anio+'/12/31' AND rubros.descripcion_corta = @rubro
GROUP BY usuarios.nombre_usuario
ORDER BY cant_compras DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresMayorCantFacturas1Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresMayorCantFacturas1Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresMayorCantFacturas1Trimestre(@anio nvarchar(4))
AS

SELECT TOP 5 usuarios.nombre_usuario,count(facturas.nro_fact) AS cant_facturas FROM WOLOLOX.facturas
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = facturas.id_publicacion
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario
WHERE facturas.fecha BETWEEN @anio+'/1/1' AND @anio+'/3/31'
GROUP BY usuarios.nombre_usuario
ORDER BY cant_facturas DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresMayorCantFacturas2Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresMayorCantFacturas2Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresMayorCantFacturas2Trimestre(@anio nvarchar(4))
AS

SELECT TOP 5 usuarios.nombre_usuario,count(facturas.nro_fact) AS cant_facturas FROM WOLOLOX.facturas
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = facturas.id_publicacion
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario
WHERE facturas.fecha BETWEEN @anio+'/4/1' AND @anio+'/6/30'
GROUP BY usuarios.nombre_usuario
ORDER BY cant_facturas DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresMayorCantFacturas3Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresMayorCantFacturas3Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresMayorCantFacturas3Trimestre(@anio nvarchar(4))
AS

SELECT TOP 5 usuarios.nombre_usuario,count(facturas.nro_fact) AS cant_facturas FROM WOLOLOX.facturas
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = facturas.id_publicacion
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario
WHERE facturas.fecha BETWEEN @anio+'/7/1' AND @anio+'/9/30'
GROUP BY usuarios.nombre_usuario
ORDER BY cant_facturas DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresMayorCantFacturas4Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresMayorCantFacturas4Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresMayorCantFacturas4Trimestre(@anio nvarchar(4))
AS

SELECT TOP 5 usuarios.nombre_usuario,count(facturas.nro_fact) AS cant_facturas FROM WOLOLOX.facturas
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = facturas.id_publicacion
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario
WHERE facturas.fecha BETWEEN @anio+'/10/1' AND @anio+'/12/31'
GROUP BY usuarios.nombre_usuario
ORDER BY cant_facturas DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresMayorMontoFacturado1Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresMayorMontoFacturado1Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresMayorMontoFacturado1Trimestre(@anio nvarchar(4))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(facturas.total) AS monto_facturado FROM WOLOLOX.facturas
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = facturas.id_publicacion
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario
WHERE facturas.fecha BETWEEN @anio+'/1/1' AND @anio+'/3/31'
GROUP BY usuarios.nombre_usuario
ORDER BY monto_facturado DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresMayorMontoFacturado2Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresMayorMontoFacturado2Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresMayorMontoFacturado2Trimestre(@anio nvarchar(4))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(facturas.total) AS monto_facturado FROM WOLOLOX.facturas
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = facturas.id_publicacion
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario
WHERE facturas.fecha BETWEEN @anio+'/4/1' AND @anio+'/6/30'
GROUP BY usuarios.nombre_usuario
ORDER BY monto_facturado DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresMayorMontoFacturado3Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresMayorMontoFacturado3Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresMayorMontoFacturado3Trimestre(@anio nvarchar(4))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(facturas.total) AS monto_facturado FROM WOLOLOX.facturas
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = facturas.id_publicacion
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario
WHERE facturas.fecha BETWEEN @anio+'/7/1' AND @anio+'/9/30'
GROUP BY usuarios.nombre_usuario
ORDER BY monto_facturado DESC

GO

IF OBJECT_ID('WOLOLOX.vendedoresMayorMontoFacturado4Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresMayorMontoFacturado4Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresMayorMontoFacturado4Trimestre(@anio nvarchar(4))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(facturas.total) AS monto_facturado FROM WOLOLOX.facturas
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = facturas.id_publicacion
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario
WHERE facturas.fecha BETWEEN @anio+'/10/1' AND @anio+'/12/31'
GROUP BY usuarios.nombre_usuario
ORDER BY monto_facturado DESC

--ABM de Rol

GO
CREATE PROCEDURE wololox.insertarRol(@nombreRol nvarchar(50))
AS

insert into WOLOLOX.roles(nombre,estado)
values (@nombreRol,1)

GO

CREATE PROCEDURE wololox.insertarFuncXRol(@idFunc numeric(2,0), @idRol numeric(2,0))
AS
insert into WOLOLOX.funcionalidades_roles
values (@idFunc,@idRol)

GO

CREATE PROCEDURE wololox.inhabilitarRol(@idRol numeric(2,0))
AS
update WOLOLOX.roles
set estado=0
where id=@idRol

GO

CREATE PROCEDURE wololox.habilitarRol(@idRol numeric(2,0))
AS
update WOLOLOX.roles
set estado=1
where id=@idRol

GO

CREATE PROCEDURE wololox.funcionalidadesDelRol(@idRol numeric(2,0))
AS
SELECT f.id, f.nombre
FROM funcionalidades_roles fr, funcionalidades f
WHERE fr.id_rol= @idRol
AND f.id=fr.id_rol

GO

CREATE PROCEDURE wololox.funcionalidadesSinRol(@idRol numeric(2,0))
AS
SELECT f.id, f.nombre
FROM funcionalidades_roles fr, funcionalidades f
WHERE fr.id_rol!= @idRol
AND f.id=fr.id_rol

GO

CREATE PROCEDURE wololox.borrarTodasFunciones(@idRol numeric(2,0))
AS
DELETE FROM WOLOLOX.funcionalidades_roles
WHERE id_rol=@idRol

GO

CREATE PROCEDURE WOLOLOX.cantidadRoles(@UserName nvarchar(50))
AS
DECLARE @roles int

select COUNT(*)
from WOLOLOX.usuarios, WOLOLOX.roles_usuarios
where usuarios.nombre_usuario=@UserName
and usuarios.id_usuario=roles_usuarios.id_usuario

GO

CREATE PROCEDURE WOLOLOX.obtenerRol(@UserName nvarchar(50))
AS
select nombre
from WOLOLOX.roles, WOLOLOX.roles_usuarios
where roles_usuarios.id_usuario=@UserName
and roles.id=roles_usuarios.id_rol

GO
