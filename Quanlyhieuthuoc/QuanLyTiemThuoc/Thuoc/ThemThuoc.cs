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
        private string error = null;
        public ThemThuoc()
        {
            InitializeComponent();
            manager = new ThuocManager();
            phanLoaiManager = new PhanLoaiManager();
            error = "";
            hienThiPhanLoai();
        }

        private void hienThiPhanLoai()
        {
            DataTable data = new DataTable();
            data = phanLoaiManager.hienThiDanhSach(ref error);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenThuoc = txtTenThuoc.Text;
            string dvt = txtDonViTinh.Text;
            string giaBan = txtGiaBan.Text;


            if (string.IsNullOrEmpty(tenThuoc))
            {
                MessageBox.Show("Vui lòng nhập tên thuốc!");
                return;
            }

            if (string.IsNullOrEmpty(dvt))
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính của thuốc!");
                return;
            }

            if (string.IsNullOrEmpty(giaBan))
            {
                MessageBox.Show("Vui lòng nhập giá bán thuốc!");
                return;
            }
            ThuocEntity entity = new ThuocEntity();
            entity.MaLoaiThuoc = Convert.ToInt32(cbLoaiThuoc.SelectedValue);
            entity.TenThuoc = tenThuoc;
            entity.DonViTinh = dvt;
            entity.GiaBan = Convert.ToDouble(giaBan);

            try
            {
                var result = manager.ThemThuoc(entity, ref error);
                if(result)
                {
                    MessageBox.Show("Thêm Thuốc thành công!");
                    this.Close();
                } else
                {
                    MessageBox.Show("Thêm Thuốc không thành công!");
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
