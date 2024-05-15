using Quanlyhieuthuoc.BanThuoc;
using Quanlyhieuthuoc.Hoadon;
using Quanlyhieuthuoc.KhachHang;
using Quanlyhieuthuoc.NhaCungCap;
using Quanlyhieuthuoc.PhanLoai;
using Quanlyhieuthuoc.TaiKhoan;
using Quanlyhieuthuoc.Thuoc;
using Quanlyhieuthuoc.TrangChu;
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
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblTenDayDu.Text = CauHinhHeThong.TenDayDu;
            handleRole();
            handleAddUC(new ucTrangChu(), "Trang Chủ");
        }

        private void handleRole()
        {
            if(CauHinhHeThong.VaiTro == 2)
            {
                btnTaiKhoan.Enabled = false;
            }
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

        private void btnPhanLoai_Click(object sender, EventArgs e)
        {
            ucPhanLoai uc = new ucPhanLoai();
            string title = "Phân Loại Thuốc";
            handleAddUC(uc, title);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ucKhachHang uc = new ucKhachHang();
            string title = "Khách Hàng";
            handleAddUC(uc, title);
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            ucHoadon uc = new ucHoadon();
            string title = "Hoá Đơn";
            handleAddUC(uc, title);
        }

        private void btnBanThuoc_Click(object sender, EventArgs e)
        {
            ucBanThuoc uc = new ucBanThuoc();
            string title = "Bán Thuốc";
            handleAddUC(uc, title);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ucTrangChu uc = new ucTrangChu();
            string title = "";
            handleAddUC(uc, title);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            ucNhaCungCap uc = new ucNhaCungCap();
            string title = "Nhà Cung Cấp";
            handleAddUC(uc, title);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất chương trình?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
                Dangnhap form = new Dangnhap();
                form.Show();
            } else
            {
                return;
            }
        }

        private void btnDoiThongTin_Click(object sender, EventArgs e)
        {

        }

        
    }
}
