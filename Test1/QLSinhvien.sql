USE [master]
GO
/****** Object:  Database [QLSinhvien]    Script Date: 8/23/2019 12:50:36 PM ******/
CREATE DATABASE [QLSinhvien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSinhvien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLSinhvien.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSinhvien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLSinhvien_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSinhvien] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSinhvien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSinhvien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSinhvien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSinhvien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSinhvien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSinhvien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSinhvien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSinhvien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSinhvien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSinhvien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSinhvien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSinhvien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSinhvien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSinhvien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSinhvien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSinhvien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSinhvien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSinhvien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSinhvien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSinhvien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSinhvien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSinhvien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSinhvien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSinhvien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLSinhvien] SET  MULTI_USER 
GO
ALTER DATABASE [QLSinhvien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSinhvien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSinhvien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSinhvien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLSinhvien] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLSinhvien]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 8/23/2019 12:50:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [char](3) NOT NULL,
	[TenLop] [nvarchar](30) NOT NULL,
	[Siso] [int] NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 8/23/2019 12:50:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [char](6) NOT NULL,
	[HotenSV] [nvarchar](40) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[HocBong] [decimal](9, 2) NULL,
	[MaLop] [char](3) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [Siso]) VALUES (N'1  ', N'12DTHB5', 50)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [Siso]) VALUES (N'2  ', N'15DTHC4', 50)
INSERT [dbo].[SinhVien] ([MaSV], [HotenSV], [NgaySinh], [GioiTinh], [HocBong], [MaLop]) VALUES (N'SV0001', N'Võ Văn Linh', CAST(N'1999-05-31 00:00:00.000' AS DateTime), 1, CAST(500000.00 AS Decimal(9, 2)), N'1  ')
INSERT [dbo].[SinhVien] ([MaSV], [HotenSV], [NgaySinh], [GioiTinh], [HocBong], [MaLop]) VALUES (N'SV0002', N'Nguyễn Văn Tự', CAST(N'1998-12-25 00:00:00.000' AS DateTime), 1, CAST(0.00 AS Decimal(9, 2)), N'1  ')
INSERT [dbo].[SinhVien] ([MaSV], [HotenSV], [NgaySinh], [GioiTinh], [HocBong], [MaLop]) VALUES (N'SV0003', N'Nguyễn Xuân Thanh', CAST(N'1999-05-12 00:00:00.000' AS DateTime), 1, CAST(0.00 AS Decimal(9, 2)), N'2  ')
INSERT [dbo].[SinhVien] ([MaSV], [HotenSV], [NgaySinh], [GioiTinh], [HocBong], [MaLop]) VALUES (N'SV0004', N'Hồng Thị Thắm', CAST(N'1999-02-02 00:00:00.000' AS DateTime), 0, CAST(500000.00 AS Decimal(9, 2)), N'2  ')
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
USE [master]
GO
ALTER DATABASE [QLSinhvien] SET  READ_WRITE 
GO
