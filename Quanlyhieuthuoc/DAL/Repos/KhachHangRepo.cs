using DAL.Entities;
using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class KhachHangRepo
    {
        private Database database = new Database();

        public DataTable HienThiDanhSach(ref string error)
        {
            try
            {
                string sql = "select * from KhachHang";
                DataTable dt = new DataTable();
                dt = database.GetData(sql, ref error);
                return dt;
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                throw;
            }
        }

        public bool ThemKhachHang(KhachHangEntity entity, ref string error)
        {
            try
            {
                string procedureName = "ThemKhachHang";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@HoTen", entity.HoTen),
                    new SqlParameter("@SoDienThoai", entity.SoDienThoai)
                };
                return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                throw;
            }

        }

        public bool SuaKhachHang(KhachHangEntity entity, ref string error)
        {
            try
            {
                string procedureName = "SuaKhachHang";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaKhachHang", entity.MaKhachHang),
                    new SqlParameter("@HoTen", entity.HoTen),
                    new SqlParameter("@SoDienThoai", entity.SoDienThoai)
                };
                return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                throw;
            }
        }

        public bool XoaKhachHang(int maKhachHang, ref string error)
        {
            try
            {
                string procedureName = "XoaKhachHang";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaKhachHang", maKhachHang)
                };
                return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                throw;
            }

        }
    }
}
