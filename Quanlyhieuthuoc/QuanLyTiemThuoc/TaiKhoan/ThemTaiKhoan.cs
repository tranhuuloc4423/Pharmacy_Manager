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
            if (string.IsNullOrEmpty(tenTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên");
                return;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            TaiKhoanEntity taiKhoan = new TaiKhoanEntity();
            taiKhoan.TenTaiKhoan = tenTaiKhoan;
            taiKhoan.HoTen = hoTen;
            taiKhoan.MatKhau = matKhau;
            taiKhoan.VaiTro = Convert.ToInt32(cbQuyen.SelectedValue);

            try
            {
                bool result = taiKhoanManager.ThemTaiKhoan(taiKhoan, ref error);
                if (result)
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                MessageBox.Show(error);
                return;
            }
        }
    }
}
