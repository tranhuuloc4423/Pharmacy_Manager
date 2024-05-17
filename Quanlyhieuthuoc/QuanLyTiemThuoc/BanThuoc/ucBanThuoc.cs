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
            data = thuocManager.HienThiDanhSachThuoc(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                dgThuoc.DataSource = data;
                if (dgThuoc.Rows.Count > 0)
                {
                    thuocSelected = dgThuoc.Rows[0];
                    //lblTenThuoc.Text = thuocSelected.Cells["TenThuoc"].Value.ToString();
                    //lblLoaiThuoc.Text = thuocSelected.Cells["TenLoaiThuoc"].Value.ToString();
                    //lblGiaBan.Text = thuocSelected.Cells["GiaBan"].Value.ToString();
                }
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

            lblTongTien.Text = sum.ToString();
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
            if (string.IsNullOrEmpty(lblTenThuoc.Text))
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

            foreach (DataGridViewRow row in dgCTHD.Rows)
            {
                if (row.Cells["MaThuocCTHD"].Value != null && row.Cells["MaThuocCTHD"].Value.ToString() == maThuoc)
                {
                    MessageBox.Show("Thuốc này đã được thêm vào chi tiết hóa đơn!");
                    return;
                }
            }


            dgCTHD.Rows.Add(maThuoc, tenThuoc, soLuong.ToString(), giaBan.ToString(), thanhTien.ToString());

            lblTenThuoc.Text = "";
            lblLoaiThuoc.Text = "";
            lblGiaBan.Text = "";
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
                lblGiaBan.Text = thuocSelected.Cells["GiaBan"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
