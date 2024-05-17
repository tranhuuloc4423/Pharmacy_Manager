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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanlyhieuthuoc.BanThuoc
{
    public partial class ucBanThuoc : UserControl
    {
        private HoaDonManager hoaDonManager = null;
        private ThuocManager thuocManager = null;
        private string error = null;
        private DataGridViewRow thuocSelected = null;
        private DataGridViewRow khachHangSelected = null;
        public ucBanThuoc()
        {
            InitializeComponent();
            hoaDonManager = new HoaDonManager();
            thuocManager = new ThuocManager();
            error = "";
            HienThiDanhSach();
            lblNguoiBan.Text = CauHinhHeThong.TenDayDu;
        }

        private void HienThiDanhSach()
        {
            DataTable data = new DataTable();
            data = thuocManager.HienThiDanhSachThuocBan(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                dgThuoc.DataSource = data;
            }
        }

        private void CapNhatTongTien()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dgCTHD.Rows)
            {
                int value = Convert.ToInt32(row.Cells["ThanhTien"].Value);
                sum += value;
            }
            lblTongTien.Text = sum.ToString("#,##0.##");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (thuocSelected == null)
            {
                MessageBox.Show("Vui lòng chọn thuốc muốn mua");
                return;
            }

            if (nudSoLuong.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            string maThuoc = thuocSelected.Cells["MaThuoc"].Value.ToString();
            string tenThuoc = thuocSelected.Cells["TenThuoc"].Value.ToString();
            string loaiThuoc = thuocSelected.Cells["TenLoaiThuoc"].Value.ToString();
            int soLuong = Convert.ToInt32(nudSoLuong.Value);
            int giaBan = Convert.ToInt32(thuocSelected.Cells["GiaBan"].Value);
            int thanhTien = soLuong * giaBan;

            bool isExist = false;

            foreach (DataGridViewRow row in dgCTHD.Rows)
            {
                if (row.Cells["MaThuocCTHD"].Value != null && row.Cells["MaThuocCTHD"].Value.ToString() == maThuoc)
                {
                    int value = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    int soLuongMoi = value + soLuong;
                    row.Cells["SoLuong"].Value = "";
                    row.Cells["SoLuong"].Value = soLuongMoi;
                    isExist = true;
                    row.Cells["ThanhTien"].Value = "";
                    row.Cells["ThanhTien"].Value = (soLuongMoi * giaBan);
                    CapNhatTongTien();
                } 
            }


            if(!isExist)
            {
                dgCTHD.Rows.Add(maThuoc, tenThuoc, soLuong, giaBan, thanhTien);
            }

           
            nudSoLuong.Value = 0;
            CapNhatTongTien();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (nudSoLuong.Value == 0)
            {
                return;
            }
            nudSoLuong.Value -= 1;
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            nudSoLuong.Value += 1;
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            ThemKhachHang form = new ThemKhachHang();
            form.ShowDialog();
            khachHangSelected = form.rowSelected;
            lblKhachHang.Text = khachHangSelected.Cells["HoTen"].Value.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (khachHangSelected == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
                return;
            }
            HoaDonEntity hoaDon = new HoaDonEntity();
            hoaDon.TenTaiKhoan = CauHinhHeThong.TenDangNhap;
            hoaDon.MaKhachHang = Convert.ToInt32(khachHangSelected.Cells["MaKhachHang"].Value);

            int maHoaDon = hoaDonManager.ThemHoaDon(hoaDon, ref error);
            if (maHoaDon == 0)
            {
                MessageBox.Show(error);
            }
            else
            {
                foreach (DataGridViewRow row in dgCTHD.Rows)
                {
                    ChiTietHoaDonEntity CTHD = new ChiTietHoaDonEntity();

                    if (row.Cells["MaThuocCTHD"].Value != null && row.Cells["SoLuong"].Value != null && row.Cells["DonGia"].Value != null)
                    {
                        CTHD.MaHoaDon = maHoaDon;
                        CTHD.MaThuoc = Convert.ToInt32(row.Cells["MaThuocCTHD"].Value);
                        CTHD.SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        CTHD.DonGia = Convert.ToInt32(row.Cells["DonGia"].Value);
                        ThemCTHD(CTHD);
                    }
                }
                MessageBox.Show("Thanh Toán Thành Công!");
                dgCTHD.Rows.Clear();
            }
        }

        private void ThemCTHD(ChiTietHoaDonEntity entity)
        {
            var result = hoaDonManager.ThemCTHD(entity, ref error);
            if (!result)
            {
                MessageBox.Show(error);
            }
        }

        private void dgThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgThuoc.RowCount)
            {
                thuocSelected = dgThuoc.Rows[e.RowIndex];
                lblTenThuoc.Text = thuocSelected.Cells["TenThuoc"].Value.ToString();
                lblLoaiThuoc.Text = thuocSelected.Cells["TenLoaiThuoc"].Value.ToString();
                decimal giaBan = (decimal)thuocSelected.Cells["GiaBan"].Value;
                lblGiaBan.Text = giaBan.ToString("#,##0.##");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgCTHD.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgCTHD.SelectedRows)
                {
                    dgCTHD.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết hoá đơn để xoá.");
            }
        }

        private void dgCTHD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgCTHD.Columns["SoLuong"].Index)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgCTHD.Rows[rowIndex];

                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                double donGia = Convert.ToDouble(row.Cells["DonGia"].Value);

                double thanhTien = soLuong * donGia;

                row.Cells["ThanhTien"].Value = thanhTien;
                CapNhatTongTien();
            }
        }

        private void dgCTHD_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewColumn soLuong = dgCTHD.Columns["SoLuong"];

            if (dgCTHD.Columns[e.ColumnIndex] != soLuong)
            {
                dgCTHD.CancelEdit();
            }
        }
    }
}
