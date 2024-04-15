using BLL.Managers;
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

namespace Quanlyhieuthuoc.KhachHang
{
    public partial class ucKhachHang : UserControl
    {
        private KhachHangManager manager = null;
        private string error = null;
        public ucKhachHang()
        {
            InitializeComponent();
            manager = new KhachHangManager();
            error = "";
            hienThiDanhSach();
        }

        private void hienThiDanhSach()
        {
            DataTable data = new DataTable();
            data = manager.hienThiDanhSach(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                dgKhachHang.DataSource = data;
                if (dgKhachHang.Rows.Count > 0)
                {
                    DataGridViewRow rowselected = dgKhachHang.Rows[0];
                    lblMaKhachHang.Text = rowselected.Cells["MaKhachHang"].Value.ToString();
                    lblHoTen.Text = rowselected.Cells["HoTen"].Value.ToString();
                    lblSoDienThoai.Text = rowselected.Cells["SoDienThoai"].Value.ToString();
                    lblKHTT.Text = rowselected.Cells["KhachHangThanThiet"].Value.ToString();
                    lblMuaTL.Text = rowselected.Cells["MuaTichLuy"].Value.ToString();
                }
            }
        }

        private void dgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgKhachHang.RowCount)
            {
                DataGridViewRow rowselected = dgKhachHang.Rows[e.RowIndex];
                lblMaKhachHang.Text = rowselected.Cells["MaKhachHang"].Value.ToString();
                lblHoTen.Text = rowselected.Cells["HoTen"].Value.ToString();
                lblSoDienThoai.Text = rowselected.Cells["SoDienThoai"].Value.ToString();
                lblKHTT.Text = rowselected.Cells["KhachHangThanThiet"].Value.ToString();
                lblMuaTL.Text = rowselected.Cells["MuaTichLuy"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemKhachHang form = new ThemKhachHang();
            form.ShowDialog();
            hienThiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(lblMaKhachHang.Text))
            {
                MessageBox.Show("Chưa chọn khách hàng để xoá!");
                return;
            }

            int maKhachHang = Convert.ToInt32(lblMaKhachHang.Text);
            try
            {
                var result = manager.XoaKhachHang(maKhachHang, ref error);
                if(result)
                {
                    MessageBox.Show("Xoá Khách Hàng thành công!");
                    hienThiDanhSach();
                    return;
                } else
                {
                    MessageBox.Show("Xoá Khách Hàng không thành công!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
                throw;
            }
        }
    }
}
