using BLL.Managers;
using Quanlyhieuthuoc.Thuoc;
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

namespace Quanlyhieuthuoc.BanThuoc
{
    public partial class ThemKhachHang : Form
    {
        private KhachHangManager manager = null;
        private string error = null;
        public DataGridViewRow rowSelected = null;
        public ThemKhachHang()
        {
            InitializeComponent();
            manager = new KhachHangManager();
            error = null;
            hienThiDanhSach();
        }

        private void hienThiDanhSach()
        {
            DataTable data = new DataTable();
            data = manager.HienThiDanhSach(ref error);
            if (data == null)
            {
                MessageBox.Show(error);
            }
            else
            {
                dgKhachHang.DataSource = data;
                if (dgKhachHang.Rows.Count > 0)
                {
                    rowSelected = dgKhachHang.Rows[0];
                }
            }
        }

        private void dgKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgKhachHang.RowCount)
            {
                rowSelected = dgKhachHang.Rows[e.RowIndex];
                this.Close();
            }
        }
    }
}
