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
    public class KhachHangManager
    {
        private KhachHangRepo process;

        public KhachHangManager()
        {
            process = new KhachHangRepo();
        }

        public DataTable HienThiDanhSach(ref string error)
        {
            return process.HienThiDanhSach(ref error);
        }

        public bool ThemKhachHang(KhachHangEntity entity, ref string error)
        {
            return process.ThemKhachHang(entity, ref error);
        }

        public bool SuaKhachHang(KhachHangEntity entity, ref string error)
        {
            return process.SuaKhachHang(entity, ref error);
        }

        public bool XoaKhachHang(int maKhachHang, ref string error)
        {
            return process.XoaKhachHang(maKhachHang, ref error);
        }
    }
}
