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

/****************** XEM HOA DON CUA NGUOI BAN  ******************/
GO
CREATE PROCEDURE XemHoaDon
(
  @TenTaiKhoan NVARCHAR(25)
)
AS
BEGIN
  SELECT *
  FROM HoaDon
  WHERE TenTaiKhoan = @TenTaiKhoan;
END;

/****************** XEM CHI TIET HOA DON CUA NGUOI BAN  ******************/

GO
CREATE PROCEDURE XemChiTietHoaDon
(
  @TenTaiKhoan NVARCHAR(25)
)
AS
BEGIN
  SELECT h.MaHoaDon, h.NgayBan, h.TongTien,
         t.TenThuoc, t.DonViTinh, ct.SoLuong, ct.DonGia
  FROM HoaDon h
  INNER JOIN ChiTietHoaDon ct ON h.MaHoaDon = ct.MaHoaDon
  INNER JOIN Thuoc t ON ct.MaThuoc = t.MaThuoc
  WHERE h.TenTaiKhoan = @TenTaiKhoan;
END;
GO
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

/****************** Thêm phiếu nhập và thêm chi tiết phiếu nhập  ******************/
CREATE PROCEDURE ThemPhieuNhap
(
	@NgayNhap DATE,
	@NguoiNhap NVARCHAR(25)
)
AS
BEGIN
	INSERT INTO PhieuNhap (NgayNhap, NguoiNhap)
	VALUES (@NgayNhap, @NguoiNhap)
END
GO
--thêm chi tiết phiếu nhập
CREATE PROCEDURE ThemChiTietPhieuNhap
(
	@MaPhieuNhap INT,
	@MaThuoc INT,
	@SoLuong INT
)
AS
BEGIN

	DECLARE @Thang INT, @Nam INT, @TonKho INT

	-- Lấy tháng và năm từ ngày nhập
	SELECT @Thang = MONTH(NgayNhap)
	FROM PhieuNhap
	WHERE MaPhieuNhap = @MaPhieuNhap

	SELECT @Nam = YEAR(NgayNhap)
	FROM PhieuNhap
	WHERE MaPhieuNhap = @MaPhieuNhap

	-- Kiểm tra xem đã có loại thuốc này trong bảng kho thuốc chưa
	IF EXISTS (SELECT * FROM KhoThuoc WHERE MaThuoc = @MaThuoc AND Thang = @Thang AND Nam = @Nam)
	BEGIN
		-- Cập nhật số lượng nhập trong tháng và tồn kho
		UPDATE KhoThuoc
		SET NhapTrongKy = NhapTrongKy + @SoLuong,
			TonKho = TonKho + @SoLuong
		WHERE MaThuoc = @MaThuoc AND Thang = @Thang AND Nam = @Nam
	END
	ELSE
	BEGIN
		-- Thêm mới thông tin vào bảng kho thuốc
		INSERT INTO KhoThuoc (Thang, Nam, MaThuoc, DauKy, NhapTrongKy, XuatTrongThang, TonKho)
		VALUES (@Thang, @Nam, @MaThuoc, 0, @SoLuong, 0, @SoLuong)
	END

	-- Thêm mới chi tiết phiếu nhập
	INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaThuoc, SoLuong)
	VALUES (@MaPhieuNhap, @MaThuoc, @SoLuong)

END
GO


/****************** Thêm phiếu nhập và Them chi tiết phiếu xuất  ******************/
CREATE PROCEDURE ThemPhieuXuat
(
	@NgayXuat DATE,
	@NguoiXuat NVARCHAR(25)
)
AS
BEGIN
	INSERT INTO PhieuXuat (NgayXuat, NguoiXuat)
	VALUES (@NgayXuat, @NguoiXuat)
END
GO
--Them chi tiết phiếu xuất
CREATE PROCEDURE ThemChiTietPhieuXuat
(
	@MaPhieuXuat INT,
	@MaThuoc INT,
	@SoLuong INT
)
AS
BEGIN

	DECLARE @Thang INT, @Nam INT, @TonKho INT

	-- Lấy tháng và năm từ ngày xuất
	SELECT @Thang = MONTH(NgayXuat)
	FROM PhieuXuat
	WHERE MaPhieuXuat = @MaPhieuXuat

	SELECT @Nam = YEAR(NgayXuat)
	FROM PhieuXuat
	WHERE MaPhieuXuat = @MaPhieuXuat

	-- Kiểm tra xem đã có loại thuốc này trong bảng kho thuốc chưa
	IF EXISTS (SELECT * FROM KhoThuoc WHERE MaThuoc = @MaThuoc AND Thang = @Thang AND Nam = @Nam)
	BEGIN
		-- Kiểm tra số lượng xuất
		SELECT @TonKho = TonKho
		FROM KhoThuoc
		WHERE MaThuoc = @MaThuoc AND Thang = @Thang AND Nam = @Nam

		IF @SoLuong > @TonKho
		BEGIN
			-- Số lượng xuất lớn hơn tồn kho, thông báo lỗi, không cho xuất, hiện form lỗi,...
			RAISERROR('Số lượng thanh toán vượt quá số lượng tồn kho!', 16,1)
			RETURN
		END

		-- Cập nhật số lượng xuất trong tháng và tồn kho
		UPDATE KhoThuoc
		SET XuatTrongThang = XuatTrongThang + @SoLuong,
			TonKho = TonKho - @SoLuong
		WHERE MaThuoc = @MaThuoc AND Thang = @Thang AND Nam = @Nam

		/*IF @TonKho = 0
		BEGIN
			-- Xóa hàng thuốc nếu tồn kho bằng 0, nhưng đã bị lỗi gì đó và không hoạt động được, để đây nếu cần phát triển tính năng này
			DELETE  FROM KhoThuoc
			WHERE MaThuoc = @MaThuoc AND Thang = @Thang AND Nam = @Nam
			hoặc WHERE @TonKho = 0
		END*/
	END

	/*ELSE
	BEGIN
		-- Thêm mới thông tin vào bảng kho thuốc nếu cần
		INSERT INTO KhoThuoc (Thang, Nam, MaThuoc, DauKy, NhapTrongKy, XuatTrongThang, TonKho)
		VALUES (@Thang, @Nam, @MaThuoc, 0, 0, @SoLuong, -@SoLuong)
	END*/
	-- Thêm mới chi tiết phiếu xuất
	INSERT INTO ChiTietPhieuXuat (MaPhieuXuat, MaThuoc, SoLuong)
	VALUES (@MaPhieuXuat, @MaThuoc, @SoLuong)
END
GO
/****************** Hóa đơn và chi tiết hóa đơn  ******************/
CREATE PROCEDURE ThemHoaDon
(
	@MaTaiKhoan INT,
	@NgayBan DATETIME,
	@MaKhachHang INT
)
AS
BEGIN

	-- Thêm hóa đơn vào bảng HoaDon
	DECLARE @GiamGia INT
	SET @GiamGia = (SELECT CASE WHEN KhachHangThanThiet = 1 THEN 10 ELSE 0 END FROM KhachHang WHERE MaKhachHang = @MaKhachHang)

	INSERT INTO HoaDon (MaTaiKhoan, NgayBan, MaKhachHang, GiamGia, TongTien)
	VALUES (@MaTaiKhoan, @NgayBan, @MaKhachHang, @GiamGia, 0)
END
GO
-- Thêm chi tiết hóa đơn
CREATE PROCEDURE ThemChiTietHoaDon
(
	@MaHoaDon INT,
	@MaThuoc INT,
	@SoLuong INT,
	@DonGia INT,
)
AS
BEGIN
	-- Tính thành tiền
	DECLARE @ThanhTien DECIMAL(18,2) 
	SET @ThanhTien = @SoLuong * @DonGia

	-- Lấy giá trị giảm giá
	DECLARE @GiamGia INT
	SET @GiamGia = (SELECT GiamGia FROM HoaDon WHERE MaHoaDon = @MaHoaDon);

	-- Cập nhật thành tiền nếu có giảm giá
	IF @GiamGia = 10
	BEGIN
		SET @ThanhTien = @ThanhTien * 0.9;
	END

	-- Thêm chi tiết hóa đơn
	INSERT INTO ChiTietHoaDon (MaHoaDon, MaThuoc, SoLuong, DonGia, ThanhTien)
	VALUES (@MaHoaDon, @MaThuoc, @SoLuong, @DonGia, @SoLuong*@DonGia)

	-- Cập nhật tổng tiền
	DECLARE @TongTien DECIMAL(18,2)
	SET @TongTien = (SELECT SUM(ThanhTien) FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon);

	UPDATE HoaDon
	SET TongTien = @TongTien
	WHERE MaHoaDon = @MaHoaDon;

	-- Cập nhật điểm mua tích lũy
	DECLARE @MuaTichLuy DECIMAL(18,2) 
	SET @MuaTichLuy = (SELECT MuaTichLuy FROM KhachHang WHERE MaKhachHang = (SELECT MaKhachHang FROM HoaDon WHERE MaHoaDon = @MaHoaDon));
	SET @MuaTichLuy = @MuaTichLuy + @ThanhTien;

	UPDATE KhachHang
	SET MuaTichLuy = @MuaTichLuy
	WHERE MaKhachHang = (SELECT MaKhachHang FROM HoaDon WHERE MaHoaDon = @MaHoaDon);

	-- Thêm chi tiết phiếu xuất
	EXEC ThemChiTietPhieuXuat @MaHoaDon, @MaThuoc, @SoLuong
END
GO

--------------------------- Khách Hàng ---------------------------
CREATE PROCEDURE ThemKhachHang
    @HoTen NVARCHAR(50),
    @SoDienThoai VARCHAR(10),
    @KhachHangThanThiet INT,
    @MuaTichLuy DECIMAL(18,2)
AS
BEGIN
    INSERT INTO KhachHang (HoTen, SoDienThoai, KhachHangThanThiet, MuaTichLuy)
    VALUES (@HoTen, @SoDienThoai, @KhachHangThanThiet, @MuaTichLuy)
END

GO

CREATE PROCEDURE SuaKhachHang
    @MaKhachHang INT,
    @HoTen NVARCHAR(50),
    @SoDienThoai VARCHAR(10),
    @KhachHangThanThiet INT,
    @MuaTichLuy DECIMAL(18,2)
AS
BEGIN
    UPDATE KhachHang
    SET HoTen = @HoTen,
        SoDienThoai = @SoDienThoai,
        KhachHangThanThiet = @KhachHangThanThiet,
        MuaTichLuy = @MuaTichLuy
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