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
    public class PhieuXuatManager
    {
        private PhieuXuatRepo process;

        public PhieuXuatManager()
        {
            process = new PhieuXuatRepo();
        }

        public DataTable HienThiDanhSach(ref string error)
        {
            return process.HienThiDanhSach(ref error);
        }

        public int ThemPhieuXuat(PhieuXuatEntity entity, ref string error)
        {
            return process.ThemPhieuXuat(entity, ref error);
        }

        public bool ThemCTPX(ChiTietPhieuXuatEntity entity, ref string error)
        {
            return process.ThemCTPX(entity, ref error);
        }
    }
}
