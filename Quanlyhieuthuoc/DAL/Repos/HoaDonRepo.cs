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

        public DataTable HienThiDanhSach(ref string error)
        {
            try
            {
                string query = "select * from HoaDon";
                return database.GetData(query, ref error);
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
