
/****** Object:  Database [Project_QLTT]  ******/
CREATE DATABASE [Project_QLTT]

GO
ALTER DATABASE [Project_QLTT] SET ANSI_NULL_DEFAULT OFF /*no Null*/
GO
ALTER DATABASE [Project_QLTT] SET ANSI_PADDING OFF /*no Padding more space*/ 
GO
ALTER DATABASE [Project_QLTT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_QLTT] SET RECURSIVE_TRIGGERS OFF /*no Recursive */ 
GO
ALTER DATABASE [Project_QLTT] SET RECOVERY FULL 
/*GO
ALTER DATABASE [Project_QLTT] SET DB_CHAINING OFF*/
GO
ALTER DATABASE [Project_QLTT] SET TARGET_RECOVERY_TIME = 0 SECONDS /*Target Recovery Time*/
GO
USE [Project_QLTT]

GO
/****** Object:  TABLE [dbo].[Thuoc]   ******/
SET ANSI_NULLS ON
GO
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Thuoc] (
    [IDThuoc] [INT] PRIMARY KEY IDENTITY(1,1),
    [TenThuoc] [NVARCHAR](50) NOT NULL,
    [DonViTinh] [NVARCHAR](15) NOT NULL,
    [SoLuong] [INT] NOT NULL,
    [GiaBan] [DECIMAL](18,2) NOT NULL
);
GO
SET ANSI_PADDING OFF
GO
--Thong tin thuoc, ngay nhap kho, nha cung cap
/****** Object:  TABLE [dbo].[QuyenDangNhap]   ******/
SET ANSI_NULLS ON
GO
SET ANSI_PADDING ON
CREATE TABLE [dbo].[QuyenDangNhap] (
	[MaQuyen] [INT] PRIMARY KEY,
	[MoTa] [NVARCHAR](10) NULL,
);
GO
SET ANSI_PADDING OFF
GO
/****** Object:  TABLE [dbo].[TaiKhoan]   ******/
SET ANSI_NULLS ON
GO
SET ANSI_PADDING ON
CREATE TABLE [dbo].[TaiKhoan] (
    [IDTaiKhoan] [INT] PRIMARY KEY IDENTITY(1,1),
    [TenTaiKhoan] [NVARCHAR](25) NOT NULL,
    [MatKhau] [NVARCHAR](30) NOT NULL,
    [VaiTro] [INT] FOREIGN KEY REFERENCES [dbo].[QuyenDangNhap]([MaQuyen]),
    [HoTen] [NVARCHAR](30) NOT NULL,
    [SoDienThoai] [NVARCHAR](15) NOT NULL,
    [Email] [NVARCHAR](30) NOT NULL
);
GO
SET ANSI_PADDING OFF
GO
/****** Object:  TABLE [dbo].[HoaDon]   ******/
SET ANSI_NULLS ON
GO
CREATE TABLE [dbo].[HoaDon] (
    [IDHoaDon] [INT] PRIMARY KEY IDENTITY(1,1),
    [IDTaiKhoan] [INT] FOREIGN KEY REFERENCES [dbo].[TaiKhoan]([IDTaiKhoan]),
    [NgayBan] [DATETIME] NOT NULL,
    [TongTien] [DECIMAL](18,2) NOT NULL
	--Ten khach hang
	--SDT
);
GO
/****** Object:  TABLE [dbo].[ChiTietHoaDon]   ******/
SET ANSI_NULLS ON
GO
SET ANSI_PADDING ON
CREATE TABLE [dbo].[ChiTietHoaDon] (
    [IDChiTiet] [INT] PRIMARY KEY IDENTITY(1,1),
    [IDHoaDon] [INT] FOREIGN KEY REFERENCES [dbo].[HoaDon]([IDHoaDon]),
    [IDThuoc] [INT] FOREIGN KEY REFERENCES [dbo].[Thuoc]([IDThuoc]),
    [SoLuong] [INT] NOT NULL,
    [GiaBan] [DECIMAL](18,2) NOT NULL
);
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Paracetamol', N'Viên', 100, 5000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Vitamin C', N'Viên sủi', 50, 10000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Amoxicillin', N'Viên nang', 20, 15000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Panadol', N'Viên', 200, 3000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Aspirin', N'Viên', 150, 2000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Nhỏ mũi Dexpanthenol', N'Chai', 10, 1000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Kem chống nắng SPF 50', N'Tuýp', 50, 350000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Thuốc ho Prospan', N'Chai', 100, 120000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Men vi sinh BioGaia', N'Hộp', 30, 150000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Nước muối sinh lý 0,9%', N'Chai', 100, 5000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Băng gạc y tế', N'Hộp', 15, 20000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Khẩu trang y tế', N'Hộp', 50 , 100000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Dung dịch sát khuẩn', N'Chai', 500, 50000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Thuốc giảm đau hạ sốt Ibuprofen', N'Viên', 100, 25000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Thuốc trị tiêu chảy Smecta', N'Gói', 30, 100000)
INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Kem chống hăm Bepanthen', N'Tuýp', 50, 150000)
INSERT [dbo].[QuyenDangNhap] ([MaQuyen], [MoTa]) VALUES (1, N'Admin')
INSERT [dbo].[QuyenDangNhap] ([MaQuyen], [MoTa]) VALUES (2, N'Nhan vien')
INSERT [dbo].[TaiKhoan] ( [TenTaiKhoan], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [Email]) VALUES ( N'admin', N'123456', 1, N'vippro123', N'0969696969', N'admin@gmail.com')
INSERT [dbo].[TaiKhoan] ( [TenTaiKhoan], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [Email]) VALUES ( N'nv1', N'123456', 2, N'Trần Hữu Lộc', N'0975757575', N'roku@gmail.com')
INSERT [dbo].[TaiKhoan] ( [TenTaiKhoan], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [Email]) VALUES ( N'nv2', N'123456', 2, N'Lê Nguyễn Thanh Tú', N'0248484848', N'tule123@gmail.com')
INSERT [dbo].[TaiKhoan] ( [TenTaiKhoan], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [Email]) VALUES ( N'nv3', N'123456', 2, N'Dương Nguyên', N'0167676767', N'nguyennguyen@gmail.com')
select * from TaiKhoan 
INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 2, '2023-10-03', 20000)
INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 3, '2023-10-15', 20000)
INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 4, '2023-10-17', 406000)
INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 3, '2023-11-09', 75000)
INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 3, '2023-11-13', 500000)
INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 2, '2023-11-25', 160000)
INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 2, '2023-11-27', 590000)
INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 2, '2023-12-19', 380000)
INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 4, '2023-12-31', 95000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (1, 1, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (1, 2, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (2, 1, 1, 5000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (2, 3, 1, 15000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (3, 1, 10, 50000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (3, 5, 3, 6000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (3, 12, 1, 100000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (3, 15, 1, 100000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (3, 16, 1, 150000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (4, 3, 5, 75000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (5, 3, 2, 30000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (5, 7, 1, 350000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (5, 8, 1, 120000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (6, 4, 15, 45000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (6, 5, 20, 40000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (6, 14, 3, 75000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 1, 5, 25000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 2, 3, 30000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 6, 10, 10000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 9, 1, 150000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 11, 5, 100000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 13, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 14, 1, 25000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 15, 2, 200000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (8, 5, 10, 20000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (8, 8, 3, 360000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (9, 3, 3, 45000)
INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (9, 10, 10, 50000)


/*USE [master]
GO
ALTER DATABASE [Project_QLTT] SET  READ_WRITE 
GO*/



