using DAL.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TaiKhoanRepo
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
    }
}
