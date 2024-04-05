using DAL.Constants;
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
        //public DataTable HienThiDanhSach(ref string error)
        //{
        //    string query = "Select * from TaiKhoan";
        //    return Constants.Procedures.Instance.ExecuteQuery(query, ref error);
        //}
        private string connectionSTR = "Data Source=ROKU\\SQLEXPRESS;Initial Catalog=Project_QLTT;Integrated Security=True;";

        public DataTable HienThiDanhSach(ref string error)
        {
            using var command = new SqlCommand();
            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "select TenTaiKhoan, HoTen, VaiTro from TaiKhoan";
                    using var reader = command.ExecuteReader();
                    DataTable data = new DataTable();
                    if (reader.HasRows)
                    {
                        data.Load(reader);
                        error = "";
                        return data;
                    }
                    else
                    {
                        error = "Khong co du lieu";
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                error = "Ket noi loi : " + ex.Message;
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool ThemTaiKhoan(ref string error)
        {
            string query = "";
            int ketqua = Constants.Procedures.Instance.ExecuteNonQuery(query, ref error);

            return ketqua > 0;
        }

        public bool XoaTaiKhoan(ref string error)
        {
            string query = "";
            int ketqua = Constants.Procedures.Instance.ExecuteNonQuery(query, ref error);
            return ketqua > 0;
        }

        public int KiemTraDangNhap(string tenTaiKhoan, string matKhau, ref string error)
        {
            int vaiTro = 0;
            SqlConnection connection = null;

            try
            {
                using (connection = new SqlConnection(connectionSTR))
                {
                    SqlCommand command = new SqlCommand("KiemTraTaiKhoan", connection);
                    command.CommandText = "SELECT CASE WHEN MatKhau = @MatKhau THEN VaiTro ELSE 0 END AS KetQua FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                    connection.Open();
                    object data = command.ExecuteScalar();
                }

                return vaiTro;
            }
            catch (Exception ex)
            {
                return 0;
                throw;
            }
            finally
            {
                connection.Close();
            }
            
        }
    }
}
