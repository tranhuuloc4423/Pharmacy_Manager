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
    GiaBan DECIMAL(18,0) NOT NULL
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
	KhachHangThanThiet INT,
	MuaTichLuy DECIMAL(18,0)
);
GO



------------ Hoa Don ------------
CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY IDENTITY(1,1),
    TenTaiKhoan NVARCHAR(25) FOREIGN KEY REFERENCES TaiKhoan(TenTaiKhoan),
    NgayBan DATETIME NOT NULL,
    TongTien DECIMAL(18,0) NOT NULL,
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

INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi)
VALUES (N'Nhà thuốc ABC', N'123 Đường ABC, Thành phố XYZ'),
       (N'Công ty XYZ', N'456 Đường XYZ, Thành phố ABC'),
       (N'Phân xưởng KLM', N'789 Đường KLM, Thành phố DEF'),
       (N'Công ty Dược phẩm Traphaco', N'789 Đường ABX, Thành phố XYZ'),
       (N'Công ty Dược phẩm DHG Pharma', N'789 Đường KLM, Thành phố DEF');
GO

INSERT INTO Thuoc (MaLoaiThuoc, TenThuoc, DonViTinh, GiaBan)
VALUES (1, N'Paracetamol', N'Viên', 5000),
       (2, N'Amoxicillin', N'Viên', 10000),
       (3, N'Glyphosate', N'Lít', 200000),
       (4, N'Cetirizine', N'Viên', 6000),
       (5, N'Calamine lotion', N'Chai(ml)', 20000);
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
       (N'user2', 'pass2', 2, N'Người dùng 2'),
       (N'user3', 'pass3', 2, N'Người dùng 3');
GO
select * from QuyenDangNhap
select * from TaiKhoan
select * from Thuoc
select * from NhaCungCap
select * from PhanLoai
select * from ChiTietPhieuNhap
select * from ChiTietHoaDon
select * from HoaDon
select * from KhachHang
select * from KhoThuoc
select * from PhieuNhap
select MaThuoc, TenThuoc from Thuoc

select MaPhieuNhap, TenThuoc, SoLuong from ChiTietPhieuNhap inner join Thuoc on ChiTietPhieuNhap.MaThuoc = Thuoc.MaThuoc

select Thang, Nam, TenThuoc, DauKy, NhapTrongKy, XuatTrongThang, TonKho from KhoThuoc inner join Thuoc on KhoThuoc.MaThuoc = Thuoc.MaThuoc

select MaThuoc, TenLoaiThuoc, TenThuoc, DonViTinh, GiaBan
from Thuoc inner join PhanLoai on Thuoc.MaLoaiThuoc = PhanLoai.MaLoaiThuoc

select TenTaiKhoan, HoTen, MoTa from TaiKhoan inner join QuyenDangNhap on TaiKhoan.VaiTro = QuyenDangNhap.MaQuyen