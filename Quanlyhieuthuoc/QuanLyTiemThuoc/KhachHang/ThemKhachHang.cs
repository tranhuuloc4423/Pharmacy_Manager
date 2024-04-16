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
            if(string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!");
                return;
            }

            if(string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại khách hàng!");
                return;
            }

            KhachHangEntity entity = new KhachHangEntity();
            entity.hoTen = hoTen;
            entity.SoDienThoai = sdt;
            
            try
            {
                var result = manager.ThemKhachHang(entity, ref error);
                if(result) 
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    this.Close();
                } else 
                {
                    MessageBox.Show("Thêm khách hàng không thành công!");
                    MessageBox.Show("Lỗi : " + error);
                }
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
