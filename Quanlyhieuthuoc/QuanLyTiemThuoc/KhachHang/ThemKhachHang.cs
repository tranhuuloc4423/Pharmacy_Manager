using BLL.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyhieuthuoc.KhachHang
{
    public partial class ThemKhachHang : Form
    {
        private KhachHangManager manager = null;
        private string error = null;
        public ThemKhachHang()
        {
            InitializeComponent();
            manager = new KhachHangManager();
            error = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string khtt = txtKHTT.Text.Trim();

            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
