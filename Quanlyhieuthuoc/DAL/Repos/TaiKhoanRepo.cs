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
        public DataTable HienThiDanhSach(ref string error)
        {
            string query = "Select * from TaiKhoan";
            return Constants.Procedures.Instance.ExecuteQuery(query, ref error);
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

        public int KiemTraDangNhap(string tenTaiKhoan, string matKhau)
        {
            int vaiTro = 0;

            string connectionString = "";
            SqlConnection connection = null;

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("KiemTraTaiKhoan", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    var vaiTroParameter = new SqlParameter("@VaiTro", SqlDbType.Int);
                    vaiTroParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(vaiTroParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    vaiTro = Convert.ToInt32(command.Parameters["@VaiTro"].Value);
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
