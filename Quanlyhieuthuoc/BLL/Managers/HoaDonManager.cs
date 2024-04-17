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
    public class HoaDonManager
    {
        private HoaDonRepo process;

        public HoaDonManager()
        {
            process = new HoaDonRepo();
        }

        public DataTable HienThiDanhSach(ref string error)
        {
            return process.HienThiDanhSach(ref error);
        }

        public int ThemHoaDon(HoaDonEntity entity, ref string error)
        {
            return process.ThemHoaDon(entity, ref error);
        }

        public bool ThemCTHD(ChiTietHoaDonEntity entity, ref string error)
        {
            return process.ThemCTHD(entity, ref error);
        }
    }
}
