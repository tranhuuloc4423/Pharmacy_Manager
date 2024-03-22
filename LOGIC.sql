USE [Project_QLTT]
GO

/****************** TAIKHOAN   ******************/

CREATE PROCEDURE KiemTraTaiKhoan
(
    @TenTaiKhoan NVARCHAR(25),
    @MatKhau NVARCHAR(30),
    @VaiTro INT OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT @VaiTro = VaiTro
    FROM TaiKhoan
    WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau
END
GO
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

GO

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
  WHERE MaTaiKhoan = @IDTaiKhoan;
END;

GO

CREATE PROCEDURE XoaTaiKhoan
(
  @IDTaiKhoan INT
)
AS
BEGIN
  DELETE FROM TaiKhoan
  WHERE MaTaiKhoan = @IDTaiKhoan;
END;

/****************** XEM HOA DON CUA NGUOI BAN  ******************/
GO
CREATE PROCEDURE XemHoaDon
(
  @IDTaiKhoan INT
)
AS
BEGIN
  SELECT *
  FROM HoaDon
  WHERE MaTaiKhoan = @IDTaiKhoan;
END;

/****************** XEM CHI TIET HOA DON CUA NGUOI BAN  ******************/

GO
CREATE PROCEDURE XemChiTietHoaDon
(
  @IDTaiKhoan INT
)
AS
BEGIN
  SELECT h.MaHoaDon, h.NgayBan, h.TongTien,
         t.TenThuoc, t.DonViTinh, ct.SoLuong, ct.GiaBan
  FROM HoaDon h
  INNER JOIN ChiTietHoaDon ct ON h.MaHoaDon = ct.MaHoaDon
  INNER JOIN Thuoc t ON ct.MaThuoc = t.MaThuoc
  WHERE h.MaTaiKhoan = @IDTaiKhoan;
END;

-- 
-- Tạo stored procedure thêm thuốc
CREATE PROCEDURE ThemThuoc
(
    @MaLoaiThuoc INT,
    @TenThuoc NVARCHAR(50),
    @DonViTinh NVARCHAR(15),
    @GiaBan DECIMAL(18,2)
)
AS
BEGIN
    INSERT INTO Thuoc (MaLoaiThuoc, TenThuoc, DonViTinh, GiaBan)
    VALUES (@MaLoaiThuoc, @TenThuoc, @DonViTinh, @GiaBan);
END
GO

-- sửa thông tin thuốc
CREATE PROCEDURE SuaThuoc
(
    @MaThuoc INT,
    @MaLoaiThuoc INT,
    @TenThuoc NVARCHAR(50),
    @DonViTinh NVARCHAR(15),
    @GiaBan DECIMAL(18,2)
)
AS
BEGIN
    UPDATE Thuoc
    SET MaLoaiThuoc = @MaLoaiThuoc,
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

-- thêm nhà cung cấp
CREATE PROCEDURE ThemNhaCungCap
(
    @TenNhaCungCap NVARCHAR(50),
    @DiaChi NVARCHAR(50)
)
AS
BEGIN
    INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi)
    VALUES (@TenNhaCungCap, @DiaChi);
END
GO

-- sửa thông tin nhà cung cấp
CREATE PROCEDURE SuaNhaCungCap
    @MaNhaCungCap INT,
    @TenNhaCungCap NVARCHAR(50),
    @DiaChi NVARCHAR(50)
AS
BEGIN
    UPDATE NhaCungCap
    SET TenNhaCungCap = @TenNhaCungCap,
        DiaChi = @DiaChi
    WHERE MaNhaCungCap = @MaNhaCungCap;
END
GO

-- xóa nhà cung cấp
CREATE PROCEDURE XoaNhaCungCap
    @MaNhaCungCap INT
AS
BEGIN
    DELETE FROM NhaCungCap
    WHERE MaNhaCungCap = @MaNhaCungCap;
END
GO

-- thêm phân loại
CREATE PROCEDURE ThemPhanLoai
    @TenLoaiThuoc NVARCHAR(50)
AS
BEGIN
    INSERT INTO PhanLoai (TenLoaiThuoc)
    VALUES (@TenLoaiThuoc);
END
GO

-- sửa thông tin phân loại
CREATE PROCEDURE SuaPhanLoai
    @MaLoaiThuoc INT,
    @TenLoaiThuoc NVARCHAR(50)
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

-- thêm kho thuốc
CREATE PROCEDURE ThemKhoThuoc
    @MaThuoc INT,
    @MaNhaCungCap INT,
    @SoLuong INT,
    @NgaySanXuat DATE,
    @NgayHetHan DATE
AS
BEGIN
    INSERT INTO KhoThuoc (MaThuoc, MaNhaCungCap, SoLuong, NgaySanXuat, NgayHetHan)
    VALUES (@MaThuoc, @MaNhaCungCap, @SoLuong, @NgaySanXuat, @NgayHetHan);
END
GO

-- sửa thông tin kho thuốc
CREATE PROCEDURE SuaKhoThuoc
    @MaKhoThuoc INT,
    @MaThuoc INT,
    @MaNhaCungCap INT,
    @SoLuong INT,
    @NgaySanXuat DATE,
    @NgayHetHan DATE
AS
BEGIN
    UPDATE KhoThuoc
    SET MaThuoc = @MaThuoc,
        MaNhaCungCap = @MaNhaCungCap,
        SoLuong = @SoLuong,
        NgaySanXuat = @NgaySanXuat,
        NgayHetHan = @NgayHetHan
    WHERE MaKhoThuoc = @MaKhoThuoc;
END
GO

--  xóa kho thuốc
CREATE PROCEDURE XoaKhoThuoc
    @MaKhoThuoc INT
AS
BEGIN
    DELETE FROM KhoThuoc
    WHERE MaKhoThuoc = @MaKhoThuoc;
END
GO

--  thêm chi tiết hóa đơn
CREATE PROCEDURE ThemChiTietHoaDon
    @MaHoaDon INT,
    @MaThuoc INT,
    @SoLuong INT,
    @GiaBan INT
AS
BEGIN
    -- Thêm chi tiết hóa đơn
    INSERT INTO ChiTietHoaDon (MaHoaDon, MaThuoc, SoLuong, GiaBan)
    VALUES (@MaHoaDon, @MaThuoc, @SoLuong, @GiaBan);

    -- Cập nhật tổng tiền trong hóa đơn
    UPDATE HoaDon
    SET TongTien = (SELECT SUM(SoLuong * GiaBan) FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon)
    WHERE MaHoaDon = @MaHoaDon;
END
GO
