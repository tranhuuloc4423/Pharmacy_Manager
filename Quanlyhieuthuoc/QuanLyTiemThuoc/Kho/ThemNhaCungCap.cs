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

namespace Quanlyhieuthuoc.Kho
{
    public partial class ThemNhaCungCap : Form
    {
        public DataGridViewRow row = null;
        private NhaCungCapManager manager = null;
        private string error = null;
        public ThemNhaCungCap()
        {
            InitializeComponent();
            manager = new NhaCungCapManager();
            error = "";
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
                dgNhaCungCap.DataSource = data;
                if (dgNhaCungCap.Rows.Count > 0)
                {
                    row = dgNhaCungCap.Rows[0];
                }
            }
        }


        private void dgNhaCungCap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgNhaCungCap.RowCount)
            {
                row = dgNhaCungCap.Rows[e.RowIndex];
                this.Close();
            }
        }
    }
}
