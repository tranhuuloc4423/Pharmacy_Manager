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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            KhachHangEntity entity = new KhachHangEntity();
            entity.HoTen = txtHoTen.Text.Trim();
            entity.SoDienThoai = txtSoDienThoai.Text.Trim();
            try
            {
                var result = manager.ThemKhachHang(entity, ref error);

                if (result)
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                MessageBox.Show(error);
                throw;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            txtSoDienThoai.Text = txtSoDienThoai.Text.Replace(" ", "");
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
