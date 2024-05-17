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

namespace Quanlyhieuthuoc.Hoadon
{
    public partial class InChiTietHoaDon : Form
    {
        private HoaDonManager HoaDonManager = null;
        private string error = null;
        public InChiTietHoaDon(HoaDonEntity HoaDonEntity, string TenKH)
        {
            InitializeComponent();
            HoaDonManager = new HoaDonManager();
            error = "";
            lblMaHoaDon.Text = HoaDonEntity.MaHoaDon.ToString();
            lblKhachHang.Text = TenKH;
            lblNgayBan.Text = HoaDonEntity.NgayBan.ToString();
            lblNguoiBan.Text = HoaDonEntity.TenTaiKhoan.ToString();
            lblTongTien.Text = HoaDonEntity.TongTien.ToString("#,##0.##");
            HienThiChiTietHoaDon(HoaDonEntity.MaHoaDon);
        }
        private void HienThiChiTietHoaDon(int MaHoaDon)
        {
            DataTable data = new DataTable();
            data = HoaDonManager.HienThiDanhSachChiTietHoaDon(MaHoaDon, ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                dgChiTiet.DataSource = data;
            }
        }
    }
}
