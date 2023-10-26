CREATE DATABASE TPIntegrador
GO
USE TPIntegrador
GO

CREATE TABLE Clientes
(
id_cliente INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nombre varchar(50),
Apellido varchar(50)
)

CREATE TABLE Reclamos
(
id_reclamo int IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_cliente int FOREIGN KEY REFERENCES Clientes(id_cliente),
Categoria varchar(50),
Descripcion varchar(50)
)


CREATE TABLE Productos
(
id_producto INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Precio float,
CantStock int,
Descripcion varchar(50)
)

CREATE TABLE Proveedores
(
id_proveedor INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_producto int FOREIGN KEY REFERENCES Productos(id_producto),
Nombre varchar(50),
NumTel int,
Precio float
)

CREATE TABLE Pedidos
(
id_pedido INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_cliente int FOREIGN KEY REFERENCES Clientes(id_cliente),
id_producto int FOREIGN KEY REFERENCES Productos(id_producto),
Fecha DateTime,
MetodoPago varchar(50),
Total float
)

CREATE TABLE Facturas
(
id_factura INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_pedido int FOREIGN KEY REFERENCES Pedidos(id_pedido),
Encabezado varchar(50),
Detalle varchar(50)
)

CREATE TABLE Empleados
(
id_empleado INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nombre varchar(50),
Apellido varchar(50),
Horario varchar(50),
Rol varchar(50),
Sueldo float
)

CREATE TABLE Envios
(
id_envio INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_pedido int FOREIGN KEY REFERENCES Pedidos(id_pedido),
id_empleado int FOREIGN KEY REFERENCES Empleados(id_empleado),
Estado varchar(50),
FechaDeEnvio date,
Direccion varchar(50),
Localidad varchar(50),
OpcionEnvio varchar(50),
)

CREATE TABLE Logistica
(
id_logistica INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_envio int FOREIGN KEY REFERENCES Envios(id_envio),
Zona varchar(50),
Horarios varchar(50),
Costo float,
)

CREATE TABLE Usuarios
(
NombreDeUsuario varchar(50) PRIMARY KEY,
Contraseña varchar(50),
Rol varchar(50),
)

INSERT INTO Usuarios VALUES ('Joaquin','123','Cliente')
INSERT INTO Usuarios VALUES ('Pepe','123','Empleado')