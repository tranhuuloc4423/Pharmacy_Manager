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
using System.Xml.Linq;

namespace Quanlyhieuthuoc.TaiKhoan
{
    public partial class ucTaiKhoan : UserControl
    {
        private TaiKhoanManager taiKhoanManager = null;
        private QuyenManager quyenManager = null;
        private string error = "";
        public ucTaiKhoan()
        {
            InitializeComponent();
            taiKhoanManager = new TaiKhoanManager();
            quyenManager = new QuyenManager();
            hienThiDanhSachTaiKhoan();
        }

        private void hienThiDanhSachTaiKhoan()
        {
            DataTable data = new DataTable();
            data = taiKhoanManager.HienThiDanhSach(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                dgTaiKhoan.DataSource = data;
                if (dgTaiKhoan.Rows.Count > 0)
                {
                    DataGridViewRow rowselected = dgTaiKhoan.Rows[0];
                    lblTenTaiKhoan.Text = rowselected.Cells["TenTaiKhoan"].Value.ToString();
                    lblHoTen.Text = rowselected.Cells["HoTen"].Value.ToString();
                    lblVaiTro.Text = rowselected.Cells["MoTa"].Value.ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan form = new ThemTaiKhoan();
            form.ShowDialog();
            hienThiDanhSachTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = lblTenTaiKhoan.Text;
            if (string.IsNullOrEmpty(tenTaiKhoan))
            {
                MessageBox.Show("Chưa chọn tài khoản để xoá");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    bool result = taiKhoanManager.XoaTaiKhoan(tenTaiKhoan, ref error);
                    if (result)
                    {
                        MessageBox.Show("Xoá tài khoản thành công");
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }
                }
                catch (Exception ex)
                {
                    error = "Lỗi : " + ex.Message;
                    return;
                }
            }
            hienThiDanhSachTaiKhoan() ;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TaiKhoanEntity entity = new TaiKhoanEntity();
            entity.TenTaiKhoan = lblTenTaiKhoan.Text;
            entity.HoTen = lblHoTen.Text;
            if(lblVaiTro.Text == "admin")
            {
                entity.VaiTro = 1;
            } else
            {
                entity.VaiTro = 2;
            }
            SuaTaiKhoan form = new SuaTaiKhoan(entity);
            form.ShowDialog();
            hienThiDanhSachTaiKhoan();
        }

        private void dgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgTaiKhoan.RowCount)
            {
                DataGridViewRow rowselected = dgTaiKhoan.Rows[e.RowIndex];
                lblTenTaiKhoan.Text = rowselected.Cells["TenTaiKhoan"].Value.ToString();
                lblHoTen.Text = rowselected.Cells["HoTen"].Value.ToString();
                lblVaiTro.Text = rowselected.Cells["MoTa"].Value.ToString();
            }
        }
    }
}
