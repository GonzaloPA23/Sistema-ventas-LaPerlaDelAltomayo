CREATE DATABASE  PRUEBITAFAKE;
GO

USE PRUEBITAFAKE;

CREATE TABLE  Rol (
    Id int IDENTITY ,
    Nombre varchar(50) NOT NULL
    CONSTRAINT  RolPk PRIMARY KEY  (Id)
)

CREATE TABLE Permiso(
    Id int IDENTITY,
    RolId int NOT NULL,
    NombreMenu varchar(50) NOT NULL,
    CONSTRAINT  PermisoPk PRIMARY KEY (Id),
    CONSTRAINT  PRolFk FOREIGN KEY  (RolId) REFERENCES  Rol(Id) ON DELETE  CASCADE ON UPDATE  CASCADE
)

CREATE TABLE Usuario(
    Id int IDENTITY,
    RolId int DEFAULT  2,
    Dni varchar(50) NOT NULL,
    Nombre varchar(50) NOT NULL,
    Apellido varchar(50) NOT NULL,
    Clave varchar(50) NOT NULL,
    Correo varchar(50) NOT NULL,
    Foto varbinary(max) NULL,
    CONSTRAINT  UsuarioPk PRIMARY KEY (Id),
    CONSTRAINT  URolFk FOREIGN KEY (RolId) REFERENCES Rol(Id) ON DELETE  CASCADE ON UPDATE  CASCADE
)

CREATE TABLE Chofer (
    Id int IDENTITY,
    Dni varchar(50) NOT NULL ,
    Nombre varchar(50) NOT NULL ,
    Apellido varchar(50) NOT NULL ,
    FechaNacimiento date NOT NULL ,
    Celular varchar(50) NOT NULL ,
    Correo varchar(50) NOT NULL
    CONSTRAINT  ChoferPk PRIMARY KEY (Id)
)

CREATE TABLE Bus (
    Id int IDENTITY,
    ChoferId int NOT NULL,
    Matricula varchar(50) NOT NULL,
    Tipo varchar(50) NOT NULL,
    AsientosDisponibles int NOT NULL,
    PuntoSalida varchar(50) NOT NULL ,
    Destino varchar(50) NOT NULL ,
    FechaSalida datetime NOT NULL,
    FechaLlegada datetime NOT NULL,
    PrecioAsiento money NOT NULL,
    CantidadAsiento int,
    CONSTRAINT BusPk PRIMARY KEY (Id),
    CONSTRAINT BChFk FOREIGN KEY (ChoferId) REFERENCES Chofer(Id) ON DELETE  CASCADE ON UPDATE  CASCADE
)

CREATE TABLE Pasaje (
    Id int IDENTITY,
    UsuarioId int NOT NULL,
    BusId int NOT NULL,
    Asiento varchar(50) NOT NULL,
    Piso int NOT NULL,
    FechaCompra datetime DEFAULT GETDATE(),
    CONSTRAINT PasajePk PRIMARY KEY (Id),
    CONSTRAINT PUFk FOREIGN KEY (UsuarioId) REFERENCES Usuario(Id) ON DELETE  CASCADE ON UPDATE  CASCADE,
    CONSTRAINT PBFk FOREIGN KEY (BusId) REFERENCES Bus(Id) ON DELETE  CASCADE ON UPDATE  CASCADE,
)

CREATE TABLE Encomienda (
    Id int IDENTITY,
    UsuarioId int NOT NULL,
    Destino varchar(50) NOT NULL ,
    PuntoSalida varchar(50) NOT NULL,
    FechaEnvio datetime NOT NULL,
    FechaLlegada datetime NOT NULL,
    TipoProducto varchar(50) NOT NULL,
    Peso float(4) NOT NULL,
    Largo float(4) NOT NULL,
    Alto float(4) NOT NULL ,
    Ancho float(4) NOT NULL,
    Precio money NOT NULL,
    FechaPedido datetime DEFAULT GETDATE(),
    CONSTRAINT EncomiendaPk PRIMARY KEY (Id),
    CONSTRAINT EUFk FOREIGN KEY (UsuarioId) REFERENCES Usuario(Id) ON DELETE  CASCADE ON UPDATE  CASCADE
)

CREATE TABLE Auditoria(
    Id int IDENTITY,
    Tabla varchar(20) NOT NULL,
    RegistroId int NOT NULL ,
    Campo varchar(20) NOT NULL,
    ValorAntes varchar(50) NOT NULL,
    ValorDespues varchar(50) NOT NULL,
    Usuario varchar(50) NOT NULL,
    Fecha datetime DEFAULT GETDATE(),
    Tipo varchar(20) NOT NULL,
    CONSTRAINT AuditoriaPk PRIMARY KEY (Id)
)
