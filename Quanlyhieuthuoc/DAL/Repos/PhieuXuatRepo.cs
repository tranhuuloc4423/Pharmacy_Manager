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
    public class PhieuXuatRepo
    {
        Database database = new Database();

        public DataTable HienThiDanhSach(ref string error)
        {
            try
            {
                string query = "select * from PhieuXuat";
                return database.GetData(query, ref error);
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                throw;
            }
        }

        public int ThemPhieuXuat(PhieuXuatEntity entity, ref string error)
        {
            try
            {
                string procedureName = "ThemPhieuXuat";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@NguoiXuat", entity.NguoiXuat),
                };
                string output = "@MaPhieuXuat";
                return database.ThemPhieu(procedureName, ref error, output, parameters);
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                return 0;
                throw;
            }
        }

        public bool ThemCTPX(ChiTietPhieuXuatEntity entity, ref string error)
        {
            try
            {
                string procedureName = "ThemChiTietPhieuXuat";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaPhieuXuat", entity.MaPhieuXuat),
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
