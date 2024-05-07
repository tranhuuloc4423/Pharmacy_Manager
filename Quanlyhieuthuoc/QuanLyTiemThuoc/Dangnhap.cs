using BLL.Managers;
using Quanlyhieuthuoc.TaiKhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quanlyhieuthuoc
{
    public partial class Dangnhap : Form
    {
        private TaiKhoanManager manager;
        private string error = null;
        public Dangnhap()
        {
            InitializeComponent();
            manager = new TaiKhoanManager();
            error = "";
        }

        private void txtDangNhap_Click(object sender, EventArgs e)
        {
            txtDangNhap.SelectAll();
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.SelectAll();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(tenTaiKhoan))
            {
                MessageBox.Show("Vui long nhap ten tai khoan!");
                return;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui long nhap mat khau!");
                return;
            }
            var result = manager.KiemTraDangNhap(tenTaiKhoan, matKhau, ref error);
            if (result != null && result.Rows.Count > 0)
            {
                MessageBox.Show("Dang nhap thanh cong, ten nguoi dung la: " + result.Rows[0]["HoTen"].ToString());
                CauHinhHeThong.TenDangNhap = tenTaiKhoan;
                CauHinhHeThong.TenDayDu = result.Rows[0]["HoTen"].ToString();
                Main frm = new Main(result.Rows[0]["HoTen"].ToString());
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Loi tai khoan, dang nhap khong thanh cong");

            }
        }
        private void pbOpenEye_Click(object sender, EventArgs e)
        {
            pbOpenEye.Visible = false;
            pbCloseEye.Visible = true;
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void pbCloseEye_Click(object sender, EventArgs e)
        {
            pbCloseEye.Visible = false;
            pbOpenEye.Visible = true;
            txtMatKhau.UseSystemPasswordChar = false;
        }
    }
}
