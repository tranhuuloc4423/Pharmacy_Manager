﻿using DAL.Entities;
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

        public DataTable HienThiDanhSach(ref string error)
        {
            return process.HienThiDanhSach(ref error);
        }

        public DataTable KiemTraDangNhap(string taikhoan, string matkhau, ref string error)
        {
            return process.KiemTraDangNhap(taikhoan, matkhau,ref error);
        }

        public bool ThemTaiKhoan(TaiKhoanEntity taiKhoan, ref string error)
        {
            if (string.IsNullOrEmpty(taiKhoan.TenTaiKhoan) == true)
            {
                error = "Vui lòng nhập tên tài khoản!";
                return false;
            }
            if (string.IsNullOrEmpty(taiKhoan.HoTen) == true)
            {
                error = "Vui lòng nhập tên họ tên!";
                return false;
            }
            if (string.IsNullOrEmpty(taiKhoan.MatKhau) == true)
            {
                error = "Vui lòng nhập mật khẩu!";
                return false;
            }
            return process.ThemTaiKhoan(taiKhoan, ref error);
        }

        public bool SuaTaiKhoan(TaiKhoanEntity taiKhoan, ref string error)
        {
            if (string.IsNullOrEmpty(taiKhoan.TenTaiKhoan) == true)
            {
                error = "Vui lòng nhập tên tài khoản!";
                return false;
            }
            if (string.IsNullOrEmpty(taiKhoan.HoTen) == true)
            {
                error = "Vui lòng nhập tên họ tên!";
                return false;
            }
            if (string.IsNullOrEmpty(taiKhoan.MatKhau) == true)
            {
                error = "Vui lòng nhập mật khẩu!";
                return false;
            }
            return process.SuaTaiKhoan(taiKhoan, ref error);
        }

        public bool CapNhatThongTin(TaiKhoanEntity taiKhoan, ref string error)
        {
            if (string.IsNullOrEmpty(taiKhoan.TenTaiKhoan) == true)
            {
                error = "Vui lòng nhập tên tài khoản!";
                return false;
            }
            if (string.IsNullOrEmpty(taiKhoan.HoTen) == true)
            {
                error = "Vui lòng nhập tên họ tên!";
                return false;
            }
            if (string.IsNullOrEmpty(taiKhoan.MatKhau) == true)
            {
                error = "Vui lòng nhập mật khẩu!";
                return false;
            }
            if (string.IsNullOrEmpty(taiKhoan.MatKhauMoi) == true)
            {
                error = "Vui lòng nhập mật khẩu mới!";
                return false;
            }
            return process.CapNhatThongTin(taiKhoan, ref error);
        }

        public bool XoaTaiKhoan(string tenTaiKhoan, ref string error)
        {
            if (string.IsNullOrEmpty(tenTaiKhoan) == true)
            {
                error = "Vui lòng chọn tài khoản để xóa!";
                return false;
            }
            return process.XoaTaiKhoan(tenTaiKhoan, ref error);
        }
    }
}
