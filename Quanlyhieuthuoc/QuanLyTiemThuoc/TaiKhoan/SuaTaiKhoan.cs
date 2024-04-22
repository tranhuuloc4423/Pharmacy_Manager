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

namespace Quanlyhieuthuoc.TaiKhoan
{
    public partial class SuaTaiKhoan : Form
    {
        private TaiKhoanManager manager = null;
        private QuyenManager quyenManager = null;
        private TaiKhoanEntity taikhoan = null;
        private string error = null;
        public SuaTaiKhoan(TaiKhoanEntity taikhoan)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.taikhoan = taikhoan;
            manager = new TaiKhoanManager();
            quyenManager = new QuyenManager();
            error = "";
            hienThiQuyen();
            hienThiThongTinEntity();
        }

        private void hienThiThongTinEntity()
        {
            txtTenTaiKhoan.Text = taikhoan.TenTaiKhoan;
            txtHoTen.Text = taikhoan.HoTen;
            cbQuyen.SelectedValue = taikhoan.VaiTro;
        }

        private void hienThiQuyen()
        {
            DataTable data = new DataTable();
            data = quyenManager.HienThiDanhSach(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                cbQuyen.DataSource = data;
                cbQuyen.DisplayMember = "MoTa";
                cbQuyen.ValueMember = "MaQuyen";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoanEntity entity = new TaiKhoanEntity();
            entity.TenTaiKhoan = taikhoan.TenTaiKhoan;
            entity.HoTen = txtHoTen.Text.Trim();
            entity.MatKhau = txtMatKhau.Text.Trim();
            entity.VaiTro = Convert.ToInt32(cbQuyen.SelectedValue);
            string error = "";

            if (!string.IsNullOrEmpty(txtMatKhau.Text) && txtMatKhau.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại chưa khớp, vui lòng nhập lại!");
                txtNhapLaiMK.Focus();
                return;
            }
            var result = manager.SuaTaiKhoan(entity, ref error);
            try
            {
                if (result)
                {
                    MessageBox.Show("Sửa tài khoản thành công!");
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
