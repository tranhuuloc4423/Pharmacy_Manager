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
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblHoTen.Text = hoTen;
        }

        private ucTaiKhoan ucTaiKhoan;

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ucTaiKhoan = new ucTaiKhoan();
            ucTaiKhoan.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucTaiKhoan);
        }

        
    }
}
