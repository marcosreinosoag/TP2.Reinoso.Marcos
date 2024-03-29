USE [master]
GO
/****** Object:  Database [TrucoArg_DB]    Script Date: 20/11/2022 19:04:16 ******/
CREATE DATABASE [TrucoArg_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TrucoArg_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\TrucoArg_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TrucoArg_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\TrucoArg_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TrucoArg_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TrucoArg_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TrucoArg_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TrucoArg_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TrucoArg_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TrucoArg_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TrucoArg_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [TrucoArg_DB] SET  MULTI_USER 
GO
ALTER DATABASE [TrucoArg_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TrucoArg_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TrucoArg_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TrucoArg_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TrucoArg_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TrucoArg_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TrucoArg_DB', N'ON'
GO
ALTER DATABASE [TrucoArg_DB] SET QUERY_STORE = OFF
GO
USE [TrucoArg_DB]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 20/11/2022 19:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[FechaDeNacimiento] [datetime] NOT NULL,
	[PuntajePartida] [int] NOT NULL,
	[PartidasGanadas] [int] NOT NULL,
 CONSTRAINT [PK_Jugadores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partidas]    Script Date: 20/11/2022 19:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partidas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NumeroDeSala] [int] NOT NULL,
	[IdJugadorUno] [int] NOT NULL,
	[IdJugadorDos] [int] NOT NULL,
	[IdGanador] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Partidas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salas]    Script Date: 20/11/2022 19:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dboSalas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Jugadores] ON 

INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (2, N'Marcos', N'Rei', CAST(N'2022-02-25T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (3, N'Pedro', N'Trejo', CAST(N'1989-03-10T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (4, N'Jose', N'Rojas', CAST(N'1997-01-28T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (5, N'Ariana', N'Marquez', CAST(N'2000-02-01T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (1006, N'Martin', N'yout', CAST(N'1988-12-27T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (1007, N'Jorge', N'Brito', CAST(N'1988-12-27T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (1008, N'Ruben', N'Estrada', CAST(N'1989-12-22T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (1009, N'Pedro', N'Suarez', CAST(N'1997-09-29T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (1010, N'Esteban', N'Andrada', CAST(N'1946-08-16T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (1011, N'Romina', N'Ruth', CAST(N'2000-02-08T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (1012, N'Mariana', N'Gonzalez', CAST(N'1999-11-24T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (1013, N'Isidora', N'Grampi', CAST(N'2003-05-12T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (1014, N'Natalia', N'Rodriguez', CAST(N'1933-08-18T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Apellido], [FechaDeNacimiento], [PuntajePartida], [PartidasGanadas]) VALUES (1015, N'Mario', N'Facio', CAST(N'2000-02-08T00:00:00.000' AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[Jugadores] OFF
GO
SET IDENTITY_INSERT [dbo].[Partidas] ON 

INSERT [dbo].[Partidas] ([ID], [NumeroDeSala], [IdJugadorUno], [IdJugadorDos], [IdGanador], [Descripcion]) VALUES (1, 1, 1007, 1012, 1007, N' TOTAL PUNTAJES: Jugador 1: 30 Jugador 2: 0')
INSERT [dbo].[Partidas] ([ID], [NumeroDeSala], [IdJugadorUno], [IdJugadorDos], [IdGanador], [Descripcion]) VALUES (2, 1, 1008, 1013, 1008, N' TOTAL PUNTAJES: Jugador 1: 29 Jugador 2: 22')
INSERT [dbo].[Partidas] ([ID], [NumeroDeSala], [IdJugadorUno], [IdJugadorDos], [IdGanador], [Descripcion]) VALUES (3, 1, 3, 1012, 3, N' TOTAL PUNTAJES: Jugador 1: 16 Jugador 2: 14')
SET IDENTITY_INSERT [dbo].[Partidas] OFF
GO
SET IDENTITY_INSERT [dbo].[Salas] ON 

INSERT [dbo].[Salas] ([Id], [Numero], [Descripcion]) VALUES (1, 1, N'La Partida fue Cancelada')
INSERT [dbo].[Salas] ([Id], [Numero], [Descripcion]) VALUES (2, 1, N'La Partida fue Cancelada')
INSERT [dbo].[Salas] ([Id], [Numero], [Descripcion]) VALUES (3, 1, N'La Partida fue Cancelada')
INSERT [dbo].[Salas] ([Id], [Numero], [Descripcion]) VALUES (4, 1, N'La Partida fue Cancelada')
INSERT [dbo].[Salas] ([Id], [Numero], [Descripcion]) VALUES (5, 1, N'La Partida fue Cancelada')
INSERT [dbo].[Salas] ([Id], [Numero], [Descripcion]) VALUES (6, 1, N'La Partida fue Cancelada')
SET IDENTITY_INSERT [dbo].[Salas] OFF
GO
USE [master]
GO
ALTER DATABASE [TrucoArg_DB] SET  READ_WRITE 
GO
