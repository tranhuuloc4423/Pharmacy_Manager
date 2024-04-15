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
    public class NhaCungCapRepo
    {
        private Database database = new Database();

        public DataTable HienThiDanhSach(ref string error)
        {
            try
            {
                string sql = "select * from NhaCungCap";
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

        public bool ThemNCC(NhaCungCapEntity entity, ref string error)
        {
            try
            {
                string procedureName = "ThemNhaCungCap";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@TenNhaCungCap", entity.TenNhaCungCap),
                    new SqlParameter("@DiaChi", entity.DiaChi),
                };
                return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                throw;
            }

        }

        public bool SuaNCC(NhaCungCapEntity entity, ref string error)
        {
            try
            {
                string procedureName = "SuaNhaCungCap";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaNhaCungCap", entity.MaNhaCungCap),
                    new SqlParameter("@TenNhaCungCap", entity.TenNhaCungCap),
                    new SqlParameter("@DiaChi", entity.DiaChi),
                };
                return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                throw;
            }
        }

        public bool XoaNCC(int maNCC, ref string error)
        {
            try
            {
                string procedureName = "XoaNhaCungCap";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaNhaCungCap", maNCC)
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
