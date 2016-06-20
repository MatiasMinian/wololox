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
  

--Creación de tablas


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
contraseña varbinary(8000),
intentos_login numeric(1,0),
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
fecha_inicio datetime,
fecha_vencimiento datetime,
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
cod_rubro numeric(18,0) REFERENCES WOLOLOX.rubros,
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

IF OBJECT_ID('WOLOLOX.login') IS NOT NULL
    DROP PROCEDURE WOLOLOX.login;
GO

CREATE PROCEDURE WOLOLOX.login(@UserName nvarchar(50), @Password varbinary(8000))
AS
DECLARE @estado int
declare @cantUsuarios numeric
declare @usrId numeric

set @cantUsuarios = (select isNull((select nombre_usuario FROM WOLOLOX.usuarios 
	WHERE 1=1 AND nombre_usuario = @UserName
	AND contraseña = @Password
	group by nombre_usuario
	having count(intentos_login)<3),0))

IF @cantUsuarios = 0
	BEGIN
		set @usrId = (select id_usuario FROM WOLOLOX.usuarios where nombre_usuario = @UserName)
		
		if (not exists (select id_usuario FROM WOLOLOX.usuarios where id_usuario = @usrId))
		begin 
			RAISERROR (40001,-1,-1, 'El Usuario no existe!')
			select 0
			return;
		end
		
		if((select intentos_login from WOLOLOX.usuarios  where id_usuario = @usrId) > 2)
		begin
			RAISERROR (40002,-1,-1, 'Usuario Bloqueado!')
			select 0
			return;
		end
		if (exists (select id_usuario FROM WOLOLOX.usuarios where nombre_usuario = @UserName))
		begin 
			RAISERROR (40003,-1,-1, 'Password incorrecta')
			update usuarios(intentos_login) set intentos_login=(intentos_login+1);
			return;
		end 
	END
	ELSE 
	BEGIN
	set @usrId = (SELECT id_usuario FROM WOLOLOX.usuarios WHERE nombre_usuario = @UserName
	AND contraseña = @password )
	
	SELECT @usrId
	END
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

CREATE PROCEDURE WOLOLOX.buscarPublicacionesPorDescripcion(@descripcion nvarchar(255))
AS

SELECT publicaciones.codigo,publicaciones.descripcion,precio,stock,tipo,visibilidades.descripcion,nombre_usuario
FROM WOLOLOX.publicaciones
INNER JOIN WOLOLOX.usuarios
ON publicaciones.id_usuario = usuarios.id_usuario
INNER JOIN visibilidades
ON publicaciones.cod_visibilidad = visibilidades.codigo
INNER JOIN WOLOLOX.estados
ON publicaciones.id_estado = estados.id_estado
WHERE publicaciones.descripcion LIKE '%'+@descripcion+'%' AND estados.descripcion_estado = 'Activa'
ORDER BY visibilidades.costo DESC

GO

IF OBJECT_ID('WOLOLOX.buscarPublicacionesPorRubros') IS NOT NULL
   DROP PROCEDURE WOLOLOX.buscarPublicacionesPorRubros;
GO

CREATE PROCEDURE WOLOLOX.buscarPublicacionesPorRubros(@rubro nvarchar(20))
AS
  SELECT publicaciones.codigo,publicaciones.descripcion,precio,stock,tipo,visibilidades.descripcion,nombre_usuario
FROM WOLOLOX.publicaciones
INNER JOIN WOLOLOX.usuarios
ON publicaciones.id_usuario = usuarios.id_usuario
INNER JOIN visibilidades
ON publicaciones.cod_visibilidad = visibilidades.codigo
INNER JOIN WOLOLOX.estados
ON publicaciones.id_estado = estados.id_estado
INNER JOIN WOLOLOX.rubros
ON publicaciones.cod_rubro = rubros.codigo
WHERE rubros.descripcion_corta = @rubro AND estados.descripcion_estado = 'Activa'
ORDER BY visibilidades.costo DESC

GO

IF OBJECT_ID('WOLOLOX.buscarPublicacionesPorRubrosYdescripcion') IS NOT NULL
   DROP PROCEDURE WOLOLOX.buscarPublicacionesPorRubrosYdescripcion;
GO

CREATE PROCEDURE WOLOLOX.buscarPublicacionesPorRubrosYdescripcion(@rubro nvarchar(20),@descripcion nvarchar(255))
AS
  SELECT publicaciones.codigo,publicaciones.descripcion,precio,stock,tipo,visibilidades.descripcion,nombre_usuario
FROM WOLOLOX.publicaciones
INNER JOIN WOLOLOX.usuarios
ON publicaciones.id_usuario = usuarios.id_usuario
INNER JOIN visibilidades
ON publicaciones.cod_visibilidad = visibilidades.codigo
INNER JOIN WOLOLOX.estados
ON publicaciones.id_estado = estados.id_estado
INNER JOIN WOLOLOX.rubros
ON publicaciones.cod_rubro = rubros.codigo
WHERE rubros.descripcion_corta = @rubro AND estados.descripcion_estado = 'Activa' AND publicaciones.descripcion LIKE '%'+@descripcion+'%'
ORDER BY visibilidades.costo DESC


GO
   
--ABM de Rol

IF OBJECT_ID('WOLOLOX.insertarRol') IS NOT NULL
   DROP PROCEDURE WOLOLOX.insertarRol;
GO

CREATE PROCEDURE wololox.insertarRol(@nombreRol nvarchar(50))
AS

insert into WOLOLOX.roles(nombre,estado)
values (@nombreRol,1)

GO

IF OBJECT_ID('WOLOLOX.insertarFuncXRol') IS NOT NULL
   DROP PROCEDURE WOLOLOX.insertarFuncXRol;
GO

CREATE PROCEDURE wololox.insertarFuncXRol(@idFunc numeric(2,0), @idRol numeric(2,0))
AS
insert into WOLOLOX.funcionalidades_roles
values (@idFunc,@idRol)

GO

IF OBJECT_ID('WOLOLOX.inhabilitarRol') IS NOT NULL
   DROP PROCEDURE WOLOLOX.inhabilitarRol;
GO

CREATE PROCEDURE wololox.inhabilitarRol(@idRol numeric(2,0))
AS
update WOLOLOX.roles
set estado=0
where id=@idRol

GO

IF OBJECT_ID('WOLOLOX.habilitarRol') IS NOT NULL
   DROP PROCEDURE WOLOLOX.habilitarRol;
GO

CREATE PROCEDURE wololox.habilitarRol(@idRol numeric(2,0))
AS
update WOLOLOX.roles
set estado=1
where id=@idRol

GO

IF OBJECT_ID('WOLOLOX.funcionalidadesDelRol') IS NOT NULL
   DROP PROCEDURE WOLOLOX.funcionalidadesDelRol;
GO

CREATE PROCEDURE wololox.funcionalidadesDelRol(@idRol numeric(2,0))
AS
SELECT f.id, f.nombre
FROM funcionalidades_roles fr, funcionalidades f
WHERE fr.id_rol= @idRol
AND f.id=fr.id_rol

GO

IF OBJECT_ID('WOLOLOX.funcionalidadesSinRol') IS NOT NULL
   DROP PROCEDURE WOLOLOX.funcionalidadesSinRol;
GO

CREATE PROCEDURE wololox.funcionalidadesSinRol(@idRol numeric(2,0))
AS
SELECT f.id, f.nombre
FROM funcionalidades_roles fr, funcionalidades f
WHERE fr.id_rol!= @idRol
AND f.id=fr.id_rol

GO

IF OBJECT_ID('WOLOLOX.borrarTodasFunciones') IS NOT NULL
   DROP PROCEDURE WOLOLOX.borrarTodasFunciones;
GO

CREATE PROCEDURE wololox.borrarTodasFunciones(@idRol numeric(2,0))
AS
DELETE FROM WOLOLOX.funcionalidades_roles
WHERE id_rol=@idRol

GO

IF OBJECT_ID('WOLOLOX.cantidadRoles') IS NOT NULL
   DROP PROCEDURE WOLOLOX.cantidadRoles;
GO

CREATE PROCEDURE WOLOLOX.cantidadRoles(@UserName nvarchar(50))
AS
DECLARE @roles int

select COUNT(*)
from WOLOLOX.usuarios, WOLOLOX.roles_usuarios
where usuarios.nombre_usuario=@UserName
and usuarios.id_usuario=roles_usuarios.id_usuario

GO

IF OBJECT_ID('WOLOLOX.obtenerRol') IS NOT NULL
   DROP PROCEDURE WOLOLOX.obtenerRol;
GO

CREATE PROCEDURE WOLOLOX.obtenerRol(@UserName nvarchar(50))
AS
select nombre
from WOLOLOX.roles, WOLOLOX.roles_usuarios, WOLOLOX.usuarios
where roles_usuarios.id_usuario=usuarios.id_usuario
and roles.id=roles_usuarios.id_rol
and usuarios.nombre_usuario=@UserName

GO

--ABM de usuarios

IF OBJECT_ID('WOLOLOX.CrearCliente') IS NOT NULL
    DROP PROCEDURE WOLOLOX.CrearCliente;
GO
CREATE PROCEDURE WOLOLOX.CrearCliente(@username nvarchar(50), @pass nvarchar(25), @nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(50), @tel nvarchar(50), @domicilio nvarchar(100),@numDom numeric(19,0), @piso numeric(18,0), @depto nvarchar(50),@localidad nvarchar(100),@ciudad nvarchar(100),@codPostal nvarchar(50), @dni numeric(18,0), @fechaNac datetime)
AS
     
    INSERT INTO WOLOLOX.clientes(apellido,nombre, dni,fecha_nacimiento,id_rol)
	VALUES	(@apellido,@nombre,@dni,@fechaNac,(SELECT id FROM WOLOLOX.roles where nombre='CLIENTE'))
	INSERT INTO WOLOLOX.direcciones(calle, numero, piso, departamento, localidad, cod_postal, ciudad)
	VALUES (@domicilio,@numDom,@piso,@depto,@localidad,@codPostal,@ciudad)
	declare @fkDireccion numeric(18,0) = scope_identity();
	INSERT INTO WOLOLOX.usuarios(nombre_usuario,contraseña,mail,fecha_creacion,intentos_login,telefono,id_direccion)
	VALUES (@username,HASHBYTES('SHA2_256',@pass),@mail,GETDATE(),0,@tel,@fkDireccion)
GO

IF OBJECT_ID('WOLOLOX.CrearCliente') IS NOT NULL
    DROP PROCEDURE WOLOLOX.CrearEmpresa;
GO
CREATE PROCEDURE WOLOLOX.CrearEmpresa(@username nvarchar(50), @pass nvarchar(25), @razSoc nvarchar(255), @mail nvarchar(50), @tel nvarchar(50), @domicilio nvarchar(100),@numDom numeric(19,0), @piso numeric(18,0), @depto nvarchar(50),@localidad nvarchar(100),@ciudad nvarchar(100),@codPostal nvarchar(50), @cuit nvarchar(50),@rubro nvarchar(20), @nomContac nvarchar(100))
AS
     
    INSERT INTO WOLOLOX.empresas(razon_social,nombre_contacto,cuit,reputacion,cod_rubro)
	VALUES	(@razSoc,@nomContac,@cuit,0, (SELECT codigo FROM WOLOLOX.rubros where descripcion_corta=@rubro))
	INSERT INTO WOLOLOX.direcciones(calle, numero, piso, departamento, localidad, cod_postal, ciudad)
	VALUES (@domicilio,@numDom,@piso,@depto,@localidad,@codPostal,@ciudad)
	declare @fkDireccion numeric(18,0) = scope_identity();
	INSERT INTO WOLOLOX.usuarios(nombre_usuario,contraseña,mail,fecha_creacion,intentos_login,telefono,id_direccion)
	VALUES (@username,HASHBYTES('SHA2_256',@pass),@mail,GETDATE(),0,@tel,@fkDireccion)
GO

IF OBJECT_ID('WOLOLOX.ObtenerClientesHabilitados') IS NOT NULL
    DROP FUNCTION WOLOLOX.ObtenerClientesHabilitados;
GO
CREATE FUNCTION WOLOLOX.ObtenerClientesHabilitados()
RETURNS TABLE
AS
RETURN(
    SELECT c.id_usuario, c.nombre, c.apellido, c.dni
	FROM WOLOLOX.clientes c, WOLOLOX.usuarios u
	WHERE c.id_usuario=u.id_usuario AND u.habilitado=1);
GO

IF OBJECT_ID('WOLOLOX.ObtenerEmpresasHabilitadas') IS NOT NULL
    DROP FUNCTION WOLOLOX.ObtenerEmpresasHabilitadas;
GO
CREATE FUNCTION WOLOLOX.ObtenerEmpresasHabilitadas()
RETURNS TABLE
AS
RETURN(
    SELECT e.id_usuario, e.razon_social, e.cuit, e.nombre_contacto, e.reputacion
	FROM WOLOLOX.empresas e, WOLOLOX.usuarios u
	WHERE e.id_usuario=u.id_usuario AND u.habilitado=1);
GO

IF OBJECT_ID('WOLOLOX.BuscarUsuario') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarUsuario;
GO
CREATE PROCEDURE WOLOLOX.BuscarUsuario(@id numeric)
AS
     
    SELECT mail, telefono
	FROM WOLOLOX.usuarios
	WHERE @id=id_usuario
GO

IF OBJECT_ID('WOLOLOX.BuscarDireccion') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarDireccion;
GO
CREATE PROCEDURE WOLOLOX.BuscarDireccion(@id numeric)
AS
     
    SELECT calle, numero, piso, departamento, localidad, cod_postal, ciudad
	FROM WOLOLOX.direcciones d, WOLOLOX.usuarios u
	WHERE @id=u.id_usuario AND d.id=u.id_direccion
GO

IF OBJECT_ID('WOLOLOX.BuscarCliente') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarCliente;
GO
CREATE PROCEDURE WOLOLOX.BuscarCliente(@nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(50), @dni numeric(18,0))
AS
     
    SELECT clientes.*
	FROM WOLOLOX.clientes, WOLOLOX.usuarios
	WHERE (@nombre IS NULL OR nombre LIKE @nombre)
	AND (@apellido IS NULL OR apellido LIKE @apellido)
	AND (@mail IS NULL OR (@mail LIKE usuarios.mail AND usuarios.id_usuario=clientes.id_usuario))
	AND (@dni IS NULL OR dni=@dni)
GO

IF OBJECT_ID('WOLOLOX.ActualizarCliente') IS NOT NULL
    DROP PROCEDURE WOLOLOX.ActualizarCliente;
GO
CREATE PROCEDURE WOLOLOX.ActualizarCliente(@id numeric(18,0), @nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(50), @tel nvarchar(50), @domicilio nvarchar(100),@numDom numeric(19,0), @piso numeric(18,0), @depto nvarchar(50),@localidad nvarchar(100),@ciudad nvarchar(100),@codPostal nvarchar(50), @dni numeric(18,0), @fechaNac datetime)
AS
     
    UPDATE WOLOLOX.clientes
	SET	apellido=@apellido,nombre=@nombre, dni=@dni,fecha_nacimiento=@fechaNac
	WHERE id_usuario = @id
	UPDATE WOLOLOX.direcciones
	SET calle=@domicilio, numero=@numDom, piso=@piso, departamento=@depto, localidad=@localidad, cod_postal=@codPostal, ciudad=@ciudad
	FROM WOLOLOX.usuarios u
	WHERE id = u.id_direccion
	AND u.id_usuario = @id
	UPDATE WOLOLOX.usuarios
	SET mail=@mail,telefono=@tel
	WHERE id_usuario=@id
GO

IF OBJECT_ID('WOLOLOX.BuscarEmpresa') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarEmpresa;
GO
CREATE PROCEDURE WOLOLOX.BuscarEmpresa(@razSoc nvarchar(255), @cuit nvarchar(50), @nomCon nvarchar(100),@rubro nvarchar(20), @repMin numeric(3,2), @repMax numeric(3,2))
AS
     
    SELECT e.id_usuario, e.razon_social, r.descripcion_corta, e.cuit, e.nombre_contacto, e.reputacion
	FROM WOLOLOX.empresas e, WOLOLOX.rubros r
	WHERE (@razSoc IS NULL OR razon_social LIKE @razSoc)
	AND (@cuit IS NULL OR cuit LIKE @cuit)
	AND (@nomCon IS NULL OR nombre_contacto LIKE @nomCon)
	AND (@repMin IS NULL OR @repMin<reputacion)
	AND (@repMax IS NULL OR @repMax>reputacion)
	AND (@rubro IS NULL OR (@rubro LIKE r.descripcion_corta AND e.cod_rubro=r.codigo))
GO

IF OBJECT_ID('WOLOLOX.ActualizarEmpresa') IS NOT NULL
    DROP PROCEDURE WOLOLOX.ActualizarEmpresa;
GO
CREATE PROCEDURE WOLOLOX.ActualizarEmpresa(@id numeric(18,0), @razSoc nvarchar(255), @rubro numeric(18,0), @mail nvarchar(50), @tel nvarchar(50), @domicilio nvarchar(100),@numDom numeric(19,0), @piso numeric(18,0), @depto nvarchar(50),@localidad nvarchar(100),@ciudad nvarchar(100),@codPostal nvarchar(50), @cuit nvarchar(50), @nomCon nvarchar(100))
AS
     
    UPDATE WOLOLOX.empresas
	SET	razon_social=@razSoc,nombre_contacto=@nomCon, cuit=@cuit,cod_rubro=@rubro
	WHERE id_usuario = @id
	UPDATE WOLOLOX.direcciones
	SET calle=@domicilio, numero=@numDom, piso=@piso, departamento=@depto, localidad=@localidad, cod_postal=@codPostal, ciudad=@ciudad
	FROM WOLOLOX.usuarios u
	WHERE id = u.id_direccion
	AND u.id_usuario = @id
	UPDATE WOLOLOX.usuarios
	SET mail=@mail,telefono=@tel
	WHERE id_usuario=@id
GO