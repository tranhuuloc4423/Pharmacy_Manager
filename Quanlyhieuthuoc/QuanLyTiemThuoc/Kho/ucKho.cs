using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Managers;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Quanlyhieuthuoc.Thuoc;

namespace Quanlyhieuthuoc.Kho
{
    public partial class ucKho : UserControl
    {
        private KhoThuocManager manager;
        private string error = null;
        public ucKho()
        {
            InitializeComponent();
            manager = new KhoThuocManager();
            error = "";
        }

        private void HienThiDanhSach()
        {
            DataTable data = new DataTable();
            data = manager.HienThiDanhSach(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                dgKhoThuoc.DataSource = data;
                if (dgKhoThuoc.Rows.Count > 0)
                {
                    DataGridViewRow rowselected = dgKhoThuoc.Rows[0];
                    lblTenThuoc.Text = rowselected.Cells["TenThuoc"].Value.ToString();
                    lblDauKy.Text = rowselected.Cells["DauKy"].Value.ToString();
                    lblNhapTrongKy.Text = rowselected.Cells["NhapTrongKy"].Value.ToString();
                    lblXuatTrongThang.Text = rowselected.Cells["XuatTrongThang"].Value.ToString();
                    lblTonKho.Text = rowselected.Cells["TonKho"].Value.ToString();
                }
            }
        }


        private void dgKhoThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgKhoThuoc.RowCount)
            {
                DataGridViewRow rowselected = dgKhoThuoc.Rows[e.RowIndex];
                lblTenThuoc.Text = rowselected.Cells["TenThuoc"].Value.ToString();
                lblDauKy.Text = rowselected.Cells["DauKy"].Value.ToString();
                lblNhapTrongKy.Text = rowselected.Cells["NhapTrongKy"].Value.ToString();
                lblXuatTrongThang.Text = rowselected.Cells["XuatTrongThang"].Value.ToString();
                lblTonKho.Text = rowselected.Cells["TonKho"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemPhieuNhap form = new ThemPhieuNhap();
            form.ShowDialog();
            HienThiDanhSach();
        }
    }
}
