CREATE DATABASE Panaderia;
GO

USE Panaderia;
GO

CREATE TABLE Usuario(
    IdUsuario INT NOT NULL PRIMARY KEY,
    Nombre NVARCHAR(80) NOT NULL,
    Clave NVARCHAR(255) NOT NULL,
    Permiso INT NOT NULL,
    Estado BIT NOT NULL
);
GO

CREATE TABLE Permisos(
    Id_Permiso INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    IdUsuario INT NOT NULL,
    Permiso NVARCHAR(50) NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)
);
GO

CREATE TABLE Proveedor (
    IdProveedor INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(80) NOT NULL,
    Estado BIT NOT NULL,
    IdUsuario INT NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)
);
GO

CREATE TABLE Inventario (
    CodigoProducto NVARCHAR(50) NOT NULL PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Estado BIT NOT NULL,
    Precio DECIMAL(18,2) NOT NULL,
    Cantidad INT NOT NULL,
    IdProveedor INT NOT NULL,
    FOREIGN KEY (IdProveedor) REFERENCES Proveedor(IdProveedor),
    IdUsuario INT NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)
);
GO

CREATE TABLE TipoPago(
    IdTipoPago NVARCHAR(50) NOT NULL PRIMARY KEY,
    Descripcion NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE CajaRegistradora(
    CodigoVenta NVARCHAR(20) NOT NULL PRIMARY KEY,
    FechaCompra DATETIME NOT NULL,
    IdTipoPago NVARCHAR(50) NOT NULL,
    CompraFinal DECIMAL(10, 2) NOT NULL,
    IdUsuario INT NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    FOREIGN KEY (IdTipoPago) REFERENCES TipoPago(IdTipoPago)
);
GO

CREATE TABLE DetalleFactura(
    IdDetalle INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    CodigoVenta NVARCHAR(20) NOT NULL,
    CodigoProducto NVARCHAR(50) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Cantidad INT NOT NULL,
    SubTotal DECIMAL(10, 2),
    FOREIGN KEY (CodigoVenta) REFERENCES CajaRegistradora(CodigoVenta),
    FOREIGN KEY (CodigoProducto) REFERENCES Inventario(CodigoProducto)
);
GO