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

namespace Quanlyhieuthuoc.Thuoc
{
    public partial class ThemThuoc : Form
    {
        private ThuocManager manager = null;
        private PhanLoaiManager phanLoaiManager = null;
        private NhaCungCapManager nhaCungCapManager = null;
        private string error = null;
        public ThemThuoc()
        {
            InitializeComponent();
            manager = new ThuocManager();
            phanLoaiManager = new PhanLoaiManager();
            nhaCungCapManager = new NhaCungCapManager();
            error = "";
            hienThiPhanLoai();
            hienThiNhaCungCap();
        }

        private void hienThiPhanLoai()
        {
            DataTable data = new DataTable();
            data = phanLoaiManager.HienThiDanhSach(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                cbLoaiThuoc.DataSource = data;
                cbLoaiThuoc.DisplayMember = "TenLoaiThuoc";
                cbLoaiThuoc.ValueMember = "MaLoaiThuoc";
            }
        }

        private void hienThiNhaCungCap()
        {
            DataTable data = new DataTable();
            data = nhaCungCapManager.HienThiDanhSachTen(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                cbNCC.DataSource = data;
                cbNCC.DisplayMember = "TenNhaCungCap";
                cbNCC.ValueMember = "MaNhaCungCap";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThuocEntity entity = new ThuocEntity();
            entity.MaLoaiThuoc = Convert.ToInt32(cbLoaiThuoc.SelectedValue);
            entity.TenThuoc = txtTenThuoc.Text;
            entity.DonViTinh = txtDonViTinh.Text;
            entity.MaNhaCungCap = Convert.ToInt32(cbNCC.SelectedValue);
            //Nếu validate như thế này thì giá trị double bị null xong lỗi nên phải kiểm tra trước
            //mà nếu thế thì mỗi bên một ít
            //manager check rồi bên này cũng check, trông hơi khó chịu
            //có thể đổi kiểu dữ liệu thành double? thì kiểm tra full bên manager
            //hoặc kiểm tra full ở đây
            if (!string.IsNullOrWhiteSpace(txtGiaBan.Text))
            {
                entity.GiaBan = Convert.ToDouble(txtGiaBan.Text);
            }
            else { MessageBox.Show("Chưa nhập giá bán!"); }
            try
            {
                var result = manager.ThemThuoc(entity, ref error);
                if (result)
                {
                    MessageBox.Show("Thêm Thuốc thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                MessageBox.Show(error);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
