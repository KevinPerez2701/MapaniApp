USE [master]
GO
/****** Object:  Database [Mapani]    Script Date: 3/21/2022 12:32:10 PM ******/
CREATE DATABASE [Mapani]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mapani', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Mapani.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Mapani_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Mapani_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Mapani] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Mapani].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Mapani] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Mapani] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Mapani] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Mapani] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Mapani] SET ARITHABORT OFF 
GO
ALTER DATABASE [Mapani] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Mapani] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Mapani] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Mapani] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Mapani] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Mapani] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Mapani] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Mapani] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Mapani] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Mapani] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Mapani] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Mapani] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Mapani] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Mapani] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Mapani] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Mapani] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Mapani] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Mapani] SET RECOVERY FULL 
GO
ALTER DATABASE [Mapani] SET  MULTI_USER 
GO
ALTER DATABASE [Mapani] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Mapani] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Mapani] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Mapani] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Mapani] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Mapani] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Mapani] SET QUERY_STORE = OFF
GO
USE [Mapani]
GO
/****** Object:  User [kevin]    Script Date: 3/21/2022 12:32:10 PM ******/
CREATE USER [kevin] FOR LOGIN [kevin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [kevin]
GO
ALTER ROLE [db_datareader] ADD MEMBER [kevin]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [kevin]
GO
/****** Object:  Table [dbo].[GestionCasosAsesoria]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GestionCasosAsesoria](
	[IdCuidador] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[TipoCaso] [nvarchar](50) NULL,
	[TipoAtencion] [nvarchar](50) NULL,
	[Seguimiento] [nvarchar](50) NULL,
	[Estatus] [nvarchar](50) NULL,
	[Observacion] [nvarchar](50) NULL,
	[Evolucion] [nvarchar](50) NULL,
 CONSTRAINT [PK_GestionCasosAsesoria] PRIMARY KEY CLUSTERED 
(
	[IdCuidador] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MapaniUsers]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MapaniUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Rol] [nvarchar](50) NULL,
 CONSTRAINT [PK_MapaniUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes](
	[IdOrden] [int] IDENTITY(1,1) NOT NULL,
	[IdNMB] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Programa] [nvarchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Pediatra] [nvarchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Despachado] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProximasVisitas]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProximasVisitas](
	[NMB] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Departamento] [nvarchar](50) NULL,
	[Doctor] [nvarchar](50) NULL,
	[Activo] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Referencia]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Referencia](
	[NMB] [int] NOT NULL,
	[Cuidador] [int] NOT NULL,
	[Parentesco] [nvarchar](50) NULL,
	[Cedula] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Referenc__140DDBE79B11472A] PRIMARY KEY CLUSTERED 
(
	[NMB] ASC,
	[Cuidador] ASC,
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReferenciaMMB]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReferenciaMMB](
	[NMB] [int] NOT NULL,
	[MMB] [int] NOT NULL,
	[Parentesco] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Referenc__ABA7EEFE7A47DE8F] PRIMARY KEY CLUSTERED 
(
	[NMB] ASC,
	[MMB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaAlmacen]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaAlmacen](
	[IdProducto] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Programa] [nvarchar](50) NULL,
	[Cantidad] [nvarchar](50) NULL,
	[Lote] [nvarchar](50) NULL,
	[FechaVencimiento] [date] NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Diferido] [int] NULL,
 CONSTRAINT [PK_TablaAlmacen] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaAsistencia]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaAsistencia](
	[IdTrabajador] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Rol] [nvarchar](50) NULL,
	[Hora] [nvarchar](50) NULL,
	[HoraSalida] [nvarchar](50) NULL,
 CONSTRAINT [PK_TablaAsistencia] PRIMARY KEY CLUSTERED 
(
	[IdTrabajador] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaBodega]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaBodega](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Cantidad] [int] NULL,
	[Programa] [nvarchar](50) NULL,
	[Lote] [nvarchar](50) NULL,
	[FechaVencimiento] [date] NULL,
	[Descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_TablaBodeg] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaContactAsesoria]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaContactAsesoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCuidador] [nvarchar](50) NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Cedula] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Parroquia] [nvarchar](50) NULL,
	[Municipio] [nvarchar](50) NULL,
	[Estado] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Ocupacion] [nvarchar](50) NULL,
	[Vinculo] [nvarchar](50) NULL,
 CONSTRAINT [PK_TablaContactAsesoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaCuidador]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaCuidador](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Foto] [image] NULL,
	[EstadoCivil] [nvarchar](50) NULL,
	[Cedula] [nvarchar](50) NOT NULL,
	[Hijos] [nvarchar](2) NULL,
	[Transporte] [nvarchar](50) NULL,
	[Parroquia] [nvarchar](50) NULL,
	[Municipio] [nvarchar](50) NULL,
	[Estado] [nvarchar](50) NULL,
	[Ocupacion] [nvarchar](50) NULL,
	[IngresosPropios] [nvarchar](50) NULL,
	[Discapacidad] [nvarchar](50) NULL,
	[TipoDiscapacidad] [nvarchar](50) NULL,
	[GrupoEtnico] [nvarchar](50) NULL,
	[TipoGrupoEtnico] [nvarchar](50) NULL,
	[Movilizacion] [nvarchar](50) NULL,
	[CharlaMuac] [nvarchar](50) NULL,
	[CharlaLactancia] [nvarchar](50) NULL,
	[TieneHijos] [nvarchar](50) NULL,
	[Rango1] [nvarchar](50) NULL,
	[Rango2] [nvarchar](50) NULL,
	[Rango3] [nvarchar](50) NULL,
 CONSTRAINT [PK_TablaCuidador] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaDocumentsAsesoria]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaDocumentsAsesoria](
	[IdCuidador] [int] NOT NULL,
	[IdNMB] [int] NOT NULL,
	[TipoDocumento] [nvarchar](50) NOT NULL,
	[PDF] [varbinary](max) NULL,
 CONSTRAINT [PK_TablaDocumentsAsesoria_1] PRIMARY KEY CLUSTERED 
(
	[IdCuidador] ASC,
	[IdNMB] ASC,
	[TipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaEnfermeria]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaEnfermeria](
	[NMB] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Programa] [nvarchar](50) NULL,
	[Peso] [nvarchar](50) NULL,
	[Talla] [nvarchar](50) NULL,
	[CMB] [nvarchar](50) NULL,
	[Hb] [nvarchar](50) NULL,
	[IMC] [nvarchar](50) NULL,
	[PZImcEdad] [nvarchar](50) NULL,
	[PZTallaEdad] [nvarchar](50) NULL,
	[PZPesoEdad] [nvarchar](50) NULL,
	[PZTallaEdad2006] [nvarchar](50) NULL,
	[PZPesoEdad2006] [nvarchar](50) NULL,
	[PZPesoTalla] [nvarchar](50) NULL,
	[IMCPZ] [nvarchar](50) NULL,
	[PesoNacimiento] [nvarchar](50) NULL,
	[Lactancia] [nvarchar](50) NULL,
	[Observacion] [nvarchar](50) NULL,
	[Patologias] [nvarchar](50) NULL,
	[Antecedentes] [nvarchar](50) NULL,
	[Urgencias] [nvarchar](50) NULL,
	[Referido] [nvarchar](50) NULL,
	[Diagnostico] [nvarchar](50) NULL,
	[DiagnosticoTalla] [nvarchar](50) NULL,
	[Muac] [nvarchar](50) NULL,
	[CC] [nvarchar](50) NULL,
	[Edema] [nvarchar](50) NULL,
 CONSTRAINT [PK_TablaEnfermeria] PRIMARY KEY CLUSTERED 
(
	[NMB] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaHistorialNutricion]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaHistorialNutricion](
	[NMB] [int] NOT NULL,
	[HoraLevantar] [time](7) NULL,
	[HoraDesayuno] [time](7) NULL,
	[HoraMerienda1] [time](7) NULL,
	[HoraAlmuerzo] [time](7) NULL,
	[HoraMerienda2] [time](7) NULL,
	[HoraCena] [time](7) NULL,
	[Levantar] [nvarchar](50) NULL,
	[Desayuno] [nvarchar](50) NULL,
	[Merienda1] [nvarchar](50) NULL,
	[Almuerzo] [nvarchar](50) NULL,
	[Merienda2] [nvarchar](50) NULL,
	[Cena] [nvarchar](50) NULL,
	[Diario] [nvarchar](100) NULL,
	[Semanal] [nvarchar](100) NULL,
	[Quincenal] [nvarchar](100) NULL,
	[Mensual] [nvarchar](100) NULL,
 CONSTRAINT [PK_TablaHistorialNutricion] PRIMARY KEY CLUSTERED 
(
	[NMB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaHistorialPsicologia]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaHistorialPsicologia](
	[IdNMB] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[RazonSalud] [nvarchar](50) NULL,
	[RazonSeguridad] [nvarchar](50) NULL,
	[RazonCuidado] [nvarchar](50) NULL,
	[RazonOtro] [nvarchar](50) NULL,
	[NoRazon] [nvarchar](50) NULL,
	[AccionSalud] [nvarchar](50) NULL,
	[AccionSeguridad] [nvarchar](50) NULL,
	[AccionCuidado] [nvarchar](50) NULL,
	[AccionOtro] [nvarchar](50) NULL,
	[NoAccion] [nvarchar](50) NULL,
	[Seguimiento] [nvarchar](50) NULL,
 CONSTRAINT [PK_TablaHistorialPsicologia] PRIMARY KEY CLUSTERED 
(
	[IdNMB] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaMMB]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaMMB](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Foto] [image] NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Cedula] [nvarchar](50) NULL,
	[CantidadHijos] [nvarchar](2) NULL,
	[Transporte] [nvarchar](50) NULL,
	[EstadoCivil] [nvarchar](50) NULL,
	[Parroquia] [nvarchar](50) NULL,
	[Municipio] [nvarchar](50) NULL,
	[Estado] [nvarchar](50) NULL,
	[Ocupacion] [nvarchar](50) NULL,
 CONSTRAINT [PK_TablaMMB] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaNMB]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaNMB](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Foto] [image] NULL,
	[FechaNacimiento] [date] NULL,
	[Cedula] [nvarchar](50) NULL,
	[IngresoPrograma] [nvarchar](50) NULL,
	[PartidaNacimiento] [nvarchar](50) NULL,
	[Discapacidad] [nvarchar](50) NULL,
	[FechaIngreso] [date] NULL,
	[Vacunas] [nvarchar](50) NULL,
	[Parto] [nvarchar](50) NULL,
	[LactanciaMaterna] [nvarchar](50) NULL,
	[Parroquia] [nvarchar](50) NULL,
	[Municipio] [nvarchar](50) NULL,
	[Estado] [nvarchar](50) NULL,
	[HistorialNutricional] [nvarchar](50) NULL,
	[Escolaridad] [nvarchar](50) NULL,
	[NombreEscuela] [nvarchar](50) NULL,
	[DireccionEscuela] [nvarchar](50) NULL,
	[Psicologia] [nvarchar](50) NULL,
	[TipoDiscapacidad] [nvarchar](50) NULL,
 CONSTRAINT [PK_TablaNMB] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaNutricion]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaNutricion](
	[NMB] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Programa] [nvarchar](50) NULL,
	[Peso] [nvarchar](50) NULL,
	[Talla] [nvarchar](50) NULL,
	[CMB] [nvarchar](50) NULL,
	[Hb] [nvarchar](50) NULL,
	[IMC] [nvarchar](50) NULL,
	[PZImcEdad] [nvarchar](50) NULL,
	[PZTallaEdad] [nvarchar](50) NULL,
	[PZPesoEdad] [nvarchar](50) NULL,
	[PZTallaEdad2006] [nvarchar](50) NULL,
	[PZPesoEdad2006] [nvarchar](50) NULL,
	[PZPesoTalla] [nvarchar](50) NULL,
	[IMCPZ] [nvarchar](50) NULL,
	[Observacion] [nvarchar](50) NULL,
	[Patologias] [nvarchar](50) NULL,
	[Antecedentes] [nvarchar](50) NULL,
	[Urgencias] [nvarchar](50) NULL,
	[Referido] [nvarchar](50) NULL,
	[Diagnostico] [nvarchar](50) NULL,
	[DiagnosticoTalla] [nvarchar](50) NULL,
	[Muac] [nvarchar](50) NULL,
	[CC] [nvarchar](50) NULL,
	[Edema] [nvarchar](50) NULL,
 CONSTRAINT [PK_TablaNutricion] PRIMARY KEY CLUSTERED 
(
	[NMB] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaPsicologia]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaPsicologia](
	[IdNMB] [int] NOT NULL,
	[SistemaFamiliar] [nvarchar](50) NULL,
	[MotivoConsulta] [nvarchar](50) NULL,
	[Evaluacion] [nvarchar](50) NULL,
	[Antecedentes] [nvarchar](50) NULL,
	[Referencia] [nvarchar](50) NULL,
	[EvaluacionInicial] [nvarchar](2000) NULL,
	[RazonAlta] [nvarchar](50) NULL,
	[RazonMedia] [nvarchar](50) NULL,
	[RazonBaja] [nvarchar](50) NULL,
	[NoRazon] [nvarchar](50) NULL,
 CONSTRAINT [PK_TablaPsicologia] PRIMARY KEY CLUSTERED 
(
	[IdNMB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visitas]    Script Date: 3/21/2022 12:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitas](
	[NMB] [int] NOT NULL,
	[Cuidador] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Departamento] [nvarchar](50) NULL,
	[Reagendada] [nvarchar](50) NULL,
	[Motivo] [nvarchar](50) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ordenes] ADD  CONSTRAINT [DF_Ordenes_Despachado]  DEFAULT (N'No') FOR [Despachado]
GO
ALTER TABLE [dbo].[ProximasVisitas] ADD  CONSTRAINT [DF_ProximasVisitas_Activo]  DEFAULT (N'No') FOR [Activo]
GO
ALTER TABLE [dbo].[TablaAlmacen] ADD  CONSTRAINT [DF_TablaAlmacen_Diferido]  DEFAULT ((0)) FOR [Diferido]
GO
ALTER TABLE [dbo].[TablaNMB] ADD  CONSTRAINT [DF_TablaNMB_HistorialNutricional]  DEFAULT (N'No') FOR [HistorialNutricional]
GO
ALTER TABLE [dbo].[TablaNMB] ADD  CONSTRAINT [DF_TablaNMB_Psicologia]  DEFAULT (N'No') FOR [Psicologia]
GO
ALTER TABLE [dbo].[Referencia]  WITH CHECK ADD  CONSTRAINT [FK__Referencia__NMB__4222D4EF] FOREIGN KEY([NMB])
REFERENCES [dbo].[TablaNMB] ([Id])
GO
ALTER TABLE [dbo].[Referencia] CHECK CONSTRAINT [FK__Referencia__NMB__4222D4EF]
GO
ALTER TABLE [dbo].[Referencia]  WITH CHECK ADD  CONSTRAINT [FK_Referencia_TablaCuidador] FOREIGN KEY([Cuidador], [Cedula])
REFERENCES [dbo].[TablaCuidador] ([Id], [Cedula])
GO
ALTER TABLE [dbo].[Referencia] CHECK CONSTRAINT [FK_Referencia_TablaCuidador]
GO
ALTER TABLE [dbo].[ReferenciaMMB]  WITH CHECK ADD  CONSTRAINT [FK__ReferenciaM__MMB__30F848ED] FOREIGN KEY([MMB])
REFERENCES [dbo].[TablaMMB] ([Id])
GO
ALTER TABLE [dbo].[ReferenciaMMB] CHECK CONSTRAINT [FK__ReferenciaM__MMB__30F848ED]
GO
ALTER TABLE [dbo].[ReferenciaMMB]  WITH CHECK ADD  CONSTRAINT [FK__ReferenciaM__NMB__3D5E1FD2] FOREIGN KEY([NMB])
REFERENCES [dbo].[TablaNMB] ([Id])
GO
ALTER TABLE [dbo].[ReferenciaMMB] CHECK CONSTRAINT [FK__ReferenciaM__NMB__3D5E1FD2]
GO
ALTER TABLE [dbo].[Visitas]  WITH CHECK ADD  CONSTRAINT [FK__Visitas__NMB__45F365D3] FOREIGN KEY([NMB])
REFERENCES [dbo].[TablaNMB] ([Id])
GO
ALTER TABLE [dbo].[Visitas] CHECK CONSTRAINT [FK__Visitas__NMB__45F365D3]
GO
USE [master]
GO
ALTER DATABASE [Mapani] SET  READ_WRITE 
GO
