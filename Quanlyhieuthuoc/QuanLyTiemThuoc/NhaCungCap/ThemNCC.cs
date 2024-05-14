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

namespace Quanlyhieuthuoc.NhaCungCap
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhaCungCapEntity entity = new NhaCungCapEntity();
            entity.TenNhaCungCap = txtTenNCC.Text;
            entity.DiaChi = txtDiaChi.Text;
            try
            {
                var result = manager.ThemNCC(entity, ref error);
                if (result)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
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
                throw;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
