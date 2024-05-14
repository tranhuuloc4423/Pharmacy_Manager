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

namespace Quanlyhieuthuoc.NhaCungCap
{
    public partial class ucNhaCungCap : UserControl
    {
        private NhaCungCapManager manager = null;
        private DataGridViewRow rowselected = null;
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
            data = manager.HienThiDanhSach(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                dgNCC.DataSource = data;
                if (dgNCC.Rows.Count > 0)
                {
                    rowselected = dgNCC.Rows[0];
                    lblMaNCC.Text = rowselected.Cells["MaNhaCungCap"].Value.ToString();
                    lblTenNCC.Text = rowselected.Cells["TenNhaCungCap"].Value.ToString();
                    lblDiaChi.Text = rowselected.Cells["DiaChi"].Value.ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNCC form = new ThemNCC();
            form.ShowDialog();
            hienThiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maNCC = Convert.ToInt32(lblMaNCC.Text);
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phân loại này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var result = manager.XoaNCC(maNCC, ref error);
                    if (result)
                    {
                        MessageBox.Show("Xoá phân loại thuốc thành công!");

                    }
                    else
                    {
                        MessageBox.Show("Xoá phân loại thuốc không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    error = "Lỗi : " + ex.Message;
                    MessageBox.Show(error);
                    throw;
                }
            }
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

        private void dgNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgNCC.RowCount)
            {
                rowselected = dgNCC.Rows[e.RowIndex];
                lblMaNCC.Text = rowselected.Cells["MaNhaCungCap"].Value.ToString();
                lblTenNCC.Text = rowselected.Cells["TenNhaCungCap"].Value.ToString();
                lblDiaChi.Text = rowselected.Cells["DiaChi"].Value.ToString();
            }
        }
    }
}
