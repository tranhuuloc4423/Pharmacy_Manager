-- Thuốc
-- Thêm thuốc mới
CREATE PROCEDURE ThemThuoc 
    @MaLoaiThuoc INT,
    @TenThuoc NVARCHAR(50),
    @DonViTinh NVARCHAR(15),
    @GiaBan DECIMAL(18,2)
AS
BEGIN
    INSERT INTO Thuoc (MaLoaiThuoc, TenThuoc, DonViTinh, GiaBan)
    VALUES (@MaLoaiThuoc, @TenThuoc, @DonViTinh, @GiaBan)
END;

-- Sửa thông tin thuốc
CREATE PROCEDURE SuaThuoc 
    @MaThuoc INT,
    @MaLoaiThuoc INT,
    @TenThuoc NVARCHAR(50),
    @DonViTinh NVARCHAR(15),
    @GiaBan DECIMAL(18,2)
AS
BEGIN
    UPDATE Thuoc
    SET MaLoaiThuoc = @MaLoaiThuoc,
        TenThuoc = @TenThuoc,
        DonViTinh = @DonViTinh,
        GiaBan = @GiaBan
    WHERE MaThuoc = @MaThuoc
END;

-- Xóa thuốc
CREATE PROCEDURE XoaThuoc 
    @MaThuoc INT
AS
BEGIN
    DELETE FROM Thuoc WHERE MaThuoc = @MaThuoc
END;

---------------------------------------------------

-- Thêm phân loại mới
CREATE PROCEDURE ThemPhanLoai 
    @TenLoaiThuoc NVARCHAR(50)
AS
BEGIN
    INSERT INTO PhanLoai (TenLoaiThuoc)
    VALUES (@TenLoaiThuoc)
END;

-- Sửa thông tin phân loại
CREATE PROCEDURE SuaPhanLoai 
    @MaLoaiThuoc INT,
    @TenLoaiThuoc NVARCHAR(50)
AS
BEGIN
    UPDATE PhanLoai
    SET TenLoaiThuoc = @TenLoaiThuoc
    WHERE MaLoaiThuoc = @MaLoaiThuoc
END;

-- Xóa phân loại
CREATE PROCEDURE XoaPhanLoai 
    @MaLoaiThuoc INT
AS
BEGIN
    DELETE FROM PhanLoai WHERE MaLoaiThuoc = @MaLoaiThuoc
END;

----------------------------------------------------------
-- Thêm nhà cung cấp mới
CREATE PROCEDURE ThemNhaCungCap 
    @TenNhaCungCap NVARCHAR(50),
    @DiaChi NVARCHAR(50)
AS
BEGIN
    INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi)
    VALUES (@TenNhaCungCap, @DiaChi)
END;

-- Sửa thông tin nhà cung cấp
CREATE PROCEDURE SuaNhaCungCap 
    @MaNhaCungCap INT,
    @TenNhaCungCap NVARCHAR(50),
    @DiaChi NVARCHAR(50)
AS
BEGIN
    UPDATE NhaCungCap
    SET TenNhaCungCap = @TenNhaCungCap,
        DiaChi = @DiaChi
    WHERE MaNhaCungCap = @MaNhaCungCap
END;

-- Xóa nhà cung cấp
CREATE PROCEDURE XoaNhaCungCap 
    @MaNhaCungCap INT
AS
BEGIN
    DELETE FROM NhaCungCap WHERE MaNhaCungCap = @MaNhaCungCap
END;

---------------------------------------------------------------

-- Thêm khách hàng mới
CREATE PROCEDURE ThemKhachHang 
    @HoTen NVARCHAR(50),
    @SoDienThoai VARCHAR(10),
    @KhachHangThanThiet INT
AS
BEGIN
    INSERT INTO KhachHang (HoTen, SoDienThoai, KhachHangThanThiet)
    VALUES (@HoTen, @SoDienThoai, @KhachHangThanThiet)
END;

-- Sửa thông tin khách hàng
CREATE PROCEDURE SuaKhachHang 
    @MaKhachHang INT,
    @HoTen NVARCHAR(50),
    @SoDienThoai VARCHAR(10),
    @KhachHangThanThiet INT
AS
BEGIN
    UPDATE KhachHang
    SET HoTen = @HoTen,
        SoDienThoai = @SoDienThoai,
        KhachHangThanThiet = @KhachHangThanThiet
    WHERE MaKhachHang = @MaKhachHang
END;

-- Xóa khách hàng
CREATE PROCEDURE XoaKhachHang 
    @MaKhachHang INT
AS
BEGIN
    DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang
END;
-----------------------------------------------------------

-- Thêm tài khoản mới
CREATE PROCEDURE ThemTaiKhoan 
    @TenTaiKhoan NVARCHAR(25),
    @MatKhau NVARCHAR(30),
    @VaiTro INT,
    @HoTen NVARCHAR(30),
    @SoDienThoai NVARCHAR(15),
    @Email NVARCHAR(30)
AS
BEGIN
    INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, VaiTro, HoTen, SoDienThoai, Email)
    VALUES (@TenTaiKhoan, @MatKhau, @VaiTro, @HoTen, @SoDienThoai, @Email)
END;

-- Sửa thông tin tài khoản
CREATE PROCEDURE SuaTaiKhoan 
    @MaTaiKhoan INT,
    @TenTaiKhoan NVARCHAR(25),
    @MatKhau NVARCHAR(30),
    @VaiTro INT,
    @HoTen NVARCHAR(30),
    @SoDienThoai NVARCHAR(15),
    @Email NVARCHAR(30)
AS
BEGIN
    UPDATE TaiKhoan
    SET TenTaiKhoan = @TenTaiKhoan,
        MatKhau = @MatKhau,
        VaiTro = @VaiTro,
        HoTen = @HoTen,
        SoDienThoai = @SoDienThoai,
        Email = @Email
    WHERE MaTaiKhoan = @MaTaiKhoan
END;

-- Xóa tài khoản
CREATE PROCEDURE XoaTaiKhoan 
    @MaTaiKhoan INT
AS
BEGIN
    DELETE FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan
END;

-------------------------------------------------------

-- Thêm phiếu nhập mới
CREATE PROCEDURE ThemPhieuNhap 
    @NgayNhap DATE,
    @NguoiNhap NVARCHAR(25)
AS
BEGIN
    INSERT INTO PhieuNhap (NgayNhap, NguoiNhap)
    VALUES (@NgayNhap, @NguoiNhap)
END;

-- Thêm chi tiết phiếu nhập
CREATE PROCEDURE ThemChiTietPhieuNhap 
    @MaPhieuNhap INT,
    @MaThuoc INT,
    @SoLuong INT
AS
BEGIN
    INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaThuoc, SoLuong)
    VALUES (@MaPhieuNhap, @MaThuoc, @SoLuong)
END;

-------------------------------------------------------

-- Thêm phiếu xuất mới
CREATE PROCEDURE ThemPhieuXuat 
    @NgayXuat DATE,
    @NguoiXuat NVARCHAR(25)
AS
BEGIN
    INSERT INTO PhieuXuat (NgayXuat, NguoiXuat)
    VALUES (@NgayXuat, @NguoiXuat)
END;

-- Thêm chi tiết phiếu xuất
CREATE PROCEDURE ThemChiTietPhieuXuat 
    @MaPhieuXuat INT,
    @MaThuoc INT,
    @SoLuong INT
AS
BEGIN
    INSERT INTO ChiTietPhieuXuat (MaPhieuXuat, MaThuoc, SoLuong)
    VALUES (@MaPhieuXuat, @MaThuoc, @SoLuong)
END;

--------------------------------------------------------

-- Thêm hóa đơn mới
CREATE PROCEDURE ThemHoaDon 
    @MaTaiKhoan INT,
    @NgayBan DATETIME,
    @TongTien DECIMAL(18,2),
    @MaKhachHang INT,
    @GiamGia INT
AS
BEGIN
    INSERT INTO HoaDon (MaTaiKhoan, NgayBan, TongTien, MaKhachHang, GiamGia)
    VALUES (@MaTaiKhoan, @NgayBan, @TongTien, @MaKhachHang, @GiamGia)
END;

-- Thêm chi tiết hóa đơn
CREATE PROCEDURE ThemChiTietHoaDon 
    @MaHoaDon INT,
    @MaThuoc INT,
    @SoLuong INT,
    @DonGia INT,
    @ThanhTien INT
AS
BEGIN
    INSERT INTO ChiTietHoaDon (MaHoaDon, MaThuoc, SoLuong, DonGia, ThanhTien)
    VALUES (@MaHoaDon, @MaThuoc, @SoLuong, @DonGia, @ThanhTien)
END;
