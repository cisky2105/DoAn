USE [master]
GO
/****** Object:  Database [QL_CuaHangDTDD]    Script Date: 6/19/2019 2:49:19 AM ******/
CREATE DATABASE [QL_CuaHangDTDD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_CuaHangDTDD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_CuaHangDTDD.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_CuaHangDTDD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_CuaHangDTDD_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_CuaHangDTDD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_CuaHangDTDD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_CuaHangDTDD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET  MULTI_USER 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_CuaHangDTDD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_CuaHangDTDD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_CuaHangDTDD]
GO
/****** Object:  Table [dbo].[ChiTietHDNhap]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHDNhap](
	[MaHDNhap] [nvarchar](20) NOT NULL,
	[MaSP] [nvarchar](20) NOT NULL,
	[MaNV] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_HDNhapHang_1] PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHDXuat]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHDXuat](
	[MaHDXuat] [nvarchar](20) NOT NULL,
	[MaSP] [nvarchar](20) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[GiaKM] [int] NULL,
 CONSTRAINT [PK_ChiTietHDXuat] PRIMARY KEY CLUSTERED 
(
	[MaHDXuat] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HinhAnh]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhAnh](
	[MaHA] [nvarchar](20) NOT NULL,
	[MaSP] [nvarchar](20) NULL,
	[DuongDan] [nvarchar](250) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_HinhAnh] PRIMARY KEY CLUSTERED 
(
	[MaHA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[MaHDNhap] [nvarchar](20) NOT NULL,
	[MaNCC] [nvarchar](20) NULL,
	[CMNDNV] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[TongTien] [int] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_HoaDonNhap_1] PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonXuat]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonXuat](
	[MaHDXuat] [nvarchar](20) NOT NULL,
	[SDTKH] [varchar](11) NULL,
	[CMNDNV] [int] NULL,
	[NgayXuat] [datetime] NULL,
	[TongTien] [int] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_HoaDonXuat] PRIMARY KEY CLUSTERED 
(
	[MaHDXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[SDTKH] [varchar](11) NOT NULL,
	[TenKH] [nvarchar](70) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[SDTKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoaiDT] [nvarchar](20) NOT NULL,
	[TenLoaiDT] [nvarchar](20) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_LoaiDT] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](20) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[SDT] [varchar](11) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[CMNDNV] [int] NOT NULL,
	[HoVaTen] [nvarchar](70) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[SDT] [varchar](11) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [nvarchar](20) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[CMNDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[MaNSX] [nvarchar](20) NOT NULL,
	[TenNSX] [nvarchar](50) NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[MaQuyen] [nvarchar](20) NOT NULL,
	[TenQuyen] [nvarchar](20) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/19/2019 2:49:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](20) NOT NULL,
	[MaNSX] [nvarchar](20) NULL,
	[MaLoaiDT] [nvarchar](20) NULL,
	[TenSP] [nvarchar](50) NULL,
	[GiaBan] [int] NULL,
	[GiaKM] [int] NULL,
	[SLTonKho] [int] NULL,
	[HinhAnh] [nvarchar](250) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[KhachHang] ([SDTKH], [TenKH], [DiaChi], [Email], [GioiTinh], [TrangThai]) VALUES (N'09629776321', N'Trần Nguyễn Hoài Nam', N'TPHCM', N'nam@gmail.com', 1, 1)
INSERT [dbo].[LoaiSP] ([MaLoaiDT], [TenLoaiDT], [TrangThai]) VALUES (N'1', N'Điện Thoại Android', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiDT], [TenLoaiDT], [TrangThai]) VALUES (N'2', N'Điện Thoại IOS', 1)
INSERT [dbo].[LoaiSP] ([MaLoaiDT], [TenLoaiDT], [TrangThai]) VALUES (N'3', N'Điện Thoại Khác', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi], [Email], [TrangThai]) VALUES (N'1', N'Mai Trung', N'0283548596', N'TPHCM', N'maitraug@gmail.com', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi], [Email], [TrangThai]) VALUES (N'2', N'Thế Giới Di Động', N'0286666666', N'TPHCM', N'thegioididong@gmail.com', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi], [Email], [TrangThai]) VALUES (N'3', N'Thế Hiển', N'0286666644', N'TPHCM', N'TheHien@gmail.com', 1)
INSERT [dbo].[NhanVien] ([CMNDNV], [HoVaTen], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [MatKhau], [Quyen], [TrangThai]) VALUES (291145264, N'Lữ Hoàng Khang', CAST(N'1998-05-21 00:00:00.000' AS DateTime), 1, N'09629776321', N'TPHCM', N'123456', N'1', 1)
INSERT [dbo].[NhanVien] ([CMNDNV], [HoVaTen], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [MatKhau], [Quyen], [TrangThai]) VALUES (291145346, N'Trần Nguyễn Hoài Nam', CAST(N'1998-02-23 00:00:00.000' AS DateTime), 1, N'09629776321', N'TPHCM', N'123456', N'1', 1)
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [TrangThai]) VALUES (N'1', N'SAMSUNG', 1)
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [TrangThai]) VALUES (N'2', N'IPHONE', 1)
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [TrangThai]) VALUES (N'3', N'SONY', 1)
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [TrangThai]) VALUES (N'4', N'OPPO', 1)
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [TrangThai]) VALUES (N'5', N'ASUS', 1)
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [TrangThai]) VALUES (N'6', N'NOKIA', 1)
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [TrangThai]) VALUES (N'7', N'XIAOMI', 1)
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [TrangThai]) VALUES (N'8', N'VIVO', 1)
INSERT [dbo].[NhaSanXuat] ([MaNSX], [TenNSX], [TrangThai]) VALUES (N'9', N'ONEPLUS', 1)
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen], [TrangThai]) VALUES (N'1', N'Admin', 1)
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen], [TrangThai]) VALUES (N'2', N'Quản Lý', 1)
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen], [TrangThai]) VALUES (N'3', N'Nhân Viên', 1)
INSERT [dbo].[SanPham] ([MaSP], [MaNSX], [MaLoaiDT], [TenSP], [GiaBan], [GiaKM], [SLTonKho], [HinhAnh], [TrangThai]) VALUES (N'SP00001', N'1', N'1', N'SamSung Galaxy S10', 20000000, 1000000, 50, NULL, 1)
INSERT [dbo].[SanPham] ([MaSP], [MaNSX], [MaLoaiDT], [TenSP], [GiaBan], [GiaKM], [SLTonKho], [HinhAnh], [TrangThai]) VALUES (N'SP00002', N'2', N'2', N'Iphone XS MAX', 30000000, 2000000, 50, NULL, 1)
INSERT [dbo].[SanPham] ([MaSP], [MaNSX], [MaLoaiDT], [TenSP], [GiaBan], [GiaKM], [SLTonKho], [HinhAnh], [TrangThai]) VALUES (N'SP00003', N'7', N'1', N'Xiaomi Mi 9', 10000000, 1000000, 50, NULL, 1)
INSERT [dbo].[SanPham] ([MaSP], [MaNSX], [MaLoaiDT], [TenSP], [GiaBan], [GiaKM], [SLTonKho], [HinhAnh], [TrangThai]) VALUES (N'SP00004', N'4', N'1', N'Oppo A5s', 3990000, 0, 0, N'abc', 1)
INSERT [dbo].[SanPham] ([MaSP], [MaNSX], [MaLoaiDT], [TenSP], [GiaBan], [GiaKM], [SLTonKho], [HinhAnh], [TrangThai]) VALUES (N'SP00005', N'1', N'1', N'Samsung Galaxy A50', 7990000, 0, 0, N'abc', 1)
ALTER TABLE [dbo].[ChiTietHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDNhap_HoaDonNhap] FOREIGN KEY([MaHDNhap])
REFERENCES [dbo].[HoaDonNhap] ([MaHDNhap])
GO
ALTER TABLE [dbo].[ChiTietHDNhap] CHECK CONSTRAINT [FK_ChiTietHDNhap_HoaDonNhap]
GO
ALTER TABLE [dbo].[ChiTietHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDNhap_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHDNhap] CHECK CONSTRAINT [FK_ChiTietHDNhap_SanPham]
GO
ALTER TABLE [dbo].[ChiTietHDXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDXuat_HoaDonXuat] FOREIGN KEY([MaHDXuat])
REFERENCES [dbo].[HoaDonXuat] ([MaHDXuat])
GO
ALTER TABLE [dbo].[ChiTietHDXuat] CHECK CONSTRAINT [FK_ChiTietHDXuat_HoaDonXuat]
GO
ALTER TABLE [dbo].[ChiTietHDXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDXuat_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHDXuat] CHECK CONSTRAINT [FK_ChiTietHDXuat_SanPham]
GO
ALTER TABLE [dbo].[HinhAnh]  WITH CHECK ADD  CONSTRAINT [FK_HinhAnh_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HinhAnh] CHECK CONSTRAINT [FK_HinhAnh_SanPham]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhanVien] FOREIGN KEY([CMNDNV])
REFERENCES [dbo].[NhanVien] ([CMNDNV])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonXuat_KhachHang] FOREIGN KEY([SDTKH])
REFERENCES [dbo].[KhachHang] ([SDTKH])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [FK_HoaDonXuat_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonXuat_NhanVien] FOREIGN KEY([CMNDNV])
REFERENCES [dbo].[NhanVien] ([CMNDNV])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [FK_HoaDonXuat_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Quyen] FOREIGN KEY([Quyen])
REFERENCES [dbo].[Quyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Quyen]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSP] FOREIGN KEY([MaLoaiDT])
REFERENCES [dbo].[LoaiSP] ([MaLoaiDT])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSP]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaSanXuat] FOREIGN KEY([MaNSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNSX])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaSanXuat]
GO
USE [master]
GO
ALTER DATABASE [QL_CuaHangDTDD] SET  READ_WRITE 
GO
