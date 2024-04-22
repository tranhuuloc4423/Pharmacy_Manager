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
    public class PhanLoaiManager
    {
        private PhanLoaiRepo process;

        public PhanLoaiManager()
        {
            process = new PhanLoaiRepo();
        }

        public DataTable HienThiDanhSach(ref string error)
        {
            return process.HienThiDanhSach(ref error);
        }

        public bool ThemLoaiThuoc(PhanLoaiEntity entity, ref string error)
        {
            if (string.IsNullOrEmpty(entity.TenLoaiThuoc) == true)
            {
                error = "Vui lòng nhập tên loại thuốc!";
                return false;
            }
            return process.ThemLoaiThuoc(entity, ref error);
        }

        public bool SuaLoaiThuoc(PhanLoaiEntity entity, ref string error)
        {
            if (string.IsNullOrEmpty(entity.TenLoaiThuoc) == true)
            {
                error = "Vui lòng nhập tên loại thuốc!";
                return false;
            }
            return process.SuaLoaiThuoc(entity, ref error);
        }

        public bool XoaLoaiThuoc(int maLoaiThuoc, ref string error)
        {
            return process.XoaLoaiThuoc(maLoaiThuoc, ref error);
        }
    }
}
