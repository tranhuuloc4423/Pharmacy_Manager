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
            txtMatKhau.UseSystemPasswordChar = true;
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
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            try
            {
                var result = manager.KiemTraDangNhap(tenTaiKhoan, matKhau, ref error);
                if (result != null && result.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công : " + result.Rows[0]["HoTen"].ToString());
                    CauHinhHeThong.TenDangNhap = txtDangNhap.Text;
                    CauHinhHeThong.VaiTro = Convert.ToInt32(result.Rows[0]["VaiTro"]);
                    CauHinhHeThong.TenDayDu = result.Rows[0]["HoTen"].ToString();
                    Main frm = new Main();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lỗi tài khoản, đăng nhập không thành công!");

                }
            }
            catch (Exception)
            {
                throw;
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
