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
    public class TaiKhoanRepo
    {
        Database database = new Database();

        public DataTable HienThiDanhSach(ref string error)
        {
            try
            {
                string sql = "select TenTaiKhoan, HoTen, VaiTro from TaiKhoan";
                DataTable dt = new DataTable();
                dt = database.GetData(sql, ref error);
                return dt;
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                return null;
            }
        }

        public bool ThemTaiKhoan(TaiKhoanEntity taikhoan, ref string error)
        {
            string procedureName = "ThemTaiKhoan";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTaiKhoan", taikhoan.TenTaiKhoan),
                new SqlParameter("@MatKhau", taikhoan.MatKhau),
                new SqlParameter("@VaiTro", taikhoan.VaiTro),
                new SqlParameter("@HoTen", taikhoan.HoTen),
            };
            return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
        }

        public bool SuaTaiKhoan(TaiKhoanEntity taikhoan, ref string error)
        {
            string procedureName = "SuaTaiKhoan";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTaiKhoan", taikhoan.TenTaiKhoan),
                new SqlParameter("@MatKhau", taikhoan.MatKhau),
                new SqlParameter("@VaiTro", taikhoan.VaiTro),
                new SqlParameter("@HoTen", taikhoan.HoTen),
            };
            return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
        }

        public bool XoaTaiKhoan(string tenTaiKhoan, ref string error)
        {
            string query = "XoaTaiKhoan";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTaiKhoan", tenTaiKhoan),
            };
            return database.ExecuteNonQuery(query, CommandType.StoredProcedure, ref error, parameters);
        }

        public string[] KiemTraDangNhap(string tenTaiKhoan, string matKhau, ref string error)
        {
            string[] taikhoan = { };
            error = "";

            try
            {
                SqlParameter[] parameters = new SqlParameter[2]
                {
                    new SqlParameter("@TenTaiKhoan", tenTaiKhoan),
                    new SqlParameter("@MatKhau", matKhau)
                };

                DataTable dataTable = database.ExecuteReader("KiemTraTaiKhoan", CommandType.StoredProcedure, ref error, parameters);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    taikhoan[0] = dataTable.Rows[0]["VaiTro"].ToString();
                    taikhoan[1] = dataTable.Rows[0]["HoTen"].ToString();
                    Console.WriteLine(taikhoan[0]);
                    Console.WriteLine(taikhoan[1]);
                    return taikhoan;
                } else
                {
                    return [];
                }

            }
            catch (Exception ex)
            {
                error = "Lỗi: " + ex.Message;
                return [];
            }
        }
    }
}
