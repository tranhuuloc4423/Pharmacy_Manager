namespace Quanlyhieuthuoc.BanThuoc
{
    partial class ThemKhachHang
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
            dgKhachHang = new DataGridView();
            MaKhachHang = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            KhachHangThanThiet = new DataGridViewTextBoxColumn();
            MuaTichLuy = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgKhachHang).BeginInit();
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
            tableLayoutPanel1.Size = new Size(991, 591);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgKhachHang);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 585);
            panel1.TabIndex = 0;
            // 
            // dgKhachHang
            // 
            dgKhachHang.AllowUserToAddRows = false;
            dgKhachHang.AllowUserToDeleteRows = false;
            dgKhachHang.AllowUserToResizeColumns = false;
            dgKhachHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgKhachHang.BackgroundColor = Color.LightPink;
            dgKhachHang.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgKhachHang.ColumnHeadersHeight = 40;
            dgKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKhachHang, HoTen, SoDienThoai, KhachHangThanThiet, MuaTichLuy });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgKhachHang.Dock = DockStyle.Fill;
            dgKhachHang.GridColor = Color.LightPink;
            dgKhachHang.Location = new Point(0, 0);
            dgKhachHang.MultiSelect = false;
            dgKhachHang.Name = "dgKhachHang";
            dgKhachHang.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgKhachHang.RowHeadersVisible = false;
            dgKhachHang.RowHeadersWidth = 40;
            dgKhachHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKhachHang.Size = new Size(985, 585);
            dgKhachHang.TabIndex = 2;
            dgKhachHang.CellDoubleClick += dgKhachHang_CellDoubleClick;
            // 
            // MaKhachHang
            // 
            MaKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaKhachHang.DataPropertyName = "MaKhachHang";
            MaKhachHang.HeaderText = "Mã Khách Hàng";
            MaKhachHang.Name = "MaKhachHang";
            MaKhachHang.ReadOnly = true;
            MaKhachHang.Visible = false;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ Tên";
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số ĐT";
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // KhachHangThanThiet
            // 
            KhachHangThanThiet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            KhachHangThanThiet.DataPropertyName = "KhachHangThanThiet";
            KhachHangThanThiet.HeaderText = "Khách Hàng Thân Thiết";
            KhachHangThanThiet.Name = "KhachHangThanThiet";
            KhachHangThanThiet.ReadOnly = true;
            KhachHangThanThiet.Visible = false;
            // 
            // MuaTichLuy
            // 
            MuaTichLuy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MuaTichLuy.DataPropertyName = "MuaTichLuy";
            MuaTichLuy.HeaderText = "Mua Tích Luỹ";
            MuaTichLuy.Name = "MuaTichLuy";
            MuaTichLuy.ReadOnly = true;
            MuaTichLuy.Visible = false;
            // 
            // ThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 591);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThemKhachHang";
            Text = "ThemKhachHang";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgKhachHang;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn KhachHangThanThiet;
        private DataGridViewTextBoxColumn MuaTichLuy;
    }
}