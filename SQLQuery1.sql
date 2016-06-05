if object_id('WOLOLOX.clientes') is not null
  drop table WOLOLOX.clientes;

create table WOLOLOX.clientes(
dni numeric(18,0),
nombre nvarchar(255),
apellido nvarchar(255),
id_rol numeric(2,0),
id_usuario numeric(18,0),
fecha_nacimiento datetime,
primary key (id_usuario)
);

if object_id('WOLOLOX.empresas') is not null
  drop table WOLOLOX.empresas;

create table WOLOLOX.empresas(
id_usuario numeric(18,0) identity,
razon_social nvarchar(255),
cuit nvarchar(50),
nombre_contacto nvarchar(100),
cod_rubro numeric(18,0),
reputacion numeric(3,2),
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
id numeric(2,0) identity,
nombre nvarchar(50),
primary key(id)
);

if object_id('WOLOLOX.roles') is not null
  drop table WOLOLOX.roles;

create table WOLOLOX.roles(
id numeric(2,0) identity,
nombre nvarchar(50),
estado bit,
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
codigo numeric(18,0) identity,
descripcion_corta nvarchar(20),
descripcion_larga nvarchar(100),
primary key(codigo)
);

if object_id('WOLOLOX.ofertas') is not null
  drop table WOLOLOX.ofertas;

create table WOLOLOX.ofertas(
codigo numeric(18,0) identity,
id_usuario numeric(18,0),
cod_publicacion numeric(18,0),
fecha datetime,
monto numeric(18,2),
primary key (codigo)
);

if object_id('WOLOLOX.item_factura') is not null
  drop table WOLOLOX.item_factura;

create table WOLOLOX.item_factura(
id_item numeric(18,0) identity,
nro_fact numeric(18,0),
tipo_fact nvarchar(1),
monto numeric(18,2),
descripcion nvarchar(255),
cantidad numeric(18,0),
primary key (id_item)
);

if object_id('WOLOLOX.calificaciones') is not null
  drop table WOLOLOX.calificaciones;

create table WOLOLOX.calificaciones(
id_calificacion numeric(18,0) identity,
cod_compra numeric(18,0),
estrellas numeric(18,0),
detalle nvarchar(255),
primary key(id_calificacion)
);

if object_id('WOLOLOX.facturas') is not null
  drop table WOLOLOX.facturas;

create table WOLOLOX.facturas(
nro_fact numeric(18,0),
id_compra numeric(18,0),
id_publicacion numeric(18,0),
tipo nvarchar(1),
fecha datetime,
total numeric(18,2),
forma_pago nvarchar(255),
primary key (nro_fact, tipo)
);

if object_id('WOLOLOX.compras') is not null
  drop table WOLOLOX.compras;

create table WOLOLOX.compras(
id_compra numeric(18,0) identity,
cantidad numeric(18,0),
fecha datetime,
cod_publicacion numeric(18,0),
id_usuario numeric(18,0),
primary key(id_compra)
);

if object_id('WOLOLOX.publicaciones') is not null
  drop table WOLOLOX.publicaciones;

create table WOLOLOX.publicaciones(
codigo numeric(18,0) identity,
id_usuario numeric(18,0),
id_estado numeric(18,0),
cod_visibilidad numeric(18,0),
cod_rubro numeric(18,0),
descripcion nvarchar (255),
stock numeric(18,0),
precio numeric(18,0),
tipo nvarchar(255),
primary key(codigo)
);

if object_id('WOLOLOX.estados') is not null
  drop table WOLOLOX.estados;

create table WOLOLOX.estados(
id_estado numeric(18,0) identity,
fecha_inicio datetime,
fecha_vencimiento datetime,
primary key (id_estado)
);

if object_id('WOLOLOX.visibilidades') is not null
  drop table WOLOLOX.visibilidades;

create table WOLOLOX.visibilidades(
codigo numeric(18,0) identity,
descripcion nvarchar(255),
porc_envio numeric(18,0),
porc_producto numeric(18,0),
porc_publicacion numeric(18,0),
costo numeric(18,0),
primary key (codigo)
);

if object_id('WOLOLOX.usuarios') is not null
  drop table WOLOLOX.usuarios;

create table WOLOLOX.usuarios(
id_usuario numeric(18,0) identity,
nombre_usuario nvarchar(25),
contraseña nvarchar(25),
intentos_login numeric(1,0),
mail nvarchar(50),
telefono nvarchar(50),
id_direccion numeric(18,0),
fecha_creacion datetime,
primary key (id_usuario),
unique (nombre_usuario)
);

if object_id('WOLOLOX.direcciones') is not null
  drop table WOLOLOX.direcciones;

create table WOLOLOX.direcciones(
id numeric(18,0) identity,
calle nvarchar(100),
numero numeric(19,0),
piso numeric(18,0),
departamento nvarchar(50),
localidad nvarchar(100),
cod_postal nvarchar(50),
ciudad nvarchar(100),
primary key(id)
);

alter table WOLOLOX.usuarios
add constraint FK_usuarios_direccion
foreign key (id_direccion)
references WOLOLOX.direcciones (id);

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
add constraint FK_clientes_rol
foreign key (id_rol)
references WOLOLOX.roles (id);

alter table WOLOLOX.clientes
add constraint FK_clientes_usuario
foreign key (id_usuario)
references WOLOLOX.usuarios (id_usuario);

alter table WOLOLOX.empresas
add constraint FK_empresas_usuario
foreign key (id_usuario)
references WOLOLOX.usuarios (id_usuario);

alter table WOLOLOX.empresas
add constraint FK_empresas_rubro
foreign key (cod_rubro)
references WOLOLOX.rubros (codigo);

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
foreign key (nro_fact,tipo_fact)
references WOLOLOX.facturas (nro_fact,tipo);

