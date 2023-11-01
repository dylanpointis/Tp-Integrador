CREATE DATABASE TPIntegrador
GO
USE TPIntegrador
GO

CREATE TABLE Usuarios
(
id_usuario INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
NombreDeUsuario varchar(50),
Clave varchar(100),
Rol varchar(50)
)


CREATE TABLE Clientes
(
id_cliente INT PRIMARY KEY REFERENCES Usuarios(id_usuario),
Nombre varchar(50),
Apellido varchar(50)
)

CREATE TABLE Empleados
(
id_empleado INT PRIMARY KEY REFERENCES Usuarios(id_usuario),
Nombre varchar(50),
Apellido varchar(50),
Horario varchar(50),
RolEmp varchar(50),
Sueldo float
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

Create TABLE Pedido_Producto
(
id_pedido INT FOREIGN KEY REFERENCES Pedidos(id_pedido),
id_producto INT FOREIGN KEY REFERENCES Productos(id_producto),
Cant int
)


CREATE TABLE Facturas
(
id_factura INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_pedido int FOREIGN KEY REFERENCES Pedidos(id_pedido),
Encabezado varchar(50),
Detalle varchar(50)
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



CREATE PROCEDURE RegistrarUsuario
	@nombreDeUsuario varchar(50),
	@clave varchar(100),
	@rol varchar(50)
AS
BEGIN
	INSERT INTO Usuarios (NombreDeUsuario, Clave, Rol) VALUES (@nombreDeUsuario, @clave, @rol);
END
GO


CREATE PROCEDURE AltaCliente
@idCliente int,
@nombre varchar(50),
@apellido varchar(50)
AS
BEGIN
	INSERT INTO Clientes VALUES (@idCliente, @nombre, @apellido);
END
GO
