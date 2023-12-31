USE [ThucAnNhanh]
GO
/****** Object:  Table [dbo].[BanAn]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[ID] [int] NOT NULL,
	[ViTri] [nvarchar](max) NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_BanAn] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangGia]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangGia](
	[ID_MonAn] [int] NOT NULL,
	[NgayAD] [date] NOT NULL,
	[GiaBan] [bigint] NULL,
	[GiaKhuyenMai] [bigint] NULL,
 CONSTRAINT [PK_BangGia] PRIMARY KEY CLUSTERED 
(
	[ID_MonAn] ASC,
	[NgayAD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Banner]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banner](
	[ID] [int] NOT NULL,
	[Description] [varchar](max) NULL,
 CONSTRAINT [PK_Banner] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ID_HoaDon] [int] NOT NULL,
	[ID_MonAn] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [bigint] NULL,
	[ThanhTien] [bigint] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[ID_HoaDon] ASC,
	[ID_MonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietOrder]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietOrder](
	[ID_Order] [int] NOT NULL,
	[ID_MonAn] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [bigint] NULL,
	[ThanhTien] [bigint] NULL,
	[TinhTrang] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietOrder] PRIMARY KEY CLUSTERED 
(
	[ID_Order] ASC,
	[ID_MonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[ID_PhieuNhap] [int] NOT NULL,
	[ID_NguyenLieu] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [bigint] NULL,
	[ThanhTien] [bigint] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ID_PhieuNhap] ASC,
	[ID_NguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DM_ManHinh]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_ManHinh](
	[ID] [int] NOT NULL,
	[TenManHinh] [nvarchar](max) NULL,
 CONSTRAINT [PK_DM_ManHinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] NOT NULL,
	[NgayLap] [datetime] NULL,
	[TongTien] [bigint] NULL,
	[ID_NhanVien] [char](11) NULL,
	[ID_KhachHang] [int] NULL,
	[ID_BanAn] [int] NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](max) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [varchar](50) NULL,
	[DiemTichLuy] [int] NULL,
	[Email] [nvarchar](max) NULL,
	[MatKhau] [nvarchar](max) NULL,
	[Token] [varchar](max) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMonAn]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMonAn](
	[ID] [int] NOT NULL,
	[TenLoaiMA] [nvarchar](max) NULL,
	[Anh] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiMonAn] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[ID] [int] NOT NULL,
	[TenLoaiNV] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[ID] [int] NOT NULL,
	[TenMA] [nvarchar](max) NULL,
	[Anh] [nvarchar](max) NULL,
	[MoTa] [nvarchar](max) NULL,
	[TinhTrang] [int] NULL,
	[ID_LoaiMA] [int] NULL,
	[GiaBan] [bigint] NULL,
	[GiaKhuyenMai] [bigint] NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNguyenLieu] [nvarchar](max) NULL,
	[DVT] [nvarchar](max) NULL,
	[SoLuongTon] [int] NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[ID] [int] NOT NULL,
	[TenNCC] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [char](11) NOT NULL,
	[TenNV] [nvarchar](max) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [char](10) NULL,
	[CMT] [char](9) NULL,
	[Anh] [nvarchar](max) NULL,
	[NgayVL] [date] NULL,
	[MatKhau] [varchar](50) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomNhanVien]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNhanVien](
	[IDNV] [char](11) NOT NULL,
	[IDLoai] [int] NOT NULL,
 CONSTRAINT [PK_NhomNhanVien] PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC,
	[IDLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_KhachHang] [int] NULL,
	[TongTien] [bigint] NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [char](10) NULL,
	[TinhTrang] [nvarchar](max) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[Email] [varchar](max) NULL,
	[TenKH] [nvarchar](max) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanCong]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCong](
	[IDNV] [char](11) NOT NULL,
	[CaLam] [int] NOT NULL,
	[NgayLam] [date] NOT NULL,
	[DiemDanh] [nvarchar](max) NULL,
 CONSTRAINT [PK_PhanCong] PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC,
	[CaLam] ASC,
	[NgayLam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[IDLoaiNV] [int] NOT NULL,
	[IDManHinh] [int] NOT NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[IDLoaiNV] ASC,
	[IDManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[ID] [int] NOT NULL,
	[NgayNhap] [datetime] NULL,
	[TongTienNhap] [bigint] NULL,
	[ID_NhanVien] [char](11) NULL,
	[ID_NCC] [int] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhPhanMonAn]    Script Date: 1/9/2022 7:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhPhanMonAn](
	[ID_MonAn] [int] NOT NULL,
	[ID_NguyenLieu] [int] NOT NULL,
	[DinhLuong] [int] NULL,
 CONSTRAINT [PK_ThanhPhanMonAn] PRIMARY KEY CLUSTERED 
(
	[ID_MonAn] ASC,
	[ID_NguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (0, N'Tại quầy', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (1, N'Tầng Trệt', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (2, N'Tầng Trệt', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (3, N'Tầng Trệt', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (4, N'Tầng Trệt', 1)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (5, N'Tầng Trệt', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (6, N'Tầng Trệt', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (7, N'Tầng 1', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (8, N'Tầng 1', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (9, N'Tầng 1', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (10, N'Tầng 1', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (11, N'Tầng 1', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (12, N'Tầng 1', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (13, N'Tầng 1', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (14, N'Tầng 1', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (15, N'Tầng 1', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (16, N'Tầng 1', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (17, N'Tầng 2', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (18, N'Tầng 2', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (19, N'Tầng 2', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (20, N'Tầng 2', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (21, N'Tầng 2', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (22, N'Tầng 2', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (23, N'Tầng 2', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (24, N'Tầng 2', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (25, N'Tầng 2', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (26, N'Tầng 2', 0)
INSERT [dbo].[BanAn] ([ID], [ViTri], [TinhTrang]) VALUES (27, N'Tầng 3', 0)
GO
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (1, CAST(N'2021-10-25' AS Date), 42000, 42000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (2, CAST(N'2021-10-25' AS Date), 13200, 132000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (3, CAST(N'2021-10-25' AS Date), 166000, 166000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (4, CAST(N'2021-10-25' AS Date), 75000, 75000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (5, CAST(N'2021-10-25' AS Date), 69000, 69000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (6, CAST(N'2021-10-25' AS Date), 89000, 89000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (7, CAST(N'2021-10-25' AS Date), 9000, 9000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (8, CAST(N'2021-10-25' AS Date), 10000, 10000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (9, CAST(N'2021-10-25' AS Date), 19000, 19000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (10, CAST(N'2021-10-25' AS Date), 19000, 19000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (11, CAST(N'2021-10-25' AS Date), 29000, 29000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (12, CAST(N'2021-10-25' AS Date), 10000, 10000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (13, CAST(N'2021-10-25' AS Date), 34000, 34000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (14, CAST(N'2021-10-25' AS Date), 39000, 39000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (15, CAST(N'2021-10-25' AS Date), 42000, 42000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (16, CAST(N'2021-10-25' AS Date), 159000, 159000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (17, CAST(N'2021-10-25' AS Date), 95000, 95000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (18, CAST(N'2021-10-25' AS Date), 72000, 72000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (19, CAST(N'2021-10-25' AS Date), 72000, 72000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (20, CAST(N'2021-10-25' AS Date), 54000, 54000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (21, CAST(N'2021-10-25' AS Date), 42000, 42000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (22, CAST(N'2021-10-25' AS Date), 45000, 45000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (23, CAST(N'2021-10-25' AS Date), 63000, 63000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (24, CAST(N'2021-10-25' AS Date), 21000, 21000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (25, CAST(N'2021-10-25' AS Date), 19000, 19000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (26, CAST(N'2021-10-25' AS Date), 19000, 19000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (27, CAST(N'2021-10-25' AS Date), 19000, 19000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (28, CAST(N'2021-10-25' AS Date), 19000, 19000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (29, CAST(N'2021-10-25' AS Date), 19000, 19000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (30, CAST(N'2021-10-25' AS Date), 42000, 42000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (31, CAST(N'2021-10-25' AS Date), 42000, 42000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (32, CAST(N'2021-10-25' AS Date), 84000, 84000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (33, CAST(N'2021-10-25' AS Date), 115000, 115000)
INSERT [dbo].[BangGia] ([ID_MonAn], [NgayAD], [GiaBan], [GiaKhuyenMai]) VALUES (33, CAST(N'2022-01-09' AS Date), 115000, 100000)
GO
INSERT [dbo].[Banner] ([ID], [Description]) VALUES (1, N'https://dscnnwjxnwl3f.cloudfront.net/media/banner/w/e/web_chiken.jpg')
INSERT [dbo].[Banner] ([ID], [Description]) VALUES (2, N'https://dscnnwjxnwl3f.cloudfront.net/media/banner/b/a/banner-1920x655-01_1.jpg')
INSERT [dbo].[Banner] ([ID], [Description]) VALUES (3, N'https://dscnnwjxnwl3f.cloudfront.net/media/banner/u/p/upsize-1920x655px-01.jpg')
GO
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (1, 2, 1, 132000, 132000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (1, 3, 3, 166000, 498000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (1, 6, 1, 89000, 89000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (1, 11, 1, 29000, 29000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (1, 12, 1, 10000, 10000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (2, 1, 2, 42000, 84000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (2, 4, 1, 75000, 75000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (2, 5, 1, 69000, 69000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (2, 8, 1, 10000, 10000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (2, 10, 1, 19000, 19000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (3, 3, 1, 166000, 166000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (3, 6, 1, 89000, 89000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (4, 3, 3, 166000, 498000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (5, 1, 1, 42000, 42000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (5, 2, 1, 132000, 132000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (5, 4, 1, 75000, 75000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (5, 5, 1, 69000, 69000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (5, 8, 1, 10000, 10000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (6, 5, 2, 69000, 138000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (7, 5, 1, 69000, 69000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (7, 6, 1, 89000, 89000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (7, 16, 1, 159000, 159000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (8, 1, 1, 42000, 42000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (8, 2, 1, 132000, 132000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (8, 24, 1, 21000, 21000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (8, 27, 3, 19000, 57000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (8, 28, 1, 19000, 19000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (8, 29, 1, 19000, 19000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (9, 1, 1, 42000, 42000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (9, 2, 1, 132000, 132000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (9, 3, 2, 166000, 332000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (9, 7, 1, 9000, 9000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (9, 8, 1, 10000, 10000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (10, 32, 1, 84000, 84000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (11, 5, 1, 69000, 69000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (11, 6, 1, 89000, 89000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (12, 22, 3, 45000, 135000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (12, 23, 2, 63000, 126000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (13, 1, 1, 42000, 42000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (13, 2, 1, 132000, 132000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (13, 3, 1, 166000, 166000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (13, 4, 1, 75000, 75000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (14, 6, 1, 89000, 89000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (14, 11, 1, 29000, 29000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (14, 12, 1, 10000, 10000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (14, 22, 1, 45000, 45000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (14, 24, 1, 21000, 21000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (16, 1, 1, 42000, 42000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (17, 1, 1, 42000, 42000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (17, 2, 1, 132000, 132000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (17, 3, 1, 166000, 166000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (18, 1, 1, 42000, 42000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (18, 2, 1, 132000, 132000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (19, 8, 1, 10000, 10000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (19, 9, 1, 19000, 19000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (19, 10, 1, 19000, 19000)
INSERT [dbo].[ChiTietHoaDon] ([ID_HoaDon], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien]) VALUES (19, 11, 1, 29000, 29000)
GO
INSERT [dbo].[ChiTietOrder] ([ID_Order], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien], [TinhTrang]) VALUES (32, 6, 2, 89000, 178000, N'Chờ xác nhận')
INSERT [dbo].[ChiTietOrder] ([ID_Order], [ID_MonAn], [SoLuong], [GiaBan], [ThanhTien], [TinhTrang]) VALUES (33, 2, 1, 132000, 132000, N'Chờ xác nhận')
GO
INSERT [dbo].[ChiTietPhieuNhap] ([ID_PhieuNhap], [ID_NguyenLieu], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (1, 2, 1000, 10000, 10000000)
INSERT [dbo].[ChiTietPhieuNhap] ([ID_PhieuNhap], [ID_NguyenLieu], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (1, 4, 10, 25000, 250000)
INSERT [dbo].[ChiTietPhieuNhap] ([ID_PhieuNhap], [ID_NguyenLieu], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (2, 1, 100, 10000, 1000000)
INSERT [dbo].[ChiTietPhieuNhap] ([ID_PhieuNhap], [ID_NguyenLieu], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (2, 3, 100, 15000, 1500000)
INSERT [dbo].[ChiTietPhieuNhap] ([ID_PhieuNhap], [ID_NguyenLieu], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (3, 4, 20, 20000, 400000)
INSERT [dbo].[ChiTietPhieuNhap] ([ID_PhieuNhap], [ID_NguyenLieu], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (4, 3, 100, 10000, 1000000)
INSERT [dbo].[ChiTietPhieuNhap] ([ID_PhieuNhap], [ID_NguyenLieu], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (4, 7, 50, 20000, 1000000)
GO
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (1, N'Màn hình chính')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (2, N'Nhân  viên')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (3, N'Danh sách nhân viên')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (4, N'Xếp lịch')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (6, N'Khách hàng')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (7, N'Nhập xuất')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (8, N'Nghiệp vụ nhập hàng')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (9, N'Thực đơn')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (10, N'Danh sách món ăn')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (11, N'Bảng giá')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (12, N'Danh sách nguyên liệu')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (13, N'Định lượng')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (14, N'Khuyến mãi')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (15, N'Danh sách khuyến mãi')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (16, N'Lịch sử đổi')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (17, N'Thống kê')
INSERT [dbo].[DM_ManHinh] ([ID], [TenManHinh]) VALUES (18, N'Đăng xuất')
GO
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (1, CAST(N'2022-01-02T23:52:41.383' AS DateTime), 758000, N'QL025872539', 1, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (2, CAST(N'2022-01-02T23:53:44.763' AS DateTime), 257000, N'QL025872539', 1, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (3, CAST(N'2022-01-02T23:55:07.070' AS DateTime), 255000, N'QL025872539', 1, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (4, CAST(N'2022-01-02T23:55:36.403' AS DateTime), 498000, N'QL025872539', 1, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (5, CAST(N'2021-12-03T00:09:42.957' AS DateTime), 328000, N'QL025872539', 1, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (6, CAST(N'2022-01-03T11:42:05.353' AS DateTime), 138000, N'QL025872539', 0, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (7, CAST(N'2022-01-03T11:54:02.030' AS DateTime), 317000, N'QL025872539', 4, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (8, CAST(N'2022-01-03T13:15:21.000' AS DateTime), 290000, N'OD123544678', 0, 8, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (9, CAST(N'2022-01-04T20:13:22.000' AS DateTime), 525000, N'OD123544678', 1, 12, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (10, CAST(N'2022-01-04T20:20:40.183' AS DateTime), 84000, N'QL025872539', 0, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (11, CAST(N'2022-01-04T20:22:15.000' AS DateTime), 158000, N'OD123544678', 1, 6, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (12, CAST(N'2022-01-04T20:24:19.380' AS DateTime), 261000, N'QL025872539', 4, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (13, CAST(N'2022-01-04T20:25:17.150' AS DateTime), 415000, N'QL025872539', 1, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (14, CAST(N'2022-01-04T20:41:36.000' AS DateTime), 194000, N'OD123544678', 1, 7, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (15, CAST(N'2022-01-05T22:55:00.797' AS DateTime), 100000, N'QL025872539', 1, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (16, CAST(N'2022-01-06T06:51:32.383' AS DateTime), 42000, N'QL025872539', 1, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (17, CAST(N'2022-01-07T20:13:59.000' AS DateTime), 340000, N'OD123544678', 1, 8, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (18, CAST(N'2022-01-07T20:24:45.883' AS DateTime), 174000, N'QL025872539', 1, 0, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([ID], [NgayLap], [TongTien], [ID_NhanVien], [ID_KhachHang], [ID_BanAn], [TinhTrang]) VALUES (19, CAST(N'2022-01-07T20:26:21.000' AS DateTime), 77000, N'OD123544678', 1, 9, N'Đã thanh toán')
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ID], [TenKH], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemTichLuy], [Email], [MatKhau], [Token]) VALUES (0, N'Khách vãng lai', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([ID], [TenKH], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemTichLuy], [Email], [MatKhau], [Token]) VALUES (1, N'Trần Huyền Trang', N'Nữ', CAST(N'2000-01-02' AS Date), N'Bến Lức, Long An', N'0334125572', 15000, N'trang@gmail.com', N'0334125572', NULL)
INSERT [dbo].[KhachHang] ([ID], [TenKH], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemTichLuy], [Email], [MatKhau], [Token]) VALUES (2, N'Nguyễn Thị Kim Oanh', N'Nữ', CAST(N'2000-07-22' AS Date), N'Ấp An Hòa, xã An Thạnh, huyện Mỏ Cày Nam, tỉnh Bến Tre', N'0334125571', NULL, N'oanh@gmail.com', N'0334125572', NULL)
INSERT [dbo].[KhachHang] ([ID], [TenKH], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemTichLuy], [Email], [MatKhau], [Token]) VALUES (3, N'Trần Lưu Định', N'Nam', CAST(N'1998-01-29' AS Date), N'Mỹ Tho, Tiền Giang', N'0228976679', NULL, N'dinh@gmail.com', N'0228976679', NULL)
INSERT [dbo].[KhachHang] ([ID], [TenKH], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemTichLuy], [Email], [MatKhau], [Token]) VALUES (4, N'Trần Ngọc Đạt', N'Nam', CAST(N'2021-12-10' AS Date), N'Tân Bình', N'0786321015', 20, N'attran123456@gmail.com', N'f5bb0c8de146c67b44babbf4e6584cc0', N'a87ff679a2f3e71d9181a67b7542122c000000:00:00.0000086')
INSERT [dbo].[KhachHang] ([ID], [TenKH], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemTichLuy], [Email], [MatKhau], [Token]) VALUES (9, N'Hoàng Thùy Dương', N'Nữ', CAST(N'2021-12-23' AS Date), N'Tân Bình', N'0774145001', 20, N'duongthuy@gmail.com', N'f5bb0c8de146c67b44babbf4e6584cc0', NULL)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
INSERT [dbo].[LoaiMonAn] ([ID], [TenLoaiMA], [Anh]) VALUES (1, N'GÀ GIÒN', N'https://popeyes.vn/media/catalog/category/menu_SPICY_alacarte_1.png')
INSERT [dbo].[LoaiMonAn] ([ID], [TenLoaiMA], [Anh]) VALUES (2, N'BURGER', N'https://popeyes.vn/media/catalog/category/menu_BURGER_fish.png')
INSERT [dbo].[LoaiMonAn] ([ID], [TenLoaiMA], [Anh]) VALUES (3, N'COMBO', N'https://popeyes.vn/media/catalog/category/m4.png')
INSERT [dbo].[LoaiMonAn] ([ID], [TenLoaiMA], [Anh]) VALUES (4, N'MÓN ĂN KÈM', N'https://popeyes.vn/media/catalog/category/menu_SIDE_cajunfries-L.png')
GO
INSERT [dbo].[LoaiNhanVien] ([ID], [TenLoaiNV]) VALUES (1, N'Quản Lý')
INSERT [dbo].[LoaiNhanVien] ([ID], [TenLoaiNV]) VALUES (2, N'Thu Ngân')
INSERT [dbo].[LoaiNhanVien] ([ID], [TenLoaiNV]) VALUES (3, N'Order')
INSERT [dbo].[LoaiNhanVien] ([ID], [TenLoaiNV]) VALUES (4, N'Chế Biến')
INSERT [dbo].[LoaiNhanVien] ([ID], [TenLoaiNV]) VALUES (5, N'Giao Hàng')
GO
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (1, N'1 miếng Gà Sốt Kem Tiêu', N'https://popeyes.vn/media/catalog/product/cache/1/thumbnail/285x225/9df78eab33525d08d6e5fb8d27136e95/g/k/gkt-1pc.jpg', N'1 miếng gà', 0, 1, 42000, 42000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (2, N'Combo Gà Sốt Kem Tiêu - 1 người', N'https://popeyes.vn/media/catalog/product/cache/1/thumbnail/285x225/9df78eab33525d08d6e5fb8d27136e95/g/k/gkt-cb94.jpg', N'2 miếng gà sốt kem tiêu, 1 khoai tây chiên (vừa), 1 coca 390ml', 0, 3, 132000, 132000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (3, N'Combo Gà Sốt Kem Tiêu - 2 người', N'https://popeyes.vn/media/catalog/product/cache/1/thumbnail/285x225/9df78eab33525d08d6e5fb8d27136e95/g/k/gkt-139.jpg', N'2 miếng gà sốt kem tiêu, 1 khoai tây chiên nghiền (vừa), 1 donut tôm, 4 snack cá / 3 snackmực', 0, 3, 166000, 166000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (4, N'5 miếng Gà Giòn Không Xương', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/m/e/menu_tenders_5pc.png', N'5 miếng gà không xương + 1 chén sốt blackened/ spicy mayo', 0, 1, 75000, 75000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (5, N'Combo Gà Giòn Không Xương 3 miếng ', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/g/a/gakoxuong_cb65.jpg', N'3 miếng gà giòn không xương + 1 phần bắp cải trộn (vừa) + 1 sốt chấm tự chọn blackened ranch/ spicy mayo + 1 coca', 0, 3, 69000, 69000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (6, N'Combo Gà Giòn Không Xương 5 miếng', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/g/a/gakoxuong_cb89.jpg', N'5 miếng gà giòn không xương + 1 phần bắp cải trộn (vừa) + 1 sốt chấm tự chọn blackened ranch/ spicy mayo + 1 coca', 0, 3, 89000, 89000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (7, N'Bánh nướng mật ong', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/b/i/biscuit-wdish.jpg', N'Một bữa ăn Popeyes "đúng chuẩn" không thể thiếu những chiếc bánh nướng mật ong bơ thơm lừng!', 0, 4, 9000, 9000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (8, N'Cơm trắng', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/r/i/rice.png', N'Mềm dẻo đặc biệt, lựa chọn hoàn hảo để bạn tận hưởng một bữa ăn Popeyes tuyệt vời.', 0, 4, 10000, 10000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (9, N'Bắp Cải Trộn', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/b/a/bap_cai_tron.png', N'Bắp cải trộn giòn, cùng lớp sốt đậm đà là sự kết hợp hoàn hỏa cho món gà rán.', 0, 4, 19000, 19000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (10, N'Khoai Tây Nghiền', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/k/h/khoai_tay_nghien.png', N'Khoai tây nghiền mịn như kem được phủ nước sốt Gravy đậm đà.', 0, 4, 19000, 19000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (11, N'Khoai Tây Chiên', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/k/h/khoai_tay_chien.png', N'Khoai tây chiên mang 100% hương vị Cajun với hỗn hợp gia vị đặc biệt từ Louisiana', 0, 4, 29000, 29000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (12, N'Canh Súp', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/s/o/soup.png', N'1 canh súp', 0, 4, 10000, 10000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (13, N'4 miếng Snack Cá', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/s/n/snack-ca.png', N'4 miếng snack cá', 0, 4, 34000, 34000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (14, N'4 miếng Snack Mực', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/s/n/snack-muc.png', N'4 miếng Snack Mực', 0, 4, 39000, 39000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (15, N'1 miếng Gà Tắm Nước Mắm', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/m/e/menu_spicy_redboat1pc.png', N'1 miếng Gà Tắm Nước Mắm', 0, 4, 42000, 42000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (16, N'Combo Gà Tắm Nước Mắm - 2 người', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/m/e/menu_spicy_redboat139.png', N'2 miếng Gà Tắm Nước Mắm Tỏi Ớt , 2 miếng Gà Giòn Không Xương, 1 Bơ-gơ Tôm, 1 Bắp Cải Trộn, 2 Nước ngọt', 0, 3, 159000, 159000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (17, N'Combo Gà Tắm Nước Mắm', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/v/i/viber_image_2020-10-30_23-54-34.jpg', N'2 miếng Gà Tắm Nước Mắm + 1 Món ăn kèm (vừa) + 1 Nước ngọt', 0, 3, 95000, 95000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (18, N'Combo Burger Gà', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/m/e/menu_burger_combo7.png', N'1 burger gà Cajun/Creole + 1 phần khoai tây chiên (vừa) + 1 coca', 0, 2, 72000, 72000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (19, N'Combo Burger Cá Cajun', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/m/e/menu_burger_combo8_1_1.png', N'1 burger cá + 1 phần khoai tây chiên (vừa) + 1 coca', 0, 2, 72000, 72000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (20, N'Burger Gà', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/g/a/ga_1.png', N'1 burger Gà', 0, 2, 54000, 54000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (21, N'Burger Tôm', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/t/o/tom.png', N'1 bơ gơ tôm + 1 phần khoai tây chiên (vừa) + 1 coca', 0, 2, 42000, 42000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (22, N'Burger Cá Cajun', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/m/e/menu_burger_fish_1.png', N'1 burger cá', 0, 2, 45000, 45000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (23, N'Combo Burger Tôm', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/m/e/menu_burger_combo9_1.png', N'1 bơ gơ tôm + 1 phần khoai tây chiên (vừa) + 1 coca', 0, 2, 63000, 63000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (24, N'Banh Tart Phô Mai', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/m/e/menu_dessert_cheesetart.png', N'1 bánh Tart Phô Mai', 0, 4, 21000, 21000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (25, N'Coca', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/c/o/coca.png', N'Uống thả ga khi dùng tại nhà hàng', 0, 4, 19000, 19000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (26, N'Fanta', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/f/a/fanta.png', N'Uống thả ga khi dùng tại nhà hàng', 0, 4, 19000, 19000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (27, N'Spire', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/s/p/sprite.png', N'Uống thả ga khi dùng tại nhà hàng', 0, 4, 19000, 19000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (28, N'Coca Light', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/c/o/cocalight.png', N'Uống thả ga khi dùng tại nhà hàng', 0, 4, 19000, 19000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (29, N'Dasani', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/d/a/dasani.png', N'Uống thả ga khi dùng tại nhà hàng', 0, 4, 19000, 19000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (30, N'1 miếng Gà Giòn Không Cay', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/_/b/_b5717c683a6c624f5508771da8fc3a2ff56c0d051ba051af62_pimgpsh_fullsize_distr.png', N'Gà giòn Cajun tươi mới được ướp với công thức gia vị Louisiana (cay hoặc không cay), tẩm bột thủ công và rán chín cùng lớp phủ giòn tan đặc trưng của miền Nam nước Mỹ.', 0, 1, 42000, 42000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (31, N'1 miếng Gà Giòn Cay', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/_/8/_8ccdd1a622a3b94e72bf0fa457756b71ba0fbe8c38d48fe976_pimgpsh_fullsize_distr.png', N'Gà giòn Cajun tươi mới được ướp với công thức gia vị Louisiana (cay hoặc không cay), tẩm bột thủ công và rán chín cùng lớp phủ giòn tan đặc trưng của miền Nam nước Mỹ.', 0, 1, 42000, 42000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (32, N'Combo Gà Giòn Cay 2 miếng', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/g/a/gacay_combo2mieng.jpg', N'2 miếng gà giòn cay + 1 khoai tây chiên (vừa) + 1 Coca', 0, 3, 84000, 84000)
INSERT [dbo].[MonAn] ([ID], [TenMA], [Anh], [MoTa], [TinhTrang], [ID_LoaiMA], [GiaBan], [GiaKhuyenMai]) VALUES (33, N'Combo Gà Giòn Cay 3 miếng', N'https://popeyes.vn/media/catalog/product/cache/1/small_image/210x/9df78eab33525d08d6e5fb8d27136e95/g/a/gacay_combo3mieng_1.jpg', N'3 miếng gà giòn cay + 1 khoai tây chiên (vừa) + 1 Coca', 0, 3, 115000, 100000)
GO
SET IDENTITY_INSERT [dbo].[NguyenLieu] ON 

INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (1, N'Đùi gà', N'Cái', 6343)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (2, N'Khoai tây', N'g', 139600)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (3, N'Bánh hamburger', N'Cái', 6556)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (4, N'Tương ớt', N'Bình', 6430)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (5, N'Tương cà', N'Bình', 6400)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (6, N'Thịt bò', N'Kg', 6400)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (7, N'Tôm Khoanh', N'Cái', 63748)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (8, N'Cá khoanh', N'Cái', 6332)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (9, N'Cánh gà', N'Cái', 6400)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (10, N'Coca', N'ML', 495360)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (11, N'Spite', N'ML', 615150)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (12, N'Gà không xương', N'Cái', 6298)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (13, N'Donut tôm', N'Cái', 6323)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (14, N'Donut cá', N'Cái', 6400)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (15, N'Snack cá', N'Cái', 6092)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (16, N'Sốt spic mayo', N'Chén', 6378)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (17, N'Bắp cải trộn', N'Chén', 6373)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (18, N'Bánh nướng mật ong', N'Cái', 6394)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (19, N'Cơm', N'Chén', 6388)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (20, N'Khoai tây nghiền', N'Chén', 6396)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (21, N'Canh súp', N'Chén', 6396)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (22, N'Snack cá', N'Cái', 6400)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (23, N'Snack mực', N'Cái', 6400)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (24, N'Gà Khoanh', N'Cái', 6398)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (25, N'Đế bánh tart', N'Cái', 6398)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (26, N'Kem trứng', N'ml', 63600)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (27, N'Fanta', N'ml', 638600)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (28, N'Coca Light', N'ml', 637900)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (29, N'Dasani', N'Chai', 6397)
INSERT [dbo].[NguyenLieu] ([ID], [TenNguyenLieu], [DVT], [SoLuongTon]) VALUES (30, N'Kha', N'Cái', NULL)
SET IDENTITY_INSERT [dbo].[NguyenLieu] OFF
GO
INSERT [dbo].[NhanVien] ([ID], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [CMT], [Anh], [NgayVL], [MatKhau], [TrangThai]) VALUES (N'OD123544678', N'Trần Hoàng Tôn', CAST(N'1997-12-19' AS Date), N'Nam', N'140 lê Trọng Tấn, Tây Thạnh, Tân Phú, TPHCM', N'0886789989', N'123544678', N'https://danviet.mediacdn.vn/upload/3-2019/images/2019-07-23/Sap-U30-van-la-nu-than-YoonA-khong-he-tuan-theo-phuong-phap-cham-soc-da-10-buoc-advbh-1563870078-width1200height1745.jpg', CAST(N'2021-12-19' AS Date), N'h@n12345', 1)
INSERT [dbo].[NhanVien] ([ID], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [CMT], [Anh], [NgayVL], [MatKhau], [TrangThai]) VALUES (N'OD146273925', N'Phạm Ngọc Diễm Quỳnh', CAST(N'1998-04-21' AS Date), N'Nữ', N'A3/55/20 Bình Hưng Hòa X Quận Tân Phú TPHCM', N'0338235472', N'146273925', N'https://media-cdn.laodong.vn/storage/newsportal/2021/10/10/962246/Suzy3-01.jpg?w=960&crop=auto&scale=both', CAST(N'2021-02-21' AS Date), N'han1234@', 1)
INSERT [dbo].[NhanVien] ([ID], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [CMT], [Anh], [NgayVL], [MatKhau], [TrangThai]) VALUES (N'OD213877987', N'Trương Quốc Bảo', CAST(N'1999-01-03' AS Date), N'Nam', N'46B, Lê Trung Nghĩa, Tân Bình, TPHCM', N'0223765561', N'213877987', N'http://t2.gstatic.com/licensed-image?q=tbn:ANd9GcT9Ia-cNVxDsS4FEb-3ttvnPd3QWoXQ5ToMxcfM4ksAzAauieZ85DKrIs-4IceS', CAST(N'2022-01-03' AS Date), N'OD213877987', 1)
INSERT [dbo].[NhanVien] ([ID], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [CMT], [Anh], [NgayVL], [MatKhau], [TrangThai]) VALUES (N'QL023648292', N'Phạm Mộng Kha', CAST(N'2000-06-05' AS Date), N'Nữ', N'Đường số 3, Bình Hưng Hòa A, quận Tân Phú', N'0334643256', N'023648292', N'https://htmediagroup.vn/wp-content/uploads/2021/07/anh-profile-nu-1.jpg', CAST(N'2021-10-10' AS Date), N'Kh@562000', 1)
INSERT [dbo].[NhanVien] ([ID], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [CMT], [Anh], [NgayVL], [MatKhau], [TrangThai]) VALUES (N'QL025872539', N'Chu Nguyễn Gia Hân', CAST(N'2000-05-05' AS Date), N'Nữ', N'F9/6B Tổ 10 Ấp 6 đường Vĩnh Lộc, xã Vĩnh Lộc B, huyện Bình Chánh', N'0938573123', N'025872539', N'https://tiemchupanh.com/wp-content/uploads/2020/06/MG_2459.jpg', CAST(N'2021-09-20' AS Date), N'H@n552000', 1)
INSERT [dbo].[NhanVien] ([ID], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [CMT], [Anh], [NgayVL], [MatKhau], [TrangThai]) VALUES (N'QL312344768', N'Phan Mỹ Hạnh', CAST(N'1999-01-04' AS Date), N'Nữ', N'Thạnh Phú, Bến Tre', N'0334125571', N'312344768', N'https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/Suzy_Bae_at_fansigning_on_February_3%2C_2018_%285%29_%28cropped%29.jpg/640px-Suzy_Bae_at_fansigning_on_February_3%2C_2018_%285%29_%28cropped%29.jpg', CAST(N'2022-01-04' AS Date), N'QL312344768', 1)
INSERT [dbo].[NhanVien] ([ID], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [CMT], [Anh], [NgayVL], [MatKhau], [TrangThai]) VALUES (N'QL328900987', N'Nguyễn Mộng Khanh', CAST(N'1999-12-19' AS Date), N'Nữ', N'8 Âu Cơ, Tân Bình, TPHCM', N'0229891198', N'212988909', N'https://danviet.mediacdn.vn/upload/3-2019/images/2019-07-23/Sap-U30-van-la-nu-than-YoonA-khong-he-tuan-theo-phuong-phap-cham-soc-da-10-buoc-advbh-1563870078-width1200height1745.jpg', CAST(N'2021-12-19' AS Date), N'D@t20122000', 1)
INSERT [dbo].[NhanVien] ([ID], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [CMT], [Anh], [NgayVL], [MatKhau], [TrangThai]) VALUES (N'TN224424632', N'Trương Thanh Phong', CAST(N'1999-03-18' AS Date), N'Nam', N'77 Lê Trung Nghĩa P12 Quận Tân Bình TPHCM', N'0938267133', N'224424632', N'https://media-cdn.laodong.vn/storage/newsportal/2021/10/10/962246/Suzy3-01.jpg?w=960&crop=auto&scale=both', CAST(N'2021-01-01' AS Date), N'Phong@123', 1)
INSERT [dbo].[NhanVien] ([ID], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [CMT], [Anh], [NgayVL], [MatKhau], [TrangThai]) VALUES (N'TN234566789', N'Mai Trọng Nguyên', CAST(N'1998-12-19' AS Date), N'Nam', N'49/21 đường số 3, phường Bình Hưng Hòa A, Bình Tân, TPHCM', N'0112987782', N'234566789', N'https://kenh14cdn.com/thumb_w/660/203336854389633024/2021/12/17/0rz82ejbpt771-1639710366823526414118.jpg', CAST(N'2021-12-19' AS Date), N'TN201121NV001', 1)
INSERT [dbo].[NhanVien] ([ID], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [CMT], [Anh], [NgayVL], [MatKhau], [TrangThai]) VALUES (N'TN322988909', N'Trần Thị Như Nga', CAST(N'2000-11-06' AS Date), N'Nữ', N'Ấp Vĩnh Lộc A, Bình Chánh', N'0334789987', N'322988909', N'https://media-cdn.laodong.vn/storage/newsportal/2021/10/10/962246/Suzy3-01.jpg?w=960&crop=auto&scale=both', CAST(N'2021-11-20' AS Date), N'Ngoc@123', 1)
GO
INSERT [dbo].[NhomNhanVien] ([IDNV], [IDLoai]) VALUES (N'OD123544678', 4)
INSERT [dbo].[NhomNhanVien] ([IDNV], [IDLoai]) VALUES (N'OD146273925', 3)
INSERT [dbo].[NhomNhanVien] ([IDNV], [IDLoai]) VALUES (N'OD213877987', 4)
INSERT [dbo].[NhomNhanVien] ([IDNV], [IDLoai]) VALUES (N'QL023648292', 1)
INSERT [dbo].[NhomNhanVien] ([IDNV], [IDLoai]) VALUES (N'QL025872539', 1)
INSERT [dbo].[NhomNhanVien] ([IDNV], [IDLoai]) VALUES (N'QL312344768', 2)
INSERT [dbo].[NhomNhanVien] ([IDNV], [IDLoai]) VALUES (N'QL328900987', 1)
INSERT [dbo].[NhomNhanVien] ([IDNV], [IDLoai]) VALUES (N'TN224424632', 2)
INSERT [dbo].[NhomNhanVien] ([IDNV], [IDLoai]) VALUES (N'TN234566789', 2)
INSERT [dbo].[NhomNhanVien] ([IDNV], [IDLoai]) VALUES (N'TN322988909', 2)
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([ID], [ID_KhachHang], [TongTien], [DiaChi], [SDT], [TinhTrang], [GhiChu], [Email], [TenKH]) VALUES (32, 0, 178000, N'jjhjhkmkm', N'1111111   ', N'Chờ xác nhận', N'', N'duong1510@gmail.com', N'ggg')
INSERT [dbo].[Order] ([ID], [ID_KhachHang], [TongTien], [DiaChi], [SDT], [TinhTrang], [GhiChu], [Email], [TenKH]) VALUES (33, 0, 132000, N'tân phú', N'0786321015', N'Chờ xác nhận', N'123', N'attran123456@gmail.com', N'Dat')
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD123544678', 1, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD123544678', 1, CAST(N'2021-12-26' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD123544678', 1, CAST(N'2022-01-04' AS Date), N'Đã điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD123544678', 1, CAST(N'2022-01-05' AS Date), N'Vắng')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD123544678', 1, CAST(N'2022-01-06' AS Date), N'Vắng')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD123544678', 2, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD123544678', 2, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD123544678', 3, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD146273925', 1, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD146273925', 1, CAST(N'2021-12-26' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD146273925', 1, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD146273925', 1, CAST(N'2022-01-05' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD146273925', 1, CAST(N'2022-01-06' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD146273925', 2, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD146273925', 2, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD146273925', 3, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD213877987', 1, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD213877987', 1, CAST(N'2022-01-05' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD213877987', 1, CAST(N'2022-01-06' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'OD213877987', 2, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL023648292', 1, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL023648292', 1, CAST(N'2021-12-26' AS Date), N'Đi làm trễ 3:43''')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL023648292', 1, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL023648292', 1, CAST(N'2022-01-05' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL023648292', 1, CAST(N'2022-01-06' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL023648292', 2, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL023648292', 2, CAST(N'2022-01-05' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL023648292', 3, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL023648292', 3, CAST(N'2021-12-26' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL025872539', 1, CAST(N'2022-01-05' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL025872539', 2, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL312344768', 1, CAST(N'2022-01-06' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'QL328900987', 1, CAST(N'2022-01-08' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN224424632', 1, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN224424632', 1, CAST(N'2022-01-05' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN224424632', 1, CAST(N'2022-01-08' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN224424632', 2, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN224424632', 3, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN234566789', 1, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN234566789', 1, CAST(N'2021-12-26' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN234566789', 1, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN234566789', 1, CAST(N'2022-01-05' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN234566789', 2, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN234566789', 2, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN322988909', 1, CAST(N'2021-12-23' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN322988909', 1, CAST(N'2021-12-26' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN322988909', 1, CAST(N'2022-01-05' AS Date), N'Chưa điểm danh')
INSERT [dbo].[PhanCong] ([IDNV], [CaLam], [NgayLam], [DiemDanh]) VALUES (N'TN322988909', 2, CAST(N'2022-01-04' AS Date), N'Chưa điểm danh')
GO
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 1)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 2)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 3)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 4)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 6)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 7)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 8)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 9)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 10)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 11)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 12)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 13)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 14)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 15)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 16)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 17)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (1, 18)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (2, 1)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (2, 7)
INSERT [dbo].[PhanQuyen] ([IDLoaiNV], [IDManHinh]) VALUES (2, 17)
GO
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTienNhap], [ID_NhanVien], [ID_NCC]) VALUES (1, CAST(N'2021-12-28T00:16:08.743' AS DateTime), 10250000, N'QL025872539', NULL)
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTienNhap], [ID_NhanVien], [ID_NCC]) VALUES (2, CAST(N'2022-01-02T21:05:44.100' AS DateTime), 2500000, N'QL025872539', NULL)
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTienNhap], [ID_NhanVien], [ID_NCC]) VALUES (3, CAST(N'2022-01-02T21:06:44.900' AS DateTime), 400000, N'QL025872539', NULL)
INSERT [dbo].[PhieuNhap] ([ID], [NgayNhap], [TongTienNhap], [ID_NhanVien], [ID_NCC]) VALUES (4, CAST(N'2022-01-04T20:31:47.293' AS DateTime), 2000000, N'QL025872539', NULL)
GO
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (1, 1, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (2, 1, 2)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (2, 2, 300)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (2, 10, 390)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (3, 1, 2)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (3, 2, 300)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (3, 13, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (3, 15, 4)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (4, 12, 5)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (4, 16, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (5, 10, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (5, 12, 3)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (5, 16, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (5, 17, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (6, 10, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (6, 12, 5)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (6, 16, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (6, 17, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (7, 18, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (8, 19, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (9, 17, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (10, 20, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (11, 2, 100)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (12, 21, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (13, 22, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (14, 23, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (15, 1, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (16, 1, 2)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (16, 3, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (16, 7, 150)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (16, 10, 700)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (16, 12, 2)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (16, 17, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (17, 1, 2)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (17, 10, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (17, 17, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (18, 2, 100)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (18, 10, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (18, 24, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (19, 2, 100)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (19, 3, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (19, 8, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (19, 10, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (20, 3, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (20, 24, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (21, 2, 100)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (21, 3, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (21, 8, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (21, 10, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (22, 3, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (22, 8, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (23, 2, 100)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (23, 3, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (23, 7, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (23, 10, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (24, 25, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (24, 26, 200)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (25, 10, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (26, 27, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (27, 11, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (28, 28, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (29, 29, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (30, 1, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (31, 1, 1)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (32, 1, 2)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (32, 2, 100)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (32, 10, 350)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (33, 1, 3)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (33, 2, 100)
INSERT [dbo].[ThanhPhanMonAn] ([ID_MonAn], [ID_NguyenLieu], [DinhLuong]) VALUES (33, 10, 350)
GO
ALTER TABLE [dbo].[BangGia]  WITH CHECK ADD  CONSTRAINT [FK_BangGia_MonAn] FOREIGN KEY([ID_MonAn])
REFERENCES [dbo].[MonAn] ([ID])
GO
ALTER TABLE [dbo].[BangGia] CHECK CONSTRAINT [FK_BangGia_MonAn]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_MonAn] FOREIGN KEY([ID_MonAn])
REFERENCES [dbo].[MonAn] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_MonAn]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_ChiTietHoaDon] FOREIGN KEY([ID_HoaDon])
REFERENCES [dbo].[HoaDon] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_HoaDon_ChiTietHoaDon]
GO
ALTER TABLE [dbo].[ChiTietOrder]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietOrder_MonAn] FOREIGN KEY([ID_MonAn])
REFERENCES [dbo].[MonAn] ([ID])
GO
ALTER TABLE [dbo].[ChiTietOrder] CHECK CONSTRAINT [FK_ChiTietOrder_MonAn]
GO
ALTER TABLE [dbo].[ChiTietOrder]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietOrder_Order] FOREIGN KEY([ID_Order])
REFERENCES [dbo].[Order] ([ID])
GO
ALTER TABLE [dbo].[ChiTietOrder] CHECK CONSTRAINT [FK_ChiTietOrder_Order]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_NguyenLieu] FOREIGN KEY([ID_NguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_NguyenLieu]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([ID_PhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_BanAn] FOREIGN KEY([ID_BanAn])
REFERENCES [dbo].[BanAn] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_BanAn]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([ID_KhachHang])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_LoaiMonAn] FOREIGN KEY([ID_LoaiMA])
REFERENCES [dbo].[LoaiMonAn] ([ID])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_LoaiMonAn]
GO
ALTER TABLE [dbo].[NhomNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhomNhanVien_LoaiNhanVien] FOREIGN KEY([IDLoai])
REFERENCES [dbo].[LoaiNhanVien] ([ID])
GO
ALTER TABLE [dbo].[NhomNhanVien] CHECK CONSTRAINT [FK_NhomNhanVien_LoaiNhanVien]
GO
ALTER TABLE [dbo].[NhomNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhomNhanVien_NhanVien] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[NhomNhanVien] CHECK CONSTRAINT [FK_NhomNhanVien_NhanVien]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_KhachHang] FOREIGN KEY([ID_KhachHang])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_KhachHang]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_PhanCong] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_PhanCong]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_DM_ManHinh] FOREIGN KEY([IDManHinh])
REFERENCES [dbo].[DM_ManHinh] ([ID])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_DM_ManHinh]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_LoaiNhanVien] FOREIGN KEY([IDLoaiNV])
REFERENCES [dbo].[LoaiNhanVien] ([ID])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_LoaiNhanVien]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NCC] FOREIGN KEY([ID_NCC])
REFERENCES [dbo].[NhaCungCap] ([ID])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NCC]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[ThanhPhanMonAn]  WITH CHECK ADD  CONSTRAINT [FK_ThanhPhanMonAn_MonAn] FOREIGN KEY([ID_MonAn])
REFERENCES [dbo].[MonAn] ([ID])
GO
ALTER TABLE [dbo].[ThanhPhanMonAn] CHECK CONSTRAINT [FK_ThanhPhanMonAn_MonAn]
GO
ALTER TABLE [dbo].[ThanhPhanMonAn]  WITH CHECK ADD  CONSTRAINT [FK_ThanhPhanMonAn_NguyenLieu] FOREIGN KEY([ID_NguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([ID])
GO
ALTER TABLE [dbo].[ThanhPhanMonAn] CHECK CONSTRAINT [FK_ThanhPhanMonAn_NguyenLieu]
GO
/****** Object:  Trigger [dbo].[deleteGiaBan]    Script Date: 1/9/2022 7:44:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[deleteGiaBan] on [dbo].[BangGia]
for delete
as
update MonAn
SET GiaBan = (select GiaBan from BangGia where ID_MonAn = (select ID from deleted) and NgayAD >= (SELECT MAX(NgayAD) FROM BangGia WHERE ID = ID_MonAn)), GiaKhuyenMai = (select GiaKhuyenMai from BangGia where ID_MonAn = (select ID from deleted) and NgayAD >= (SELECT MAX(NgayAD) FROM BangGia WHERE ID = ID_MonAn))
				where ID = (select ID_MonAn from deleted)
GO
ALTER TABLE [dbo].[BangGia] ENABLE TRIGGER [deleteGiaBan]
GO
/****** Object:  Trigger [dbo].[updateGiaBan]    Script Date: 1/9/2022 7:44:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  trigger [dbo].[updateGiaBan] on [dbo].[BangGia]
for insert, update
as
update MonAn
SET GiaBan = (select GiaBan from BangGia where ID_MonAn = (select ID from inserted) and NgayAD >= (SELECT MAX(NgayAD) FROM BangGia WHERE ID = ID_MonAn)),GiaKhuyenMai = (select GiaKhuyenMai from BangGia where ID_MonAn = (select ID from inserted) and NgayAD >= (SELECT MAX(NgayAD) FROM BangGia WHERE ID = ID_MonAn))
				where ID = (select ID_MonAn from inserted)
GO
ALTER TABLE [dbo].[BangGia] ENABLE TRIGGER [updateGiaBan]
GO
/****** Object:  Trigger [dbo].[updateTongTienHD]    Script Date: 1/9/2022 7:44:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[updateTongTienHD]
on [dbo].[ChiTietHoaDon]
for update, insert
as
update HoaDon
set TongTien=(select sum(ThanhTien) from ChiTietHoaDon where ID_HoaDon=(select ID_HoaDon from inserted))
where ID=(select ID_HoaDon from inserted)
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [updateTongTienHD]
GO
/****** Object:  Trigger [dbo].[updateTongTienHDXoa]    Script Date: 1/9/2022 7:44:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[updateTongTienHDXoa]
on [dbo].[ChiTietHoaDon]
for delete
as
update HoaDon
set TongTien=(select sum(ThanhTien) from ChiTietHoaDon where ID_HoaDon = (select ID_HoaDon from deleted))
where ID=(select ID_HoaDon from deleted)
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [updateTongTienHDXoa]
GO
/****** Object:  Trigger [dbo].[updateSLtonInsert]    Script Date: 1/9/2022 7:44:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[updateSLtonInsert] on [dbo].[ChiTietPhieuNhap] for insert
as
update NguyenLieu
set SoLuongTon = SoLuongTon + (select SoLuong from inserted)
where ID = (select ID_NguyenLieu from inserted)
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ENABLE TRIGGER [updateSLtonInsert]
GO
/****** Object:  Trigger [dbo].[updateTongTienNhapPN]    Script Date: 1/9/2022 7:44:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[updateTongTienNhapPN]
on [dbo].[ChiTietPhieuNhap]
for update, insert
as
update PhieuNhap
set TongTienNhap =(select sum(ThanhTien) from ChiTietPhieuNhap where ID_PhieuNhap=(select ID_PhieuNhap from inserted))
where ID=(select ID_PhieuNhap from inserted)
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ENABLE TRIGGER [updateTongTienNhapPN]
GO
/****** Object:  Trigger [dbo].[updateTongTienNhapPNXoa]    Script Date: 1/9/2022 7:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[updateTongTienNhapPNXoa]
on [dbo].[ChiTietPhieuNhap]
for delete
as
update PhieuNhap
set TongTienNhap=(select sum(ThanhTien) from [ChiTietPhieuNhap] where ID_PhieuNhap = (select ID_PhieuNhap from deleted))
where ID=(select ID_PhieuNhap from deleted)
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ENABLE TRIGGER [updateTongTienNhapPNXoa]
GO
/****** Object:  Trigger [dbo].[insertMonAninsertBangGia]    Script Date: 1/9/2022 7:44:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[insertMonAninsertBangGia] on [dbo].[MonAn]
for insert
as
insert BangGia(ID_MonAn, NgayAD, GiaBan, GiaKhuyenMai)  (select ID, GETDATE(), GiaBan, GiaKhuyenMai from inserted)
GO
ALTER TABLE [dbo].[MonAn] ENABLE TRIGGER [insertMonAninsertBangGia]
GO
