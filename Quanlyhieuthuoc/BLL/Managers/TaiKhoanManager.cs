using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class TaiKhoanManager
    {
        private TaiKhoanRepo process;

        public TaiKhoanManager()
        {
            process = new TaiKhoanRepo();
        }

        public int KiemTraDangNhap(string taikhoan, string matkhau)
        {

            return process.KiemTraDangNhap(taikhoan, matkhau);
        }
    }
}
