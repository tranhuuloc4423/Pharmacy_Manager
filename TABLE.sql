
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
GO
CREATE TABLE [dbo].[PhanLoai] (
	[MaLoaiThuoc] [INT] PRIMARY KEY IDENTITY(1,1),
    [TenLoaiThuoc] [NVARCHAR](50) NOT NULL,
);
GO
SET ANSI_PADDING OFF

CREATE TABLE [dbo].[NhaCungCap] (
	[MaNhaCungCap] [INT] PRIMARY KEY IDENTITY(1,1),
    [TenNhaCungCap] [NVARCHAR](50) NOT NULL,
    [DiaChi] [NVARCHAR](50) NOT NULL,
);
GO
CREATE TABLE [dbo].[Thuoc] (
    [MaThuoc] [INT] PRIMARY KEY IDENTITY(1,1),
    [MaLoaiThuoc] [INT] FOREIGN KEY REFERENCES [dbo].[PhanLoai]([MaLoaiThuoc]),
    [TenThuoc] [NVARCHAR](50) NOT NULL,
    [DonViTinh] [NVARCHAR](15) NOT NULL,
    [GiaBan] [DECIMAL](18,2) NOT NULL
);
GO
CREATE TABLE [dbo].[KhoThuoc] (
	[MaKhoThuoc] [INT] PRIMARY KEY IDENTITY(1,1),
    [MaThuoc] [INT] FOREIGN KEY REFERENCES [dbo].[Thuoc]([MaThuoc]),
    [MaNhaCungCap] [INT] FOREIGN KEY REFERENCES [dbo].[NhaCungCap]([MaNhaCungCap]),
	[SoLuong] [INT] NOT NULL,
	[NgaySanXuat] [DATE] NOT NULL,
	[NgayHetHan] [DATE] NOT NULL,
); 
GO
--Phan loai thuoc, ngay nhap kho, nha cung cap
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
    [MaTaiKhoan] [INT] PRIMARY KEY IDENTITY(1,1),
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
    [MaHoaDon] [INT] PRIMARY KEY IDENTITY(1,1),
    [MaTaiKhoan] [INT] FOREIGN KEY REFERENCES [dbo].[TaiKhoan]([MaTaiKhoan]),
    [NgayBan] [DATETIME] NOT NULL,
    [TongTien] [DECIMAL](18,2) NOT NULL,
	[TenKhachHang] [NVARCHAR](50) NOT NULL,
	[SoDienThoai] [VARCHAR](10) NOT NULL,
);
GO
/****** Object:  TABLE [dbo].[ChiTietHoaDon]   ******/
SET ANSI_NULLS ON
GO
SET ANSI_PADDING ON
CREATE TABLE [dbo].[ChiTietHoaDon] (
    [MaChiTietHoaDon] [INT] PRIMARY KEY IDENTITY(1,1),
    [MaHoaDon] [INT] FOREIGN KEY REFERENCES [dbo].[HoaDon]([MaHoaDon]),
    [MaThuoc] [INT] FOREIGN KEY REFERENCES [dbo].[Thuoc]([MaThuoc]),
    [SoLuong] [INT] NOT NULL,
);
GO
SET ANSI_PADDING OFF
GO
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Paracetamol', N'Viên', 100, 5000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Vitamin C', N'Viên sủi', 50, 10000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Amoxicillin', N'Viên nang', 20, 15000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Panadol', N'Viên', 200, 3000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Aspirin', N'Viên', 150, 2000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Nhỏ mũi Dexpanthenol', N'Chai', 10, 1000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Kem chống nắng SPF 50', N'Tuýp', 50, 350000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Thuốc ho Prospan', N'Chai', 100, 120000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Men vi sinh BioGaia', N'Hộp', 30, 150000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Nước muối sinh lý 0,9%', N'Chai', 100, 5000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Băng gạc y tế', N'Hộp', 15, 20000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Khẩu trang y tế', N'Hộp', 50 , 100000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Dung dịch sát khuẩn', N'Chai', 500, 50000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Thuốc giảm đau hạ sốt Ibuprofen', N'Viên', 100, 25000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Thuốc trị tiêu chảy Smecta', N'Gói', 30, 100000)
--INSERT [dbo].[Thuoc] ( [TenThuoc], [DonViTinh], [SoLuong], [GiaBan]) VALUES ( N'Kem chống hăm Bepanthen', N'Tuýp', 50, 150000)
--INSERT [dbo].[QuyenDangNhap] ([MaQuyen], [MoTa]) VALUES (1, N'Admin')
--INSERT [dbo].[QuyenDangNhap] ([MaQuyen], [MoTa]) VALUES (2, N'Nhan vien')
--INSERT [dbo].[TaiKhoan] ( [TenTaiKhoan], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [Email]) VALUES ( N'admin', N'123456', 1, N'vippro123', N'0969696969', N'admin@gmail.com')
--INSERT [dbo].[TaiKhoan] ( [TenTaiKhoan], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [Email]) VALUES ( N'nv1', N'123456', 2, N'Trần Hữu Lộc', N'0975757575', N'roku@gmail.com')
--INSERT [dbo].[TaiKhoan] ( [TenTaiKhoan], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [Email]) VALUES ( N'nv2', N'123456', 2, N'Lê Nguyễn Thanh Tú', N'0248484848', N'tule123@gmail.com')
--INSERT [dbo].[TaiKhoan] ( [TenTaiKhoan], [MatKhau], [VaiTro], [HoTen], [SoDienThoai], [Email]) VALUES ( N'nv3', N'123456', 2, N'Dương Nguyên', N'0167676767', N'nguyennguyen@gmail.com')
--select * from TaiKhoan 
--INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 2, '2023-10-03', 20000)
--INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 3, '2023-10-15', 20000)
--INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 4, '2023-10-17', 406000)
--INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 3, '2023-11-09', 75000)
--INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 3, '2023-11-13', 500000)
--INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 2, '2023-11-25', 160000)
--INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 2, '2023-11-27', 590000)
--INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 2, '2023-12-19', 380000)
--INSERT [dbo].[HoaDon] ( [IDTaiKhoan], [NgayBan], [TongTien]) VALUES ( 4, '2023-12-31', 95000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (1, 1, 2, 10000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (1, 2, 1, 10000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (2, 1, 1, 5000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (2, 3, 1, 15000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (3, 1, 10, 50000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (3, 5, 3, 6000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (3, 12, 1, 100000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (3, 15, 1, 100000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (3, 16, 1, 150000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (4, 3, 5, 75000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (5, 3, 2, 30000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (5, 7, 1, 350000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (5, 8, 1, 120000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (6, 4, 15, 45000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (6, 5, 20, 40000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (6, 14, 3, 75000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 1, 5, 25000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 2, 3, 30000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 6, 10, 10000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 9, 1, 150000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 11, 5, 100000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 13, 1, 50000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 14, 1, 25000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (7, 15, 2, 200000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (8, 5, 10, 20000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (8, 8, 3, 360000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (9, 3, 3, 45000)
--INSERT [dbo].[ChiTietHoaDon] ([IDHoaDon], [IDThuoc], [SoLuong], [GiaBan]) VALUES (9, 10, 10, 50000)


--/*USE [master]
--GO
--ALTER DATABASE [Project_QLTT] SET  READ_WRITE 
--GO*/



GO
-- new values
-- Phan Loai
INSERT INTO PhanLoai (TenLoaiThuoc)
VALUES 
    (N'Thuốc ho'),
    (N'Thuốc hạ sốt'),
    (N'Thuốc giảm đau'),
    (N'Thuốc vitamin'),
    (N'Thuốc kháng vi khuẩn');
GO
-- Nha Cung Cap
INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi)
VALUES 
    (N'Nhà cung cấp A', N'Địa chỉ A'),
    (N'Nhà cung cấp B', N'Địa chỉ B'),
    (N'Nhà cung cấp C', N'Địa chỉ C'),
    (N'Nhà cung cấp D', N'Địa chỉ D'),
    (N'Nhà cung cấp E', N'Địa chỉ E');
GO
-- Thuoc
INSERT INTO Thuoc (MaLoaiThuoc, TenThuoc, DonViTinh, GiaBan)
VALUES 
    (1, N'Paracetamol', N'Viên', 18000),
    (2, N'Ibuprofen', N'Viên', 10000),
    (3, N'Aspirin', N'Viên', 5000),
    (4, N'Vitamin C', N'Viên', 10000),
    (5, N'Amoxicillin', N'Viên', 12000);
GO
-- Kho Thuoc
INSERT INTO KhoThuoc (MaThuoc, MaNhaCungCap, SoLuong, NgaySanXuat, NgayHetHan)
VALUES 
    (1, 1, 100, '2022-01-01', '2024-01-01'),
    (2, 1, 150, '2021-12-01', '2023-12-01'),
    (3, 2, 200, '2022-03-01', '2024-03-01'),
    (4, 3, 80, '2023-02-15', '2025-02-15'),
    (5, 4, 120, '2022-08-20', '2024-08-20');
INSERT INTO QuyenDangNhap (MaQuyen, MoTa)
VALUES 
    (1, N'Admin'),
    (2, N'Nhân viên');
GO
-- TaiKhoan
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, VaiTro, HoTen, SoDienThoai, Email)
VALUES 
    ( N'admin', N'123456', 1, N'vippro123', N'0969696969', N'admin@gmail.com'),
    ( N'nv1', N'123456', 2, N'Trần Hữu Lộc', N'0975757575', N'roku@gmail.com'),
	( N'nv2', N'123456', 2, N'Lê Nguyễn Thanh Tú', N'0248484848', N'tule123@gmail.com'),
	( N'nv3', N'123456', 2, N'Dương Kim Nguyên', N'0167676767', N'nguyennguyen@gmail.com');

GO
-- Hoa Don
INSERT INTO HoaDon (MaTaiKhoan, NgayBan, TongTien, TenKhachHang, SoDienThoai)
VALUES
(2, '2024-03-10 10:00:00', 50000, N'Khách hàng A', '0123456789'),
(2, '2024-03-11 15:30:00', 75000, N'Khách hàng B', '0987654321'),
(3, '2024-03-12 08:45:00', 30000, N'Khách hàng C', '0123456789'),
(4, '2024-03-12 11:20:00', 45000, N'Khách hàng D', '0987654321');

GO
-- Chi tiet hoa don
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThuoc, SoLuong, GiaBan)
VALUES
(1, 1, 2, 20000),
(1, 2, 3, 15000),
(2, 3, 1, 75000),
(3, 4, 2, 15000),
(4, 5, 3, 15000);

SELECT * FROM PhanLoai
SELECT * FROM NhaCungCap
SELECT * FROM Thuoc
SELECT * FROM KhoThuoc
SELECT * FROM TaiKhoan
SELECT * FROM QuyenDangNhap
SELECT * FROM HoaDon
SELECT * FROM ChiTietHoaDon
