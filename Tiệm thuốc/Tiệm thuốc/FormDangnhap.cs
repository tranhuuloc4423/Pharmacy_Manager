using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiệm_thuốc
{
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }
        private void txtDangNhap_Click(object sender, EventArgs e)
        {
            txtDangNhap.SelectAll();
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.SelectAll();
        }

        private void btnDangnhap_MouseEnter(object sender, EventArgs e)
        {
            btnDangnhap.ForeColor = Color.White;
        }

        private void btnDangnhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangnhap.ForeColor = Color.Black;
        }

        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.ForeColor = Color.White;
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.ForeColor = Color.Black;
        }
    }
}
