﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Managers;
using Quanlyhieuthuoc.TaiKhoan;
using DAL.Entities;

namespace Quanlyhieuthuoc.Thuoc
{
    public partial class ucThuoc : UserControl
    {
        private ThuocManager manager = null;
        private string error = null;

        private DataTable originalDataTable = null;
        public ucThuoc()
        {
            InitializeComponent();
            manager = new ThuocManager();
            error = "";
            hienThiDanhSach();
        }

        private void hienThiDanhSach()
        {
            DataTable data = new DataTable();
            data = manager.HienThiDanhSachThuoc(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                originalDataTable = data;
                dgThuoc.DataSource = data;
                if (dgThuoc.Rows.Count > 0)
                {
                    DataGridViewRow rowselected = dgThuoc.Rows[0];
                    lblMaThuoc.Text = rowselected.Cells["MaThuoc"].Value.ToString();
                    lblTenThuoc.Text = rowselected.Cells["TenThuoc"].Value.ToString();
                    lblDonViTinh.Text = rowselected.Cells["DonViTinh"].Value.ToString();
                    lblGiaBan.Text = rowselected.Cells["GiaBan"].Value.ToString();
                    cbLoaiThuoc.Text = rowselected.Cells["TenLoaiThuoc"].Value.ToString();
                }
            }
        }

        private void dgThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgThuoc.RowCount)
            {
                DataGridViewRow rowselected = dgThuoc.Rows[e.RowIndex];
                lblMaThuoc.Text = rowselected.Cells["MaThuoc"].Value.ToString();
                lblTenThuoc.Text = rowselected.Cells["TenThuoc"].Value.ToString();
                lblDonViTinh.Text = rowselected.Cells["DonViTinh"].Value.ToString();
                lblGiaBan.Text = rowselected.Cells["GiaBan"].Value.ToString();
                cbLoaiThuoc.Text = rowselected.Cells["TenLoaiThuoc"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMaThuoc.Text))
            {
                MessageBox.Show("Chưa chọn Thuốc để xoá");
                return;
            }
            int maThuoc = Convert.ToInt32(lblMaThuoc.Text);
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thuốc này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    bool result = manager.XoaThuoc(maThuoc, ref error);
                    if (result)
                    {
                        MessageBox.Show("Xoá Thuốc thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xoá Thuốc không thành công");
                    }
                }
                catch (Exception ex)
                {
                    error = "Lỗi : " + ex.Message;
                    return;
                }
            }
            hienThiDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThuoc form = new ThemThuoc();
            form.ShowDialog();
            hienThiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThuocEntity entity = new ThuocEntity();
            entity.MaThuoc = Convert.ToInt32(lblMaThuoc.Text);
            entity.GiaBan = Convert.ToDouble(lblGiaBan.Text);
            entity.TenThuoc = lblTenThuoc.Text;
            entity.DonViTinh = lblDonViTinh.Text;
            SuaThuoc form = new SuaThuoc(entity);
            form.ShowDialog();
            hienThiDanhSach();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (originalDataTable != null)
            {
                DataTable filteredDataTable = originalDataTable.Clone();

                foreach (DataRow row in originalDataTable.Rows)
                {
                    if (
                        row["TenThuoc"].ToString().ToLower().Contains(keyword)
                        || row["TenLoaiThuoc"].ToString().ToLower().Contains(keyword)
                        || row["DonViTinh"].ToString().ToLower().Contains(keyword)
                        || row["GiaBan"].ToString().ToLower().Contains(keyword)
                        || row["TenNhaCungCap"].ToString().ToLower().Contains(keyword)
                        )
                    {
                        filteredDataTable.ImportRow(row);
                    }
                }

                dgThuoc.DataSource = filteredDataTable;
            }
        }
    }
}
