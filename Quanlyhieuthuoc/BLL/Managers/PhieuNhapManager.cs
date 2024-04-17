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
    public class PhieuNhapManager
    {
        private PhieuNhapRepo process;

        public PhieuNhapManager()
        {
            process = new PhieuNhapRepo();
        }

        public DataTable HienThiDanhSach(ref string error)
        {
            return process.HienThiDanhSach(ref error);
        } 

        public int ThemPhieuNhap(PhieuNhapEntity entity, ref string error)
        {
            return process.ThemPhieuNhap(entity, ref error);
        }

        public bool ThemCTPN(ChiTietPhieuNhapEntity entity, ref string error)
        {
            return process.ThemCTPN(entity, ref error);
        }
    }
}
