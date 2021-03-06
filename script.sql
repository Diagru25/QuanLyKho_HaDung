USE [master]
GO
/****** Object:  Database [QuanLyKho_HaDung]    Script Date: 6/1/2018 4:59:01 PM ******/
CREATE DATABASE [QuanLyKho_HaDung]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKho_HaDung', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyKho_HaDung.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyKho_HaDung_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyKho_HaDung_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyKho_HaDung] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKho_HaDung].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKho_HaDung] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKho_HaDung] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyKho_HaDung] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyKho_HaDung', N'ON'
GO
USE [QuanLyKho_HaDung]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [varchar](50) NULL,
	[EmployeeID] [bigint] NULL,
	[Status] [bit] NULL,
	[CreateDate] [date] NULL,
	[UpdateData] [date] NULL,
	[PermissionID] [bigint] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[Phone] [varchar](12) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DeliveryNote]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryNote](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[StorageID] [bigint] NULL,
	[EmployeeID] [bigint] NULL,
	[DeliveryDate] [date] NULL,
	[CustomerID] [bigint] NULL,
 CONSTRAINT [PK_DeliveryNote] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DeliveryNoteDetail]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryNoteDetail](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[DeliveryNoteID] [bigint] NULL,
	[MaterialID] [bigint] NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DeliveryNoteDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Gender] [bit] NULL,
	[Address] [nvarchar](100) NULL,
	[Phone] [varchar](12) NULL,
	[Email] [varchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[Regency] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Material]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Price] [decimal](18, 0) NULL,
	[Unit] [nvarchar](50) NULL,
	[TypeMaterialID] [bigint] NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permission]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Unit] [nvarchar](50) NULL,
	[UserID] [bigint] NULL,
	[TypeProductID] [bigint] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReceiptNote]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptNote](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplierID] [bigint] NULL,
	[StorageID] [bigint] NULL,
	[ReceiptDate] [date] NULL,
 CONSTRAINT [PK_ReceiptNote] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReceiptNoteDetail]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptNoteDetail](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ReceiptNoteID] [bigint] NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[Describe] [ntext] NULL,
 CONSTRAINT [PK_ReceiptNoteDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Request]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [bigint] NULL,
	[RequestDate] [date] NULL,
	[ReceivedDate] [date] NULL,
	[StorageID] [bigint] NULL,
	[IntoMoney] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RequestDetail]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestDetail](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[RequestID] [bigint] NULL,
	[MaterialID] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_RequestDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Storage]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storage](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[EmployeeID] [bigint] NULL,
 CONSTRAINT [PK_Storage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Storage_Material]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storage_Material](
	[StorageID] [bigint] NOT NULL,
	[MaterialID] [bigint] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Storage_Material] PRIMARY KEY CLUSTERED 
(
	[StorageID] ASC,
	[MaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [varchar](15) NULL,
	[Describe] [ntext] NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TypeMaterial]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeMaterial](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[SupplierID] [bigint] NULL,
	[StorageID] [bigint] NULL,
 CONSTRAINT [PK_TypeMaterial] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeProduct]    Script Date: 6/1/2018 4:59:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeProduct](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Describe] [ntext] NULL,
	[Faculty] [nvarchar](50) NULL,
 CONSTRAINT [PK_TypeProduct] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [QuanLyKho_HaDung] SET  READ_WRITE 
GO
