USE GD1C2016

if object_id('WOLOLOX.clientes') is not null
  drop table WOLOLOX.clientes;

create table WOLOLOX.clientes(
dni numeric(18,0),
nombre nvarchar(255),
apellido nvarchar(255),
id_usuario numeric(18,0) ,
fecha_nacimiento datetime,
primary key (id_usuario)
);

if object_id('WOLOLOX.empresas') is not null
  drop table WOLOLOX.empresas;

create table WOLOLOX.empresas(
id_usuario numeric(18,0),
razon_social nvarchar(255),
cuit nvarchar(50),
nombre_contacto nvarchar(100),
cod_rubro numeric(18,0),
reputacion numeric(3,2),
primary key(id_usuario),
);


if object_id('WOLOLOX.roles_usuarios') is not null
  drop table WOLOLOX.roles_usuarios;

create table WOLOLOX.roles_usuarios(
id_rol numeric(2,0),
id_usuario numeric(18,0),
primary key(id_rol,id_usuario)
);

if object_id('WOLOLOX.funcionalidades_roles') is not null
  drop table WOLOLOX.funcionalidades_roles;

create table WOLOLOX.funcionalidades_roles(
id_funcionalidad numeric(2,0),
id_rol numeric(2,0),
primary key(id_funcionalidad,id_rol)
);

if object_id('WOLOLOX.funcionalidades') is not null
  drop table WOLOLOX.funcionalidades;

create table WOLOLOX.funcionalidades(
id numeric(2,0) identity(1,1),
nombre nvarchar(50),
primary key(id)
);

if object_id('WOLOLOX.roles') is not null
  drop table WOLOLOX.roles;

create table WOLOLOX.roles(
id numeric(2,0) identity(1,1),
nombre nvarchar(50),
estado bit default 1,
primary key(id)
);

if object_id('WOLOLOX.publicaciones_rubros') is not null
  drop table WOLOLOX.publicaciones_rubros;

create table WOLOLOX.publicaciones_rubros(
cod_publicacion numeric(18,0),
cod_rubro numeric(18,0)
primary key (cod_publicacion,cod_rubro)
);

if object_id('WOLOLOX.rubros') is not null
  drop table WOLOLOX.rubros;

create table WOLOLOX.rubros(
codigo numeric(18,0) identity(1,1),
descripcion_corta nvarchar(20),
descripcion_larga nvarchar(255),
primary key(codigo)
);

if object_id('WOLOLOX.ofertas') is not null
  drop table WOLOLOX.ofertas;

create table WOLOLOX.ofertas(
codigo numeric(18,0) identity(1,1),
id_usuario numeric(18,0),
cod_publicacion numeric(18,0),
fecha datetime,
monto numeric(18,2),
primary key (codigo)
);

if object_id('WOLOLOX.item_factura') is not null
  drop table WOLOLOX.item_factura;

create table WOLOLOX.item_factura(
id_item numeric(18,0) identity(1,1),
nro_fact numeric(18,0),
monto numeric(18,2),
descripcion nvarchar(255),
cantidad numeric(18,0),
primary key (id_item)
);

if object_id('WOLOLOX.calificaciones') is not null
  drop table WOLOLOX.calificaciones;

create table WOLOLOX.calificaciones(
id_calificacion numeric(18,0) identity (1,1),
cod_compra numeric(18,0),
estrellas numeric(18,0),
detalle nvarchar(255),
primary key(id_calificacion)
);

if object_id('WOLOLOX.facturas') is not null
  drop table WOLOLOX.facturas;

create table WOLOLOX.facturas(
nro_fact numeric(18,0) identity(1,1),
id_compra numeric(18,0),
id_publicacion numeric(18,0),
fecha datetime,
forma_pago nvarchar(255),
total numeric(18,2),
primary key (nro_fact)
);

if object_id('WOLOLOX.compras') is not null
  drop table WOLOLOX.compras;

create table WOLOLOX.compras(
id_compra numeric(18,0) identity(1,1),
cantidad numeric(18,0),
fecha datetime,
cod_publicacion numeric(18,0),
id_usuario numeric(18,0),
primary key(id_compra)
);

if object_id('WOLOLOX.publicaciones') is not null
  drop table WOLOLOX.publicaciones;

create table WOLOLOX.publicaciones(
codigo numeric(18,0) identity(1,1),
id_usuario numeric(18,0),
id_estado numeric(18,0),
cod_visibilidad numeric(18,0),
fecha_inicio datetime,
fecha_vencimiento datetime,
descripcion nvarchar (255),
stock numeric(18,0),
precio numeric(18,0),
tipo nvarchar(255),
primary key(codigo)
);

if object_id('WOLOLOX.estados') is not null
  drop table WOLOLOX.estados;

create table WOLOLOX.estados(
id_estado numeric(18,0) identity(1,1),
nombre nvarchar(255),
primary key (id_estado)
);

if object_id('WOLOLOX.visibilidades') is not null
  drop table WOLOLOX.visibilidades;

create table WOLOLOX.visibilidades(
codigo numeric(18,0) identity(1,1),
descripcion nvarchar(255),
costo_envio numeric(18,0),
porc_producto numeric(18,0),
costo_publicacion numeric(18,0),
habilitada bit default 1,
primary key (codigo)
);

if object_id('WOLOLOX.direcciones') is not null
  drop table WOLOLOX.direcciones;

create table WOLOLOX.direcciones(
id numeric(18,0) identity(1,1),
id_usuario numeric(18,0),
calle nvarchar(255),
numero numeric(18,0),
piso numeric(18,0),
departamento nvarchar(50),
localidad nvarchar(100),
cod_postal nvarchar(50),
ciudad nvarchar(100),
primary key(id)
);

if object_id('WOLOLOX.usuarios') is not null
  drop table WOLOLOX.usuarios;

create table WOLOLOX.usuarios(
id_usuario numeric(18,0) identity(1,1),
nombre_usuario nvarchar(255),
--contraseña nvarchar(255),
contraseña varbinary(8000),
intentos_login numeric(1,0),
mail nvarchar(255),
telefono nvarchar(50),
fecha_creacion datetime,
habilitado bit DEFAULT 1,
primary key (id_usuario),
unique (nombre_usuario)
);

alter table WOLOLOX.publicaciones
add constraint FK_publicaciones_usuarios
foreign key (id_usuario)
references WOLOLOX.usuarios (id_usuario);

alter table WOLOLOX.publicaciones
add constraint FK_publicaciones_estados
foreign key (id_estado)
references WOLOLOX.estados (id_estado);

alter table WOLOLOX.publicaciones
add constraint FK_publicaciones_visibilidades
foreign key (cod_visibilidad)
references WOLOLOX.visibilidades (codigo);

alter table WOLOLOX.direcciones
add constraint FK_direcciones_usuario
foreign key (id_usuario)
references WOLOLOX.usuarios (id_usuario);

alter table WOLOLOX.compras
add constraint FK_compras_publicacion
foreign key (cod_publicacion)
references WOLOLOX.publicaciones (codigo);

alter table WOLOLOX.compras
add constraint FK_compras_usuario
foreign key (id_usuario)
references WOLOLOX.usuarios (id_usuario);

alter table WOLOLOX.roles_usuarios
add constraint FK_rolesUsuarios_rol
foreign key (id_rol)
references WOLOLOX.roles (id);

alter table WOLOLOX.roles_usuarios
add constraint FK_rolesUsuarios_usuario
foreign key (id_usuario)
references WOLOLOX.usuarios (id_usuario);

alter table WOLOLOX.funcionalidades_roles
add constraint FK_funcionalidadesRoles_rol
foreign key (id_rol)
references WOLOLOX.roles (id);

alter table WOLOLOX.funcionalidades_roles
add constraint FK_rfuncionalidadesRoles_funcionalidad
foreign key (id_funcionalidad)
references WOLOLOX.funcionalidades (id);

alter table WOLOLOX.clientes
add constraint FK_clientes_usuario
foreign key (id_usuario)
references WOLOLOX.usuarios (id_usuario);

alter table WOLOLOX.empresas
add constraint FK_empresas_usuario
foreign key (id_usuario)
references WOLOLOX.usuarios (id_usuario);

alter table WOLOLOX.ofertas
add constraint FK_ofertas_usuario
foreign key (id_usuario)
references WOLOLOX.usuarios (id_usuario);

alter table WOLOLOX.ofertas
add constraint FK_empresas_publicacion
foreign key (cod_publicacion)
references WOLOLOX.publicaciones (codigo);

alter table WOLOLOX.publicaciones_rubros
add constraint FK_publicacionesRubros_publicacion
foreign key (cod_publicacion)
references WOLOLOX.publicaciones (codigo);

alter table WOLOLOX.publicaciones_rubros
add constraint FK_publicacionesRubros_rubro
foreign key (cod_rubro)
references WOLOLOX.rubros (codigo);

alter table WOLOLOX.calificaciones
add constraint FK_calificaciones_compra
foreign key (cod_compra)
references WOLOLOX.compras (id_compra);

alter table WOLOLOX.facturas
add constraint FK_facturas_compra
foreign key (id_compra)
references WOLOLOX.compras (id_compra);

alter table WOLOLOX.facturas
add constraint FK_facturas_publicacion
foreign key (id_publicacion)
references WOLOLOX.publicaciones (codigo);

alter table WOLOLOX.item_factura
add constraint FK_itemFactura_factura
foreign key (nro_fact)
references WOLOLOX.facturas (nro_fact);

if OBJECT_ID('WOLOLOX.pa_migracion_maestra') is not null
drop proc WOLOLOX.pa_migracion_maestra;

GO

create procedure WOLOLOX.pa_migracion_maestra  -- (@fecha_de_hoy datetime)
AS
declare @fecha_de_hoy datetime 

insert into WOLOLOX.direcciones(calle,numero,piso,departamento,cod_postal)
select DISTINCT Cli_Dom_Calle, Cli_Nro_Calle,Cli_Piso,Cli_Depto,Cli_Cod_Postal from gd_esquema.Maestra
where Cli_Nro_Calle is not null

insert into WOLOLOX.direcciones(calle,numero,piso,departamento,cod_postal)
select DISTINCT Publ_Empresa_Dom_Calle, Publ_Empresa_Nro_Calle,Publ_Empresa_Piso,Publ_Empresa_Depto,Publ_Empresa_Cod_Postal from gd_esquema.Maestra
where Publ_Empresa_Nro_Calle is not null

insert into WOLOLOX.usuarios (nombre_usuario,mail)
select DISTINCT Cli_Mail, Cli_Mail from gd_esquema.Maestra
where Cli_Mail is not null 

insert into WOLOLOX.usuarios (nombre_usuario,mail)
select DISTINCT Publ_Cli_Mail, Publ_Cli_Mail from gd_esquema.Maestra
where Publ_Cli_Mail is not null AND not( Publ_Cli_Mail IN(select mail from usuarios))


insert into WOLOLOX.usuarios (nombre_usuario,mail,fecha_creacion)
select DISTINCT Publ_Empresa_Mail,Publ_Empresa_Mail,Publ_Empresa_Fecha_Creacion from gd_esquema.Maestra
where Publ_Empresa_Mail is not null

insert into WOLOLOX.estados(nombre) values('Publicada')
insert into WOLOLOX.estados(nombre) values('Finalizada')
insert into WOLOLOX.estados(nombre) values('Pausada')
insert into WOLOLOX.estados(nombre) values('Borrador')

insert into WOLOLOX.roles(nombre) values('Administrador')
insert into WOLOLOX.roles(nombre) values('Cliente')
insert into WOLOLOX.roles(nombre) values('Empresa')

insert into WOLOLOX.funcionalidades(nombre) values('ABM usuarios')
insert into WOLOLOX.funcionalidades(nombre) values('ABM roles')
insert into WOLOLOX.funcionalidades(nombre) values('Modificacion usuario')
insert into WOLOLOX.funcionalidades(nombre) values('Modificacion publicacion')
insert into WOLOLOX.funcionalidades(nombre) values('ABM visibilidades')
insert into WOLOLOX.funcionalidades(nombre) values('Generar publicacion')
insert into WOLOLOX.funcionalidades(nombre) values('Comprar-ofertar')
insert into WOLOLOX.funcionalidades(nombre) values('Historial cliente')
insert into WOLOLOX.funcionalidades(nombre) values('Calificar vendedor')
insert into WOLOLOX.funcionalidades(nombre) values('Consulta facturas')
insert into WOLOLOX.funcionalidades(nombre) values('Listado estadistico')

declare @funcionalidades_empresa table(nombre nvarchar(50))
declare @funcionalidades_cliente table(nombre nvarchar(50))
declare @funcionalidades_administrador table(nombre nvarchar(50))

insert into @funcionalidades_empresa values('Generar publicacion')
insert into @funcionalidades_empresa values('Listado estadistico')
insert into @funcionalidades_empresa values('Modificacion usuario')
insert into @funcionalidades_empresa values('Modificacion publicacion')

insert into @funcionalidades_cliente values('Generar publicacion')
insert into @funcionalidades_cliente values('Comprar-ofertar')
insert into @funcionalidades_cliente values('Historial cliente')
insert into @funcionalidades_cliente values('Calificar vendedor')
insert into @funcionalidades_cliente values('Modificacion usuario')
insert into @funcionalidades_cliente values('Modificacion publicacion')
insert into @funcionalidades_cliente values('Listado estadistico')

insert into @funcionalidades_administrador values('ABM roles')
insert into @funcionalidades_administrador values('ABM usuarios')
insert into @funcionalidades_administrador values('ABM visibilidades')
insert into @funcionalidades_administrador values('Consulta facturas')

insert into funcionalidades_roles(id_rol,id_funcionalidad)
select r.id, f.id from roles r , funcionalidades f
where r.nombre LIKE 'empresa' AND f.nombre IN (select * from @funcionalidades_empresa)

insert into funcionalidades_roles(id_rol,id_funcionalidad)
select r.id, f.id from roles r , funcionalidades f
where r.nombre LIKE 'cliente' AND f.nombre IN (select * from @funcionalidades_cliente)

insert into funcionalidades_roles(id_rol,id_funcionalidad)
select r.id, f.id from roles r , funcionalidades f
where r.nombre LIKE 'administrador' AND f.nombre IN (select * from @funcionalidades_administrador)

set IDENTITY_INSERT WOLOLOX.visibilidades ON
insert into WOLOLOX.visibilidades(codigo,descripcion,porc_producto,costo_publicacion,costo_envio)
select DISTINCT Publicacion_Visibilidad_Cod,Publicacion_Visibilidad_Desc,Publicacion_Visibilidad_Porcentaje,Publicacion_Visibilidad_Precio,0 from gd_esquema.Maestra
set IDENTITY_INSERT WOLOLOX.visibilidades OFF

declare @fecha_inicio datetime, @fecha_vencimiento datetime
	declare cursorEstado CURSOR FOR
        SELECT fecha_inicio,fecha_vencimiento
        FROM WOLOLOX.publicaciones
    OPEN cursorEstado
	FETCH NEXT FROM cursorEstado INTO @fecha_inicio,@fecha_vencimiento

	WHILE @@FETCH_STATUS = 0 BEGIN
		
		--Chequear si la fecha de vencimiento es mayor o menor a la de hoy.
		declare @id_estado numeric(18,0)

		IF(@fecha_de_hoy > @fecha_vencimiento) BEGIN
			SET @id_estado = (select id_estado from estados where nombre like 'Finalizada')
		END 
		ELSE BEGIN
		SET @id_estado = (select id_estado from estados where nombre like 'Publicada')
		END
		insert into WOLOLOX.publicaciones(fecha_inicio,fecha_vencimiento,id_estado)
		values(@fecha_inicio,@fecha_vencimiento,@id_estado)
		END
		close cursorEstado
		deallocate cursorEstado

insert  into WOLOLOX.rubros(descripcion_larga)
select DISTINCT Publicacion_Rubro_Descripcion from gd_esquema.Maestra
where Publicacion_Rubro_Descripcion is not null

set IDENTITY_INSERT WOLOLOX.publicaciones ON		
insert into WOLOLOX.publicaciones(id_usuario,codigo,id_estado,descripcion,fecha_inicio,fecha_vencimiento,precio,stock,tipo,cod_visibilidad)
select DISTINCT u.id_usuario,Publicacion_Cod,estados.id_estado ,Publicacion_Descripcion,Publicacion_Fecha,Publicacion_Fecha_Venc,Publicacion_Precio,Publicacion_Stock,Publicacion_Tipo,Publicacion_Visibilidad_Cod from gd_esquema.Maestra, usuarios u ,estados
where Publicacion_Cod is not null AND u.mail like Publ_Empresa_Mail AND Publicacion_Estado = estados.nombre
set IDENTITY_INSERT WOLOLOX.publicaciones OFF

set IDENTITY_INSERT WOLOLOX.publicaciones ON		
insert into WOLOLOX.publicaciones(id_usuario,codigo,id_estado,descripcion,fecha_inicio,fecha_vencimiento,precio,stock,tipo,cod_visibilidad)
select DISTINCT u.id_usuario, Publicacion_Cod,estados.id_estado, Publicacion_Descripcion,Publicacion_Fecha,Publicacion_Fecha_Venc, Publicacion_Precio, Publicacion_Stock, Publicacion_Tipo, Publicacion_Visibilidad_Cod from gd_esquema.Maestra, usuarios u,estados
where Publicacion_Cod is not null AND u.mail like Publ_Cli_Mail AND Publicacion_Estado = estados.nombre
set IDENTITY_INSERT WOLOLOX.publicaciones OFF

insert into WOLOLOX.publicaciones_rubros(cod_publicacion,cod_rubro)
select DISTINCT m.Publicacion_Cod, r.codigo from gd_esquema.Maestra m, rubros r where m.Publicacion_Rubro_Descripcion like r.descripcion_larga

insert into WOLOLOX.compras(id_usuario,cantidad,fecha,cod_publicacion)
select DISTINCT u.id_usuario, m.Compra_Cantidad, m.Compra_Fecha, m.Publicacion_Cod from gd_esquema.Maestra m, usuarios u
where Compra_Cantidad is not null AND u.mail = m.Cli_Mail

set IDENTITY_INSERT WOLOLOX.facturas ON
insert into WOLOLOX.facturas(nro_fact,fecha,total,id_publicacion, forma_pago)
select DISTINCT Factura_Nro,Factura_Fecha,Factura_Total,Publicacion_Cod,Forma_Pago_Desc from gd_esquema.Maestra
where Factura_Nro is not null
set IDENTITY_INSERT WOLOLOX.facturas OFF

set IDENTITY_INSERT WOLOLOX.calificaciones ON
insert into WOLOLOX.calificaciones(cod_compra,id_calificacion,estrellas,detalle)
select DISTINCT (select c.id_compra from compras c, usuarios u where c.id_usuario = u.id_usuario AND u.mail = Cli_Mail AND c.cod_publicacion = Publicacion_Cod AND c.fecha = Compra_Fecha AND c.cantidad = Compra_Cantidad), Calificacion_Codigo,Calificacion_Cant_Estrellas,Calificacion_Descripcion from gd_esquema.Maestra
where Calificacion_Codigo is not null
set IDENTITY_INSERT WOLOLOX.calificaciones OFF

insert into WOLOLOX.item_factura(cantidad,monto,nro_fact)
select DISTINCT Item_Factura_Cantidad,Item_Factura_Monto,Factura_Nro from gd_esquema.Maestra
where Factura_Nro is not null

insert into WOLOLOX.ofertas(id_usuario,fecha,monto,cod_publicacion)
select DISTINCT (select id_usuario from usuarios where mail like Cli_Mail), Oferta_Fecha,Oferta_Monto,Publicacion_Cod from gd_esquema.Maestra
where Oferta_Monto is not null

insert into WOLOLOX.clientes (id_usuario,dni,apellido,nombre,fecha_nacimiento)
select DISTINCT u.id_usuario,m.Cli_Dni, m.Cli_Apeliido,m.Cli_Nombre,m.Cli_Fecha_Nac 
from usuarios u, gd_esquema.Maestra m
where (m.Cli_Mail is not null) AND u.mail like Cli_Mail

insert into WOLOLOX.roles_usuarios(id_usuario,id_rol)
select u.id_usuario,(select id from roles where nombre LIKE 'cliente') from usuarios u, clientes c
where u.id_usuario = c.id_usuario

insert into WOLOLOX.empresas(id_usuario,cod_rubro,razon_social,cuit,reputacion)
select DISTINCT u.id_usuario , (select top 1  pr.cod_rubro from publicaciones p , publicaciones_rubros pr where u.id_usuario = p.id_usuario AND p.codigo = pr.cod_publicacion group by pr.cod_rubro having count(pr.cod_rubro) = (select max(i.total) from (select count(pr2.cod_rubro) as total from publicaciones p2,publicaciones_rubros pr2 where p2.codigo = pr2.cod_publicacion AND p2.id_usuario = u.id_usuario group by pr2.cod_rubro) i)), m.Publ_Empresa_Razon_Social, m.Publ_Empresa_Cuit, (select AVG(calif.estrellas) from calificaciones calif, compras comp where calif.cod_compra = comp.id_compra AND comp.cod_publicacion = m.Publicacion_Cod AND m.Cli_Mail like u.mail)
from usuarios u, gd_esquema.Maestra m
where (m.Publ_Empresa_Mail is not null) AND u.mail like Publ_Empresa_Mail

insert into WOLOLOX.roles_usuarios(id_usuario,id_rol)
select u.id_usuario,(select id from roles where nombre LIKE 'empresa') from usuarios u, empresas e
where u.id_usuario = e.id_usuario
GO

--Procedures y triggers



--Visibilidad

IF OBJECT_ID('WOLOLOX.CrearVisibilidad') IS NOT NULL
    DROP PROCEDURE WOLOLOX.CrearVisibilidad;
GO
CREATE PROCEDURE WOLOLOX.CrearVisibilidad(@descripcion nvarchar(255),@costo_envio numeric(18,0),@porc_producto numeric(18,0),@costo_publicacion numeric(18,0))
AS
     
    INSERT INTO WOLOLOX.visibilidades(descripcion,costo_envio,porc_producto,costo_publicacion)
	VALUES	(@descripcion,@costo_envio,@porc_producto,@costo_publicacion)
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
CREATE PROCEDURE WOLOLOX.ModificarVisibilidad(@codigo numeric(18,0),@descripcion nvarchar(255),@costo_envio numeric(18,0),@porc_producto numeric(18,0),@costo_publicacion numeric(18,0))
AS

    UPDATE WOLOLOX.visibilidades
	SET   descripcion = @descripcion,costo_envio = @costo_envio, porc_producto = @porc_producto,costo_publicacion = @costo_publicacion
	WHERE @codigo = codigo
GO


IF OBJECT_ID('WOLOLOX.BusquedaPorDescripcion') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BusquedaPorDescripcion;
GO
CREATE PROCEDURE WOLOLOX.BusquedaPorDescripcion(@descripcionIngresada nvarchar(255))
AS
    SELECT codigo,descripcion,costo_envio,porc_producto,costo_publicacion,habilitada FROM WOLOLOX.visibilidades
	WHERE descripcion LIKE '%'+@descripcionIngresada+'%' AND habilitada = 1
GO

IF OBJECT_ID('WOLOLOX.BusquedaPorCostos') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BusquedaPorCostos;
GO
CREATE PROCEDURE WOLOLOX.BusquedaPorCostos(@costoMinimo numeric(18,0),@costoMaximo numeric(18,0))
AS
    SELECT codigo,descripcion,costo_envio,porc_producto,costo_publicacion,habilitada FROM WOLOLOX.visibilidades
	WHERE (costo_publicacion>=@costoMinimo AND costo_publicacion<=@costoMaximo) AND habilitada = 1
GO


IF OBJECT_ID('WOLOLOX.BusquedaPorDescripcionYcostos') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BusquedaPorDescripcionYcostos;
GO
CREATE PROCEDURE WOLOLOX.BusquedaPorDescripcionYcostos(@descripcionIngresada nvarchar(255),@costoMinimo numeric(18,0),@costoMaximo numeric(18,0))
AS
    SELECT codigo,descripcion,costo_envio,porc_producto,costo_publicacion,habilitada FROM WOLOLOX.visibilidades
	WHERE descripcion LIKE '%'+@descripcionIngresada+'%' AND (costo_publicacion>=@costoMinimo AND costo_publicacion<=@costoMaximo) AND habilitada = 1
	
GO

--Login

IF OBJECT_ID('WOLOLOX.login') IS NOT NULL
    DROP PROCEDURE WOLOLOX.login;
GO

CREATE PROCEDURE WOLOLOX.login(@UserName nvarchar(255), @Password nvarchar(255))
AS
DECLARE @estado int
declare @cantUsuarios numeric
declare @usrId numeric

set @cantUsuarios = ISNULL((select COUNT(*) FROM WOLOLOX.usuarios 
	WHERE nombre_usuario = @UserName
	AND contraseña = HASHBYTES('SHA2_256', @Password)
	group by nombre_usuario
	having count(intentos_login)<3),0)

IF @cantUsuarios = 0
	BEGIN
		set @usrId = (select id_usuario FROM WOLOLOX.usuarios where nombre_usuario = @UserName)
		
		if (not exists (select id_usuario FROM WOLOLOX.usuarios where id_usuario = @usrId))
		begin 
			RAISERROR (40001,-1,-1, 'El Usuario no existe!')
			return;
		end
		
		if((select intentos_login from WOLOLOX.usuarios  where id_usuario = @usrId) > 2)
		begin
			RAISERROR (40002,-1,-1, 'Usuario Bloqueado!')
			UPDATE usuarios
			SET habilitado=0
			WHERE id_usuario=@usrId
			return;
		end
		if (exists (select id_usuario FROM WOLOLOX.usuarios WHERE nombre_usuario = @UserName AND contraseña<>@Password))
		begin 
			RAISERROR (40003,-1,-1, 'Password incorrecta')
			UPDATE usuarios
			SET intentos_login=(intentos_login+1)
			WHERE id_usuario=@usrId
			return;
		end 
END
	ELSE 
BEGIN
	set @usrId = (SELECT id_usuario FROM WOLOLOX.usuarios WHERE nombre_usuario = @UserName
	AND contraseña = HASHBYTES('SHA2_256', @Password) )
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

--Publicaciones

IF OBJECT_ID('WOLOLOX.publicacionesParaModificacion') IS NOT NULL
   DROP PROCEDURE WOLOLOX.publicacionesParaModificacion;

GO

CREATE PROCEDURE WOLOLOX.publicacionesParaModificacion(@id numeric(18,0))
AS
SELECT publicaciones.codigo,estados.nombre,visibilidades.descripcion,publicaciones.descripcion,stock,precio,tipo,fecha_inicio,fecha_vencimiento FROM WOLOLOX.publicaciones
INNER JOIN WOLOLOX.visibilidades ON publicaciones.cod_visibilidad = visibilidades.codigo
INNER JOIN WOLOLOX.estados ON publicaciones.id_estado = estados.id_estado
WHERE publicaciones.id_usuario = 1 AND estados.nombre<>'Finalizada'

GO

IF OBJECT_ID('WOLOLOX.actualizarEstadoPublicacion') IS NOT NULL
   DROP PROCEDURE WOLOLOX.actualizarEstadoPublicacion;

GO

CREATE PROCEDURE WOLOLOX.actualizarEstadoPublicacion(@idPubli numeric(18,0),@idEstado numeric(18,0))
AS
UPDATE WOLOLOX.publicaciones
SET publicaciones.id_estado = @idEstado
WHERE publicaciones.codigo = @idPubli

GO

IF OBJECT_ID('WOLOLOX.rubrosDePublicacion') IS NOT NULL
   DROP PROCEDURE WOLOLOX.rubrosDePublicacion;

GO

CREATE PROCEDURE WOLOLOX.rubrosDePublicacion(@idPubli numeric (18,0))
AS
SELECT rubros.descripcion_corta FROM WOLOLOX.rubros
INNER JOIN WOLOLOX.publicaciones_rubros ON rubros.codigo = publicaciones_rubros.cod_rubro
INNER JOIN WOLOLOX.publicaciones ON publicaciones.codigo = publicaciones_rubros.cod_publicacion
WHERE publicaciones.codigo = @idPubli


GO

IF OBJECT_ID('WOLOLOX.ActualizarPublicacion') IS NOT NULL
   DROP PROCEDURE WOLOLOX.ActualizarPublicacion;

GO

CREATE PROCEDURE WOLOLOX.ActualizarPublicacion(@idPubli numeric (18,0),@id_estado numeric(18,0),@cod_visi numeric(18,0),@descripcion nvarchar(255),@stock numeric(18,0),@precio numeric(18,0),@fecha_inicio DateTime,@fecha_vencimiento DateTime)
AS
UPDATE WOLOLOX.publicaciones
SET publicaciones.id_estado = @id_estado,
    cod_visibilidad = @cod_visi,
	descripcion = @descripcion,
	stock = @stock,
	precio = @precio,
	fecha_inicio = @fecha_inicio,
	fecha_vencimiento = @fecha_vencimiento
WHERE publicaciones.codigo = @idPubli

GO

IF OBJECT_ID('WOLOLOX.ActualizarPubliRubros') IS NOT NULL
   DROP PROCEDURE WOLOLOX.ActualizarPubliRubros;

GO

CREATE PROCEDURE WOLOLOX.ActualizarPubliRubros(@idPubli numeric (18,0),@idRubro numeric(18,0))
AS
DELETE FROM WOLOLOX.publicaciones_rubros
WHERE publicaciones_rubros.cod_publicacion = @idPubli

INSERT INTO WOLOLOX.publicaciones_rubros(publicaciones_rubros.cod_publicacion,publicaciones_rubros.cod_rubro)
VALUES(@idPubli,@idRubro)


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


IF OBJECT_ID('WOLOLOX.IDultimaCompraUsuario') IS NOT NULL
   DROP PROCEDURE WOLOLOX.IDultimaCompraUsuario;
GO

CREATE PROCEDURE WOLOLOX.IDultimaCompraUsuario(@idUser numeric(18,0))
AS
DECLARE @id int;
SET @id = (SELECT TOP 1 id_compra FROM WOLOLOX.compras
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = compras.id_usuario
WHERE usuarios.id_usuario = @idUser
ORDER BY id_compra DESC)

SELECT @id



GO

IF OBJECT_ID('WOLOLOX.cantidadPublicacionesPorDescripcion') IS NOT NULL
   DROP PROCEDURE WOLOLOX.cantidadPublicacionesPorDescripcion;
GO

CREATE PROCEDURE WOLOLOX.cantidadPublicacionesPorDescripcion(@descripcion nvarchar(255),@id numeric(18,0))
AS
DECLARE @cantidad int
SET @cantidad = (SELECT count(*)
FROM WOLOLOX.publicaciones
INNER JOIN WOLOLOX.usuarios
ON publicaciones.id_usuario = usuarios.id_usuario
INNER JOIN WOLOLOX.visibilidades
ON publicaciones.cod_visibilidad = visibilidades.codigo
INNER JOIN WOLOLOX.estados
ON publicaciones.id_estado = estados.id_estado
WHERE publicaciones.descripcion LIKE '%'+@descripcion+'%' AND estados.nombre = 'Publicada' AND @id <> publicaciones.id_usuario)
SELECT @cantidad

GO

IF OBJECT_ID('WOLOLOX.buscarPublicacionesPorDescripcion') IS NOT NULL
   DROP PROCEDURE WOLOLOX.buscarPublicacionesPorDescripcion;
GO

CREATE PROCEDURE WOLOLOX.buscarPublicacionesPorDescripcion(@descripcion nvarchar(255),@id numeric(18,0),@rowInicial int)
AS

SELECT publicaciones.codigo AS codigo,publicaciones.descripcion,precio,stock,tipo,visibilidades.descripcion,nombre_usuario
FROM WOLOLOX.publicaciones
INNER JOIN WOLOLOX.usuarios
ON publicaciones.id_usuario = usuarios.id_usuario
INNER JOIN WOLOLOX.visibilidades
ON publicaciones.cod_visibilidad = visibilidades.codigo
INNER JOIN WOLOLOX.estados
ON publicaciones.id_estado = estados.id_estado
WHERE publicaciones.descripcion LIKE '%'+@descripcion+'%' AND estados.nombre = 'Publicada' AND @id <> publicaciones.id_usuario
ORDER BY visibilidades.costo_publicacion DESC OFFSET @rowInicial ROWS FETCH NEXT 5 ROWS ONLY


GO

IF OBJECT_ID('WOLOLOX.cantidadPublicacionesPorRubros') IS NOT NULL
   DROP PROCEDURE WOLOLOX.cantidadPublicacionesPorRubros;
GO

CREATE PROCEDURE WOLOLOX.cantidadPublicacionesPorRubros(@rubro nvarchar(20),@id numeric(18,0))
AS
DECLARE @cantidad int
SET @cantidad = (SELECT count(*)
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
WHERE rubros.descripcion_larga = @rubro AND estados.nombre = 'Publicada' AND @id <> publicaciones.id_usuario)
SELECT @cantidad

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
INNER JOIN WOLOLOX.visibilidades
ON publicaciones.cod_visibilidad = visibilidades.codigo
INNER JOIN WOLOLOX.estados
ON publicaciones.id_estado = estados.id_estado
INNER JOIN WOLOLOX.publicaciones_rubros
ON publicaciones.codigo = publicaciones_rubros.cod_publicacion
INNER JOIN WOLOLOX.rubros
ON rubros.codigo = publicaciones_rubros.cod_rubro
WHERE rubros.descripcion_larga = @rubro AND estados.nombre = 'Publicada' AND @id <> publicaciones.id_usuario

GO

IF OBJECT_ID('WOLOLOX.cantidadPublicacionesPorRubrosYdescripcion') IS NOT NULL
   DROP PROCEDURE WOLOLOX.cantidadPublicacionesPorRubrosYdescripcion;
GO

CREATE PROCEDURE WOLOLOX.cantidadPublicacionesPorRubrosYdescripcion(@rubro nvarchar(20),@descripcion nvarchar(255),@id numeric(18,0))
AS
DECLARE @cantidad int
SET @cantidad = (SELECT count(*)
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
WHERE rubros.descripcion_larga = @rubro AND estados.nombre = 'Publicada' AND publicaciones.descripcion LIKE '%'+@descripcion+'%' AND @id <> publicaciones.id_usuario)

SELECT @cantidad

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
WHERE rubros.descripcion_larga = @rubro AND estados.nombre = 'Publicada' AND publicaciones.descripcion LIKE '%'+@descripcion+'%' AND @id <> publicaciones.id_usuario
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

set @cantidadCompras = (SELECT COUNT(*) FROM WOLOLOX.publicaciones
										INNER JOIN WOLOLOX.estados ON estados.id_estado = publicaciones.id_estado
									    WHERE publicaciones.id_usuario = @idUser AND estados.nombre<>'Borrador')

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
set @idrubro = (SELECT rubros.codigo FROM WOLOLOX.rubros WHERE rubros.descripcion_larga = @rubro)
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
SET @idestado =(SELECT estados.id_estado FROM WOLOLOX.estados WHERE estados.nombre = @estado)

SELECT @idestado

GO
IF OBJECT_ID('WOLOLOX.consultaIDestado') IS NOT NULL
   DROP PROCEDURE WOLOLOX.consultaIDestado;
GO
  CREATE PROCEDURE WOLOLOX.consultaIDestado(@estado nvarchar(255))
AS
DECLARE @idestado int
SET @idestado =(SELECT estados.id_estado FROM WOLOLOX.estados WHERE estados.nombre = @estado)

SELECT @idestado


GO

----Listado estadístico

IF OBJECT_ID('WOLOLOX.vendedoresProductosNoVendidos1Trimestre') IS NOT NULL
   DROP PROCEDURE WOLOLOX.vendedoresProductosNoVendidos1Trimestre;
GO
  CREATE PROCEDURE WOLOLOX.vendedoresProductosNoVendidos1Trimestre(@anio nvarchar(4) ,@visi nvarchar(255))
AS

SELECT TOP 5 usuarios.nombre_usuario,sum(publicaciones.stock) AS cant_no_vendidos FROM WOLOLOX.publicaciones 
INNER JOIN WOLOLOX.usuarios ON usuarios.id_usuario = publicaciones.id_usuario 
INNER JOIN WOLOLOX.visibilidades ON visibilidades.codigo = publicaciones.cod_visibilidad
INNER JOIN WOLOLOX.estados on publicaciones.id_estado = estados.id_estado
WHERE (publicaciones.fecha_inicio BETWEEN @anio+'/1/1' AND @anio+'/3/31') 
AND (publicaciones.fecha_vencimiento BETWEEN @anio+'/1/1' AND @anio+'/3/31')
AND (visibilidades.descripcion = @visi)
AND (estados.nombre = 'Publicada')
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
INNER JOIN WOLOLOX.estados on publicaciones.id_estado = estados.id_estado
WHERE (publicaciones.fecha_inicio BETWEEN @anio+'/4/1' AND @anio+'/6/30') 
AND (publicaciones.fecha_vencimiento BETWEEN @anio+'/4/1' AND @anio+'/6/30')
AND (visibilidades.descripcion = @visi)
AND (estados.nombre = 'Publicada')
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
INNER JOIN WOLOLOX.estados on publicaciones.id_estado = estados.id_estado
WHERE (publicaciones.fecha_inicio BETWEEN @anio+'/7/1' AND @anio+'/9/30') 
AND (publicaciones.fecha_vencimiento BETWEEN @anio+'/7/1' AND @anio+'/9/30')
AND (visibilidades.descripcion = @visi)
AND (estados.nombre = 'Publicada')
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
INNER JOIN WOLOLOX.estados on publicaciones.id_estado = estados.id_estado
WHERE (publicaciones.fecha_inicio BETWEEN @anio+'/10/1' AND @anio+'/12/31') 
AND (publicaciones.fecha_vencimiento BETWEEN @anio+'/10/1' AND @anio+'/12/31')
AND (visibilidades.descripcion = @visi)
AND (estados.nombre = 'Publicada')
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
WHERE compras.fecha BETWEEN @anio+'/1/1' AND @anio+'/3/31' AND rubros.descripcion_larga = @rubro
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
WHERE compras.fecha BETWEEN @anio+'/4/1' AND @anio+'/6/30' AND rubros.descripcion_larga = @rubro
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
WHERE compras.fecha BETWEEN @anio+'/7/1' AND @anio+'/9/30' AND rubros.descripcion_larga = @rubro
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
WHERE compras.fecha BETWEEN @anio+'/10/1' AND @anio+'/12/31' AND rubros.descripcion_larga = @rubro
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

GO
      
--Facturas

IF OBJECT_ID('WOLOLOX.busquedaDeFacturas') IS NOT NULL
   DROP PROCEDURE WOLOLOX.busquedaDeFacturas;
GO
  CREATE PROCEDURE WOLOLOX.busquedaDeFacturas(@id_compra numeric(18,0))
AS
SELECT nro_fact,total FROM WOLOLOX.facturas
WHERE id_compra = @id_compra


GO

IF OBJECT_ID('WOLOLOX.cantidadDeFacturas') IS NOT NULL
   DROP PROCEDURE WOLOLOX.cantidadDeFacturas;
GO
  CREATE PROCEDURE WOLOLOX.cantidadDeFacturas(@id numeric(18,0),@fecha1 DateTime,@fecha2 DateTime,@importe1 nvarchar(21),@importe2 nvarchar(21),@detalle nvarchar(255))
AS
DECLARE @cantidad int

SET @cantidad = (SELECT sum(cantFacturas.cantidad_facturas) from (SELECT count(*) as cantidad_facturas from WOLOLOX.facturas
                 INNER JOIN WOLOLOX.compras on compras.id_compra = facturas.id_compra
                 INNER JOIN WOLOLOX.publicaciones on publicaciones.codigo = compras.cod_publicacion
				 WHERE (@id IS NULL OR compras.id_usuario = @id)
				 AND ((@fecha1 is null AND @fecha2 is null) OR facturas.fecha BETWEEN @fecha1 AND @fecha2)
				 AND ((@importe1 is null AND @importe2 is null) OR facturas.total BETWEEN @importe1 AND @importe2)
				 AND ((@detalle is null) OR publicaciones.descripcion LIKE '%'+@detalle+'%')
				 UNION
				 SELECT count(*) as cantidad_facturas from WOLOLOX.facturas
                 INNER JOIN WOLOLOX.publicaciones on publicaciones.codigo = facturas.id_publicacion
				 WHERE (@id IS NULL OR publicaciones.id_usuario = @id)
				 AND ((@fecha1 is null AND @fecha2 is null) OR facturas.fecha BETWEEN @fecha1 AND @fecha2)
				 AND ((@importe1 is null AND @importe2 is null) OR facturas.total BETWEEN @importe1 AND @importe2)
				 AND ((@detalle is null) OR publicaciones.descripcion LIKE '%'+@detalle+'%')) as cantFacturas)

SELECT @cantidad

GO

IF OBJECT_ID('WOLOLOX.consultaDeFacturas') IS NOT NULL
   DROP PROCEDURE WOLOLOX.consultaDeFacturas;
GO
  CREATE PROCEDURE WOLOLOX.consultaDeFacturas(@id numeric(18,0),@fecha1 DateTime,@fecha2 DateTime,@importe1 nvarchar(21),@importe2 nvarchar(21),@detalle nvarchar(255),@rowInicial int)
AS

(select nro_fact,publicaciones.descripcion,compras.id_compra as id_compra,facturas.fecha,facturas.total from WOLOLOX.facturas
INNER JOIN WOLOLOX.compras on compras.id_compra = facturas.id_compra
INNER JOIN WOLOLOX.publicaciones on publicaciones.codigo = compras.cod_publicacion
WHERE ((@id IS NULL) OR compras.id_usuario = @id)
				AND ((@fecha1 is null AND @fecha2 is null) OR facturas.fecha BETWEEN @fecha1 AND @fecha2)
				AND ((@importe1 is null AND @importe2 is null) OR facturas.total BETWEEN @importe1 AND @importe2)
				AND ((@detalle is null) OR publicaciones.descripcion LIKE '%'+@detalle+'%')
UNION
select nro_fact,publicaciones.descripcion,null,facturas.fecha,facturas.total from WOLOLOX.facturas
INNER JOIN WOLOLOX.publicaciones on publicaciones.codigo = facturas.id_publicacion
WHERE ((@id IS NULL) OR publicaciones.id_usuario = @id)
				AND ((@fecha1 is null AND @fecha2 is null) OR facturas.fecha BETWEEN @fecha1 AND @fecha2)
				AND ((@importe1 is null AND @importe2 is null) OR facturas.total BETWEEN @importe1 AND @importe2)
				AND ((@detalle is null) OR publicaciones.descripcion LIKE '%'+@detalle+'%'))

ORDER BY facturas.nro_fact OFFSET @rowInicial ROWS FETCH NEXT 6 ROWS ONLY

GO

--Ofertas

IF OBJECT_ID('WOLOLOX.insertOferta') IS NOT NULL
   DROP PROCEDURE WOLOLOX.insertOferta;
GO

CREATE PROCEDURE WOLOLOX.insertOferta(@idUser numeric(18,0),@codPubli numeric(18,0),@fecha DateTime,@monto numeric(18,0))
AS

insert into WOLOLOX.ofertas(id_usuario,cod_publicacion,fecha,monto)
values (@idUser,@codPubli,@fecha,@monto)

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

USE GD1C2016

IF OBJECT_ID('WOLOLOX.CrearUsuarioRolGenerico') IS NOT NULL
    DROP PROCEDURE WOLOLOX.CrearUsuarioRolGenerico;
GO
CREATE PROCEDURE WOLOLOX.CrearUsuarioRolGenerico(@username nvarchar(50), @pass nvarchar(25), @mail nvarchar(50), @tel nvarchar(50), @domicilio nvarchar(100),@numDom numeric(19,0), @piso numeric(18,0), @depto nvarchar(50),@localidad nvarchar(100),@ciudad nvarchar(100),@codPostal nvarchar(50), @idRol numeric(2,0))
AS
	
	INSERT INTO WOLOLOX.usuarios(nombre_usuario,contraseña,mail,fecha_creacion,intentos_login,telefono)
	VALUES (@username,HASHBYTES('SHA2_256',@pass),@mail,GETDATE(),0,@tel)
	declare @fkUsuario numeric(18,0) = scope_identity();   
	INSERT INTO WOLOLOX.direcciones(calle, numero, piso, departamento, localidad, cod_postal, ciudad, id_usuario)
	VALUES (@domicilio,@numDom,@piso,@depto,@localidad,@codPostal,@ciudad,@fkUsuario)
	INSERT INTO WOLOLOX.roles_usuarios(id_rol, id_usuario)
	VALUES (@idRol,@fkUsuario)
	
GO

IF OBJECT_ID('WOLOLOX.CrearCliente') IS NOT NULL
    DROP PROCEDURE WOLOLOX.CrearCliente;
GO
CREATE PROCEDURE WOLOLOX.CrearCliente(@username nvarchar(50), @pass nvarchar(25), @nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(50), @tel nvarchar(50), @domicilio nvarchar(100),@numDom numeric(19,0), @piso numeric(18,0), @depto nvarchar(50),@localidad nvarchar(100),@ciudad nvarchar(100),@codPostal nvarchar(50), @dni numeric(18,0), @fechaNac datetime)
AS
     
	INSERT INTO WOLOLOX.usuarios(nombre_usuario,contraseña,mail,fecha_creacion,intentos_login,telefono)
	VALUES (@username,HASHBYTES('SHA2_256',@pass),@mail,GETDATE(),0,@tel)
	declare @fkUsuario numeric(18,0) = scope_identity();
	INSERT INTO WOLOLOX.clientes(apellido,nombre, dni,fecha_nacimiento,id_usuario)
	VALUES	(@apellido,@nombre,@dni,@fechaNac,@fkUsuario)
	INSERT INTO WOLOLOX.direcciones(calle, numero, piso, departamento, localidad, cod_postal, ciudad,id_usuario)
	VALUES (@domicilio,@numDom,@piso,@depto,@localidad,@codPostal,@ciudad,@fkUsuario)
	INSERT INTO WOLOLOX.roles_usuarios(id_rol,id_usuario)
	VALUES ((SELECT id FROM roles r WHERE r.nombre='Cliente'),@fkUsuario)
	
GO

IF OBJECT_ID('WOLOLOX.CrearEmpresa') IS NOT NULL
    DROP PROCEDURE WOLOLOX.CrearEmpresa;
GO
CREATE PROCEDURE WOLOLOX.CrearEmpresa(@username nvarchar(50), @pass nvarchar(25), @razSoc nvarchar(255), @mail nvarchar(50), @tel nvarchar(50), @domicilio nvarchar(100),@numDom numeric(19,0), @piso numeric(18,0), @depto nvarchar(50),@localidad nvarchar(100),@ciudad nvarchar(100),@codPostal nvarchar(50), @cuit nvarchar(50),@rubro nvarchar(20), @nomContac nvarchar(100))
AS
     
    
	INSERT INTO WOLOLOX.usuarios(nombre_usuario,contraseña,mail,fecha_creacion,intentos_login,telefono)
	VALUES (@username,HASHBYTES('SHA2_256',@pass),@mail,GETDATE(),0,@tel)
	declare @fkUsuario numeric(18,0) = scope_identity();
	INSERT INTO WOLOLOX.empresas(id_usuario,razon_social,nombre_contacto,cuit,reputacion,cod_rubro)
	VALUES	(@fkUsuario, @razSoc,@nomContac,@cuit,0, (SELECT codigo FROM WOLOLOX.rubros where descripcion_larga=@rubro))
	INSERT INTO WOLOLOX.direcciones(calle, numero, piso, departamento, localidad, cod_postal, ciudad,id_usuario)
	VALUES (@domicilio,@numDom,@piso,@depto,@localidad,@codPostal,@ciudad,@fkUsuario)
	INSERT INTO WOLOLOX.roles_usuarios(id_rol,id_usuario)
	VALUES ((SELECT id FROM roles r WHERE r.nombre='Empresa'),@fkUsuario)
	
GO

IF OBJECT_ID('WOLOLOX.ObtenerClientesHabilitados') IS NOT NULL
    DROP PROCEDURE WOLOLOX.ObtenerClientesHabilitados;
GO
CREATE PROCEDURE WOLOLOX.ObtenerClientesHabilitados
AS
    SELECT c.id_usuario, c.nombre, c.apellido,u.mail, c.dni
	FROM WOLOLOX.clientes c, WOLOLOX.usuarios u
	WHERE c.id_usuario=u.id_usuario AND u.habilitado=1
GO

IF OBJECT_ID('WOLOLOX.ObtenerEmpresasHabilitadas') IS NOT NULL
    DROP PROCEDURE WOLOLOX.ObtenerEmpresasHabilitadas;
GO
CREATE PROCEDURE WOLOLOX.ObtenerEmpresasHabilitadas
AS
    SELECT e.id_usuario, e.razon_social,r.descripcion_larga, e.cuit, e.nombre_contacto, e.reputacion
	FROM WOLOLOX.empresas e, WOLOLOX.usuarios u, rubros r
	WHERE e.id_usuario=u.id_usuario AND u.habilitado=1 AND r.codigo=e.cod_rubro
GO

IF OBJECT_ID('WOLOLOX.ObtenerClientesBloqueados') IS NOT NULL
    DROP PROCEDURE WOLOLOX.ObtenerClientesBloqueados;
GO
CREATE PROCEDURE WOLOLOX.ObtenerClientesBloqueados
AS
    SELECT c.id_usuario,c.nombre,c.apellido,u.mail,c.dni
	FROM WOLOLOX.clientes c, WOLOLOX.usuarios u
	WHERE c.id_usuario=u.id_usuario
	AND u.habilitado=0;
GO

USE GD1C2016

IF OBJECT_ID('WOLOLOX.ObtenerEmpresasBloqueadas') IS NOT NULL
    DROP PROCEDURE WOLOLOX.ObtenerEmpresasBloqueadas;
GO
CREATE PROCEDURE WOLOLOX.ObtenerEmpresasBloqueadas
AS
    SELECT e.id_usuario, e.razon_social,r.descripcion_larga, e.cuit, e.nombre_contacto, e.reputacion
	FROM WOLOLOX.empresas e, WOLOLOX.usuarios u, WOLOLOX.rubros r
	WHERE e.id_usuario=u.id_usuario AND u.habilitado=0 AND r.codigo=e.cod_rubro;
GO

IF OBJECT_ID('WOLOLOX.ObtenerUsuariosHabilitados') IS NOT NULL
    DROP PROCEDURE WOLOLOX.ObtenerUsuariosHabilitados;
GO
CREATE PROCEDURE WOLOLOX.ObtenerUsuariosHabilitados(@idRol numeric(2,0))
AS
    SELECT nombre_usuario, mail, telefono, fecha_creacion
	FROM WOLOLOX.usuarios u, WOLOLOX.roles_usuarios r
	WHERE u.habilitado=1 AND r.id_rol=@idRol AND r.id_usuario=u.id_usuario
	--AND  NOT EXISTS (SELECT * FROM empresas e WHERE e.id_usuario=u.id_usuario)
	--AND  NOT EXISTS (SELECT * FROM clientes c WHERE c.id_usuario=u.id_usuario)
GO

IF OBJECT_ID('WOLOLOX.ObtenerUsuariosBloqueados') IS NOT NULL
    DROP PROCEDURE WOLOLOX.ObtenerUsuariosBloqueados;
GO
CREATE PROCEDURE WOLOLOX.ObtenerUsuariosBloqueados(@idRol numeric(2,0))
AS
    SELECT nombre_usuario, mail, telefono, fecha_creacion
	FROM WOLOLOX.usuarios u, WOLOLOX.roles_usuarios r
	WHERE u.habilitado=0 AND r.id_rol=@idRol AND r.id_usuario=u.id_usuario
	--AND  NOT EXISTS (SELECT * FROM empresas e WHERE e.id_usuario=u.id_usuario)
	--AND  NOT EXISTS (SELECT * FROM clientes c WHERE c.id_usuario=u.id_usuario)
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

IF OBJECT_ID('WOLOLOX.BuscarUsuarioHabilitado') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarUsuarioHabilitado;
GO
CREATE PROCEDURE WOLOLOX.BuscarUsuarioHabilitado(@nombre nvarchar(25), @tel nvarchar(50), @mail nvarchar(50), @rolID numeric(2,0))
AS
    declare @query nvarchar(256)
	set @query = 'SELECT u.id_usuario,nombre_usuario,mail,telefono FROM WOLOLOX.usuarios u, WOLOLOX.roles_usuarios r WHERE u.id_usuario=r.id_usuario AND u.habilitado=1 AND r.id_rol='+QUOTENAME(@rolID,'''') +' '

	if(LEN(@nombre) > 0) SET @query += ' AND nombre_usuario LIKE '+QUOTENAME(@nombre,'''') +' ';
	if(LEN(@tel) > 0) SET @query += ' AND telefono LIKE '+QUOTENAME(@tel,'''')+' ';
	if(LEN(@mail) > 0) SET @query += ' AND mail LIKE '+QUOTENAME(@mail,'''')+' ';
		
	print @query

	execute sp_executesql @query
GO

IF OBJECT_ID('WOLOLOX.BuscarUsuarioBloq') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarUsuarioBloq;
GO
CREATE PROCEDURE WOLOLOX.BuscarUsuarioBloq(@nombre nvarchar(25), @tel nvarchar(50), @mail nvarchar(50), @rolID numeric(2,0))
AS
    declare @query nvarchar(256)
	set @query = 'SELECT u.id_usuario,nombre_usuario,mail,telefono FROM WOLOLOX.usuarios u, WOLOLOX.roles_usuarios r WHERE u.id_usuario=r.id_usuario AND u.habilitado=0 AND r.id_rol='+QUOTENAME(@rolID,'''') +' '

	if(LEN(@nombre) > 0) SET @query += ' AND nombre_usuario LIKE '+QUOTENAME(@nombre,'''') +' ';
	if(LEN(@tel) > 0) SET @query += ' AND telefono LIKE '+QUOTENAME(@tel,'''')+' ';
	if(LEN(@mail) > 0) SET @query += ' AND mail LIKE '+QUOTENAME(@mail,'''')+' ';
		
	print @query

	execute sp_executesql @query
GO

IF OBJECT_ID('WOLOLOX.BuscarDireccion') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarDireccion;
GO
CREATE PROCEDURE WOLOLOX.BuscarDireccion(@id numeric)
AS
     
    SELECT calle, numero, piso, departamento, localidad, cod_postal, ciudad
	FROM WOLOLOX.direcciones d, WOLOLOX.usuarios u
	WHERE @id=d.id_usuario
GO

IF OBJECT_ID('WOLOLOX.BuscarCliente') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarCliente;
GO
CREATE PROCEDURE WOLOLOX.BuscarCliente(@nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(255), @dni numeric(18,0))
AS
    declare @query nvarchar(256)
	set @query = 'SELECT c.id_usuario, nombre,apellido,mail,dni FROM WOLOLOX.clientes c, WOLOLOX.usuarios u WHERE 1=1 AND c.id_usuario=u.id_usuario AND u.habilitado=1'

	if(LEN(@nombre) > 0) SET @query += ' AND nombre LIKE '+QUOTENAME(@nombre,'''') +' ';
	if(LEN(@apellido) > 0) SET @query += ' AND apellido LIKE '+QUOTENAME(@apellido,'''')+' ';
	if(LEN(@mail) > 0) SET @query += ' AND mail LIKE '+QUOTENAME(@mail,'''')+' ';
	if((@dni) > 0) SET @query += ' AND dni LIKE '+QUOTENAME(@dni,'''')+' ';
		
	print @query

	execute sp_executesql @query
GO

IF OBJECT_ID('WOLOLOX.BuscarClienteBloq') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarClienteBloq;
GO
CREATE PROCEDURE WOLOLOX.BuscarClienteBloq(@nombre nvarchar(255), @apellido nvarchar(255), @mail nvarchar(255), @dni numeric(18,0))
AS
    declare @query nvarchar(256)
	set @query = 'SELECT c.id_usuario, nombre,apellido,mail,dni FROM WOLOLOX.clientes c, WOLOLOX.usuarios u WHERE 1=1 AND c.id_usuario=u.id_usuario AND u.habilitado=0'

	if(LEN(@nombre) > 0) SET @query += ' AND nombre LIKE '+QUOTENAME(@nombre,'''') +' ';
	if(LEN(@apellido) > 0) SET @query += ' AND apellido LIKE '+QUOTENAME(@apellido,'''')+' ';
	if(LEN(@mail) > 0) SET @query += ' AND mail LIKE '+QUOTENAME(@mail,'''')+' ';
	if((@dni) > 0) SET @query += ' AND dni LIKE '+QUOTENAME(@dni,'''')+' ';
		
	print @query

	execute sp_executesql @query
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
	FROM WOLOLOX.direcciones d
	WHERE @id = d.id_usuario
	UPDATE WOLOLOX.usuarios
	SET mail=@mail,telefono=@tel
	WHERE id_usuario=@id
GO

USE GD1C2016

IF OBJECT_ID('WOLOLOX.ActualizarUsuario') IS NOT NULL
    DROP PROCEDURE WOLOLOX.ActualizarUsuario;
GO
CREATE PROCEDURE WOLOLOX.ActualizarUsuario(@id numeric(18,0), @nombre nvarchar(255), @mail nvarchar(50), @tel nvarchar(50), @domicilio nvarchar(100),@numDom numeric(19,0), @piso numeric(18,0), @depto nvarchar(50),@localidad nvarchar(100),@ciudad nvarchar(100),@codPostal nvarchar(50))
AS
     
	UPDATE WOLOLOX.direcciones
	SET calle=@domicilio, numero=@numDom, piso=@piso, departamento=@depto, localidad=@localidad, cod_postal=@codPostal, ciudad=@ciudad
	FROM WOLOLOX.direcciones d
	WHERE d.id_usuario = @id
	UPDATE WOLOLOX.usuarios
	SET nombre_usuario=@nombre, mail=@mail,telefono=@tel
	WHERE id_usuario=@id
GO

IF OBJECT_ID('WOLOLOX.BuscarEmpresa') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarEmpresa;
GO
CREATE PROCEDURE WOLOLOX.BuscarEmpresa(@razSoc nvarchar(255), @cuit nvarchar(50), @nomCon nvarchar(100),@rubro nvarchar(20), @repMin numeric(3,2), @repMax numeric(3,2))
AS
    declare @query nvarchar(256)
	set @query = 'SELECT e.id_usuario,razon_social,descripcion_larga,cuit,nombre_contacto,reputacion FROM WOLOLOX.empresas e, WOLOLOX.usuarios u, WOLOLOX.rubros r WHERE 1=1 AND e.id_usuario=u.id_usuario AND e.cod_rubro=r.codigo AND u.habilitado=1'

	if(LEN(@razSoc) > 0) SET @query += ' AND razon_social LIKE '+QUOTENAME(@razSoc,'''') +' ';
	if(LEN(@cuit) > 0) SET @query += ' AND cuit LIKE '+QUOTENAME(@cuit,'''')+' ';
	if(LEN(@nomCon) > 0) SET @query += ' AND nombre_contacto LIKE '+QUOTENAME(@nomCon,'''')+' ';
	if(LEN(@rubro) > 0) SET @query += ' AND descripcion_larga LIKE '+QUOTENAME(@rubro,'''')+' ';
	if((@repMin) > 0) SET @query += ' AND reputacion> '+QUOTENAME(@repMin,'''')+' ';
	if((@repMax) > 0) SET @query += ' AND reputacion> '+QUOTENAME(@repMax,'''')+' ';
		
	print @query

	execute sp_executesql @query
   
GO

IF OBJECT_ID('WOLOLOX.BuscarEmpresaBloq') IS NOT NULL
    DROP PROCEDURE WOLOLOX.BuscarEmpresaBloq;
GO
CREATE PROCEDURE WOLOLOX.BuscarEmpresaBloq(@razSoc nvarchar(255), @cuit nvarchar(50), @nomCon nvarchar(100),@rubro nvarchar(20), @repMin numeric(3,2), @repMax numeric(3,2))
AS
    declare @query nvarchar(256)
	set @query = 'SELECT e.id_usuario,razon_social,descripcion_larga,cuit,nombre_contacto,reputacion FROM WOLOLOX.empresas e, WOLOLOX.usuarios u, WOLOLOX.rubros r WHERE 1=1 AND e.id_usuario=u.id_usuario AND e.cod_rubro=r.codigo AND u.habilitado=0'

	if(LEN(@razSoc) > 0) SET @query += ' AND razon_social LIKE '+QUOTENAME(@razSoc,'''') +' ';
	if(LEN(@cuit) > 0) SET @query += ' AND cuit LIKE '+QUOTENAME(@cuit,'''')+' ';
	if(LEN(@nomCon) > 0) SET @query += ' AND nombre_contacto LIKE '+QUOTENAME(@nomCon,'''')+' ';
	if(LEN(@rubro) > 0) SET @query += ' AND descripcion_larga LIKE '+QUOTENAME(@rubro,'''')+' ';
	if((@repMin) > 0) SET @query += ' AND reputacion> '+QUOTENAME(@repMin,'''')+' ';
	if((@repMax) > 0) SET @query += ' AND reputacion> '+QUOTENAME(@repMax,'''')+' ';
		
	print @query

	execute sp_executesql @query
   
GO

IF OBJECT_ID('WOLOLOX.obtenerCliente') IS NOT NULL
    DROP PROCEDURE WOLOLOX.obtenerCliente;
GO
CREATE PROCEDURE WOLOLOX.obtenerCliente(@id numeric(18,0))
AS
    SELECT c.nombre,c.apellido,c.dni
    FROM WOLOLOX.clientes c, WOLOLOX.usuarios u
	WHERE c.id_usuario=u.id_usuario AND u.id_usuario=@id
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
	FROM WOLOLOX.direcciones d
	WHERE @id = d.id_usuario
	UPDATE WOLOLOX.usuarios
	SET mail=@mail,telefono=@tel
	WHERE id_usuario=@id
GO

IF OBJECT_ID('WOLOLOX.CambiarContraseña') IS NOT NULL
    DROP PROCEDURE WOLOLOX.CambiarContraseña;
GO
CREATE PROCEDURE WOLOLOX.CambiarContraseña(@nombre nvarchar(255), @contraseña nvarchar(255))
AS
UPDATE WOLOLOX.usuarios
SET contraseña= HASHBYTES('SHA2_256',@contraseña)
WHERE nombre_usuario=@nombre

GO

--Funcionalidades

IF OBJECT_ID('WOLOLOX.traerFuncionalidades') IS NOT NULL
    DROP PROCEDURE WOLOLOX.traerFuncionalidades;
GO
CREATE PROCEDURE WOLOLOX.traerFuncionalidades(@rol nvarchar(50))
AS

SELECT funcionalidades.nombre FROM WOLOLOX.funcionalidades
INNER JOIN WOLOLOX.funcionalidades_roles ON funcionalidades_roles.id_funcionalidad = funcionalidades.id
INNER JOIN WOLOLOX.roles ON roles.id = funcionalidades_roles.id_rol
WHERE roles.nombre LIKE @rol

GO

IF OBJECT_ID('WOLOLOX.DeshabilitarUsuario') IS NOT NULL
    DROP PROCEDURE WOLOLOX.DeshabilitarUsuario;
GO
CREATE PROCEDURE WOLOLOX.DeshabilitarUsuario(@id numeric(18,0))
AS
	UPDATE WOLOLOX.usuarios
	SET habilitado=0
	WHERE id_usuario=@id
GO


IF OBJECT_ID('WOLOLOX.HabilitarUsuario') IS NOT NULL
    DROP PROCEDURE WOLOLOX.HabilitarUsuario;
GO
CREATE PROCEDURE WOLOLOX.HabilitarUsuario(@id numeric(18,0))
AS
	UPDATE WOLOLOX.usuarios
	SET habilitado=1
	WHERE id_usuario=@id
GO

--Chequear publicaciones vencidas

IF OBJECT_ID('WOLOLOX.ActualizarPublicacionesVencidas') IS NOT NULL
 DROP PROCEDURE WOLOLOX.ActualizarPublicacionesVencidas;
GO
CREATE PROCEDURE WOLOLOX.ActualizarPublicacionesVencidas(@fechaDeHoy DateTime)
AS
 BEGIN TRANSACTION

 UPDATE WOLOLOX.publicaciones
 set publicaciones.id_estado = (SELECT estados.id_estado FROM WOLOLOX.estados WHERE estados.nombre LIKE 'Finalizada')
 WHERE @fechaDeHoy > publicaciones.fecha_vencimiento
 
 COMMIT
GO


-- Eliminar usuario, elimina su dirección, sus datos, sus rol-usuario, sus ofertas, sus publicaciones y sus compras

IF OBJECT_ID('WOLOLOX.EliminarUsuario') IS NOT NULL
	DROP TRIGGER WOLOLOX.EliminarUsuario
GO
CREATE TRIGGER WOLOLOX.EliminarUsuario
	ON WOLOLOX.usuarios
	INSTEAD OF DELETE
AS
	BEGIN TRANSACTION
	
	-- Eliminar su dirección

	DELETE FROM WOLOLOX.direcciones
	WHERE direcciones.id_usuario IN(SELECT id_usuario FROM deleted)

	-- Eliminar sus datos

	DELETE FROM WOLOLOX.clientes
	WHERE clientes.id_usuario IN(SELECT id_usuario FROM deleted)

	DELETE FROM WOLOLOX.empresas
	WHERE empresas.id_usuario IN(SELECT id_usuario FROM deleted)

	-- Eliminar sus rol-usuario

	DELETE FROM WOLOLOX.roles_usuarios
	WHERE roles_usuarios.id_usuario IN(SELECT id_usuario FROM deleted)

	-- Eliminar usuarios

	DELETE FROM WOLOLOX.usuarios
	WHERE usuarios.id_usuario IN(SELECT id_usuario FROM deleted)

	COMMIT
GO

-- Hacer una compra, resta la cantidad comprada de la publicación y genera una factura

IF OBJECT_ID('WOLOLOX.InsertarCompra') IS NOT NULL
 DROP TRIGGER WOLOLOX.InsertarCompra;
GO
CREATE TRIGGER WOLOLOX.InsertarCompra
    ON WOLOLOX.compras
    FOR INSERT
AS
 BEGIN TRANSACTION
 
 -- Actualizo la cantidad de stock
 
 UPDATE WOLOLOX.publicaciones SET stock = stock - inserted.cantidad 
 FROM inserted 
 WHERE publicaciones.codigo = inserted.cod_publicacion
 
 -- Genero una factura
 
 INSERT INTO WOLOLOX.facturas (id_compra, id_publicacion, fecha, total)
 SELECT inserted.id_compra, inserted.cod_publicacion, GETDATE(), inserted.cantidad * publicaciones.precio 
 FROM inserted, WOLOLOX.publicaciones
 WHERE inserted.cod_publicacion = publicaciones.codigo

 -- GENERO item_factura

 INSERT INTO WOLOLOX.item_factura (nro_fact, monto, descripcion, cantidad)
 SELECT SCOPE_IDENTITY(), publicaciones.precio, publicaciones.descripcion, inserted.cantidad
 FROM inserted, WOLOLOX.publicaciones
 WHERE publicaciones.codigo = inserted.cod_publicacion
 
 COMMIT
GO

-- Actualizar publicación, pasa el estado a finalizada si stock = 0 y genera factura

IF OBJECT_ID('WOLOLOX.ActualizarPubli') IS NOT NULL
 DROP TRIGGER WOLOLOX.ActualizarPubli;
GO
CREATE TRIGGER WOLOLOX.ActualizarPubli
 ON WOLOLOX.publicaciones
 FOR UPDATE
AS
 BEGIN TRANSACTION

 -- Actualizo el estado

 UPDATE WOLOLOX.publicaciones
 set publicaciones.id_estado = (SELECT estados.id_estado FROM WOLOLOX.estados WHERE estados.nombre LIKE 'Finalizada')
 FROM inserted WHERE inserted.codigo = publicaciones.codigo AND inserted.stock = 0

 -- Genero una factura si estado pasó a finalizada

 if ((SELECT inserted.stock FROM inserted) = 0)
 BEGIN
  INSERT INTO WOLOLOX.facturas (id_publicacion, fecha, total)
  SELECT publicaciones.codigo, GETDATE(), visibilidades.costo_envio + visibilidades.costo_publicacion + (visibilidades.porc_producto*publicaciones.precio* 
  (SELECT SUM(compras.cantidad)
  FROM WOLOLOX.compras, WOLOLOX.publicaciones, inserted 
  WHERE compras.cod_publicacion = publicaciones.codigo AND publicaciones.codigo = inserted.codigo))
  FROM WOLOLOX.publicaciones, WOLOLOX.visibilidades, inserted
  WHERE publicaciones.codigo = inserted.codigo
  AND publicaciones.cod_visibilidad = visibilidades.codigo

  -- Genero item_facutra

  INSERT INTO WOLOLOX.item_factura (nro_fact, monto, descripcion, cantidad)
  SELECT SCOPE_IDENTITY(), (visibilidades.costo_envio + visibilidades.costo_publicacion + (visibilidades.porc_producto*publicaciones.precio*  
  (SELECT SUM(compras.cantidad)
  FROM WOLOLOX.compras, WOLOLOX.publicaciones, inserted 
  WHERE compras.cod_publicacion = publicaciones.codigo AND publicaciones.codigo = inserted.codigo))), publicaciones.descripcion, 
  (SELECT SUM(compras.cantidad) FROM WOLOLOX.compras, WOLOLOX.publicaciones, inserted 
  WHERE compras.cod_publicacion = publicaciones.codigo AND publicaciones.codigo = inserted.codigo)
  FROM WOLOLOX.publicaciones, WOLOLOX.visibilidades, inserted
  WHERE publicaciones.codigo = inserted.codigo AND visibilidades.codigo = publicaciones.cod_visibilidad
  
 END

 COMMIT
GO

-- Hacer una oferta, actualiza el valor de la publicación

IF OBJECT_ID('WOLOLOX.InsertarOferta') IS NOT NULL
 DROP TRIGGER WOLOLOX.InsertarOferta;
GO
CREATE TRIGGER WOLOLOX.InsertarOferta
 ON WOLOLOX.ofertas
 FOR INSERT
AS
 BEGIN TRANSACTION

 -- Actualizo el valor de la subasta

 UPDATE WOLOLOX.publicaciones
 SET precio = inserted.monto FROM inserted, publicaciones
 WHERE publicaciones.codigo = inserted.cod_publicacion

 COMMIT
GO

-- Actualizar estado, genera una factura si estado pasa a ser 'finalizada'

IF OBJECT_ID('WOLOLOX.ActualizarEstado') IS NOT NULL
	DROP TRIGGER WOLOLOX.ActualizarEstado;
GO
CREATE TRIGGER WOLOLOX.ActualizarEstado
	ON WOLOLOX.estados
	FOR UPDATE
AS
	BEGIN TRANSACTION

	-- Genero factura si estado pasa a 'finalizada'

	INSERT INTO WOLOLOX.facturas (id_publicacion, fecha, total)
	SELECT publicaciones.codigo, GETDATE(), visibilidades.costo_envio + visibilidades.costo_publicacion + (visibilidades.porc_producto * publicaciones.precio * 
		(SELECT SUM(compras.cantidad)
		FROM WOLOLOX.compras, WOLOLOX.publicaciones, inserted 
		WHERE compras.cod_publicacion = publicaciones.codigo AND publicaciones.id_estado = inserted.id_estado))    
	FROM inserted, WOLOLOX.publicaciones, WOLOLOX.visibilidades
	WHERE inserted.id_estado = publicaciones.id_estado AND publicaciones.cod_visibilidad = visibilidades.codigo

	COMMIT
GO