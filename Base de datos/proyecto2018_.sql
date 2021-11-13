Create database proyecto2018_
use proyecto2018_

Create table TBL_Cliente
 (
nombre varchar(20),
apellido nvarchar(20),
cedula nvarchar(11),
telefono nvarchar(11),
direccion nvarchar(60),
imagen nvarchar (max),

)

Create table TBL_Empleados
(

nombre varchar (20)not null,
apellido nvarchar(20)not null,
cedula nvarchar(11)not null,
telefono nvarchar(11)not null,
direccion nvarchar(60)not null,
imagen nvarchar (max) not null,
)

Create table  TBL_Suplidores
(
nombre varchar (20)not null,
apellido nvarchar(20)not null,
cedula nvarchar(11)not null,
telefono nvarchar(11)not null,
direccion nvarchar(60)not null,
imagen nvarchar (max) not null,
)

Create table TBL_Proveedores
(
nombre varchar (20)not null,
apellido nvarchar(20)not null,
cedula nvarchar(11)not null,
telefono nvarchar(11)not null,
direccion nvarchar(60)not null,
imagen nvarchar (max) not null,
)

Create table TBL_Inversionista 
(
nombre varchar (20),
apellido nvarchar(20),
cedula nvarchar(11),
telefono nvarchar(11),
direccion nvarchar(60),
imagen nvarchar(max) not null,
)

Create table TBL_Vehiculo
(
codigo nvarchar(20) not null,
articulo nvarchar(20) not null,
marca nvarchar(20) null,
precio nvarchar(20) not null,
Descripcion nvarchar (90) not null,
imagen_Vehiculo nvarchar(max) not null,


)

Create table TBL_CuentasApagar 
(
nombre varchar (20)not null,
apellido nvarchar(20)not null,
cedula nvarchar(11)not null,
Descripcion nvarchar (90) not null,
telefono nvarchar(11)not null,
direccion nvarchar(60)not null,
imagen nvarchar(max) not null,
)

create table TBL_CuentasACobrar
(
nombre varchar (20)not null,
apellido nvarchar(20)not null,
cedula nvarchar(11) not null,
Descripcion nvarchar (90) not null,
telefono nvarchar(11)not null,
direccion nvarchar(60)not null,
imagen nvarchar (max) not null,
)

create table TBL_Cuentasincobrables
(
nombre varchar (20)not null,
apellido nvarchar(20)not null,
cedula nvarchar(11)not null,
Descripcion nvarchar (90) not null,
telefono nvarchar(11)not null,
direccion nvarchar(60)not null,
imagen nvarchar (max) not null,
)
