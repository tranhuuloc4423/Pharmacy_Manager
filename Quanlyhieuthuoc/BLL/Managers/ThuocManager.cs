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

        public DataTable HienThiDanhSachThuoc(ref string error)
        {
            return process.HienThiDanhSachThuoc(ref error);
        }

        public DataTable HienThiDanhSachKhoThuoc(ref string error)
        {
            return process.HienThiDanhSachKhoThuoc(ref error);
        }

        public DataTable HienThiDanhSachMaVaTen(ref string error)
        {
            return process.HienThiDanhSachMaVaTen(ref error);
        }

        public bool ThemThuoc(ThuocEntity entity, ref string error)
        {
            if(string.IsNullOrEmpty(entity.TenThuoc))
            {
                error = "Vui lòng nhập tên thuốc!";
                return false;
            }
            if (string.IsNullOrEmpty(entity.DonViTinh))
            {
                error = "Vui lòng nhập đơn vị tính!";
                return false;
            }
            if (string.IsNullOrEmpty(entity.GiaBan.ToString()))
            {
                error = "Vui lòng nhập giá bán!";
                return false;
            }
            if (string.IsNullOrEmpty(entity.MaLoaiThuoc.ToString()))
            {
                error = "Vui lòng chọn mã loại thuốc!";
                return false;
            }
            if (string.IsNullOrEmpty(entity.MaNhaCungCap.ToString()))
            {
                error = "Vui lòng chọn mã nhà cung cấp!";
                return false;
            }
            return process.ThemThuoc(entity, ref error);
        }

        public bool SuaThuoc(ThuocEntity entity, ref string error)
        {
            if (string.IsNullOrEmpty(entity.TenThuoc))
            {
                error = "Vui lòng nhập tên thuốc!";
                return false;
            }
            if (string.IsNullOrEmpty(entity.DonViTinh))
            {
                error = "Vui lòng nhập đơn vị tính!";
                return false;
            }
            if (string.IsNullOrEmpty(entity.GiaBan.ToString()))
            {
                error = "Vui lòng nhập giá bán!";
                return false;
            }
            if (string.IsNullOrEmpty(entity.MaLoaiThuoc.ToString()))
            {
                error = "Vui lòng chọn mã loại thuốc!";
                return false;
            }
            if (string.IsNullOrEmpty(entity.MaNhaCungCap.ToString()))
            {
                error = "Vui lòng chọn mã nhà cung cấp!";
                return false;
            }
            return process.SuaThuoc(entity, ref error);
        }

        public bool XoaThuoc(int maThuoc, ref string error)
        {
            return process.XoaThuoc(maThuoc, ref error);
        }
    }
}
