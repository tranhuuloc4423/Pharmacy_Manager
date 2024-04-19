using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class KhoThuocRepo
    {
        private Database database = new Database();

        public DataTable HienThiDanhSach(ref string error)
        {
            try
            {
                string query = "select Thang, Nam, TenThuoc, DauKy, NhapTrongKy, XuatTrongThang, TonKho from KhoThuoc inner join Thuoc on KhoThuoc.MaThuoc = Thuoc.MaThuoc";
                return database.GetData(query, ref error);
            }   
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                return null;
            }
        }
    }
}
