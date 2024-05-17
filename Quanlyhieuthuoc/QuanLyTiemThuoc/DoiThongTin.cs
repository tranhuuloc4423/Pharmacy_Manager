using BLL.Managers;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyhieuthuoc
{
    public partial class DoiThongTin : Form
    {
        private TaiKhoanManager manager = null;
        private QuyenManager quyenManager = null;
        private TaiKhoanEntity taikhoan = null;
        private string error = null;
        public DoiThongTin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.taikhoan = taikhoan;
            manager = new TaiKhoanManager();
            quyenManager = new QuyenManager();
            error = "";
            txtTenTaiKhoan.Text = CauHinhHeThong.TenDangNhap;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Chưa nhập họ tên!");
                txtMatKhauCu.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhauCu.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ!");
                txtMatKhauCu.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Chưa nhập mật mới!");
                txtMatKhauCu.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNhapLaiMatKhauMoi.Text))
            {
                MessageBox.Show("Chưa nhập lại mật mới!");
                txtMatKhauCu.Focus();
                return;
            }

            if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!");
                txtMatKhauMoi.Focus();
                return;
            }

            TaiKhoanEntity entity = new TaiKhoanEntity();
            entity.TenTaiKhoan = txtTenTaiKhoan.Text;
            entity.HoTen = txtHoTen.Text.Trim();
            entity.MatKhau = txtMatKhauCu.Text.Trim();
            entity.MatKhauMoi = txtMatKhauMoi.Text.Trim();

            var result = manager.CapNhatThongTin(entity, ref error);
            try
            {
                if (result)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                return;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
