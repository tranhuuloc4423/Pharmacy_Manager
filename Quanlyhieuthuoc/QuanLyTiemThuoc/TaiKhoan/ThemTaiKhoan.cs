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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanlyhieuthuoc.TaiKhoan
{
    public partial class ThemTaiKhoan : Form
    {
        private TaiKhoanManager taiKhoanManager;
        private QuyenManager quyenManager;
        private string error;
        public ThemTaiKhoan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            taiKhoanManager = new TaiKhoanManager();
            quyenManager = new QuyenManager();
            error = "";
            hienThiQuyen();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtTenTaiKhoan.Text;
            string hoTen = txtHoTen.Text;
            string matKhau = txtMatKhau.Text;

            TaiKhoanEntity taiKhoan = new TaiKhoanEntity();
            taiKhoan.TenTaiKhoan = tenTaiKhoan;
            taiKhoan.HoTen = hoTen;
            taiKhoan.MatKhau = matKhau;
            taiKhoan.VaiTro = Convert.ToInt32(cbQuyen.SelectedValue);
            if (!string.IsNullOrEmpty(txtMatKhau.Text) && txtMatKhau.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại chưa khớp, vui lòng nhập lại!");
                txtNhapLaiMK.Focus();
                return;
            }
            bool result = taiKhoanManager.ThemTaiKhoan(taiKhoan, ref error);
            try
            {
                if (result)
                {
                    MessageBox.Show("Thêm tài khoản thành công");
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
        //
        private void ClearSpace()
        {
            txtMatKhau.Text = txtMatKhau.Text.Replace(" ", "");
            txtNhapLaiMK.Text = txtNhapLaiMK.Text.Replace(" ", "");
        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            ClearSpace();
        }
        private void txtNhapLaiMK_TextChanged(object sender, EventArgs e)
        {
            ClearSpace();
        }
    }
}
