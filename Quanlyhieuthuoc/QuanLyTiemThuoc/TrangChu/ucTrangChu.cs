using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyhieuthuoc.TrangChu
{
    public partial class ucTrangChu : UserControl
    {
        public ucTrangChu()
        {
            InitializeComponent();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            DoiThongTin form = new DoiThongTin();
            form.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất chương trình?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Dangnhap form = new Dangnhap();
                form.Show();
            }
            else
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
