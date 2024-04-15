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
    public class ThuocManager
    {
        private ThuocRepo process;

        public ThuocManager()
        {
            process = new ThuocRepo();
        }

        public DataTable hienThiDanhSach(ref string error)
        {
            return process.HienThiDanhSach(ref error);
        }

        public bool ThemThuoc(ThuocEntity entity, ref string error)
        {
            return process.ThemThuoc(entity, ref error);
        }

        public bool SuaThuoc(ThuocEntity entity, ref string error)
        {
            return process.SuaThuoc(entity, ref error);
        }

        public bool XoaThuoc(int maThuoc, ref string error)
        {
            return process.XoaThuoc(maThuoc, ref error);
        }
    }
}
