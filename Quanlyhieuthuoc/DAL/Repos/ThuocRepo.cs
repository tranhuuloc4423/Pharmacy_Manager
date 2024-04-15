using DAL.Entities;
using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL.Repos
{
    public class ThuocRepo
    {
        private Database database = new Database();

        public DataTable HienThiDanhSach(ref string error)
        {
            try
            {
                string sql = "select MaThuoc, TenLoaiThuoc, TenThuoc, DonViTinh, GiaBan from Thuoc inner join PhanLoai on Thuoc.MaLoaiThuoc = PhanLoai.MaLoaiThuoc";
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

        public bool ThemThuoc(ThuocEntity entity, ref string error)
        {
            try
            {
                string procedureName = "ThemThuoc";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaLoaiThuoc", entity.MaLoaiThuoc),
                    new SqlParameter("@TenThuoc", entity.TenThuoc),
                    new SqlParameter("@DonViTinh", entity.DonViTinh),
                    new SqlParameter("@GiaBan", entity.GiaBan)
                };
                return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                throw;
            }
            
        }

        public bool SuaThuoc(ThuocEntity entity, ref string error)
        {
            try
            {
                string procedureName = "SuaThuoc";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaThuoc", entity.MaThuoc),
                    new SqlParameter("@MaLoaiThuoc", entity.MaLoaiThuoc),
                    new SqlParameter("@TenThuoc", entity.TenThuoc),
                    new SqlParameter("@DonViTinh", entity.DonViTinh),
                    new SqlParameter("@GiaBan", entity.GiaBan)
                };
                return database.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, ref error, parameters);
            }
            catch (Exception ex)
            {
                error = "Loi : " + ex.Message;
                throw;
            }
        }

        public bool XoaThuoc(int maThuoc, ref string error)
        {
            try
            {
                string procedureName = "XoaThuoc";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaThuoc", maThuoc)
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
