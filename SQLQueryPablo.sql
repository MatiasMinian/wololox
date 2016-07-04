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

