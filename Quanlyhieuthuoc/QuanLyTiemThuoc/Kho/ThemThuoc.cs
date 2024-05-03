using BLL.Managers;
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

namespace Quanlyhieuthuoc.Kho
{
    public partial class ThemThuoc : Form
    {
        public DataGridViewRow row = null;
        private ThuocManager manager = null;
        private string error = null;
        public ThemThuoc()
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
                dgThuoc.DataSource = data;
                if (dgThuoc.Rows.Count > 0)
                {
                    row = dgThuoc.Rows[0];
                }
            }
        }

        private void dgThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgThuoc.RowCount)
            {
                row = dgThuoc.Rows[e.RowIndex];
                this.Close();
            }
        }
    }
}
