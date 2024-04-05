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

namespace Quanlyhieuthuoc.TaiKhoan
{
    public partial class ucTaiKhoan : UserControl
    {
        private TaiKhoanManager taiKhoanManager = null;
        private string error = "";
        private DataTable data = null;
        public ucTaiKhoan()
        {
            InitializeComponent();
            taiKhoanManager = new TaiKhoanManager();
            data = new DataTable();
            hienThiDanhSachTaiKhoan();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void ucTaiKhoan_Load(object sender, EventArgs e)
        {
            
        }

        private void hienThiDanhSachTaiKhoan()
        {
            data = taiKhoanManager.hienThiDanhSachTaiKhoan(ref error);
            if(data == null)
            {
                MessageBox.Show(error);
            } else
            {
                dgTaiKhoan.DataSource = data;
                if(dgTaiKhoan.Rows.Count > 0)
                {
                    DataGridViewRow rowselected = dgTaiKhoan.Rows[0];
                    txtTenTaiKhoan.Text = rowselected.Cells["TenTaiKhoan"].Value.ToString();
                    txtHoTen.Text = rowselected.Cells["HoTen"].Value.ToString();
                    txtVaiTro.Text = rowselected.Cells["VaiTro"].Value.ToString();
                }
            }
        }
    }
}
