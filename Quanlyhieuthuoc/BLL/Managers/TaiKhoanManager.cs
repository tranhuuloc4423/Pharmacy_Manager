using DAL.Entities;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable hienThiDanhSachTaiKhoan(ref string error)
        {
            return process.HienThiDanhSach(ref error);
        }

        public string[] KiemTraDangNhap(string taikhoan, string matkhau, ref string error)
        {
            return process.KiemTraDangNhap(taikhoan, matkhau,ref error);
        }

        public bool ThemTaiKhoan(TaiKhoanEntity taiKhoan, ref string error)
        {
            return process.ThemTaiKhoan(taiKhoan, ref error);
        }

        public bool SuaTaiKhoan(TaiKhoanEntity taiKhoan, ref string error)
        {
            return process.SuaTaiKhoan(taiKhoan, ref error);
        }

        public bool XoaTaiKhoan(string tenTaiKhoan, ref string error)
        {
            return process.XoaTaiKhoan(tenTaiKhoan, ref error);
        }
    }
}
