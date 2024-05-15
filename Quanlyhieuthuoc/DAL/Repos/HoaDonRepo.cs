using DAL.Entities;
using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class HoaDonRepo
    {
        private Database database = new Database();

        public DataTable HienThiDanhSachHoaDon(DateTime TuNgay, DateTime DenNgay, ref string error)
        {
            try
            {
                string sql = "SELECT HD.MaHoaDon, HD.TenTaiKhoan, HD.NgayBan, KH.HoTen, HD.TongTien " +
                            " FROM HoaDon HD " + 
                            " INNER JOIN KhachHang KH on HD.MaKhachHang = KH.MaKhachHang " +
                            " WHERE HD.NgayBan >= @TuNgay AND HD.NgayBan <= @DenNgay";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TuNgay", TuNgay),
                    new SqlParameter("@DenNgay", DenNgay)
                };
                return database.GetData(sql, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                return null;
            }
        }

        public DataTable HienThiDanhSachChiTietHoaDon(int MaHoaDon, ref string error)
        {
            try
            {
                string sql = "SELECT T.TenThuoc, T.DonViTinh, CT.SoLuong, CT.DonGia, CT.ThanhTien " +
                            "FROM ChiTietHoaDon CT " +
                            "INNER JOIN Thuoc T on CT.MaThuoc = T.MaThuoc " +
                            "where CT.MaHoaDon = @MaHoaDon";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaHoaDon", MaHoaDon)
                };
                return database.GetData(sql, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                return null;
            }
        }
        public int ThemHoaDon(HoaDonEntity entity, ref string error)
        {
            try
            {
                string procedureName = "ThemHoaDon";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TenTaiKhoan", entity.TenTaiKhoan),
                    new SqlParameter("@MaKhachHang", entity.MaKhachHang)
                };
                string output = "@MaHoaDon";
                return database.ThemPhieu(procedureName, ref error, output, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                return 0;
            }
        }

        public bool ThemCTHD(ChiTietHoaDonEntity entity, ref string error)
        {
            try
            {
                string procedureName = "ThemChiTietHoaDon";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaHoaDon", entity.MaHoaDon),
                    new SqlParameter("@MaThuoc", entity.MaThuoc),
                    new SqlParameter("@SoLuong", entity.SoLuong),
                    new SqlParameter("@DonGia", entity.DonGia)
                };
                return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                return false;
            }
        }
    }
}
