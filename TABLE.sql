CREATE DATABASE [Project_QLTT]
GO
USE [Project_QLTT]
GO
------------ Thuoc ------------
CREATE TABLE PhanLoai (
    MaLoaiThuoc INT PRIMARY KEY IDENTITY(1,1),
    TenLoaiThuoc NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE NhaCungCap (
    MaNhaCungCap INT PRIMARY KEY IDENTITY(1,1),
    TenNhaCungCap NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Thuoc (
    MaThuoc INT PRIMARY KEY IDENTITY(1,1),
    MaLoaiThuoc INT FOREIGN KEY REFERENCES PhanLoai(MaLoaiThuoc),
    TenThuoc NVARCHAR(50) NOT NULL,
    DonViTinh NVARCHAR(15) NOT NULL,
    GiaBan DECIMAL(18,2) NOT NULL
);
GO
------------ Kho ------------

CREATE TABLE KhoThuoc (
    Thang INT NOT NULL,
	Nam INT NOT NULL,
    MaThuoc INT FOREIGN KEY REFERENCES Thuoc(MaThuoc),
	DauKy INT NOT NULL,
	NhapTrongKy INT NOT NULL,
	XuatTrongThang INT NOT NULL,
    TonKho INT NOT NULL,
	CONSTRAINT PK_KhoThuoc PRIMARY KEY (Thang, Nam, MaThuoc)
);
GO

CREATE TABLE PhieuNhap (
    MaPhieuNhap INT PRIMARY KEY IDENTITY(1,1),
    MaNhaCungCap INT FOREIGN KEY REFERENCES NhaCungCap(MaNhaCungCap),
    NgayNhap DATE,
    NguoiNhap NVARCHAR(25)
);
GO

CREATE TABLE ChiTietPhieuNhap (
    MaChiTietPhieuNhap INT PRIMARY KEY IDENTITY(1,1),
    MaPhieuNhap INT FOREIGN KEY REFERENCES PhieuNhap(MaPhieuNhap),
    MaThuoc INT FOREIGN KEY REFERENCES Thuoc(MaThuoc),
    SoLuong INT
);
GO

CREATE TABLE PhieuXuat (
    MaPhieuXuat INT PRIMARY KEY IDENTITY(1,1),
    NgayXuat DATE,
    NguoiXuat NVARCHAR(25)
);
GO

CREATE TABLE ChiTietPhieuXuat (
    MaChiTietPhieuXuat INT PRIMARY KEY IDENTITY(1,1),
    MaPhieuXuat INT FOREIGN KEY REFERENCES PhieuXuat(MaPhieuXuat),
    MaThuoc INT FOREIGN KEY REFERENCES Thuoc(MaThuoc),
    SoLuong INT
);
GO



------------ Tai Khoan ------------
CREATE TABLE QuyenDangNhap (
    MaQuyen INT PRIMARY KEY,
    MoTa NVARCHAR(10) NULL
);
GO

CREATE TABLE TaiKhoan (
    MaTaiKhoan INT PRIMARY KEY IDENTITY(1,1),
    TenTaiKhoan NVARCHAR(25) NOT NULL,
    MatKhau NVARCHAR(30) NOT NULL,
    VaiTro INT FOREIGN KEY REFERENCES QuyenDangNhap(MaQuyen),
    HoTen NVARCHAR(30) NOT NULL,
);
GO

------------ Hoa Don ------------
CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY IDENTITY(1,1),
    MaTaiKhoan INT FOREIGN KEY REFERENCES TaiKhoan(MaTaiKhoan),
    NgayBan DATETIME NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL,
	MaKhachHang INT FOREIGN KEY REFERENCES KhachHang(MaKhachHang),
	GiamGia INT
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

------------ KhachHang ------------
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY IDENTITY(1,1),
	HoTen NVARCHAR(50) NOT NULL,
	SoDienThoai VARCHAR(10),
	KhachHangThanThiet INT,
	MuaTichLuy DECIMAL(18,2) NOT NULL
);

-- INSERT DATA

INSERT INTO PhanLoai (TenLoaiThuoc)
VALUES ('Loại 1'), ('Loại 2'), ('Loại 3');

INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi)
VALUES ('Nhà cung cấp 1', 'Địa chỉ 1'),
       ('Nhà cung cấp 2', 'Địa chỉ 2'),
       ('Nhà cung cấp 3', 'Địa chỉ 3');

INSERT INTO Thuoc (MaLoaiThuoc, TenThuoc, DonViTinh, GiaBan)
VALUES (1, 'Thuốc 1', 'Đơn vị 1', 100.50),
       (2, 'Thuốc 2', 'Đơn vị 2', 50.25),
       (3, 'Thuốc 3', 'Đơn vị 3', 75.75);

INSERT INTO KhoThuoc (Thang, Nam, MaThuoc, DauKy, NhapTrongKy, XuatTrongThang, TonKho)
VALUES (1, 2024, 1, 50, 20, 10, 60),
       (1, 2024, 2, 100, 30, 20, 110),
       (1, 2024, 3, 75, 25, 15, 85);

INSERT INTO PhieuNhap (MaNhaCungCap, NgayNhap, NguoiNhap)
VALUES (1, '2024-01-01', 'Người nhập 1'),
       (2, '2024-01-02', 'Người nhập 2'),
       (3, '2024-01-03', 'Người nhập 3');

INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaThuoc, SoLuong)
VALUES (1, 1, 10),
       (1, 2, 5),
       (2, 2, 8),
       (3, 3, 12);

INSERT INTO PhieuXuat (NgayXuat, NguoiXuat)
VALUES ('2024-01-01', 'Người xuất 1'),
       ('2024-01-02', 'Người xuất 2'),
       ('2024-01-03', 'Người xuất 3');

INSERT INTO ChiTietPhieuXuat (MaPhieuXuat, MaThuoc, SoLuong)
VALUES (1, 1, 5),
       (1, 2, 3),
       (2, 2, 6),
       (3, 3, 10);

INSERT INTO QuyenDangNhap (MaQuyen, MoTa)
VALUES (1, N'admin'),
       (2, N'user');
GO
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, VaiTro, HoTen)
VALUES ('admin', '123', 1, N'Quản Trị'),
       ('user2', 'pass2', 2, N'Người dùng 2'),
       ('user3', 'pass3', 2, N'Người dùng 3');

INSERT INTO HoaDon (MaTaiKhoan, NgayBan, TongTien, MaKhachHang, GiamGia)
VALUES (1, '2024-01-01', 500.00, 1, 10),
       (2, '2024-01-02', 750.00, 2, 20),
       (3, '2024-01-03', 1000.00, 3, 30);

INSERT INTO ChiTietHoaDon (MaHoaDon, MaThuoc, SoLuong, DonGia, ThanhTien)
VALUES (1, 1, 5, 100.00, 500.00),
       (1, 2, 3, 50.00, 150.00),
       (2, 2, 6, 100.00, 1000.00);


select * from TaiKhoan