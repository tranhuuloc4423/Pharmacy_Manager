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

namespace Quanlyhieuthuoc.Kho
{
    public partial class ThemPhieuNhap : Form
    {
        private PhieuNhapManager manager = null;
        private ThuocManager thuocManager = null;
        private string error = null;
        private int maPhieuNhap = 0;
        private DataGridViewRow rowThuoc = null;
        private DataGridViewRow rowNhaCungCap = null;
        public ThemPhieuNhap()
        {
            InitializeComponent();
            manager = new PhieuNhapManager();
            thuocManager = new ThuocManager();
            error = "";
        }

        private void dgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgCTPN.RowCount)
            {
                DataGridViewRow rowselected = dgCTPN.Rows[e.RowIndex];
                txtThuoc.Text = rowselected.Cells["TenThuoc"].Value.ToString();
                txtSoLuong.Text = rowselected.Cells["SoLuong"].Value.ToString();
            }
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            string maThuoc = rowThuoc.Cells["MaThuoc"].Value.ToString();
            string tenThuoc = txtThuoc.Text;
            string soLuong = txtSoLuong.Text;

            if (string.IsNullOrEmpty(tenThuoc))
            {
                MessageBox.Show("Vui lòng chọn thuốc");
                return;
            }

            if (string.IsNullOrEmpty(soLuong))
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }


            dgCTPN.Rows.Add(maThuoc, tenThuoc, soLuong);

            txtThuoc.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgCTPN.SelectedRows)
            {
                dgCTPN.Rows.Remove(row);
            }
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            if (rowNhaCungCap != null)
            {
                PhieuNhapEntity entity = new PhieuNhapEntity();
                entity.NguoiNhap = CauHinhHeThong.TenDayDu;
                entity.MaNhaCungCap = Convert.ToInt32(rowNhaCungCap.Cells["MaNhaCungCap"].Value);

                int maPhieuNhap = manager.ThemPhieuNhap(entity, ref error);
                if(maPhieuNhap == 0)
                {
                    MessageBox.Show(error);
                    return;
                } else
                {
                    foreach (DataGridViewRow row in dgCTPN.Rows)
                    {
                        ChiTietPhieuNhapEntity CTPN = new ChiTietPhieuNhapEntity();

                        // Kiểm tra xem dữ liệu trong hàng có hợp lệ hay không
                        if (row.Cells["MaThuoc"].Value != null && row.Cells["SoLuong"].Value != null)
                        {
                            CTPN.MaPhieuNhap = maPhieuNhap;
                            CTPN.MaThuoc = Convert.ToInt32(row.Cells["MaThuoc"].Value);
                            CTPN.SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                            ThemCTPN(CTPN);
                        }
                    }
                    MessageBox.Show("Thêm Phiếu Nhập Thành Công!");
                    this.Close();
                }
                
            }
        }

        private void ThemCTPN(ChiTietPhieuNhapEntity entity)
        {
            var result = manager.ThemCTPN(entity, ref error);
            if(!result)
            {
                MessageBox.Show(error);
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            ThemThuoc form = new ThemThuoc();
            form.ShowDialog();
            rowThuoc = form.row;
            txtThuoc.Text = form.row.Cells["TenThuoc"].Value.ToString();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            ThemNhaCungCap form = new ThemNhaCungCap();
            form.ShowDialog();
            rowNhaCungCap = form.row;
            txtNhaCungCap.Text = form.row.Cells["TenNhaCungCap"].Value.ToString();
        }
    }
}
