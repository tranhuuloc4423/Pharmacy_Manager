﻿using BLL.Managers;
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
            hienThiQuyen();
        }

        private void ucTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void hienThiQuyen()
        {
            DataTable data = new DataTable();
            data = quyenManager.HienThiDanhSach(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                cbQuyen.DataSource = data;
                cbQuyen.DisplayMember = "MoTa";
                cbQuyen.ValueMember = "MaQuyen";
            }
        }

        private void hienThiDanhSachTaiKhoan()
        {
            DataTable data = new DataTable();
            data = taiKhoanManager.hienThiDanhSachTaiKhoan(ref error);
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
                    lblTaiKhoan.Text = rowselected.Cells["TenTaiKhoan"].Value.ToString();
                    lblHoTen.Text = rowselected.Cells["HoTen"].Value.ToString();
                    cbQuyen.Text = rowselected.Cells["MoTa"].Value.ToString();
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

            try
            {
                bool result = taiKhoanManager.XoaTaiKhoan(tenTaiKhoan, ref error);
                if (result)
                {
                    MessageBox.Show("Xoá tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Xoá tài khoản không thành công");
                }
            }
            catch (Exception ex)
            {
                error = "Lỗi : " + ex.Message;
                return;
            }
            hienThiDanhSachTaiKhoan();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TaiKhoanEntity entity = new TaiKhoanEntity();
            entity.TenTaiKhoan = lblTenTaiKhoan.Text;
            entity.HoTen = lblHoTen.Text;
            entity.VaiTro = Convert.ToInt32(cbQuyen.SelectedValue);
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
                cbQuyen.Text = rowselected.Cells["MoTa"].Value.ToString();
            }
        }
    }
}