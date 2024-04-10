using Quanlyhieuthuoc.TaiKhoan;
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
            uc.Dock = DockStyle.Fill;
            pnMain.Controls.Add(uc);
            lblDanhMuc.Text = title;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ucTaiKhoan ucTaiKhoan = new ucTaiKhoan();
            string title = "Tài Khoản";
            handleAddUC(ucTaiKhoan, title);
        }
    }
}
