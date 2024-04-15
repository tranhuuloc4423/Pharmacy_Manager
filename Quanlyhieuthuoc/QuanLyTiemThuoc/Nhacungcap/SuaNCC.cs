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

namespace Quanlyhieuthuoc.Nhacungcap
{
    public partial class SuaNCC : Form
    {
        private NhaCungCapManager manager = null;
        private NhaCungCapEntity nhaCungCap = null;
        private string error = null;
        public SuaNCC(NhaCungCapEntity nhaCungCap)
        {
            InitializeComponent();
            manager = new NhaCungCapManager();
            this.nhaCungCap = nhaCungCap;
            error = "";
            hienThiThongTinSua();
        }

        private void hienThiThongTinSua()
        {
            txtMaNCC.Text = nhaCungCap.MaNhaCungCap.ToString();
            txtTenNCC.Text = nhaCungCap.TenNhaCungCap;
            txtDiaChi.Text = nhaCungCap.DiaChi;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenNCC = txtTenNCC.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            if (string.IsNullOrEmpty(tenNCC))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!");
                return;
            }

            if (string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp!");
                return;
            }
            NhaCungCapEntity entity = new NhaCungCapEntity();
            entity.MaNhaCungCap = nhaCungCap.MaNhaCungCap;
            entity.TenNhaCungCap = tenNCC;
            entity.DiaChi = diaChi;
            try
            {
                var result = manager.SuaNCC(entity, ref error);
                if (result)
                {
                    MessageBox.Show("Sửa Nhà Cung Cấp thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa Nhà Cung Cấp không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
                throw;
            }
        }
    }
}
