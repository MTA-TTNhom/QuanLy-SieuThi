USE [master]
GO
/****** Object:  Database [banhangsieuthi]    Script Date: 10/1/2019 11:11:19 PM ******/
CREATE DATABASE [banhangsieuthi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'banhangsieuthi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\banhangsieuthi.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'banhangsieuthi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\banhangsieuthi_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [banhangsieuthi] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [banhangsieuthi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [banhangsieuthi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [banhangsieuthi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [banhangsieuthi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [banhangsieuthi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [banhangsieuthi] SET ARITHABORT OFF 
GO
ALTER DATABASE [banhangsieuthi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [banhangsieuthi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [banhangsieuthi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [banhangsieuthi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [banhangsieuthi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [banhangsieuthi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [banhangsieuthi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [banhangsieuthi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [banhangsieuthi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [banhangsieuthi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [banhangsieuthi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [banhangsieuthi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [banhangsieuthi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [banhangsieuthi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [banhangsieuthi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [banhangsieuthi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [banhangsieuthi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [banhangsieuthi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [banhangsieuthi] SET  MULTI_USER 
GO
ALTER DATABASE [banhangsieuthi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [banhangsieuthi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [banhangsieuthi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [banhangsieuthi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [banhangsieuthi] SET DELAYED_DURABILITY = DISABLED 
GO
USE [banhangsieuthi]
GO
/****** Object:  Table [dbo].[chitiethoadon]    Script Date: 10/1/2019 11:11:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiethoadon](
	[stt] [int] NOT NULL,
	[mahoadon] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
 CONSTRAINT [PK_chitiethoadon] PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitietphieugiaoca]    Script Date: 10/1/2019 11:11:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieugiaoca](
	[stt] [int] NOT NULL,
	[magiaoca] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_chitietphieugiaoca] PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitietphieunhap]    Script Date: 10/1/2019 11:11:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieunhap](
	[stt] [int] NOT NULL,
	[manhap] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
 CONSTRAINT [PK_chitietphieunhap] PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitietphieuxuat]    Script Date: 10/1/2019 11:11:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieuxuat](
	[stt] [int] NOT NULL,
	[maxuat] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
 CONSTRAINT [PK_chitietphieuxuat] PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 10/1/2019 11:11:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_chucvu] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 10/1/2019 11:11:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[ma] [nvarchar](20) NOT NULL,
	[ngaylap] [datetime] NULL,
	[tonggiatri] [float] NULL,
	[thanhtien] [float] NULL,
	[manhanvien] [nvarchar](20) NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 10/1/2019 11:11:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](200) NULL,
	[sodienthoai] [nvarchar](15) NULL,
	[uudai] [float] NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachmuahang]    Script Date: 10/1/2019 11:11:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachmuahang](
	[stt] [int] NOT NULL,
	[makhachhang] [nvarchar](20) NULL,
	[mahoadon] [nvarchar](20) NULL,
 CONSTRAINT [PK_khachmuahang] PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khohang]    Script Date: 10/1/2019 11:11:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khohang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](200) NULL,
 CONSTRAINT [PK_khohang] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mathang]    Script Date: 10/1/2019 11:11:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mathang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[loaimathang] [nvarchar](50) NULL,
	[donvitinh] [nvarchar](10) NULL,
	[maquay] [nvarchar](20) NULL,
	[manhacc] [nvarchar](20) NULL,
 CONSTRAINT [PK_mathang] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [banhangsieuthi] SET  READ_WRITE 
GO
