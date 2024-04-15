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

namespace Quanlyhieuthuoc.PhanLoai
{
    public partial class SuaPhanLoai : Form
    {
        private PhanLoaiManager manager = null;
        private PhanLoaiEntity phanLoaiEntity = null;
        private string error = null;
        public SuaPhanLoai(PhanLoaiEntity phanLoaiEntity)
        {
            InitializeComponent();
            manager = new PhanLoaiManager();
            error = "";
            this.phanLoaiEntity = phanLoaiEntity;
            hienThiThongTinSuaPhanLoai();
        }

        private void hienThiThongTinSuaPhanLoai()
        {
            txtMaLoaiThuoc.Text = phanLoaiEntity.MaLoaiThuoc.ToString();
            txtTenLoaiThuoc.Text = phanLoaiEntity.TenLoaiThuoc;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenLoaiThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại thuốc muốn sửa!");
                return;
            }
            PhanLoaiEntity entity = new PhanLoaiEntity();
            entity.MaLoaiThuoc = phanLoaiEntity.MaLoaiThuoc;
            entity.TenLoaiThuoc = txtTenLoaiThuoc.Text.Trim();

            try
            {
                var result = manager.SuaLoaiThuoc(entity, ref error);
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
    }
}
