﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyhieuthuoc.KhachHang
{
    public partial class SuaKhachHang : Form
    {
        private KhachHangManager manager = null;
        private KhachHangEntity khacHang = null;
        private string error = null;
        public SuaKhachHang(KhachHangEntity khachHang)
        {
            InitializeComponent();
            manager = new KhachHangManager();
            error = "";
            this.khachHang = khachHang;
            hienThiThongTinSua();
        }

        private void hienThiThongTinSua()
        {
            txtHoTen.Text = khachHang.HoTen;
            txtSoDienThoai.Text = khachHang.SoDienThoai;
        }

        private void btnSua_Click()
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            if(string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng muốn sửa!");
                return;
            }
            if(string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng muốn sửa!");
                return;
            }
            KhachHangEntity entity = new KhachHangEntity();
            entity.HoTen = hoTen;
            entity.SoDienThoai = sdt;
            try
            {
                var result = manager.SuaKhachHang(entity, ref error);
                if(result)
                {
                    MessageBox.Show("Sửa khách hàng thành công!");
                    this.Close();
                } else
                {
                    MessageBox.Show("Sửa khách hàng không thành công!");
                    MessageBox.Show("Lỗi : " + error.Message);
                }
            } catch(Exception ex)
            {
                
            }
        
        }

        private void btnThoat_Click()
        {
            this.Close();
        }
    }
}
