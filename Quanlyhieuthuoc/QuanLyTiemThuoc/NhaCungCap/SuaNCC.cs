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
    public partial class SuaNCC : Form
    {
        private NhaCungCapManager manager = null;
        private NhaCungCapEntity nhaCungCapEntity = null;
        private string error = null;

        public SuaNCC(NhaCungCapEntity nhaCungCapEntity)
        {
            InitializeComponent();
            manager = new NhaCungCapManager();
            error = "";
            this.nhaCungCapEntity = nhaCungCapEntity;
            hienThiThongTinSuaPhanLoai();
        }

        private void hienThiThongTinSuaPhanLoai()
        {
            txtMaNCC.Text = nhaCungCapEntity.MaNhaCungCap.ToString();
            txtTenNCC.Text = nhaCungCapEntity.TenNhaCungCap;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaCungCapEntity entity = new NhaCungCapEntity();
            entity.MaNhaCungCap = nhaCungCapEntity.MaNhaCungCap;
            entity.TenNhaCungCap = nhaCungCapEntity.TenNhaCungCap.Trim();

            try
            {
                var result = manager.SuaNCC(entity, ref error);
                if (result)
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công!");
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
    }
}
