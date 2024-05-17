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
            if (string.IsNullOrEmpty(entity.TenNhaCungCap))
            {
                error = "Vui lòng nhập tên nhà cung cấp!";
                return false;
            }

            if (string.IsNullOrEmpty(entity.DiaChi))
            {
                error = "Vui lòng nhập địa chỉ nhà cung cấp!";
                return false;
            }
            return process.ThemNCC(entity, ref error);
        }

        public bool SuaNCC(NhaCungCapEntity entity, ref string error)
        {
            if (string.IsNullOrEmpty(entity.TenNhaCungCap))
            {
                error = "Vui lòng nhập tên nhà cung cấp!";
                return false;
            }

            if (string.IsNullOrEmpty(entity.DiaChi))
            {
                error = "Vui lòng nhập địa chỉ nhà cung cấp!";
                return false;
            }
            return process.SuaNCC(entity, ref error);
        }

        public bool XoaNCC(int maNCC, ref string error)
        {
            if (maNCC == 0)
            {
                error = "Vui lòng nhập mã nhà cung cấp!";
                return false;
            }
            return process.XoaNCC(maNCC, ref error);
        }
    }
}
