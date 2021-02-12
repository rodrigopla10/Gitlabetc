USE [master]
GO
/****** Object:  Database [ACF]    Script Date: 2/11/2021 7:42:49 PM ******/
CREATE DATABASE [ACF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ACF', FILENAME = N'C:\Users\rodri\ACF.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ACF_log', FILENAME = N'C:\Users\rodri\ACF_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ACF] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ACF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ACF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ACF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ACF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ACF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ACF] SET ARITHABORT OFF 
GO
ALTER DATABASE [ACF] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ACF] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ACF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ACF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ACF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ACF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ACF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ACF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ACF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ACF] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ACF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ACF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ACF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ACF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ACF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ACF] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ACF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ACF] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ACF] SET  MULTI_USER 
GO
ALTER DATABASE [ACF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ACF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ACF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ACF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ACF] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ACF] SET QUERY_STORE = OFF
GO
USE [ACF]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ACF]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2/11/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 2/11/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[primerNombre] [nvarchar](250) NOT NULL,
	[primerApellido] [nvarchar](250) NOT NULL,
	[edad] [int] NULL,
	[fechaCreacion] [datetime2](7) NOT NULL,
	[identificacion] [nvarchar](100) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ACF] SET  READ_WRITE 
GO
