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

namespace Quanlyhieuthuoc.PhanLoai
{
    public partial class ucPhanLoai : UserControl
    {
        private PhanLoaiManager manager = null;
        private string error = null;
        public ucPhanLoai()
        {
            InitializeComponent();
            manager = new PhanLoaiManager();
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
                dgPhanLoai.DataSource = data;
                if (dgPhanLoai.Rows.Count > 0)
                {
                    DataGridViewRow rowselected = dgPhanLoai.Rows[0];
                    lblMaLoaiThuoc.Text = rowselected.Cells["MaLoaiThuoc"].Value.ToString();
                    lblTenLoaiThuoc.Text = rowselected.Cells["TenLoaiThuoc"].Value.ToString();
                }
            }
        }

        private void dgPhanLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgPhanLoai.RowCount)
            {
                DataGridViewRow rowselected = dgPhanLoai.Rows[e.RowIndex];
                lblMaLoaiThuoc.Text = rowselected.Cells["MaLoaiThuoc"].Value.ToString();
                lblTenLoaiThuoc.Text = rowselected.Cells["TenLoaiThuoc"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemPhanLoai form = new ThemPhanLoai();
            form.ShowDialog();
            hienThiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maLoaiThuoc = Convert.ToInt32(lblMaLoaiThuoc.Text);
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phân loại này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var result = manager.XoaLoaiThuoc(maLoaiThuoc, ref error);
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
            PhanLoaiEntity entity = new PhanLoaiEntity();
            entity.MaLoaiThuoc = Convert.ToInt32(lblMaLoaiThuoc.Text);
            entity.TenLoaiThuoc = lblTenLoaiThuoc.Text;
            SuaPhanLoai form = new SuaPhanLoai(entity);
            form.ShowDialog();
            hienThiDanhSach();
        }
    }
}
