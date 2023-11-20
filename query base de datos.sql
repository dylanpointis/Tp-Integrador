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

CREATE TABLE Pedidos
(
id_pedido INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_cliente int FOREIGN KEY REFERENCES Clientes(id_cliente),
Fecha varchar(50),
MetodoPago varchar(50),
Total float
)

Create TABLE Pedido_Producto
(
id_pedido INT FOREIGN KEY REFERENCES Pedidos(id_pedido),
id_producto INT FOREIGN KEY REFERENCES Productos(id_producto),
Cant int
)


CREATE TABLE Proveedores
(
id_proveedor INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nombre varchar(50),
NumTel int,
Precio float
)

CREATE TABLE OrdenDeCompra
(
id_proveedor INT FOREIGN KEY REFERENCES Proveedores(id_proveedor),
id_producto INT FOREIGN KEY REFERENCES Productos(id_producto),
CantAReponer int,
FechaDeEntrega varchar(50),
LugarDeEntrega varchar(50)
)


CREATE TABLE Descuentos
(
id_proveedor INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_producto INT FOREIGN KEY REFERENCES Productos(id_producto),
PorcentajeDescuento float,
Duracion varchar(50)
)

CREATE TABLE Facturas
(
id_factura INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_pedido int FOREIGN KEY REFERENCES Pedidos(id_pedido),
Encabezado varchar(50),
Detalle varchar(50)
)

CREATE TABLE Logistica
(
id_logistica INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Zona varchar(50),
Horarios varchar(50),
Costo float,
)

CREATE TABLE Envios
(
id_envio INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_pedido int FOREIGN KEY REFERENCES Pedidos(id_pedido),
id_empleado int FOREIGN KEY REFERENCES Empleados(id_empleado),
id_logistica int FOREIGN KEY REFERENCES Logistica(id_logistica),
Estado varchar(50),
FechaDeEnvio varchar(50),
Direccion varchar(50),
Localidad varchar(50),
OpcionEnvio varchar(50),
)


GO

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


CREATE PROCEDURE AltaProducto
@Precio float,
@Descripcion varchar(50)
AS
BEGIN
	INSERT INTO Productos VALUES (@Precio, 0, @Descripcion);
END
GO

CREATE PROCEDURE EditarProducto
@id_producto int,
@Precio float,
@Descripcion varchar(50)
AS
BEGIN
	UPDATE Productos set Precio = @Precio, Descripcion = @Descripcion where id_producto = @id_producto;
END
GO


Insert into Usuarios VALUES ('Joaquin','202cb962ac59075b964b07152d234b70','Cliente')
Insert into Usuarios VALUES ('Empleado','202cb962ac59075b964b07152d234b70','Empleado')
Insert into Usuarios VALUES ('Admin','202cb962ac59075b964b07152d234b70','Admin')

Insert into Clientes VALUES (1,'Joaquin','Perez')
Insert into Empleados VALUES (2,'Esteban','Rodriguez','6 hs', 250000)

Insert into Productos VALUES (1500,60,'Coca-Cola');
Insert into Productos VALUES (3000,20,'Pizza mozzarella');

INSERT INTO Proveedores values ('Distribuidora Lomas', 1111234, 6000)
