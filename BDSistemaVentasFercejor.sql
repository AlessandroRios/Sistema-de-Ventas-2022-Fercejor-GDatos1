IF( EXISTS ( SELECT name FROM master.sys.databases WHERE name = 'DBSVFercejor' ) )
BEGIN
	DROP DATABASE DBSVFercejor;
END;
go
CREATE DATABASE DBSVFercejor;
go

USE DBSVFercejor;
go
-------------ESQUEMAS
CREATE SCHEMA NEGOCIO;
GO
CREATE SCHEMA PERSONAS;
GO

--FORMATO FECHA
SET DATEFORMAT dmy;
GO
----TABLAS

CREATE TABLE NEGOCIO.ROLES(
idRol INT IDENTITY PRIMARY KEY,
nombreRol VARCHAR(30) not null
)
GO

CREATE TABLE PERSONAS.EMPLEADOS(
idEmpleado INT IDENTITY PRIMARY KEY,
nombre VARCHAR(30) not null,
apellido VARCHAR(30)not null,
telefono VARCHAR(9) not null,
idRol INT REFERENCES NEGOCIO.ROLES (idRol)
)
GO

CREATE TABLE PERSONAS.USUARIOS(
idUsuario INT IDENTITY (1,1) PRIMARY KEY,
idEmpleado INT REFERENCES PERSONAS.EMPLEADOS(idEmpleado),
nombreUsuario VARCHAR(20) not null,
contraseña VARCHAR(10) not null,
fechaRegistro DATETIME DEFAULT GETDATE()
)
GO

CREATE TABLE PERSONAS.PROVEEDORES(
idProveedor INT IDENTITY PRIMARY KEY,
razonSocial VARCHAR(60) NOT NULL,
documento VARCHAR(20) NOT NULL,
correo VARCHAR(50) NOT NULL,
telefono VARCHAR(11) NOT NULL,
estado CHAR(1) NOT NULL,
fechaRegistro  DATETIME DEFAULT GETDATE()
)
GO

CREATE TABLE PERSONAS.CLIENTES(
idCliente INT IDENTITY PRIMARY KEY,
nombre VARCHAR(30) NOT NULL,
Apellido VARCHAR (30) NOT NULL,
telefono VARCHAR(9) NOT NULL,
correo VARCHAR(50) NOT NULL,
estado CHAR(1) DEFAULT 1 NOT NULL,
fechaRegistro DATETIME DEFAULT GETDATE()
)
GO


CREATE TABLE NEGOCIO.CATEGORIAS(
idCategoria INT IDENTITY PRIMARY KEY,
nombreCategoria VARCHAR(40)
)

CREATE TABLE NEGOCIO.PRODUCTOS(
idProducto INT IDENTITY PRIMARY KEY,
idCategoria INT REFERENCES NEGOCIO.CATEGORIAS(idCategoria),
nombreProducto VARCHAR (50) NOT NULL,
descripcion TEXT,
stock INT DEFAULT 0 NOT NULL,
/*
EL PRECIO MAYORITARIO Y MINORITATIO SE ESPERA CALCULAR MEDIANTE EL PRECIO DE COMPRA DE LA TABLA COMPRA(DETALLE COMPRA)
APLICANDO LA SIGUIENTE LOGICA:
PrecioMinoritario y Mayoritario = PrecioCompra + (PrecioCompra * (porcentaje que introducira el administrador en el GUI) )
el porcentaje que introduzca sera el margen de ganacia.
*/ 
precioMayoritario DECIMAL(10,2) DEFAULT 0 ,
precioMinoritario DECIMAL(10,2) DEFAULT 0,
estado CHAR(1)
)
GO

CREATE TABLE NEGOCIO.COMPRA(
idCompra INT IDENTITY PRIMARY KEY,
idUsuario INT REFERENCES PERSONAS.USUARIOS(idUsuario),
idProveedor INT REFERENCES PERSONAS.PROVEEDORES(idProveedor),
tipoDocumento VARCHAR(20) NOT NULL,
numeroDocumento VARCHAR(18) NOT NULL,
montoTotal DECIMAL(10,2),
fechaRegistro DATETIME DEFAULT GETDATE (),
)
GO


CREATE TABLE NEGOCIO.DETALLE_COMPRA(
idDetalleCompra INT IDENTITY PRIMARY KEY,
idCompra INT REFERENCES NEGOCIO.COMPRA(idCompra),
idProducto INT REFERENCES NEGOCIO.PRODUCTOS(idProducto),
precioCompra DECIMAL(10,2) NOT NULL,
cantidad INT NOT NULL,
montoTotal DECIMAL (10,2) NOT NULL,
fechaRegistro DATETIME DEFAULT GETDATE()
)
GO

CREATE TABLE NEGOCIO.VENTAS(
idVenta INT IDENTITY PRIMARY KEY,
idUsuario INT REFERENCES PERSONAS.USUARIOS(idUsuario),
idCliente INT REFERENCES PERSONAS.CLIENTES(idCliente),
tipoComprobante CHAR(1),--B O F , boleta o factura
montoTotal DECIMAL(10,2), 
/*
Monto total se calcula mediante el subtotal(DETALLE_venta) + 18% IGV
*/
fechaRegistro DATETIME DEFAULT GETDATE()
)
GO

CREATE TABLE NEGOCIO.DETALLE_VENTA(
idDetalleVenta INT IDENTITY PRIMARY KEY,
idVenta INT REFERENCES NEGOCIO.VENTAS(idVenta),
idProducto INT REFERENCES NEGOCIO.PRODUCTOS(idProducto),
cantidad INT DEFAULT 0,
subTotal DECIMAL(10,2) NOT NULL,
fechaRegistro DATETIME DEFAULT GETDATE()
)
GO

CREATE TABLE NEGOCIO.GUIA_RUTA(
idGuia INT IDENTITY PRIMARY KEY,
idVenta INT REFERENCES NEGOCIO.VENTAS(idVenta),
direccionEntrega TEXT NOT NULL,
fechaEnvio DATETIME,
fechaEntrega DATETIME,
estado VARCHAR(10),
/*
estados:
Enviado
Entregado
*/
)
GO

/*
LOS PEDIDOS SON AQUELLAS VENTAS QUE SON ENTREGABLES A CLIENTES LEJOS O CLIENTES
*/
CREATE TABLE NEGOCIO.PEDIDOS(
idPedido INT IDENTITY PRIMARY KEY,
idUsuario INT REFERENCES PERSONAS.USUARIOS(idUsuario),
idCliente INT REFERENCES PERSONAS.CLIENTES(idCliente),
prioridad INT NOT NULL,
/*
La prioridad sera :
1. alto
2. medio
3.bajo
*/
tipoComprobante CHAR(1),--B O F , boleta o factura
montoTotal DECIMAL(10,2), 
/*
Monto total se calcula mediante el subtotal(DETALLE_venta) + 18% IGV
*/
fechaRegistro DATETIME DEFAULT GETDATE()
)
GO












------------------------PROCEDMIENTOS----------------------------------

---Procedimiento almacenado de Creacion de pedidos---
CREATE PROCEDURE sp_CrearPedido
    @idUsuario INT,
    @idCliente INT,
    @prioridad INT,
    @tipoComprobante CHAR(1),
    @montoTotal DECIMAL(10, 2),
    @fechaRegistro DATETIME
AS
BEGIN
    INSERT INTO NEGOCIO.PEDIDOS (idUsuario, idCliente, prioridad, tipoComprobante, montoTotal)
    VALUES (@idUsuario, @idCliente, @prioridad, @tipoComprobante, @montoTotal);
END
GO

---Procedimiento almacenado de Eliminar de pedidos---
CREATE PROCEDURE sp_EliminarPedido
    @idPedido INT
AS
BEGIN
    DELETE FROM NEGOCIO.PEDIDOS
    WHERE idPedido = @idPedido
END
GO
---Procedimiento almacenado de modificación de pedidos---
CREATE PROCEDURE sp_ModificarPedido
    @idPedido INT,
    @idUsuario INT,
    @idCliente INT,
    @prioridad INT,
    @tipoComprobante CHAR(1),
    @montoTotal DECIMAL(10, 2),
    @fechaRegistro DATETIME
AS
BEGIN
    UPDATE NEGOCIO.PEDIDOS
    SET idUsuario = @idUsuario,
        idCliente = @idCliente,
        prioridad = @prioridad,
        tipoComprobante = @tipoComprobante,
        montoTotal = @montoTotal,
        fechaRegistro = @fechaRegistro
    WHERE idPedido = @idPedido;
END
GO

--PROCEDIMIENTOS DE CRUD DEL INVENTARIO
--PROCEDIMIENTO DE INSERTAR
CREATE PROCEDURE sp_insertarProducto
    @idCategoria INT,
    @nombreProducto VARCHAR(50),
    @descripcion TEXT,
    @stock INT,
    @precioMayoritario DECIMAL(10,2),
    @precioMinoritario DECIMAL(10,2),
    @estado CHAR(1)
AS
BEGIN
    INSERT INTO NEGOCIO.PRODUCTOS (idCategoria, nombreProducto, descripcion, stock, precioMayoritario, precioMinoritario, estado)
    VALUES (@idCategoria, @nombreProducto, @descripcion, @stock, @precioMayoritario, @precioMinoritario, @estado);
END
GO

--PROCEDIMIENTO DE MODIFICAR
CREATE PROCEDURE sp_modificarProducto
    @idProducto INT,
    @idCategoria INT,
    @nombreProducto VARCHAR(50),
    @descripcion TEXT,
    @stock INT,
    @precioMayoritario DECIMAL(10,2),
    @precioMinoritario DECIMAL(10,2),
    @estado CHAR(1)
AS
BEGIN
    UPDATE NEGOCIO.PRODUCTOS
    SET idCategoria = @idCategoria,
        nombreProducto = @nombreProducto,
        descripcion = @descripcion,
        stock = @stock,
        precioMayoritario = @precioMayoritario,
        precioMinoritario = @precioMinoritario,
        estado = @estado
    WHERE idProducto = @idProducto;
END
GO

--PROCEDIMIENTO DE ELIMINAR
CREATE PROCEDURE sp_eliminarProducto
    @idProducto INT
AS
BEGIN
    DELETE FROM NEGOCIO.PRODUCTOS
    WHERE idProducto = @idProducto;
END
GO

----PROCEDIMIENTO BUSCAR PEDIDOS
CREATE PROCEDURE sp_BuscarPedidos
    @idPedido INT = NULL,
    @idUsuario INT = NULL,
    @idCliente INT = NULL,
    @fechaRegistroInicio DATETIME = NULL,
    @fechaRegistroFin DATETIME = NULL
AS
BEGIN
    SELECT *
    FROM NEGOCIO.PEDIDOS
    WHERE (@idPedido IS NULL OR idPedido = @idPedido)
        AND (@idUsuario IS NULL OR idUsuario = @idUsuario)
        AND (@idCliente IS NULL OR idCliente = @idCliente)
        AND (@fechaRegistroInicio IS NULL OR fechaRegistro >= @fechaRegistroInicio)
        AND (@fechaRegistroFin IS NULL OR fechaRegistro <= @fechaRegistroFin);
END
GO


--PROCEDIMIENTO DE BUSCAR PRODUCTO
CREATE PROCEDURE BuscarProductoInventario
    @nombreProducto VARCHAR(50) = NULL,
    @idCategoria INT = NULL
AS
BEGIN
    SELECT p.idProducto, c.nombreCategoria, p.nombreProducto, p.descripcion, p.stock, p.precioMayoritario, p.precioMinoritario
    FROM NEGOCIO.PRODUCTOS p
    INNER JOIN NEGOCIO.CATEGORIAS c ON p.idCategoria = c.idCategoria
    WHERE (@nombreProducto IS NULL OR p.nombreProducto LIKE '%' + @nombreProducto + '%')
    AND (@idCategoria IS NULL OR p.idCategoria = @idCategoria)
END
GO






-------------------------VISTAS------------------------------------------
---Vistas de Empleados---
CREATE VIEW VistaEmpleados AS
SELECT e.idEmpleado, e.nombre, e.apellido, e.telefono, r.nombreRol AS 'Cargo'
FROM PERSONAS.EMPLEADOS e
JOIN NEGOCIO.ROLES r ON e.idRol = r.idRol;
GO
---Vistas de usuarios---
CREATE VIEW VistaUsuarios AS
SELECT u.idUsuario, u.nombreUsuario, e.nombre, e.apellido, e.telefono
FROM PERSONAS.USUARIOS u
JOIN PERSONAS.EMPLEADOS e ON u.idEmpleado = e.idEmpleado;
GO
---Vistas de proveedores---
CREATE VIEW VistaProveedores AS
SELECT idProveedor, razonSocial, documento, correo, telefono, fechaRegistro
FROM PERSONAS.PROVEEDORES
WHERE estado = 'A';
GO
----Vistas de Pedidos-----
CREATE VIEW VistaPedidos AS
SELECT p.idPedido,u.nombreUsuario AS 'Encargado',
c.nombre AS 'Cliente' ,p.prioridad,p.tipoComprobante,p.montoTotal,p.fechaRegistro
FROM NEGOCIO.PEDIDOS p
INNER JOIN PERSONAS.USUARIOS u ON (p.idPedido=u.idUsuario)  
INNER JOIN PERSONAS.CLIENTES c ON (p.idPedido = c.idCliente)
GO

---Vistas de clientes---
CREATE VIEW VistaClientes AS
SELECT idCliente, nombre, Apellido, telefono, correo, fechaRegistro
FROM PERSONAS.CLIENTES
WHERE estado = '1';
GO
---Vistas de productos---
CREATE VIEW VistaProductos AS
SELECT p.idProducto, c.nombreCategoria, p.nombreProducto, p.descripcion, p.stock, p.precioMayoritario, p.precioMinoritario
FROM NEGOCIO.PRODUCTOS p
JOIN NEGOCIO.CATEGORIAS c ON p.idCategoria = c.idCategoria
WHERE p.estado = 'A';
GO
---Vistas de compras---
CREATE VIEW VistaCompras AS
SELECT c.idCompra, u.nombreUsuario, pr.razonSocial, c.tipoDocumento, c.numeroDocumento, c.montoTotal, c.fechaRegistro
FROM NEGOCIO.COMPRA c
JOIN PERSONAS.USUARIOS u ON c.idUsuario = u.idUsuario
JOIN PERSONAS.PROVEEDORES pr ON c.idProveedor = pr.idProveedor;
GO
---Vistas de detalles de compras---
CREATE VIEW VistaDetallesCompra AS
SELECT dc.idDetalleCompra, c.idCompra, p.nombreProducto, dc.precioCompra, dc.cantidad, dc.montoTotal, dc.fechaRegistro
FROM NEGOCIO.DETALLE_COMPRA dc
JOIN NEGOCIO.COMPRA c ON dc.idCompra = c.idCompra
JOIN NEGOCIO.PRODUCTOS p ON dc.idProducto = p.idProducto;
GO
---Vistas de ventas---
CREATE VIEW VistaVentas AS
SELECT v.idVenta, u.nombreUsuario, cl.nombre, cl.Apellido, v.tipoComprobante, v.montoTotal, v.fechaRegistro
FROM NEGOCIO.VENTAS v
JOIN PERSONAS.USUARIOS u ON v.idUsuario = u.idUsuario
JOIN PERSONAS.CLIENTES cl ON v.idCliente = cl.idCliente;
GO
---Vistas de detalles de ventas---
CREATE VIEW VistaDetallesVenta AS
SELECT dv.idDetalleVenta, v.idVenta, p.nombreProducto, dv.cantidad, dv.subTotal, dv.fechaRegistro
FROM NEGOCIO.DETALLE_VENTA dv
JOIN NEGOCIO.VENTAS v ON dv.idVenta = v.idVenta
JOIN NEGOCIO.PRODUCTOS p ON dv.idProducto = p.idProducto;
GO
---Vistas de guías de ruta---
CREATE VIEW VistaGuias AS
SELECT gr.idGuia, v.idVenta, gr.direccionEntrega, gr.fechaEnvio, gr.fechaEntrega, gr.estado
FROM NEGOCIO.GUIA_RUTA gr
JOIN NEGOCIO.VENTAS v ON gr.idVenta = v.idVenta;
GO














-----------------------CONSULTAS------------------------
--Seleccionar todos los empleados cuyo nombre empiece con "A":
SELECT *
FROM VistaEmpleados
WHERE nombre LIKE 'A%'
GO


--Obtener la lista de empleados con el cargo de "ADMINISTRADOR":
SELECT *
FROM VistaEmpleados
WHERE Cargo = 'EMPLEADO';
GO


--Obtener la lista de usuarios con su nombre completo y número de teléfono:
SELECT nombreUsuario, CONCAT(nombre, ' ', apellido) AS NombreCompleto, telefono
FROM VistaUsuarios;
GO


--Obtener la lista de proveedores activos ordenados por fecha de registro de forma descendente:
SELECT *
FROM VistaProveedores
ORDER BY fechaRegistro DESC;
GO


--Obtener la lista de clientes activos con su nombre, apellido y correo electrónico:
SELECT nombre, Apellido, correo
FROM VistaClientes
GO


--Obtener la lista de productos con su categoría y stock disponible mayor a 50:
SELECT nombreProducto, nombreCategoria, stock
FROM VistaProductos
WHERE stock > 50;
GO


--Obtener la cantidad de empleados por cargo:
SELECT Cargo, COUNT(*) AS CantidadEmpleados
FROM VistaEmpleados
GROUP BY Cargo;
GO


--Obtener el promedio de stock de productos por categoría:
SELECT nombreCategoria, AVG(stock) AS PromedioStock
FROM VistaProductos
GROUP BY nombreCategoria;
GO


--Obtener la lista de clientes con su nombre, apellido y fecha de registro:
SELECT nombre, Apellido, fechaRegistro
FROM VistaClientes;
GO


--Obtener la lista de productos con precio mayoritario superior a 250:
SELECT *
FROM VistaProductos
WHERE precioMayoritario > 250;
GO


--Obtener la cantidad total de ventas por año y tipo de comprobante:
SELECT YEAR(fechaRegistro) AS Anio, tipoComprobante, COUNT(*) AS TotalVentas
FROM VistaVentas
GROUP BY YEAR(fechaRegistro), tipoComprobante;
GO


--Obtener el monto total de compras por proveedor ordenado de forma descendente:
SELECT razonSocial, SUM(montoTotal) AS MontoTotalCompras
FROM VistaCompras
GROUP BY razonSocial
ORDER BY MontoTotalCompras DESC;
GO


--Obtener la lista de clientes con su nombre, apellido y fecha de registro para aquellos que se registraron en los últimos 6 meses:
SELECT nombre, Apellido, fechaRegistro
FROM VistaClientes
WHERE fechaRegistro >= DATEADD(MONTH, -6, GETDATE());
GO


--Obtener el monto total de ventas por mes y año en los últimos 2 años:
SELECT YEAR(fechaRegistro) AS Anio, MONTH(fechaRegistro) AS Mes, SUM(montoTotal) AS MontoTotalVentas
FROM VistaVentas
WHERE fechaRegistro >= DATEADD(YEAR, -2, GETDATE())

GROUP BY YEAR(fechaRegistro), MONTH(fechaRegistro);
GO


--Obtener el promedio de precios mayoritarios de los productos por categoría:
SELECT nombreCategoria, AVG(precioMayoritario) AS PromedioPrecioMayoritario
FROM VistaProductos
GROUP BY nombreCategoria;
GO


--1. Seleccionar todos los empleados cuyo apellido inicie con "R":
SELECT *
FROM VistaEmpleados
WHERE apellido LIKE 'R%'
GO


--2. Obtener la lista de usuarios ordenados por su apellido de forma ascendente
SELECT *
FROM VistaUsuarios
ORDER BY apellido ASC;
GO


--3. Obtener la lista de productos con su categoría y precio minoritario:
SELECT P.nombreProducto, C.nombreCategoria, P.precioMinoritario
FROM NEGOCIO.PRODUCTOS P
JOIN NEGOCIO.CATEGORIAS C ON P.idCategoria = C.idCategoria;
GO


--4. Obtener la lista de categorías de productos y la cantidad de productos en cada una:
SELECT C.nombreCategoria, COUNT(P.idCategoria) AS CantidadProductos
FROM NEGOCIO.CATEGORIAS C
LEFT JOIN NEGOCIO.PRODUCTOS P ON C.idCategoria = P.idCategoria
GROUP BY C.nombreCategoria;
GO


--5. Obtener la lista de clientes inactivos con sus nombres, apellidos y correos electrónicos:
SELECT nombre, Apellido, correo
FROM PERSONAS.CLIENTES
WHERE estado = '0';
GO


--6. Obtener la cantidad total de proveedores en cada estado:
SELECT estado, COUNT(*) AS CantidadProveedores
FROM PERSONAS.PROVEEDORES
GROUP BY estado;
GO


--7. Obtener la lista de usuarios con su nombre de usuario y año de registro:
SELECT nombreUsuario, YEAR(fechaRegistro) AS AnioRegistro
FROM PERSONAS.USUARIOS;
GO


--8. Obtener la cantidad de usuarios por año
SELECT YEAR(fechaRegistro) AS Anio, COUNT(*) AS CantidadUsuarios
FROM PERSONAS.USUARIOS
GROUP BY YEAR(fechaRegistro);
GO


--9. Obtener lista productos con precio mayoritario por encima del promedio
SELECT nombreProducto, precioMayoritario
FROM NEGOCIO.PRODUCTOS
WHERE precioMayoritario > (
  SELECT AVG(precioMayoritario)
  FROM NEGOCIO.PRODUCTOS
);
GO

--10. Obtener la cantidad total de productos cuyo precio mayoritario se encuentra dentro de 100 a 200
SELECT COUNT(*) AS CantidadProductos
FROM NEGOCIO.PRODUCTOS
WHERE precioMayoritario BETWEEN 100 AND 200;
GO

--11. Obtener la lista de productos con su nombre y precio mayoritario en orden ascendente por precio
SELECT nombreProducto, precioMayoritario
FROM NEGOCIO.PRODUCTOS
ORDER BY precioMayoritario;
GO

--12. Obtener la cantidad total de productos cuyo stock está por debajo de 100:
SELECT COUNT(*) AS CantidadProductos
FROM NEGOCIO.PRODUCTOS
WHERE stock < 100;
GO

--13. Obtener el producto con el stock mínimo:
SELECT TOP 1 nombreProducto, stock
FROM NEGOCIO.PRODUCTOS
ORDER BY stock ASC;
GO

--14. Obtener la cantidad total de productos en cada categoría con su respectivo stock acumulado:
SELECT C.nombreCategoria, SUM(P.stock) AS StockAcumulado
FROM NEGOCIO.PRODUCTOS P
JOIN NEGOCIO.CATEGORIAS C ON P.idCategoria = C.idCategoria
GROUP BY C.nombreCategoria;
GO

--15. Obtener la lista de proveedores con su razón social y dirección de correo electrónico:
SELECT razonSocial, correo
FROM PERSONAS.PROVEEDORES;
GO

-- "X" cantidad de últimos clientes agregados a la BD que esten activos
CREATE PROCEDURE ObtenerUltimosClientes
    @cantidad INT
AS
BEGIN
    SELECT TOP (@cantidad) idCliente, nombre, Apellido, telefono, correo, fechaRegistro
    FROM PERSONAS.CLIENTES
    WHERE estado = '1'
    ORDER BY fechaRegistro DESC;
END
GO

-- Productos según una id en especifico
CREATE PROCEDURE ObtenerProductoPorID
    @idProducto INT
AS
BEGIN
    SELECT p.idProducto, c.nombreCategoria, p.nombreProducto, p.descripcion, p.stock, p.precioMayoritario, p.precioMinoritario
    FROM NEGOCIO.PRODUCTOS p
    JOIN NEGOCIO.CATEGORIAS c ON p.idCategoria = c.idCategoria
    WHERE p.idProducto = @idProducto;
END
go

-- Clientes Por año, solo activos
CREATE PROCEDURE ObtenerClientesPorAnio
    @anio INT
AS
BEGIN
    DECLARE @fechaInicio DATETIME, @fechaFin DATETIME;
    SET @fechaInicio = DATEFROMPARTS(@anio, 1, 1);
    SET @fechaFin = DATEFROMPARTS(@anio, 12, 31);

    SELECT idCliente, nombre, Apellido, telefono, correo, fechaRegistro
    FROM PERSONAS.CLIENTES
    WHERE estado = '1'
    AND fechaRegistro >= @fechaInicio AND fechaRegistro <= @fechaFin;
END
GO

-- Solo los productos activos
CREATE VIEW ObtenerProductosActivos
AS
    SELECT idProducto, idCategoria, nombreProducto, descripcion, stock, precioMayoritario, precioMinoritario, estado
    FROM NEGOCIO.PRODUCTOS
    WHERE estado = 'A';
GO

--Proveedores de un año en especifico 
CREATE PROCEDURE ObtenerProveedoresPorAnio
    @anio INT
AS
BEGIN
    DECLARE @fechaInicio DATETIME, @fechaFin DATETIME;
    SET @fechaInicio = DATEFROMPARTS(@anio, 1, 1);
    SET @fechaFin = DATEFROMPARTS(@anio, 12, 31);

    SELECT idProveedor, razonSocial, documento, correo, telefono, fechaRegistro
    FROM PERSONAS.PROVEEDORES
    WHERE estado = 'A'
    AND fechaRegistro >= @fechaInicio AND fechaRegistro <= @fechaFin;
END
GO

-- Productos con stock mayor a "x"
CREATE PROCEDURE ObtenerProductosPorStock
    @stockMinimo INT
AS
BEGIN
    SELECT p.idProducto, c.nombreCategoria, p.nombreProducto, p.stock
    FROM NEGOCIO.PRODUCTOS p
    JOIN NEGOCIO.CATEGORIAS c ON p.idCategoria = c.idCategoria
    WHERE p.stock > @stockMinimo;
END
GO

--Productos con un nombre especifico
CREATE PROCEDURE ObtenerProductosPorNombre
    @nombreProducto VARCHAR(150)
AS
BEGIN
    SELECT p.idProducto, c.nombreCategoria, p.nombreProducto, p.descripcion, p.stock, p.precioMayoritario, p.precioMinoritario
    FROM NEGOCIO.PRODUCTOS p
    JOIN NEGOCIO.CATEGORIAS c ON p.idCategoria = c.idCategoria
    WHERE p.nombreProducto = @nombreProducto;
END
GO

-- Productos con un nombre en especifico
CREATE PROCEDURE ObtenerProductosPorProveedor
    @nombreProveedor VARCHAR(60)
AS
BEGIN
    SELECT p.idProducto, c.nombreCategoria, p.nombreProducto, p.descripcion, p.stock, p.precioMayoritario, p.precioMinoritario
    FROM NEGOCIO.PRODUCTOS p
    JOIN NEGOCIO.CATEGORIAS c ON p.idCategoria = c.idCategoria
    JOIN PERSONAS.PROVEEDORES pr ON pr.idProveedor = pr.idProveedor
    WHERE pr.razonSocial = @nombreProveedor;
END
GO

--Nombre de los empleados que comiencen con "?"
CREATE PROCEDURE ObtenerEmpleadosPorLetra
    @letraInicial CHAR(1)
AS
BEGIN
    SELECT idEmpleado, nombre, apellido, telefono
    FROM PERSONAS.EMPLEADOS
    WHERE nombre LIKE @letraInicial + '%';
END
GO

-- Empleados con un rol en especifico
CREATE PROCEDURE ObtenerEmpleadosPorRol
    @nombreRol VARCHAR(30)
AS
BEGIN
    SELECT e.idEmpleado, e.nombre, e.apellido, e.telefono
    FROM PERSONAS.EMPLEADOS e
    JOIN NEGOCIO.ROLES r ON e.idRol = r.idRol
    WHERE r.nombreRol = @nombreRol;
END
GO

