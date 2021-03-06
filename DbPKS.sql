USE [master]
GO
/****** Object:  Database [DbPKS]    Script Date: 21.01.2020 13:09:44 ******/
CREATE DATABASE [DbPKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbPKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DbPKS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbPKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DbPKS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DbPKS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbPKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbPKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbPKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbPKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbPKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbPKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbPKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbPKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbPKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbPKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbPKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbPKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbPKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbPKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbPKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbPKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbPKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbPKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbPKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbPKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbPKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbPKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbPKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbPKS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbPKS] SET  MULTI_USER 
GO
ALTER DATABASE [DbPKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbPKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbPKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbPKS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DbPKS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbPKS] SET QUERY_STORE = OFF
GO
USE [DbPKS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [DbPKS]
GO
/****** Object:  Table [dbo].[TblPersonel]    Script Date: 21.01.2020 13:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPersonel](
	[PersId] [smallint] IDENTITY(1,1) NOT NULL,
	[PersAd] [nvarchar](30) NULL,
	[PersSoyad] [nvarchar](30) NULL,
	[PersDT] [date] NULL,
	[DepartmanId] [tinyint] NULL,
	[Maas] [money] NULL,
 CONSTRAINT [PK_TblPersonel] PRIMARY KEY CLUSTERED 
(
	[PersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDepartman]    Script Date: 21.01.2020 13:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDepartman](
	[DepartmanId] [tinyint] IDENTITY(1,1) NOT NULL,
	[Departman] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblDepartman] PRIMARY KEY CLUSTERED 
(
	[DepartmanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblIslemler]    Script Date: 21.01.2020 13:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblIslemler](
	[IslemId] [bigint] IDENTITY(1,1) NOT NULL,
	[PersId] [smallint] NULL,
	[GirisTarih] [datetime] NULL,
	[GirisSaati] [time](7) NULL,
	[CikisTarih] [datetime] NULL,
	[CikisSaati] [time](7) NULL,
	[GunlukUcret] [money] NULL,
 CONSTRAINT [PK_TblIslemler] PRIMARY KEY CLUSTERED 
(
	[IslemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TempTable]    Script Date: 21.01.2020 13:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TempTable] as
select pers.PersAd,pers.PersSoyad,depart.Departman,islem.GirisTarih,islem.GirisSaati,islem.CikisTarih,islem.CikisSaati,pers.PersId
from TblIslemler islem join TblPersonel pers on islem.PersId=pers.PersId join TblDepartman depart on depart.DepartmanId=pers.DepartmanId
GO
/****** Object:  Table [dbo].[TblGiris]    Script Date: 21.01.2020 13:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblGiris](
	[KulId] [tinyint] IDENTITY(1,1) NOT NULL,
	[KulAdi] [nvarchar](50) NULL,
	[Parola] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblGiris] PRIMARY KEY CLUSTERED 
(
	[KulId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblDepartman] ON 

INSERT [dbo].[TblDepartman] ([DepartmanId], [Departman]) VALUES (1, N'Halkla İlişkiler')
INSERT [dbo].[TblDepartman] ([DepartmanId], [Departman]) VALUES (2, N'Muhasebe')
INSERT [dbo].[TblDepartman] ([DepartmanId], [Departman]) VALUES (3, N'Bilgi İşlem')
SET IDENTITY_INSERT [dbo].[TblDepartman] OFF
SET IDENTITY_INSERT [dbo].[TblGiris] ON 

INSERT [dbo].[TblGiris] ([KulId], [KulAdi], [Parola]) VALUES (1, N'ugur', N'1632')
INSERT [dbo].[TblGiris] ([KulId], [KulAdi], [Parola]) VALUES (3, N'deneme', N'1234')
SET IDENTITY_INSERT [dbo].[TblGiris] OFF
SET IDENTITY_INSERT [dbo].[TblIslemler] ON 

INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (1, 19, CAST(N'2020-01-01T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-01T18:20:57.710' AS DateTime), CAST(N'18:20:00' AS Time), 112.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (2, 19, CAST(N'2020-01-02T09:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-02T18:00:00.000' AS DateTime), CAST(N'18:20:00' AS Time), 112.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (3, 19, CAST(N'2020-01-03T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-03T20:20:57.710' AS DateTime), CAST(N'20:20:00' AS Time), 125.0000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (4, 19, CAST(N'2020-01-04T09:00:00.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-04T18:00:00.710' AS DateTime), CAST(N'18:20:00' AS Time), 112.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (5, 19, CAST(N'2020-01-05T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-05T18:00:57.710' AS DateTime), CAST(N'18:00:00' AS Time), 112.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (6, 19, CAST(N'2020-01-06T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-06T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 100.0000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (7, 19, CAST(N'2020-01-07T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-07T18:20:57.710' AS DateTime), CAST(N'18:20:00' AS Time), 100.0000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (8, 19, CAST(N'2020-01-08T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-08T17:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 100.0000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (9, 19, CAST(N'2020-01-09T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-09T17:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 87.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (10, 19, CAST(N'2020-01-10T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-10T18:20:57.710' AS DateTime), CAST(N'18:20:00' AS Time), 100.0000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (11, 19, CAST(N'2020-01-11T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-11T18:20:57.710' AS DateTime), CAST(N'18:20:00' AS Time), 112.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (12, 19, CAST(N'2020-01-12T11:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-12T18:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 87.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (13, 19, CAST(N'2020-01-13T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-13T21:20:57.710' AS DateTime), CAST(N'21:20:00' AS Time), 137.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (14, 19, CAST(N'2020-01-14T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-14T21:20:57.710' AS DateTime), CAST(N'21:20:00' AS Time), 137.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (15, 19, CAST(N'2020-01-15T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-15T18:00:57.710' AS DateTime), CAST(N'18:00:00' AS Time), 100.0000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (16, 19, CAST(N'2020-01-16T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-16T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 100.0000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (17, 19, CAST(N'2020-01-17T09:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-17T17:30:57.710' AS DateTime), CAST(N'17:30:00' AS Time), 100.0000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (18, 19, CAST(N'2020-01-18T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-18T18:25:57.710' AS DateTime), CAST(N'18:25:00' AS Time), 100.0000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (19, 19, CAST(N'2020-01-19T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-19T17:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 87.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (20, 19, CAST(N'2020-01-20T09:45:57.710' AS DateTime), CAST(N'09:45:00' AS Time), CAST(N'2020-01-20T18:45:57.710' AS DateTime), CAST(N'18:45:00' AS Time), 112.5000)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (21, 19, CAST(N'2020-01-21T10:30:57.710' AS DateTime), CAST(N'10:30:00' AS Time), NULL, NULL, NULL)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (22, 20, CAST(N'2020-01-01T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-01T17:23:57.710' AS DateTime), CAST(N'17:23:00' AS Time), 116.6664)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (23, 20, CAST(N'2020-01-02T09:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-02T18:00:00.000' AS DateTime), CAST(N'18:20:00' AS Time), 131.2497)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (24, 20, CAST(N'2020-01-03T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-03T19:30:57.710' AS DateTime), CAST(N'19:30:00' AS Time), 131.2497)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (25, 20, CAST(N'2020-01-04T09:00:00.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-04T18:00:00.710' AS DateTime), CAST(N'18:20:00' AS Time), 131.2497)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (26, 20, CAST(N'2020-01-05T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-05T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 116.6664)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (27, 20, CAST(N'2020-01-06T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-06T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 116.6664)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (28, 20, CAST(N'2020-01-07T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-07T18:20:57.710' AS DateTime), CAST(N'18:20:00' AS Time), 116.6664)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (29, 20, CAST(N'2020-01-08T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-08T17:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 116.6664)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (30, 20, CAST(N'2020-01-09T09:43:57.710' AS DateTime), CAST(N'09:43:00' AS Time), CAST(N'2020-01-09T17:45:57.710' AS DateTime), CAST(N'17:45:00' AS Time), 116.6664)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (31, 20, CAST(N'2020-01-10T10:45:57.710' AS DateTime), CAST(N'10:45:00' AS Time), CAST(N'2020-01-10T19:50:57.710' AS DateTime), CAST(N'19:50:00' AS Time), 131.2497)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (32, 20, CAST(N'2020-01-11T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-11T18:20:57.710' AS DateTime), CAST(N'18:20:00' AS Time), 131.2497)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (33, 20, CAST(N'2020-01-12T11:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-12T18:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 102.0831)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (34, 20, CAST(N'2020-01-13T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-13T21:20:57.710' AS DateTime), CAST(N'21:20:00' AS Time), 160.4163)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (35, 20, CAST(N'2020-01-14T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-14T21:20:57.710' AS DateTime), CAST(N'21:20:00' AS Time), 160.4163)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (36, 20, CAST(N'2020-01-15T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-15T18:00:57.710' AS DateTime), CAST(N'18:00:00' AS Time), 116.6664)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (37, 20, CAST(N'2020-01-16T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-16T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 116.6664)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (38, 20, CAST(N'2020-01-17T09:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-17T17:30:57.710' AS DateTime), CAST(N'17:30:00' AS Time), 116.6664)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (39, 20, CAST(N'2020-01-18T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-18T18:25:57.710' AS DateTime), CAST(N'18:25:00' AS Time), 116.6664)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (40, 20, CAST(N'2020-01-19T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-19T17:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 102.0831)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (41, 22, CAST(N'2020-01-01T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-01T17:23:57.710' AS DateTime), CAST(N'17:23:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (42, 22, CAST(N'2020-01-02T09:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-02T18:00:00.000' AS DateTime), CAST(N'18:20:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (43, 22, CAST(N'2020-01-03T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-03T19:30:57.710' AS DateTime), CAST(N'19:30:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (44, 22, CAST(N'2020-01-04T09:00:00.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-04T18:00:00.710' AS DateTime), CAST(N'18:20:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (45, 22, CAST(N'2020-01-05T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-05T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (46, 22, CAST(N'2020-01-06T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-06T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (47, 22, CAST(N'2020-01-07T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-07T18:20:57.710' AS DateTime), CAST(N'18:20:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (48, 22, CAST(N'2020-01-08T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-08T17:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (49, 22, CAST(N'2020-01-09T09:43:57.710' AS DateTime), CAST(N'09:43:00' AS Time), CAST(N'2020-01-09T17:45:57.710' AS DateTime), CAST(N'17:45:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (50, 22, CAST(N'2020-01-10T10:45:57.710' AS DateTime), CAST(N'10:45:00' AS Time), CAST(N'2020-01-10T19:50:57.710' AS DateTime), CAST(N'19:50:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (51, 22, CAST(N'2020-01-11T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-11T18:20:57.710' AS DateTime), CAST(N'18:20:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (52, 22, CAST(N'2020-01-12T11:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-12T18:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 116.6662)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (53, 22, CAST(N'2020-01-13T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-13T21:20:57.710' AS DateTime), CAST(N'21:20:00' AS Time), 183.3326)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (54, 22, CAST(N'2020-01-14T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-14T21:20:57.710' AS DateTime), CAST(N'21:20:00' AS Time), 183.3326)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (55, 22, CAST(N'2020-01-15T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-15T18:00:57.710' AS DateTime), CAST(N'18:00:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (56, 22, CAST(N'2020-01-16T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-16T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (57, 22, CAST(N'2020-01-17T09:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-17T17:30:57.710' AS DateTime), CAST(N'17:30:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (58, 22, CAST(N'2020-01-18T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-18T18:25:57.710' AS DateTime), CAST(N'18:25:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (59, 22, CAST(N'2020-01-19T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-19T17:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 116.6662)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (60, 21, CAST(N'2020-01-01T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-01T17:23:57.710' AS DateTime), CAST(N'17:23:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (61, 21, CAST(N'2020-01-02T09:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-02T18:00:00.000' AS DateTime), CAST(N'18:20:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (62, 21, CAST(N'2020-01-03T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-03T19:30:57.710' AS DateTime), CAST(N'19:30:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (63, 21, CAST(N'2020-01-04T09:00:00.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-04T18:00:00.710' AS DateTime), CAST(N'18:20:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (64, 21, CAST(N'2020-01-05T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-05T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (65, 21, CAST(N'2020-01-06T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-06T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (66, 21, CAST(N'2020-01-07T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-07T18:20:57.710' AS DateTime), CAST(N'18:20:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (67, 21, CAST(N'2020-01-08T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-08T17:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (68, 21, CAST(N'2020-01-09T09:43:57.710' AS DateTime), CAST(N'09:43:00' AS Time), CAST(N'2020-01-09T17:45:57.710' AS DateTime), CAST(N'17:45:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (69, 21, CAST(N'2020-01-10T10:45:57.710' AS DateTime), CAST(N'10:45:00' AS Time), CAST(N'2020-01-10T19:50:57.710' AS DateTime), CAST(N'19:50:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (70, 21, CAST(N'2020-01-11T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-11T18:20:57.710' AS DateTime), CAST(N'18:20:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (71, 21, CAST(N'2020-01-12T11:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-12T18:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 116.6662)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (72, 21, CAST(N'2020-01-13T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-13T21:20:57.710' AS DateTime), CAST(N'21:20:00' AS Time), 183.3326)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (73, 21, CAST(N'2020-01-14T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-14T21:20:57.710' AS DateTime), CAST(N'21:20:00' AS Time), 183.3326)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (74, 21, CAST(N'2020-01-15T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-15T18:00:57.710' AS DateTime), CAST(N'18:00:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (75, 21, CAST(N'2020-01-16T09:00:57.710' AS DateTime), CAST(N'09:00:00' AS Time), CAST(N'2020-01-16T17:00:57.710' AS DateTime), CAST(N'17:00:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (76, 21, CAST(N'2020-01-17T09:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-17T17:30:57.710' AS DateTime), CAST(N'17:30:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (77, 21, CAST(N'2020-01-18T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-18T18:25:57.710' AS DateTime), CAST(N'18:25:00' AS Time), 133.3328)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (78, 21, CAST(N'2020-01-19T10:00:57.710' AS DateTime), CAST(N'10:00:00' AS Time), CAST(N'2020-01-19T17:20:57.710' AS DateTime), CAST(N'17:20:00' AS Time), 116.6662)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (79, 21, CAST(N'2020-01-20T09:45:57.710' AS DateTime), CAST(N'09:45:00' AS Time), CAST(N'2020-01-20T18:45:57.710' AS DateTime), CAST(N'18:45:00' AS Time), 149.9994)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (80, 21, CAST(N'2020-01-21T00:48:53.650' AS DateTime), CAST(N'00:48:53' AS Time), NULL, NULL, NULL)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (81, 23, CAST(N'2020-01-21T11:51:57.177' AS DateTime), CAST(N'11:51:57' AS Time), NULL, NULL, NULL)
INSERT [dbo].[TblIslemler] ([IslemId], [PersId], [GirisTarih], [GirisSaati], [CikisTarih], [CikisSaati], [GunlukUcret]) VALUES (82, 22, CAST(N'2020-01-21T12:47:03.663' AS DateTime), CAST(N'12:47:03' AS Time), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TblIslemler] OFF
SET IDENTITY_INSERT [dbo].[TblPersonel] ON 

INSERT [dbo].[TblPersonel] ([PersId], [PersAd], [PersSoyad], [PersDT], [DepartmanId], [Maas]) VALUES (19, N'şevval', N'kaya', CAST(N'1996-10-10' AS Date), 1, 3000.0000)
INSERT [dbo].[TblPersonel] ([PersId], [PersAd], [PersSoyad], [PersDT], [DepartmanId], [Maas]) VALUES (20, N'sevde', N'çetin', CAST(N'1990-12-12' AS Date), 2, 3500.0000)
INSERT [dbo].[TblPersonel] ([PersId], [PersAd], [PersSoyad], [PersDT], [DepartmanId], [Maas]) VALUES (21, N'uğur', N'mamak', CAST(N'1998-01-30' AS Date), 3, 4000.0000)
INSERT [dbo].[TblPersonel] ([PersId], [PersAd], [PersSoyad], [PersDT], [DepartmanId], [Maas]) VALUES (22, N'emine', N'eybek', CAST(N'1996-02-02' AS Date), 2, 4000.0000)
INSERT [dbo].[TblPersonel] ([PersId], [PersAd], [PersSoyad], [PersDT], [DepartmanId], [Maas]) VALUES (23, N'kadir', N'doğan', CAST(N'1997-02-04' AS Date), 3, 6000.0000)
SET IDENTITY_INSERT [dbo].[TblPersonel] OFF
ALTER TABLE [dbo].[TblIslemler]  WITH CHECK ADD  CONSTRAINT [FK_TblIslemler_TblPersonel] FOREIGN KEY([PersId])
REFERENCES [dbo].[TblPersonel] ([PersId])
GO
ALTER TABLE [dbo].[TblIslemler] CHECK CONSTRAINT [FK_TblIslemler_TblPersonel]
GO
ALTER TABLE [dbo].[TblPersonel]  WITH CHECK ADD  CONSTRAINT [FK_TblPersonel_TblDepartman] FOREIGN KEY([DepartmanId])
REFERENCES [dbo].[TblDepartman] ([DepartmanId])
GO
ALTER TABLE [dbo].[TblPersonel] CHECK CONSTRAINT [FK_TblPersonel_TblDepartman]
GO
/****** Object:  StoredProcedure [dbo].[prcAylikList]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[prcAylikList](@ay tinyint) as begin
set language turkish
select pers.PersId,pers.PersAd,pers.PersSoyad,depart.Departman,pers.Maas,DATENAME(M,GirisTarih) as 'Ay',COUNT(GirisTarih) as 'Toplam Gün'
from TblDepartman depart join TblPersonel pers on pers.DepartmanId=depart.DepartmanId join TblIslemler islem on islem.PersId=pers.PersId
where MONTH(GirisTarih)=@ay
group by pers.PersAd,MONTH(GirisTarih),pers.PersSoyad,depart.Departman,DATENAME(M,GirisTarih),pers.Maas,pers.PersId
end
GO
/****** Object:  StoredProcedure [dbo].[prcDepartmanList]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prcDepartmanList] as begin
select * from TblDepartman
end
GO
/****** Object:  StoredProcedure [dbo].[PrcGiris]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcGiris](@KulAdi varchar(10),@Parola varchar(10)) as begin
select COUNT(*),*from TblGiris where KulAdi=@KulAdi and Parola=@Parola group by KulId,KulAdi,Parola
end
GO
/****** Object:  StoredProcedure [dbo].[prcHesapGuncelle]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prcHesapGuncelle] (@KulId tinyint,@KulAdi varchar(20),@Parola varchar(20)) as begin 
update TblGiris set KulAdi=@KulAdi, Parola=@Parola where KulId=@KulId
end
GO
/****** Object:  StoredProcedure [dbo].[prcHesapListele]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[prcHesapListele] as begin 
select * from TblGiris
end
GO
/****** Object:  StoredProcedure [dbo].[prcHesapOlustur]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prcHesapOlustur](@KulAdi varchar(20),@Parola varchar(20))
 as begin 

 insert into TblGiris values(@KulAdi,@Parola)

end
GO
/****** Object:  StoredProcedure [dbo].[prcIslemYap]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[prcIslemYap]
(@adsoyad varchar(50),
@tarih datetime,
@saat time(7),
@persId tinyint
)as begin

	select pers.PersAd,pers.PersSoyad,depart.Departman,islem.GirisTarih,islem.GirisSaati,islem.CikisTarih,islem.CikisSaati,pers.PersId,islem.IslemId
	into #TempTable2
	from TblIslemler islem join TblPersonel pers on islem.PersId=pers.PersId join TblDepartman depart on depart.DepartmanId=pers.DepartmanId
	where CONVERT(DATE,islem.GirisTarih,104)=CONVERT(DATE,@tarih,104) or CikisTarih is null
	

	declare @kontrol int select @kontrol=tt.IslemId
	from #TempTable2 tt right join TblPersonel pers on tt.PersId=pers.PersId join TblDepartman depart on depart.DepartmanId=pers.DepartmanId
	where pers.PersAd+'_'+pers.PersSoyad=@adsoyad

	if(@kontrol is null)
	begin 
		insert into TblIslemler(PersId,GirisTarih,GirisSaati) values(@persId,@tarih,@saat)-- işlemler tablosuna eklenecek veriler
		select 0
	end

	else 
	begin
		declare @maas money select @maas=Maas from TblPersonel where PersId=@persId --kişinin maaşını aldık.

		declare @girisTarih datetime select @girisTarih=GirisTarih from #TempTable2 where PersId=@persId --kişinin giriş saatini çektik.

		--declare @kacsaat tinyint set @kacsaat= datediff(HOUR, CAST(@girisSaat as time(7)) ,@saat)
		declare @kacsaat int set @kacsaat= datediff( HH, CAST(@girisTarih as datetime) ,@tarih)-- bize iki tarih arasındaki saati verir.
		 	
		declare @gunlukUcret money
		--if @kacsaat>=8 
		--begin						
			set @gunlukUcret=(@maas/240)*@kacsaat --8 saatten fazla çalıştıysa mesai ücretleriyle birlikte hesaplanır.
		--end
		/*
		else if @kacsaat<8
		begin			
			set @gunlukUcret=((@kacsaat)*(@maas/240)) --fazla mesai yaptıysa onuda eklemiş olduk
		end
		*/
		update TblIslemler set CikisSaati=@saat,CikisTarih=@tarih,GunlukUcret=@gunlukUcret where IslemId=@kontrol --eğer giri yapıldığı belliyse güncelleme yapılır. 
		select 1
	end
end
GO
/****** Object:  StoredProcedure [dbo].[PrcListele]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcListele](@tarih date) 
as 
begin

select pers.PersAd,pers.PersSoyad,depart.Departman,islem.GirisTarih,islem.GirisSaati,islem.CikisTarih,islem.CikisSaati,pers.PersId,islem.GunlukUcret
into #TempTable
from TblIslemler islem join TblPersonel pers on islem.PersId=pers.PersId join TblDepartman depart on depart.DepartmanId=pers.DepartmanId
where CONVERT(DATE,islem.GirisTarih,104)=@tarih

select pers.PersAd,pers.PersSoyad,depart.Departman,tt.GirisTarih,tt.GirisSaati,tt.CikisTarih,tt.CikisSaati,
	case 
		when tt.CikisTarih is null then datediff( HH, CAST(tt.GirisTarih as datetime) ,GETDATE()) --eğer çıkış yapmadıysa
		when tt.CikisTarih is not null then datediff( HH, CAST(tt.GirisTarih as datetime) ,tt.CikisTarih) end as 'Çalıştığı saat',
	case
		when tt.GunlukUcret is null then datediff( HH, CAST(GirisTarih as datetime) ,GETDATE() )*(pers.Maas/240)--Çıkış yapmadıysa o sisteme girilen saate göre işlem alır.
		when tt.GunlukUcret is not null then tt.GunlukUcret end as 'Günlük Ücret',pers.PersId
from #TempTable tt right join TblPersonel pers on tt.PersId=pers.PersId join TblDepartman depart on depart.DepartmanId=pers.DepartmanId



end
GO
/****** Object:  StoredProcedure [dbo].[prcPersonelDetayList]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[prcPersonelDetayList]
(@persId tinyint,@ay tinyint)as begin
set language Turkish

select pers.PersId,pers.PersAd,pers.PersSoyad,depart.Departman,
DATENAME(M,GirisTarih) as 'Ay',
pers.Maas,
COUNT(GirisTarih) as 'Çalıştığı Gün Sayısı',
COUNT(GirisTarih)*8 as 'Çalışması gereken saat',
SUM(datediff(HH, CAST(islem.GirisTarih as datetime) ,islem.CikisTarih)) as 'çalıştığı saat',
(SUM(datediff(HH, CAST(islem.GirisTarih as datetime) ,islem.CikisTarih))-COUNT(GirisTarih)*8) as'Bu ay çalıştığı fazla mesai saati',
(SUM(datediff(HH, CAST(islem.GirisTarih as datetime) ,islem.CikisTarih))-COUNT(GirisTarih)*8)*(pers.Maas/240) as'Fazla Mesai ücreti',
SUM(GunlukUcret) as 'Alacağı Ücret'
from TblPersonel pers  left join TblIslemler islem on pers.PersId=islem.PersId join TblDepartman depart on depart.DepartmanId=pers.DepartmanId
where (MONTH(GirisTarih)=@ay or GirisTarih is null) and pers.persId=@persId  and islem.CikisTarih is not null
group by pers.PersAd,MONTH(GirisTarih),pers.PersSoyad,depart.Departman,DATENAME(M,GirisTarih),pers.Maas,pers.PersId
end
GO
/****** Object:  StoredProcedure [dbo].[prcPersonelInsert]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prcPersonelInsert] 
(@persAd varchar(50),
@persSoyad varchar(50),
@persDt date,
@departman varchar(50),
@maas money
)as begin
declare @depId tinyint
select @depId=DepartmanId from TblDepartman where Departman=@departman
insert into TblPersonel values(@persAd,@persSoyad,@persDt,@depId,@maas)
end
GO
/****** Object:  StoredProcedure [dbo].[prcPersoneList]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[prcPersoneList] as begin 
select pers.PersId,pers.PersAd,pers.PersSoyad,pers.PersDT,depart.Departman,pers.Maas 
from TblPersonel pers join TblDepartman depart on pers.DepartmanId=depart.DepartmanId
 end
GO
/****** Object:  StoredProcedure [dbo].[prcPersonelUpdate]    Script Date: 21.01.2020 13:09:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[prcPersonelUpdate] 
(@persId int,
@persSoyad varchar(50),
@persDt date,
@departman varchar(50),
@maas money
)as begin
declare @depId tinyint
select @depId=DepartmanId from TblDepartman where Departman=@departman

update TblPersonel set PersSoyad=@persSoyad, PersDT=@persDt, DepartmanId=@depId, Maas=@maas where PersId=@persId


end
GO
USE [master]
GO
ALTER DATABASE [DbPKS] SET  READ_WRITE 
GO
