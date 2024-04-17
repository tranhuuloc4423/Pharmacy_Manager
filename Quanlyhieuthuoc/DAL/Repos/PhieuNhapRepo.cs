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
    public class PhieuNhapRepo
    {
        Database database = new Database();

        public DataTable HienThiDanhSach(ref string error)
        {
            try
            {
                string query = "select * from PhieuNhap";
                return database.GetData(query, ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                throw;
            }
        }

        public int ThemPhieuNhap(PhieuNhapEntity entity, ref string error)
        {
            //string connectionStr = "";
            //SqlConnection connection = null;
            try
            {
                //using (connection = new SqlConnection(connectionStr))
                //{
                //    connection.Open();
                //    SqlCommand command = new SqlCommand("ThemPhieuNhap", connection);
                //    command.CommandType = CommandType.StoredProcedure;
                //    command.Parameters.AddWithValue("@NgayNhap", DateTime.Now);
                //    command.Parameters.AddWithValue("@NguoiNhap", entity.NguoiNhap);
                //    command.Parameters.AddWithValue("@MaNhaCungCap", entity.MaNhaCungCap);

                //    SqlParameter maPhieuNhapParameter = new SqlParameter("@MaPhieuNhap", SqlDbType.Int);
                //    maPhieuNhapParameter.Direction = ParameterDirection.Output;
                //    command.Parameters.Add(maPhieuNhapParameter);

                //    command.ExecuteNonQuery();

                //    return (int)command.Parameters["@MaPhieuNhap"].Value;
                //}
                string procedureName = "ThemPhieuNhap";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@NguoiNhap", entity.NguoiNhap),
                    new SqlParameter("@MaNhaCungCap", entity.MaNhaCungCap)
                };
                string output = "@MaPhieuNhap";
                return database.ThemPhieu(procedureName, ref error, output, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                return 0;
                throw;
            }
        }

        public bool ThemCTPN(ChiTietPhieuNhapEntity entity, ref string error)
        {
            try
            {
                string procedureName = "ThemChiTietPhieuNhap";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaPhieuNhap", entity.MaPhieuNhap),
                    new SqlParameter("@MaThuoc", entity.MaThuoc),
                    new SqlParameter("@SoLuong", entity.SoLuong)
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
