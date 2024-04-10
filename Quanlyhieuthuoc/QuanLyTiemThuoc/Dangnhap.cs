﻿using BLL.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quanlyhieuthuoc
{
    public partial class Dangnhap : Form
    {
        TaiKhoanManager taiKhoanManager;
        public Dangnhap()
        {
            InitializeComponent();
            taiKhoanManager = new TaiKhoanManager();
        }

        private void txtDangNhap_Click(object sender, EventArgs e)
        {
            txtDangNhap.SelectAll();
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.SelectAll();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(tenTaiKhoan))
            {
                MessageBox.Show("Vui long nhap ten tai khoan!");
                return;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui long nhap mat khau!");
                return;
            }
            string connectionSTR = "Data Source=ROKU\\SQLEXPRESS;Initial Catalog=Project_QLTT;Integrated Security=True";

            SqlConnection connection = null;

            try
            {
                using (connection = new SqlConnection(connectionSTR))
                {
                    SqlCommand command = new SqlCommand("KiemTraTaiKhoan", connection);
                    command.CommandText = "select VaiTro from TaiKhoan where TenTaiKhoan like @TenTaiKhoan and MatKhau like @MatKhau";
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                    connection.Open();
                    object data = command.ExecuteScalar();

                    if (data == null)
                    {
                        MessageBox.Show("Loi tai khoan, dang nhap khong thanh cong");
                    }
                    else
                    {
                        //MessageBox.Show("Dan nhap thanh cong, ten nguoi dang la: "+data.ToString());
                        CauHinhHeThong.TenDangNhap = txtDangNhap.Text;
                        CauHinhHeThong.TenDayDu = data.ToString();
                        Main frm = new Main(data.ToString());
                        frm.Show();
                        this.Hide();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
