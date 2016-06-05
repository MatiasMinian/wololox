if object_id('clientes') is not null
  drop table clientes;

create table clientes(
dni numeric(18,0),
nombre nvarchar(255),
apellido nvarchar(255),
id_rol numeric(2,0),
id_usuario numeric(18,0),
fecha_nacimiento datetime,
primary key (id_usuario)
);

if object_id('empresas') is not null
  drop table empresas;

create table empresas(
id_usuario numeric(18,0) identity,
razon_social nvarchar(255),
cuit nvarchar(50),
nombre_contacto nvarchar(100),
cod_rubro numeric(18,0),
reputacion numeric(3,2),
);


if object_id('roles_usuarios') is not null
  drop table roles_usuarios;

create table roles_usuarios(
id_rol numeric(2,0),
id_usuario numeric(18,0),
primary key(id_rol,id_usuario)
);

if object_id('funcionalidades_roles') is not null
  drop table funcionalidades_roles;

create table funcionalidades_roles(
id_funcionalidad numeric(2,0),
id_rol numeric(2,0),
primary key(id_funcionalidad,id_rol)
);

if object_id('funcionalidades') is not null
  drop table funcionalidades;

create table funcionalidades(
id numeric(2,0) identity,
nombre nvarchar(50),
primary key(id)
);

if object_id('roles') is not null
  drop table roles;

create table roles(
id numeric(2,0) identity,
nombre nvarchar(50),
estado bit,
primary key(id)
);

if object_id('publicaciones_rubros') is not null
  drop table publicaciones_rubros;

create table publicaciones_rubros(
cod_publicacion numeric(18,0),
cod_rubro numeric(18,0)
primary key (cod_publicacion,cod_rubro)
);

if object_id('rubros') is not null
  drop table rubros;

create table rubros(
codigo numeric(18,0) identity,
descripcion_corta nvarchar(20),
descripcion_larga nvarchar(100),
primary key(codigo)
);

if object_id('ofertas') is not null
  drop table ofertas;

create table ofertas(
codigo numeric(18,0) identity,
id_usuario numeric(18,0),
cod_publicacion numeric(18,0),
fecha datetime,
monto numeric(18,2),
primary key (codigo)
);

if object_id('item_factura') is not null
  drop table item_factura;

create table item_factura(
id_item numeric(18,0) identity,
nro_fact numeric(18,0),
tipo_fact nvarchar(1),
monto numeric(18,2),
descripcion nvarchar(255),
cantidad numeric(18,0),
primary key (id_item)
);

if object_id('calificaciones') is not null
  drop table calificaciones;

create table calificaciones(
id_calificacion numeric(18,0) identity,
cod_compra numeric(18,0),
estrellas numeric(18,0),
detalle nvarchar(255),
primary key(id_calificacion)
);

if object_id('compras') is not null
  drop table compras;

create table compras(
id_compra numeric(18,0) identity,
cantidad numeric(18,0),
nro_fact numeric(18,0),
tipo_fact nvarchar(1),
fecha datetime,
cod_publicacion numeric(18,0),
id_usuario numeric(18,0),
primary key(id_compra)
);

if object_id('facturas') is not null
  drop table facturas;

create table facturas(
nro_fact numeric(18,0),
id_compra numeric(18,0),
id_publicacion numeric(18,0),
tipo nvarchar(1),
fecha datetime,
total numeric(18,2),
forma_pago nvarchar(255),
primary key (nro_fact, tipo)
);

if object_id('publicaciones') is not null
  drop table publicaciones;

create table publicaciones(
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

if object_id('estados') is not null
  drop table estados;

create table estados(
id_estado numeric(18,0) identity,
fecha_inicio datetime,
fecha_vencimiento datetime,
primary key (id_estado)
);

if object_id('visibilidades') is not null
  drop table visibilidades;

create table visibilidades(
codigo numeric(18,0) identity,
descripcion nvarchar(255),
porc_envio numeric(18,0),
porc_producto numeric(18,0),
porc_publicacion numeric(18,0),
costo numeric(18,0),
primary key (codigo)
);

if object_id('usuarios') is not null
  drop table usuarios;

create table usuarios(
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

if object_id('direcciones') is not null
  drop table direcciones;

create table direcciones(
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

alter table usuarios
add constraint FK_usuarios_direccion
foreign key (id_direccion)
references direcciones (id);

alter table compras
add constraint FK_compras_factura
foreign key (nro_fact,tipo_fact)
references facturas (nro_fact,tipo);

alter table compras
add constraint FK_compras_publicacion
foreign key (cod_publicacion)
references publicaciones (codigo);

alter table compras
add constraint FK_compras_usuario
foreign key (id_usuario)
references usuarios (id_usuario);

alter table roles_usuarios
add constraint FK_rolesUsuarios_rol
foreign key (id_rol)
references roles (id);

alter table roles_usuarios
add constraint FK_rolesUsuarios_usuario
foreign key (id_usuario)
references usuarios (id_usuario);

alter table funcionalidades_roles
add constraint FK_funcionalidadesRoles_rol
foreign key (id_rol)
references roles (id);

alter table funcionalidades_roles
add constraint FK_rfuncionalidadesRoles_funcionalidad
foreign key (id_funcionalidad)
references funcionalidades (id);

alter table clientes
add constraint FK_clientes_rol
foreign key (id_rol)
references roles (id);

alter table clientes
add constraint FK_clientes_usuario
foreign key (id_usuario)
references usuarios (id_usuario);

alter table empresas
add constraint FK_empresas_usuario
foreign key (id_usuario)
references usuarios (id_usuario);

alter table empresas
add constraint FK_empresas_rubro
foreign key (cod_rubro)
references rubros (codigo);

alter table ofertas
add constraint FK_ofertas_usuario
foreign key (id_usuario)
references usuarios (id_usuario);

alter table ofertas
add constraint FK_empresas_publicacion
foreign key (cod_publicacion)
references publicaciones (codigo);

alter table publicaciones_rubros
add constraint FK_publicacionesRubros_publicacion
foreign key (cod_publicacion)
references publicaciones (codigo);

alter table publicaciones_rubros
add constraint FK_publicacionesRubros_rubro
foreign key (cod_rubro)
references rubros (codigo);

alter table calificaciones
add constraint FK_calificaciones_compra
foreign key (cod_compra)
references compras (id_compra);

alter table facturas
add constraint FK_facturas_compra
foreign key (id_compra)
references compras (id_compra);

alter table facturas
add constraint FK_facturas_publicacion
foreign key (id_publicacion)
references publicaciones (codigo);


alter table item_factura
add constraint FK_itemFactura_factura
foreign key (nro_fact,tipo_fact)
references facturas (nro_fact,tipo);

