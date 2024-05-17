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
    public class NhaCungCapManager
    {
        private NhaCungCapRepo process;

        public NhaCungCapManager()
        {
            process = new NhaCungCapRepo();
        }

        public DataTable HienThiDanhSach(ref string error)
        {
            return process.HienThiDanhSach(ref error);
        }

        public DataTable HienThiDanhSachTen(ref string error)
        {
            return process.HienThiDanhSachTen(ref error);
        }

        public bool ThemNCC(NhaCungCapEntity entity, ref string error)
        {
            return process.ThemNCC(entity, ref error);
        }

        public bool SuaNCC(NhaCungCapEntity entity, ref string error)
        {
            return process.SuaNCC(entity, ref error);
        }

        public bool XoaNCC(int maNCC, ref string error)
        {
            return process.XoaNCC(maNCC, ref error);
        }
    }
}
