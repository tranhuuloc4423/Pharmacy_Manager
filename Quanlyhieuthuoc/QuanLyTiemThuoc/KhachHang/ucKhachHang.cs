using BLL.Managers;
using DAL.Entities;
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
            data = manager.HienThiDanhSach(ref error);
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
            KhachHangEntity entity = new KhachHangEntity();
            entity.MaKhachHang = Convert.ToInt32(lblMaKhachHang.Text);
            entity.HoTen = lblHoTen.Text.Trim();
            entity.SoDienThoai = lblSoDienThoai.Text.Trim();
            SuaKhachHang form = new SuaKhachHang(entity);
            form.ShowDialog();
            hienThiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maKhachHang = Convert.ToInt32(lblMaKhachHang.Text);
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var result = manager.XoaKhachHang(maKhachHang, ref error);
                    if (result)
                    {
                        MessageBox.Show("Xoá Khách Hàng thành công!");
                        hienThiDanhSach();
                        return;
                    }
                    else
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
            hienThiDanhSach();
        }
    }
}
