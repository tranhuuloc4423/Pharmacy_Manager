using BLL.Managers;
using DAL.Entities;
using Quanlyhieuthuoc.Kho;
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
    public partial class SuaThuoc : Form
    {
        private ThuocManager manager = null;
        private PhanLoaiManager phanLoaiManager = null;
        private ThuocEntity thuoc = null;
        private string error = null;
        public SuaThuoc(ThuocEntity thuoc)
        {
            InitializeComponent();
            manager = new ThuocManager();
            phanLoaiManager = new PhanLoaiManager();
            error = "";
            this.thuoc = thuoc;
            hienThiPhanLoai();
            hienThiThongTinSuaThuoc();
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

        private void hienThiThongTinSuaThuoc()
        {
            txtMaThuoc.Text = thuoc.MaThuoc.ToString();
            txtTenThuoc.Text = thuoc.TenThuoc;
            txtDonViTinh.Text = thuoc.DonViTinh;
            txtGiaBan.Text = thuoc.GiaBan.ToString();
            cbLoaiThuoc.SelectedValue = thuoc.MaLoaiThuoc;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thuốc!");
                txtTenThuoc.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính của thuốc!");
                txtDonViTinh.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtGiaBan.Text) || Convert.ToDouble(txtGiaBan.Text) < 0)
            {
                MessageBox.Show("Vui lòng nhập giá bán thuốc!");
                txtGiaBan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbLoaiThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập loại thuốc!");
                cbLoaiThuoc.Focus();
                return;
            }
            //tương tự cần nghiên cưu thêm khúc double, nửa bên này nửa bên kia trông phèn ác
            ThuocEntity entity = new ThuocEntity();
            entity.MaThuoc = thuoc.MaThuoc;
            entity.MaLoaiThuoc = Convert.ToInt32(cbLoaiThuoc.SelectedValue);
            entity.TenThuoc = txtTenThuoc.Text;
            entity.DonViTinh = txtDonViTinh.Text;
            entity.GiaBan = Convert.ToInt32(txtGiaBan.Text);

            try
            {
                var result = manager.SuaThuoc(entity, ref error);
                if (result)
                {
                    MessageBox.Show("Sửa Thuốc thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa Thuốc không thành công!");
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
    }
}
