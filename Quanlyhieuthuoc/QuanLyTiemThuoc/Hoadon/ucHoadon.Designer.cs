namespace Quanlyhieuthuoc.Hoadon
{
    partial class ucHoadon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lblNgayKetThuc = new Label();
            lblNgayBatDau = new Label();
            btnInHoaDon = new Button();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            panel2 = new Panel();
            dgHoaDon = new DataGridView();
            MaHoaDon = new DataGridViewTextBoxColumn();
            TenTaiKhoan = new DataGridViewTextBoxColumn();
            NgayBan = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgHoaDon).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1110, 621);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(lblNgayKetThuc);
            panel1.Controls.Add(lblNgayBatDau);
            panel1.Controls.Add(btnInHoaDon);
            panel1.Controls.Add(dtpNgayKetThuc);
            panel1.Controls.Add(dtpNgayBatDau);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 74);
            panel1.TabIndex = 0;
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Font = new Font("Tahoma", 16F);
            lblNgayKetThuc.Location = new Point(405, 24);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new Size(155, 27);
            lblNgayKetThuc.TabIndex = 15;
            lblNgayKetThuc.Text = "Ngày Kết Thúc";
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Font = new Font("Tahoma", 16F);
            lblNgayBatDau.Location = new Point(22, 24);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(147, 27);
            lblNgayBatDau.TabIndex = 14;
            lblNgayBatDau.Text = "Ngày Bắt Đầu";
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.White;
            btnInHoaDon.FlatAppearance.BorderColor = Color.LightPink;
            btnInHoaDon.FlatAppearance.BorderSize = 2;
            btnInHoaDon.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnInHoaDon.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnInHoaDon.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInHoaDon.Location = new Point(905, 19);
            btnInHoaDon.Margin = new Padding(4, 3, 4, 3);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(164, 37);
            btnInHoaDon.TabIndex = 13;
            btnInHoaDon.Text = "In Hoá Đơn";
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Font = new Font("Segoe UI", 16F);
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Location = new Point(566, 20);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(164, 36);
            dtpNgayKetThuc.TabIndex = 1;
            dtpNgayKetThuc.Value = new DateTime(2024, 5, 3, 0, 0, 0, 0);
            dtpNgayKetThuc.ValueChanged += dtpNgayKetThuc_ValueChanged;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Font = new Font("Segoe UI", 16F);
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(175, 19);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(170, 36);
            dtpNgayBatDau.TabIndex = 0;
            dtpNgayBatDau.ValueChanged += dtpNgayBatDau_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgHoaDon);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 535);
            panel2.TabIndex = 1;
            // 
            // dgHoaDon
            // 
            dgHoaDon.AllowUserToAddRows = false;
            dgHoaDon.AllowUserToDeleteRows = false;
            dgHoaDon.AllowUserToResizeColumns = false;
            dgHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgHoaDon.BackgroundColor = Color.LightPink;
            dgHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgHoaDon.ColumnHeadersHeight = 40;
            dgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, TenTaiKhoan, NgayBan, TenKhachHang, TongTien });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgHoaDon.DefaultCellStyle = dataGridViewCellStyle4;
            dgHoaDon.Dock = DockStyle.Fill;
            dgHoaDon.GridColor = Color.LightPink;
            dgHoaDon.Location = new Point(0, 0);
            dgHoaDon.MultiSelect = false;
            dgHoaDon.Name = "dgHoaDon";
            dgHoaDon.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgHoaDon.RowHeadersVisible = false;
            dgHoaDon.RowHeadersWidth = 40;
            dgHoaDon.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgHoaDon.Size = new Size(1104, 535);
            dgHoaDon.TabIndex = 2;
            dgHoaDon.CellClick += dgHoaDon_CellClick;
            // 
            // MaHoaDon
            // 
            MaHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaHoaDon.DataPropertyName = "MaHoaDon";
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            // 
            // TenTaiKhoan
            // 
            TenTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            TenTaiKhoan.HeaderText = "Tên Người Bán";
            TenTaiKhoan.Name = "TenTaiKhoan";
            TenTaiKhoan.ReadOnly = true;
            // 
            // NgayBan
            // 
            NgayBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayBan.DataPropertyName = "NgayBan";
            NgayBan.HeaderText = "Ngày Bán";
            NgayBan.Name = "NgayBan";
            NgayBan.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            TenKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKhachHang.DataPropertyName = "HoTen";
            TenKhachHang.HeaderText = "Tên Khách Hàng";
            TenKhachHang.Name = "TenKhachHang";
            TenKhachHang.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle3.Format = "N0";
            TongTien.DefaultCellStyle = dataGridViewCellStyle3;
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // ucHoadon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucHoadon";
            Size = new Size(1110, 621);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private DataGridView dgHoaDon;
        private Label lblNgayKetThuc;
        private Label lblNgayBatDau;
        private Button btnInHoaDon;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn TenTaiKhoan;
        private DataGridViewTextBoxColumn NgayBan;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn TongTien;
    }
}
