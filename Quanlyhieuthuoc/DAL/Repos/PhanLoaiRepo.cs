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
    public class PhanLoaiRepo
    {
        private Database database = new Database();

        public DataTable HienThiDanhSach(ref string error)
        {
            try
            {
                string sql = "select * from PhanLoai";
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

        public bool ThemLoaiThuoc(PhanLoaiEntity entity, ref string error)
        {
            try
            {
                string procedureName = "ThemPhanLoai";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@TenLoaiThuoc", entity.TenLoaiThuoc),
                };
                return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                throw;
            }

        }

        public bool SuaLoaiThuoc(PhanLoaiEntity entity, ref string error)
        {
            try
            {
                string procedureName = "SuaPhanLoai";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaLoaiThuoc", entity.MaLoaiThuoc),
                    new SqlParameter("@MaLoaiThuoc", entity.MaLoaiThuoc),
                };
                return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                throw;
            }
        }

        public bool XoaLoaiThuoc(int maPhanLoai, ref string error)
        {
            try
            {
                string procedureName = "XoaPhanLoai";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaLoaiThuoc", maPhanLoai)
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
