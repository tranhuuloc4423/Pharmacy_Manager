using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class QuyenRepo
    {
        Database database = new Database();

        public DataTable HienThiDanhSach(ref string error)
        {
            string sql = "select * from QuyenDangNhap";
            return database.GetData(sql, ref error);
        }
    }
}
