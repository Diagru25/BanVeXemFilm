USE [master]
GO
/****** Object:  Database [VeXemPhim]    Script Date: 10/8/2018 6:42:49 PM ******/
CREATE DATABASE [VeXemPhim]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VeXemPhim', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\VeXemPhim.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VeXemPhim_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\VeXemPhim_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VeXemPhim] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VeXemPhim].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VeXemPhim] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VeXemPhim] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VeXemPhim] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VeXemPhim] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VeXemPhim] SET ARITHABORT OFF 
GO
ALTER DATABASE [VeXemPhim] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VeXemPhim] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VeXemPhim] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VeXemPhim] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VeXemPhim] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VeXemPhim] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VeXemPhim] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VeXemPhim] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VeXemPhim] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VeXemPhim] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VeXemPhim] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VeXemPhim] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VeXemPhim] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VeXemPhim] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VeXemPhim] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VeXemPhim] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VeXemPhim] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VeXemPhim] SET RECOVERY FULL 
GO
ALTER DATABASE [VeXemPhim] SET  MULTI_USER 
GO
ALTER DATABASE [VeXemPhim] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VeXemPhim] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VeXemPhim] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VeXemPhim] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [VeXemPhim] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'VeXemPhim', N'ON'
GO
USE [VeXemPhim]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 10/8/2018 6:42:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichChieu]    Script Date: 10/8/2018 6:42:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichChieu](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ThoiGianBatDau] [time](7) NULL,
	[ThoiGianKetThuc] [time](7) NULL,
	[NgayChieu] [date] NULL,
	[GiaVe] [decimal](18, 0) NULL,
	[PhongChieuID] [bigint] NULL,
	[PhimID] [bigint] NULL,
 CONSTRAINT [PK_LichChieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phim]    Script Date: 10/8/2018 6:42:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phim](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenPhim] [nvarchar](50) NULL,
	[ThoiLuong] [int] NULL,
	[MoTa] [ntext] NULL,
	[KhoiChieu] [date] NULL,
	[TheLoaiID] [bigint] NULL,
 CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongChieu]    Script Date: 10/8/2018 6:42:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongChieu](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenPhongChieu] [nvarchar](50) NULL,
	[ViTri] [nvarchar](50) NULL,
	[TongSoGhe] [int] NULL CONSTRAINT [DF_PhongChieu_TongSoGhe]  DEFAULT ((1)),
 CONSTRAINT [PK_PhongChieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 10/8/2018 6:42:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenTheLoai] [nvarchar](50) NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ve]    Script Date: 10/8/2018 6:42:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ve](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LichChieuID] [bigint] NULL,
	[SoGhe] [varchar](50) NULL,
	[NgayMua] [date] NULL CONSTRAINT [DF_Ve_NgayMua]  DEFAULT (getdate()),
 CONSTRAINT [PK_Ve] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Account] ([Username], [Password]) VALUES (N'admin', N'123456')
SET IDENTITY_INSERT [dbo].[LichChieu] ON 

INSERT [dbo].[LichChieu] ([ID], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayChieu], [GiaVe], [PhongChieuID], [PhimID]) VALUES (2, CAST(N'09:35:00' AS Time), CAST(N'10:50:00' AS Time), CAST(N'2018-09-18' AS Date), CAST(60000 AS Decimal(18, 0)), 1, 1)
INSERT [dbo].[LichChieu] ([ID], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayChieu], [GiaVe], [PhongChieuID], [PhimID]) VALUES (3, CAST(N'08:15:00' AS Time), CAST(N'08:40:00' AS Time), CAST(N'2018-10-18' AS Date), CAST(60000 AS Decimal(18, 0)), 1, 4)
SET IDENTITY_INSERT [dbo].[LichChieu] OFF
SET IDENTITY_INSERT [dbo].[Phim] ON 

INSERT [dbo].[Phim] ([ID], [TenPhim], [ThoiLuong], [MoTa], [KhoiChieu], [TheLoaiID]) VALUES (1, N'Cá mập siêu khủng khiếp', 121, N'cá mập', CAST(N'2018-09-02' AS Date), 3)
INSERT [dbo].[Phim] ([ID], [TenPhim], [ThoiLuong], [MoTa], [KhoiChieu], [TheLoaiID]) VALUES (4, N'One piece', 24, N'bbq', CAST(N'2018-10-08' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Phim] OFF
SET IDENTITY_INSERT [dbo].[PhongChieu] ON 

INSERT [dbo].[PhongChieu] ([ID], [TenPhongChieu], [ViTri], [TongSoGhe]) VALUES (1, N'Phòng chiếu 1', N'Trái', 120)
SET IDENTITY_INSERT [dbo].[PhongChieu] OFF
SET IDENTITY_INSERT [dbo].[TheLoai] ON 

INSERT [dbo].[TheLoai] ([ID], [TenTheLoai], [GhiChu]) VALUES (1, N'Hành động', NULL)
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai], [GhiChu]) VALUES (2, N'Lãng mạn', N'')
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai], [GhiChu]) VALUES (3, N'Kinh dị', N'abck')
SET IDENTITY_INSERT [dbo].[TheLoai] OFF
SET IDENTITY_INSERT [dbo].[Ve] ON 

INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (2, 2, N'A3', CAST(N'2018-09-18' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (4, 2, N'A4', CAST(N'2018-09-19' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (6, 2, N'A5', CAST(N'2018-09-19' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (8, 2, N'A6', CAST(N'2018-09-19' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (9, 2, N'A7', CAST(N'2018-09-19' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (10, 2, N'A8', CAST(N'2018-09-19' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (11, 2, N'A9', CAST(N'2018-09-19' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (12, 2, N'A10', CAST(N'2018-09-19' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (13, 2, N'A11', CAST(N'2018-09-19' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (14, 2, N'A12', CAST(N'2018-09-19' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (16, 2, N'A2', CAST(N'2018-09-25' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (17, 2, N'A1', CAST(N'2018-09-25' AS Date))
INSERT [dbo].[Ve] ([ID], [LichChieuID], [SoGhe], [NgayMua]) VALUES (18, 2, N'A13', CAST(N'2018-09-27' AS Date))
SET IDENTITY_INSERT [dbo].[Ve] OFF
ALTER TABLE [dbo].[LichChieu]  WITH CHECK ADD  CONSTRAINT [FK_LichChieu_Phim] FOREIGN KEY([PhimID])
REFERENCES [dbo].[Phim] ([ID])
GO
ALTER TABLE [dbo].[LichChieu] CHECK CONSTRAINT [FK_LichChieu_Phim]
GO
ALTER TABLE [dbo].[LichChieu]  WITH CHECK ADD  CONSTRAINT [FK_LichChieu_PhongChieu] FOREIGN KEY([PhongChieuID])
REFERENCES [dbo].[PhongChieu] ([ID])
GO
ALTER TABLE [dbo].[LichChieu] CHECK CONSTRAINT [FK_LichChieu_PhongChieu]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_TheLoai] FOREIGN KEY([TheLoaiID])
REFERENCES [dbo].[TheLoai] ([ID])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_TheLoai]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_LichChieu] FOREIGN KEY([LichChieuID])
REFERENCES [dbo].[LichChieu] ([ID])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_LichChieu]
GO
USE [master]
GO
ALTER DATABASE [VeXemPhim] SET  READ_WRITE 
GO
