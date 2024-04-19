namespace Quanlyhieuthuoc.Kho
{
    partial class ThemThuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgThuoc = new DataGridView();
            MaThuoc = new DataGridViewTextBoxColumn();
            TenLoaiThuoc = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgThuoc).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(832, 507);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgThuoc);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 501);
            panel1.TabIndex = 0;
            // 
            // dgThuoc
            // 
            dgThuoc.AllowUserToAddRows = false;
            dgThuoc.AllowUserToDeleteRows = false;
            dgThuoc.AllowUserToResizeColumns = false;
            dgThuoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgThuoc.BackgroundColor = Color.LightPink;
            dgThuoc.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgThuoc.ColumnHeadersHeight = 40;
            dgThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgThuoc.Columns.AddRange(new DataGridViewColumn[] { MaThuoc, TenLoaiThuoc, TenThuoc, DonViTinh, GiaBan });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgThuoc.DefaultCellStyle = dataGridViewCellStyle3;
            dgThuoc.Dock = DockStyle.Fill;
            dgThuoc.GridColor = Color.LightPink;
            dgThuoc.Location = new Point(0, 0);
            dgThuoc.MultiSelect = false;
            dgThuoc.Name = "dgThuoc";
            dgThuoc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgThuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgThuoc.RowHeadersVisible = false;
            dgThuoc.RowHeadersWidth = 40;
            dgThuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgThuoc.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgThuoc.Size = new Size(826, 501);
            dgThuoc.TabIndex = 2;
            dgThuoc.CellDoubleClick += dgThuoc_CellDoubleClick;
            // 
            // MaThuoc
            // 
            MaThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaThuoc.DataPropertyName = "MaThuoc";
            MaThuoc.HeaderText = "Mã Thuốc";
            MaThuoc.Name = "MaThuoc";
            MaThuoc.ReadOnly = true;
            // 
            // TenLoaiThuoc
            // 
            TenLoaiThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoaiThuoc.DataPropertyName = "TenLoaiThuoc";
            TenLoaiThuoc.HeaderText = "Tên Loại Thuốc";
            TenLoaiThuoc.Name = "TenLoaiThuoc";
            TenLoaiThuoc.ReadOnly = true;
            // 
            // TenThuoc
            // 
            TenThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenThuoc.DataPropertyName = "TenThuoc";
            TenThuoc.HeaderText = "Tên Thuốc";
            TenThuoc.Name = "TenThuoc";
            TenThuoc.ReadOnly = true;
            // 
            // DonViTinh
            // 
            DonViTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DonViTinh.DataPropertyName = "DonViTinh";
            DonViTinh.HeaderText = "Đơn Vị Tính";
            DonViTinh.Name = "DonViTinh";
            DonViTinh.ReadOnly = true;
            // 
            // GiaBan
            // 
            GiaBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GiaBan.DataPropertyName = "GiaBan";
            GiaBan.HeaderText = "Giá Bán";
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // ThemThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 507);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThemThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemThuoc";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgThuoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgThuoc;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn TenLoaiThuoc;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn GiaBan;
    }
}