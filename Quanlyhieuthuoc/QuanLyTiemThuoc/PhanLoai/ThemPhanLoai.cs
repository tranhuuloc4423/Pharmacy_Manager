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

namespace Quanlyhieuthuoc.PhanLoai
{
    public partial class ThemPhanLoai : Form
    {
        private PhanLoaiManager manager = null;
        private string error = null;
        public ThemPhanLoai()
        {
            InitializeComponent();
            manager = new PhanLoaiManager();
            error = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtTenLoaiThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phân loại!");
                return;
            }
            PhanLoaiEntity entity = new PhanLoaiEntity();
            entity.TenLoaiThuoc = txtTenLoaiThuoc.Text;

            try
            {
                var result = manager.ThemLoaiThuoc(entity, ref error);
                if(result)
                {
                    MessageBox.Show("Thêm phân loại thuốc thành công!");
                    this.Close();
                } else
                {
                    MessageBox.Show("Thêm phân loại thuốc không thành công!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
