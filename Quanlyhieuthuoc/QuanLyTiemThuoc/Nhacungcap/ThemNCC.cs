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
    public partial class ThemNCC : Form
    {
        private NhaCungCapManager manager = null;
        private string error = null;
        public ThemNCC()
        {
            InitializeComponent();
            manager = new NhaCungCapManager();
            error = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!");
                return;
            }
            NhaCungCapEntity entity = new NhaCungCapEntity();
            entity.TenNhaCungCap = tenNCC;
            entity.DiaChi = diaChi;
            try
            {
                var result = manager.ThemNCC(entity, ref error);
                if(result)
                {
                    MessageBox.Show("Thêm Nhà Cung Cấp thành công!");
                    this.Close();
                } else
                {
                    MessageBox.Show("Thêm Nhà Cung Cấp không thành công!");
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
