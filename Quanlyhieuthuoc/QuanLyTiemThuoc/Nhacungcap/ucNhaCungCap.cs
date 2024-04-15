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

namespace Quanlyhieuthuoc.Nhacungcap
{
    public partial class ucNhaCungCap : UserControl
    {
        private NhaCungCapManager manager = null;
        private string error = null;
        public ucNhaCungCap()
        {
            InitializeComponent();
            manager = new NhaCungCapManager();
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
                dgNhaCungCap.DataSource = data;
                if (dgNhaCungCap.Rows.Count > 0)
                {
                    DataGridViewRow rowselected = dgNhaCungCap.Rows[0];
                    lblMaNCC.Text = rowselected.Cells["MaNhaCungCap"].Value.ToString();
                    lblTenNCC.Text = rowselected.Cells["TenNhaCungCap"].Value.ToString();
                    lblDiaChi.Text = rowselected.Cells["DiaChi"].Value.ToString();
                }
            }
        }

        private void dgNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgNhaCungCap.RowCount)
            {
                DataGridViewRow rowselected = dgNhaCungCap.Rows[e.RowIndex];
                lblMaNCC.Text = rowselected.Cells["MaNhaCungCap"].Value.ToString();
                lblTenNCC.Text = rowselected.Cells["TenNhaCungCap"].Value.ToString();
                lblDiaChi.Text = rowselected.Cells["DiaChi"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNCC form = new ThemNCC();
            form.ShowDialog();
            hienThiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaCungCapEntity entity = new NhaCungCapEntity();
            entity.MaNhaCungCap = Convert.ToInt32(lblMaNCC.Text);
            entity.TenNhaCungCap = lblTenNCC.Text;
            entity.DiaChi = lblDiaChi.Text;
            SuaNCC form = new SuaNCC(entity);
            form.ShowDialog();
            hienThiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(lblMaNCC.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xoá!");
                return;
            }

            try
            {
                var result = manager.XoaNCC(Convert.ToInt32(lblMaNCC.Text), ref error);
                if(result)
                {
                    MessageBox.Show("Xoá Nhà Cung Cấp thành công!");
                    hienThiDanhSach();
                    return;
                } else
                {
                    MessageBox.Show("Xoá Nhà Cung Cấp không thành công!");
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
