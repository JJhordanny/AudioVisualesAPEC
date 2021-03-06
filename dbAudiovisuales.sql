USE [master]
GO
/****** Object:  Database [dbAudiovisuales]    Script Date: 8/8/2016 11:39:48 PM ******/
CREATE DATABASE [dbAudiovisuales]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbAudiovisuales', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbAudiovisuales.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbAudiovisuales_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbAudiovisuales_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbAudiovisuales] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbAudiovisuales].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbAudiovisuales] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbAudiovisuales] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbAudiovisuales] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbAudiovisuales] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbAudiovisuales] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET RECOVERY FULL 
GO
ALTER DATABASE [dbAudiovisuales] SET  MULTI_USER 
GO
ALTER DATABASE [dbAudiovisuales] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbAudiovisuales] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbAudiovisuales] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbAudiovisuales] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbAudiovisuales] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbAudiovisuales', N'ON'
GO
USE [dbAudiovisuales]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 8/8/2016 11:39:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Cedula] [text] NOT NULL,
	[TandaLabor] [varchar](10) NOT NULL,
	[FechaIngreso] [date] NOT NULL,
	[Estado] [varchar](10) NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 8/8/2016 11:39:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Equipos](
	[IdEquipo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Serial] [varchar](50) NOT NULL,
	[ServiceTag] [varchar](50) NOT NULL,
	[IdTipoEquipo] [int] NOT NULL,
	[IdMarca] [int] NOT NULL,
	[IdModelo] [int] NOT NULL,
	[IdTecnologia] [int] NOT NULL,
	[Estado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Equipos] PRIMARY KEY CLUSTERED 
(
	[IdEquipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Login]    Script Date: 8/8/2016 11:39:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[IdLogin] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
	[Rol] [varchar](50) NULL,
 CONSTRAINT [PK__tmp_ms_x__C3C6C6F12CE935B5] PRIMARY KEY CLUSTERED 
(
	[IdLogin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 8/8/2016 11:39:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marcas](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Estado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 8/8/2016 11:39:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modelos](
	[IdModelo] [int] IDENTITY(1,1) NOT NULL,
	[IdMarca] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Estado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Modelos] PRIMARY KEY CLUSTERED 
(
	[IdModelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 8/8/2016 11:39:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prestamos](
	[IdPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[IdEquipo] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[FechaPrestamo] [date] NOT NULL,
	[FechaDevolucion] [date] NOT NULL,
	[Comentario] [text] NOT NULL,
	[Estado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Prestamos] PRIMARY KEY CLUSTERED 
(
	[IdPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tecnologias]    Script Date: 8/8/2016 11:39:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tecnologias](
	[IdTecnologia] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Estado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Tecnologias] PRIMARY KEY CLUSTERED 
(
	[IdTecnologia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposEquipos]    Script Date: 8/8/2016 11:39:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposEquipos](
	[IdTipoEquipo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Estado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_TiposEquipos] PRIMARY KEY CLUSTERED 
(
	[IdTipoEquipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 8/8/2016 11:39:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Cedula] [int] NOT NULL,
	[NoCarnet] [int] NOT NULL,
	[TipoUsuario] [varchar](50) NOT NULL,
	[TipoPersona] [varchar](50) NOT NULL,
	[Estado] [varchar](10) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Equipos]  WITH CHECK ADD  CONSTRAINT [FK_Equipos_Marcas] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marcas] ([IdMarca])
GO
ALTER TABLE [dbo].[Equipos] CHECK CONSTRAINT [FK_Equipos_Marcas]
GO
ALTER TABLE [dbo].[Equipos]  WITH CHECK ADD  CONSTRAINT [FK_Equipos_Modelos] FOREIGN KEY([IdModelo])
REFERENCES [dbo].[Modelos] ([IdModelo])
GO
ALTER TABLE [dbo].[Equipos] CHECK CONSTRAINT [FK_Equipos_Modelos]
GO
ALTER TABLE [dbo].[Equipos]  WITH CHECK ADD  CONSTRAINT [FK_Equipos_Tecnologias] FOREIGN KEY([IdTecnologia])
REFERENCES [dbo].[Tecnologias] ([IdTecnologia])
GO
ALTER TABLE [dbo].[Equipos] CHECK CONSTRAINT [FK_Equipos_Tecnologias]
GO
ALTER TABLE [dbo].[Equipos]  WITH CHECK ADD  CONSTRAINT [FK_Equipos_TiposEquipos] FOREIGN KEY([IdEquipo])
REFERENCES [dbo].[TiposEquipos] ([IdTipoEquipo])
GO
ALTER TABLE [dbo].[Equipos] CHECK CONSTRAINT [FK_Equipos_TiposEquipos]
GO
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [FK_Modelos_Marcas] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marcas] ([IdMarca])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [FK_Modelos_Marcas]
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamos_Empleados] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [FK_Prestamos_Empleados]
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamos_Equipos] FOREIGN KEY([IdEquipo])
REFERENCES [dbo].[Equipos] ([IdEquipo])
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [FK_Prestamos_Equipos]
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamos_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [FK_Prestamos_Usuarios]
GO
USE [master]
GO
ALTER DATABASE [dbAudiovisuales] SET  READ_WRITE 
GO
