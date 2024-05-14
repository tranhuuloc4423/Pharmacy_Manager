CREATE DATABASE [Project_QLTT]
GO
USE [Project_QLTT]
GO
------------ Thuoc ------------
CREATE TABLE PhanLoai (
    MaLoaiThuoc INT PRIMARY KEY IDENTITY(1,1),
    TenLoaiThuoc NVARCHAR(255) NOT NULL
);
GO


CREATE TABLE NhaCungCap (
    MaNhaCungCap INT PRIMARY KEY IDENTITY(1,1),
    TenNhaCungCap NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(255) NOT NULL
);
GO

CREATE TABLE Thuoc (
    MaThuoc INT PRIMARY KEY IDENTITY(1,1),
    MaLoaiThuoc INT FOREIGN KEY REFERENCES PhanLoai(MaLoaiThuoc),    
	MaNhaCungCap INT FOREIGN KEY REFERENCES NhaCungCap(MaNhaCungCap),
    TenThuoc NVARCHAR(255) NOT NULL,
    DonViTinh NVARCHAR(15) NOT NULL,
    GiaBan DECIMAL(18,0) NOT NULL
);
GO

------------ Tai Khoan ------------
CREATE TABLE QuyenDangNhap (
    MaQuyen INT PRIMARY KEY,
    MoTa NVARCHAR(10) NULL
);
GO

CREATE TABLE TaiKhoan (
    TenTaiKhoan NVARCHAR(25) PRIMARY KEY,
    MatKhau NVARCHAR(30) NOT NULL,
    VaiTro INT FOREIGN KEY REFERENCES QuyenDangNhap(MaQuyen),
    HoTen NVARCHAR(30) NOT NULL,
);
GO

------------ KhachHang ------------
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY IDENTITY(1,1),
	HoTen NVARCHAR(50) NOT NULL,
	SoDienThoai VARCHAR(10),
);
GO

------------ Hoa Don ------------
CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY IDENTITY(1,1),
    TenTaiKhoan NVARCHAR(25) FOREIGN KEY REFERENCES TaiKhoan(TenTaiKhoan),
    NgayBan DATETIME NOT NULL,
    TongTien DECIMAL(18,0) NOT NULL,
	MaKhachHang INT FOREIGN KEY REFERENCES KhachHang(MaKhachHang),
);
GO


CREATE TABLE ChiTietHoaDon (
    MaChiTietHoaDon INT PRIMARY KEY IDENTITY(1,1),
    MaHoaDon INT FOREIGN KEY REFERENCES HoaDon(MaHoaDon),
    MaThuoc INT FOREIGN KEY REFERENCES Thuoc(MaThuoc),
    SoLuong INT NOT NULL,
	DonGia INT NOT NULL,
	ThanhTien INT NOT NULL
);
GO

-- INSERT DATA

INSERT INTO PhanLoai (TenLoaiThuoc)
VALUES (N'Hoạt chất'),
       (N'Dược phẩm'),
       (N'Thuốc bảo vệ thực vật'),
       (N'Thuốc thông thường'),
       (N'Thực phẩm chức năng'),
       (N'Thuốc giảm đau'),
       (N'Thuốc dị ứng'),
       (N'Thuốc kháng viêm'),
       (N'Thuốc hạ sốt');
GO

INSERT INTO NhaCungCap(TenNhaCungCap, DiaChi)
VALUES (N'Pharmacity', N'248A Nơ Trang Long, P.12, Q.Bình Thạnh, TP.HCM'),
       (N'Phano Pharmacy', N'9 Hồ Biểu Chánh, P.11, Q. Phú Nhuận, TP.HCM'),
       (N'Nhà Thuốc An Khang', N'128 Trần Quang Khải, P. Tân Định, Q.1, TP.HCM'),
       (N'Nhà Thuốc Minh Châu', N'161 Bạch Đằng, P.2, Q. Tân Bình, TP.HCM');
GO

INSERT INTO Thuoc (MaLoaiThuoc,MaNhaCungCap, TenThuoc, DonViTinh, GiaBan)
VALUES (1, 1, N'Paracetamol', N'Viên', 5000),
       (2, 2, N'Amoxicillin', N'Viên', 10000),
       (3, 3, N'Glyphosate', N'Lít', 200000),
       (4, 3, N'Cetirizine', N'Viên', 6000),
       (5, 4, N'Calamine lotion', N'Chai(ml)', 20000);
GO

INSERT INTO KhachHang(HoTen, SoDienThoai)
VALUES (N'Nguyễn Văn A', N'0123456789'),
       (N'Trần Thị B', N'0987654321'),
       (N'Lê Minh C', N'0369852147');
GO
INSERT INTO QuyenDangNhap (MaQuyen, MoTa)
VALUES (1, N'admin'),
       (2, N'user');
GO
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, VaiTro, HoTen)
VALUES (N'admin', '123', 1, N'Quản Trị'),
       (N'tranhuuloc', '123', 2, N'Lộc'),
       (N'kimnguyen', '123', 2, N'Nguyên'),
       (N'thanhtu', '123', 2, N'Tú');
GO

select * from QuyenDangNhap
select * from TaiKhoan
select * from Thuoc
select * from PhanLoai
select * from ChiTietHoaDon
select * from HoaDon
select * from KhachHang
select * from NhaCungCap