using Quanlyhieuthuoc.Nhacungcap;
using Quanlyhieuthuoc.PhanLoai;
using Quanlyhieuthuoc.TaiKhoan;
using Quanlyhieuthuoc.Thuoc;
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
    public partial class Main : Form
    {
        string hoTen;
        public Main(string hoTen)
        {
            InitializeComponent();
            this.hoTen = hoTen;
            lblDanhMuc.Text = "Trang chủ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        void handleAddUC(UserControl uc, string title)
        {
            pnMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnMain.Controls.Add(uc);
            lblDanhMuc.Text = title;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ucTaiKhoan uc = new ucTaiKhoan();
            string title = "Tài Khoản";
            handleAddUC(uc, title);
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            ucThuoc uc = new ucThuoc();
            string title = "Thuốc";
            handleAddUC(uc, title);
        }

        private void btnNhacungcap_Click(object sender, EventArgs e)
        {
            ucNhaCungCap uc = new ucNhaCungCap();
            string title = "Nhà Cung Cấp";
            handleAddUC(uc, title);
        }

        private void btnPhanLoai_Click(object sender, EventArgs e)
        {
            ucPhanLoai uc = new ucPhanLoai();
            string title = "Phân Loại Thuốc";
            handleAddUC(uc, title);
        }
    }
}
