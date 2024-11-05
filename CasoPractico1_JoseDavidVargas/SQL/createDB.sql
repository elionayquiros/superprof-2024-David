CREATE DATABASE RENTACAR
 
GO 
USE RENTACAR
GO
 
 
CREATE TABLE [dbo].[FLOTA_ADMINISTRATIVA](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [varchar](30) NOT NULL,
	[Marca] [varchar](30) NOT NULL,
	[Anio] [varchar](4) NOT NULL,
	[TipoDeVehiculo] int NOT NULL,
	[MontoPorDia] decimal(18,2) NOT NULL,
	[MontoDeSeguro] decimal(18,2) NULL,
	[FechaDeRegistro] [datetime] NOT NULL,
	[FechaDeModificacion] [datetime] NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO USE RENTACAR
 
 
CREATE TABLE [dbo].[RESERVACIONES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreCliente] [varchar](150) NOT NULL,
	[Telefono] [varchar](10) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Identificacion] [varchar](15) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[TarjetaDeCredito] [varchar](4) NOT NULL,
	[IdVehiculo] [int] NOT NULL,
	[MontoPorDia] decimal(18,2) NOT NULL,
	[MontoSeguro] decimal(18,2) NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFin] [datetime] NOT NULL,
	[FechaDeRegistro] [datetime] NULL,
	[CantidadDeDias] [int] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO