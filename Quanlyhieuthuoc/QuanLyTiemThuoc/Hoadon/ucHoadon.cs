using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Managers;
using Quanlyhieuthuoc.KhachHang;
using DAL.Entities;

namespace Quanlyhieuthuoc.Hoadon
{
    public partial class ucHoadon : UserControl
    {
        private HoaDonManager HoaDonManager = null;
        private HoaDonEntity HoaDonEntity = null;
        private ChiTietHoaDonEntity ChiTietHDEntity = null;

        private string TenKH = null;
        private string error = null;
        public ucHoadon()
        {
            InitializeComponent();
            HoaDonManager = new HoaDonManager();
            HoaDonEntity = new HoaDonEntity();

            ChiTietHDEntity = new ChiTietHoaDonEntity();
            TenKH = "";
            error = "";

            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";

            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";

            dtpNgayBatDau.Value = DateTime.Now.AddDays(-31);
            dtpNgayKetThuc.Value = DateTime.Now;
            HienThiHoaDon();
        }

        private void HienThiHoaDon()
        {
            DataTable data = new DataTable();
            data = HoaDonManager.HienThiDanhSach(dtpNgayBatDau.Value, dtpNgayKetThuc.Value, ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                dgHoaDon.DataSource = data;
            }
        }

        private void dgHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgHoaDon.RowCount)
            {
                DataGridViewRow rowselected = dgHoaDon.Rows[e.RowIndex];
                HoaDonEntity.MaHoaDon = Convert.ToInt32(rowselected.Cells["MaHoaDon"].Value);
                HoaDonEntity.TenTaiKhoan = rowselected.Cells["TenTaiKhoan"].Value.ToString();
                HoaDonEntity.NgayBan = rowselected.Cells["NgayBan"].Value.ToString();
                HoaDonEntity.TongTien = Convert.ToInt32(rowselected.Cells["TongTien"].Value);
                //HoaDonEntity.GiamGia = Convert.ToInt32(rowselected.Cells["GiamGia"].Value);
                TenKH = rowselected.Cells["TenKhachHang"].Value.ToString();
            }
        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TenKH))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in!");
            }
            else
            {
                InChiTietHoaDon frm = new InChiTietHoaDon(HoaDonEntity, TenKH);
                frm.ShowDialog();
            }
        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            HienThiHoaDon();
        }
        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            HienThiHoaDon();
        }

        
    }
}
