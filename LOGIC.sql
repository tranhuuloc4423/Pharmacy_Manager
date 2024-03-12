USE DATABASE [Project_QLTT]

/****************** TAIKHOAN   ******************/

/****** Procedure: Themtaikhoan   ******/
CREATE PROCEDURE ThemTaiKhoan 
(
  @TenTaiKhoan NVARCHAR(25),
  @MatKhau NVARCHAR(30),
  @VaiTro INT,
  @HoTen NVARCHAR(30),
  @SoDienThoai NVARCHAR(15),
  @Email NVARCHAR(30)
)
AS
BEGIN
  INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, VaiTro, HoTen, SoDienThoai, Email)
  VALUES (@TenTaiKhoan, @MatKhau, @VaiTro, @HoTen, @SoDienThoai, @Email);
END;

/*EXEC ThemTaiKhoan N'nv4', N'123456', 2, N'lmaolmao', N'123456789', N'lmao@gmail.com'
select * from TaiKhoan*/

/****** Procedure: SuaTaiKhoan   ******/
CREATE PROCEDURE SuaTaiKhoan 
(
  @IDTaiKhoan INT,
  @TenTaiKhoan NVARCHAR(25),
  @MatKhau NVARCHAR(30),
  @VaiTro INT,
  @HoTen NVARCHAR(30),
  @SoDienThoai NVARCHAR(15),
  @Email NVARCHAR(30)
)
AS
BEGIN
  UPDATE TaiKhoan
  SET TenTaiKhoan = @TenTaiKhoan,
  MatKhau = @MatKhau,
  VaiTro = @VaiTro,
  HoTen = @HoTen,
  SoDienThoai = @SoDienThoai,
  Email = @Email
  WHERE IDTaiKhoan = @IDTaiKhoan;
END;
/*EXEC SuaTaiKhoan 5, N'nv5', N'123456', 2, N'bruhbruh', N'123456789', N'bruh@gmail.com'
select * from TaiKhoan*/

/****** Procedure: XoaTaiKhoan   ******/
CREATE PROCEDURE XoaTaiKhoan 
(
  @IDTaiKhoan INT
)
AS
BEGIN
  DELETE FROM TaiKhoan
  WHERE IDTaiKhoan = @IDTaiKhoan;
END;

/*EXEC XoaTaiKhoan 5
select * from TaiKhoan*/

/****************** THUOC   ******************/

/****** Procedure: ThemThuoc   ******/
CREATE PROCEDURE ThemThuoc
(
  @TenThuoc NVARCHAR(50),
  @DonViTinh NVARCHAR(15),
  @SoLuong INT,
  @GiaBan DECIMAL(18,2)
)
AS
BEGIN
  INSERT INTO Thuoc (TenThuoc, DonViTinh, SoLuong, GiaBan)
  VALUES (@TenThuoc, @DonViTinh, @SoLuong, @GiaBan);
END;

/*EXEC ThemThuoc N'lmao', N'bruh', 100, 5000
select * from Thuoc*/

/****** Procedure: SuaThuoc   ******/
CREATE PROCEDURE SuaThuoc
(
  @IDThuoc INT,
  @TenThuoc NVARCHAR(50),
  @DonViTinh NVARCHAR(15),
  @SoLuong INT,
  @GiaBan DECIMAL(18,2)
)
AS
BEGIN
  UPDATE Thuoc
  SET TenThuoc = @TenThuoc,
  DonViTinh = @DonViTinh,
  SoLuong = @SoLuong,
  GiaBan = @GiaBan
  WHERE IDThuoc = @IDThuoc;
END;

/*EXEC SuaThuoc 17, N'vip', N'pro', 100, 5000
select * from Thuoc*/

/****** Procedure: XoaThuoc   ******/
CREATE PROCEDURE XoaThuoc
(
  @IDThuoc INT
)
AS
BEGIN
  DELETE FROM Thuoc
  WHERE IDThuoc = @IDThuoc;
END;
/*EXEC XoaThuoc 17
select * from Thuoc*/

/****************** XEM HOA DON CUA NGUOI BAN  ******************/
CREATE PROCEDURE XemHoaDon
(
  @IDTaiKhoan INT
)
AS
BEGIN
  SELECT *
  FROM HoaDon
  WHERE IDTaiKhoan = @IDTaiKhoan;
END;

/*EXEC XemHoaDon 4
SELECT * FROM HoaDon*/

/****************** XEM CHI TIET HOA DON CUA NGUOI BAN  ******************/

CREATE PROCEDURE XemChiTietHoaDon
(
  @IDTaiKhoan INT
)
AS
BEGIN
  SELECT h.IDHoaDon, h.NgayBan, h.TongTien,
         t.TenThuoc, t.DonViTinh, ct.SoLuong, ct.GiaBan
  FROM HoaDon h
  INNER JOIN ChiTietHoaDon ct ON h.IDHoaDon = ct.IDHoaDon
  INNER JOIN Thuoc t ON ct.IDThuoc = t.IDThuoc
  WHERE h.IDTaiKhoan = @IDTaiKhoan;
END;

/*EXEC XemChiTietHoaDon 4
SELECT * FROM HoaDon*/