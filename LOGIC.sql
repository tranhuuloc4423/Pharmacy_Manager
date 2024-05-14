USE [Project_QLTT]
GO

/****************** TAIKHOAN   ******************/

CREATE PROCEDURE KiemTraTaiKhoan
(
    @TenTaiKhoan NVARCHAR(25),
    @MatKhau NVARCHAR(30)
)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT VaiTro, HoTen
    FROM TaiKhoan
    WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau
END
GO
CREATE PROCEDURE ThemTaiKhoan
(
  @TenTaiKhoan NVARCHAR(25),
  @MatKhau NVARCHAR(30),
  @VaiTro INT,
  @HoTen NVARCHAR(30)
)
AS
BEGIN
  INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, VaiTro, HoTen)
  VALUES (@TenTaiKhoan, @MatKhau, @VaiTro, @HoTen);
END;

GO

CREATE PROCEDURE SuaTaiKhoan
(
  @TenTaiKhoan NVARCHAR(25),
  @MatKhau NVARCHAR(30),
  @VaiTro INT,
  @HoTen NVARCHAR(30)
)
AS
BEGIN
  UPDATE TaiKhoan
  SET MatKhau = @MatKhau,
  VaiTro = @VaiTro,
  HoTen = @HoTen
  WHERE TenTaiKhoan = @TenTaiKhoan;
END;

GO

CREATE PROCEDURE XoaTaiKhoan
(
  @TenTaiKhoan NVARCHAR(25)
)
AS
BEGIN
  DELETE FROM TaiKhoan
  WHERE TenTaiKhoan = @TenTaiKhoan;
END;

GO
-- 
--  thêm thuốc
CREATE PROCEDURE ThemThuoc
(
    @MaLoaiThuoc INT,
    @TenThuoc NVARCHAR(255),
    @MaNhaCungCap INT,
    @DonViTinh NVARCHAR(15),
    @GiaBan DECIMAL(18,0)
)
AS
BEGIN
    INSERT INTO Thuoc (MaLoaiThuoc,MaNhaCungCap,  TenThuoc, DonViTinh, GiaBan)
    VALUES (@MaLoaiThuoc, @MaNhaCungCap, @TenThuoc, @DonViTinh, @GiaBan);
END
GO

-- sửa thông tin thuốc
CREATE PROCEDURE SuaThuoc
(
    @MaThuoc INT,
    @MaLoaiThuoc INT,
    @MaNhaCungCap INT,
    @TenThuoc NVARCHAR(255),
    @DonViTinh NVARCHAR(15),
    @GiaBan DECIMAL(18,0)
)
AS
BEGIN
    UPDATE Thuoc
    SET MaLoaiThuoc = @MaLoaiThuoc,
        MaNhaCungCap = @MaNhaCungCap,
        TenThuoc = @TenThuoc,
        DonViTinh = @DonViTinh,
        GiaBan = @GiaBan
    WHERE MaThuoc = @MaThuoc;
END
GO

-- xóa thuốc
CREATE PROCEDURE XoaThuoc
(
    @MaThuoc INT
)
AS
BEGIN
    DELETE FROM Thuoc
    WHERE MaThuoc = @MaThuoc;
END
GO

-- thêm phân loại
CREATE PROCEDURE ThemPhanLoai
    @TenLoaiThuoc NVARCHAR(255)
AS
BEGIN
    INSERT INTO PhanLoai (TenLoaiThuoc)
    VALUES (@TenLoaiThuoc);
END
GO

-- sửa thông tin phân loại
CREATE PROCEDURE SuaPhanLoai
    @MaLoaiThuoc INT,
    @TenLoaiThuoc NVARCHAR(255)
AS
BEGIN
    UPDATE PhanLoai
    SET TenLoaiThuoc = @TenLoaiThuoc
    WHERE MaLoaiThuoc = @MaLoaiThuoc;
END
GO

-- xóa phân loại
CREATE PROCEDURE XoaPhanLoai
    @MaLoaiThuoc INT
AS
BEGIN
    DELETE FROM PhanLoai
    WHERE MaLoaiThuoc = @MaLoaiThuoc;
END
GO

-- thêm nhà cung cấp
CREATE PROCEDURE ThemNhaCungCap
    @TenNhaCungCap NVARCHAR(255),
	@DiaChi NVARCHAR(255)
AS
BEGIN
    INSERT INTO NhaCungCap(TenNhaCungCap, DiaChi)
    VALUES (@TenNhaCungCap, @DiaChi);
END
GO

-- sửa thông tin phân loại
CREATE PROCEDURE SuaNhaCungCap
    @MaNhaCungCap INT,
    @TenNhaCungCap NVARCHAR(50),
	@DiaChi VARCHAR(255)
AS
BEGIN
    UPDATE NhaCungCap
    SET TenNhaCungCap = @TenNhaCungCap,
		DiaChi = @DiaChi
    WHERE MaNhaCungCap = @MaNhaCungCap;
END
GO

-- xóa phân loại
CREATE PROCEDURE XoaNhaCungCap
    @MaNhaCungCap INT
AS
BEGIN
    DELETE FROM NhaCungCap
    WHERE MaNhaCungCap = @MaNhaCungCap;
END
GO

/****************** Hóa đơn và chi tiết hóa đơn  ******************/
CREATE PROCEDURE ThemHoaDon
(
	@TenTaiKhoan NVARCHAR(25),
	@MaKhachHang INT,
	@MaHoaDon INT OUTPUT
)
AS
BEGIN
	INSERT INTO HoaDon (TenTaiKhoan, NgayBan, MaKhachHang, TongTien)
	VALUES (@TenTaiKhoan, GETDATE(), @MaKhachHang, 0)
	SET @MaHoaDon = SCOPE_IDENTITY()
END
GO
-- Thêm chi tiết hóa đơn
CREATE PROCEDURE ThemChiTietHoaDon
(
	@MaHoaDon INT,
	@MaThuoc INT,
	@SoLuong INT,
	@DonGia INT
)
AS
BEGIN
	-- Tính thành tiền
	DECLARE @ThanhTien DECIMAL(18,0) 
	SET @ThanhTien = @SoLuong * @DonGia

	-- Thêm chi tiết hóa đơn
	INSERT INTO ChiTietHoaDon (MaHoaDon, MaThuoc, SoLuong, DonGia, ThanhTien)
	VALUES (@MaHoaDon, @MaThuoc, @SoLuong, @DonGia, @SoLuong*@DonGia)

	-- Cập nhật tổng tiền
	DECLARE @TongTien DECIMAL(18,0)
	SET @TongTien = (SELECT SUM(ThanhTien) FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon);

	UPDATE HoaDon
	SET TongTien = @TongTien
	WHERE MaHoaDon = @MaHoaDon;
END
GO

--------------------------- Khách Hàng ---------------------------
CREATE PROCEDURE ThemKhachHang
    @HoTen NVARCHAR(50),
    @SoDienThoai VARCHAR(10)
AS
BEGIN
    INSERT INTO KhachHang (HoTen, SoDienThoai)
    VALUES (@HoTen, @SoDienThoai)
END

GO

CREATE PROCEDURE SuaKhachHang
    @MaKhachHang INT,
    @HoTen NVARCHAR(50),
    @SoDienThoai VARCHAR(10)
AS
BEGIN
    UPDATE KhachHang
    SET HoTen = @HoTen,
        SoDienThoai = @SoDienThoai
    WHERE MaKhachHang = @MaKhachHang
END

GO

CREATE PROCEDURE XoaKhachHang
    @MaKhachHang INT
AS
BEGIN
    DELETE FROM KhachHang
    WHERE MaKhachHang = @MaKhachHang
END