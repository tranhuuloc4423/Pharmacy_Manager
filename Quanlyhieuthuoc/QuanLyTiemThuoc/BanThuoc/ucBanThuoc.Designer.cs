namespace Quanlyhieuthuoc.BanThuoc
{
    partial class ucBanThuoc
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgCTHD = new DataGridView();
            panel2 = new Panel();
            dgThuoc = new DataGridView();
            MaThuoc = new DataGridViewTextBoxColumn();
            TenLoaiThuoc = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            nudSoLuong = new NumericUpDown();
            btnGiam = new Button();
            btnTang = new Button();
            lblGiaBan = new Label();
            lblLoaiThuoc = new Label();
            lblTenThuoc = new Label();
            label4 = new Label();
            label1 = new Label();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lblTongTien = new Button();
            lblGiamGia = new Button();
            lblNguoiBan = new Button();
            lblKhachHang = new Button();
            btnThemKhach = new Button();
            btnThanhToan = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            MaThuocCTHD = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCTHD).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgThuoc).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1343, 704);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgCTHD);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(674, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 346);
            panel1.TabIndex = 0;
            // 
            // dgCTHD
            // 
            dgCTHD.AllowUserToAddRows = false;
            dgCTHD.AllowUserToDeleteRows = false;
            dgCTHD.AllowUserToResizeColumns = false;
            dgCTHD.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgCTHD.BackgroundColor = Color.LightPink;
            dgCTHD.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgCTHD.ColumnHeadersHeight = 40;
            dgCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgCTHD.Columns.AddRange(new DataGridViewColumn[] { MaThuocCTHD, Column1, SoLuong, DonGia, ThanhTien });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgCTHD.DefaultCellStyle = dataGridViewCellStyle3;
            dgCTHD.Dock = DockStyle.Fill;
            dgCTHD.GridColor = Color.LightPink;
            dgCTHD.Location = new Point(0, 0);
            dgCTHD.MultiSelect = false;
            dgCTHD.Name = "dgCTHD";
            dgCTHD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgCTHD.RowHeadersVisible = false;
            dgCTHD.RowHeadersWidth = 40;
            dgCTHD.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgCTHD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCTHD.Size = new Size(666, 346);
            dgCTHD.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgThuoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 346);
            panel2.TabIndex = 1;
            // 
            // dgThuoc
            // 
            dgThuoc.AllowUserToAddRows = false;
            dgThuoc.AllowUserToDeleteRows = false;
            dgThuoc.AllowUserToResizeColumns = false;
            dgThuoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgThuoc.BackgroundColor = Color.LightPink;
            dgThuoc.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgThuoc.ColumnHeadersHeight = 40;
            dgThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgThuoc.Columns.AddRange(new DataGridViewColumn[] { MaThuoc, TenLoaiThuoc, TenThuoc, DonViTinh, GiaBan });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgThuoc.DefaultCellStyle = dataGridViewCellStyle8;
            dgThuoc.Dock = DockStyle.Fill;
            dgThuoc.GridColor = Color.LightPink;
            dgThuoc.Location = new Point(0, 0);
            dgThuoc.MultiSelect = false;
            dgThuoc.Name = "dgThuoc";
            dgThuoc.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgThuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgThuoc.RowHeadersVisible = false;
            dgThuoc.RowHeadersWidth = 40;
            dgThuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgThuoc.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgThuoc.Size = new Size(665, 346);
            dgThuoc.TabIndex = 2;
            dgThuoc.CellClick += dgThuoc_CellClick;
            // 
            // MaThuoc
            // 
            MaThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaThuoc.DataPropertyName = "MaThuoc";
            MaThuoc.HeaderText = "Mã Thuốc";
            MaThuoc.Name = "MaThuoc";
            MaThuoc.ReadOnly = true;
            MaThuoc.Visible = false;
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
            // panel3
            // 
            panel3.BackColor = Color.Thistle;
            panel3.Controls.Add(nudSoLuong);
            panel3.Controls.Add(btnGiam);
            panel3.Controls.Add(btnTang);
            panel3.Controls.Add(lblGiaBan);
            panel3.Controls.Add(lblLoaiThuoc);
            panel3.Controls.Add(lblTenThuoc);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 355);
            panel3.Name = "panel3";
            panel3.Size = new Size(665, 346);
            panel3.TabIndex = 2;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Font = new Font("Segoe UI", 16F);
            nudSoLuong.Location = new Point(251, 146);
            nudSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(70, 36);
            nudSoLuong.TabIndex = 36;
            // 
            // btnGiam
            // 
            btnGiam.BackColor = Color.White;
            btnGiam.FlatAppearance.BorderColor = Color.LightPink;
            btnGiam.FlatAppearance.BorderSize = 2;
            btnGiam.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnGiam.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnGiam.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnGiam.FlatStyle = FlatStyle.Flat;
            btnGiam.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGiam.Location = new Point(203, 147);
            btnGiam.Margin = new Padding(4, 3, 4, 3);
            btnGiam.Name = "btnGiam";
            btnGiam.Size = new Size(36, 33);
            btnGiam.TabIndex = 35;
            btnGiam.Text = "-";
            btnGiam.UseVisualStyleBackColor = false;
            btnGiam.Click += btnGiam_Click;
            // 
            // btnTang
            // 
            btnTang.BackColor = Color.White;
            btnTang.FlatAppearance.BorderColor = Color.LightPink;
            btnTang.FlatAppearance.BorderSize = 2;
            btnTang.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnTang.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnTang.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnTang.FlatStyle = FlatStyle.Flat;
            btnTang.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTang.Location = new Point(336, 148);
            btnTang.Margin = new Padding(4, 3, 4, 3);
            btnTang.Name = "btnTang";
            btnTang.Size = new Size(36, 33);
            btnTang.TabIndex = 34;
            btnTang.Text = "+";
            btnTang.UseVisualStyleBackColor = false;
            btnTang.Click += btnTang_Click;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 16F);
            lblGiaBan.Location = new Point(198, 205);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(97, 30);
            lblGiaBan.TabIndex = 32;
            lblGiaBan.Text = "Giá Bán :";
            // 
            // lblLoaiThuoc
            // 
            lblLoaiThuoc.AutoSize = true;
            lblLoaiThuoc.Font = new Font("Segoe UI", 16F);
            lblLoaiThuoc.Location = new Point(198, 95);
            lblLoaiThuoc.Name = "lblLoaiThuoc";
            lblLoaiThuoc.Size = new Size(128, 30);
            lblLoaiThuoc.TabIndex = 31;
            lblLoaiThuoc.Text = "Loại Thuốc :";
            // 
            // lblTenThuoc
            // 
            lblTenThuoc.AutoSize = true;
            lblTenThuoc.Font = new Font("Segoe UI", 16F);
            lblTenThuoc.Location = new Point(198, 40);
            lblTenThuoc.Name = "lblTenThuoc";
            lblTenThuoc.Size = new Size(123, 30);
            lblTenThuoc.TabIndex = 29;
            lblTenThuoc.Text = "Tên Thuốc :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(35, 205);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 28;
            label4.Text = "Giá Bán :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(35, 95);
            label1.Name = "label1";
            label1.Size = new Size(128, 30);
            label1.TabIndex = 27;
            label1.Text = "Loại Thuốc :";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.FlatAppearance.BorderColor = Color.LightPink;
            btnXoa.FlatAppearance.BorderSize = 2;
            btnXoa.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnXoa.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnXoa.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(471, 278);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(164, 44);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatAppearance.BorderColor = Color.LightPink;
            btnThem.FlatAppearance.BorderSize = 2;
            btnThem.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnThem.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThem.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(35, 278);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 44);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(35, 147);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 24;
            label3.Text = "Số Lượng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(35, 40);
            label2.Name = "label2";
            label2.Size = new Size(123, 30);
            label2.TabIndex = 22;
            label2.Text = "Tên Thuốc :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(lblTongTien);
            panel4.Controls.Add(lblGiamGia);
            panel4.Controls.Add(lblNguoiBan);
            panel4.Controls.Add(lblKhachHang);
            panel4.Controls.Add(btnThemKhach);
            panel4.Controls.Add(btnThanhToan);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(674, 355);
            panel4.Name = "panel4";
            panel4.Size = new Size(666, 346);
            panel4.TabIndex = 3;
            // 
            // lblTongTien
            // 
            lblTongTien.BackColor = Color.White;
            lblTongTien.Enabled = false;
            lblTongTien.FlatAppearance.BorderColor = Color.LightPink;
            lblTongTien.FlatAppearance.BorderSize = 2;
            lblTongTien.FlatAppearance.CheckedBackColor = Color.LightPink;
            lblTongTien.FlatAppearance.MouseDownBackColor = Color.LightPink;
            lblTongTien.FlatAppearance.MouseOverBackColor = Color.LightPink;
            lblTongTien.FlatStyle = FlatStyle.Flat;
            lblTongTien.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(195, 205);
            lblTongTien.Margin = new Padding(4, 3, 4, 3);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(186, 39);
            lblTongTien.TabIndex = 43;
            lblTongTien.Text = "khách hàng";
            lblTongTien.UseVisualStyleBackColor = false;
            // 
            // lblGiamGia
            // 
            lblGiamGia.BackColor = Color.White;
            lblGiamGia.Enabled = false;
            lblGiamGia.FlatAppearance.BorderColor = Color.LightPink;
            lblGiamGia.FlatAppearance.BorderSize = 2;
            lblGiamGia.FlatAppearance.CheckedBackColor = Color.LightPink;
            lblGiamGia.FlatAppearance.MouseDownBackColor = Color.LightPink;
            lblGiamGia.FlatAppearance.MouseOverBackColor = Color.LightPink;
            lblGiamGia.FlatStyle = FlatStyle.Flat;
            lblGiamGia.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiamGia.Location = new Point(195, 146);
            lblGiamGia.Margin = new Padding(4, 3, 4, 3);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(186, 39);
            lblGiamGia.TabIndex = 42;
            lblGiamGia.Text = "khách hàng";
            lblGiamGia.UseVisualStyleBackColor = false;
            // 
            // lblNguoiBan
            // 
            lblNguoiBan.BackColor = Color.White;
            lblNguoiBan.Enabled = false;
            lblNguoiBan.FlatAppearance.BorderColor = Color.LightPink;
            lblNguoiBan.FlatAppearance.BorderSize = 2;
            lblNguoiBan.FlatAppearance.CheckedBackColor = Color.LightPink;
            lblNguoiBan.FlatAppearance.MouseDownBackColor = Color.LightPink;
            lblNguoiBan.FlatAppearance.MouseOverBackColor = Color.LightPink;
            lblNguoiBan.FlatStyle = FlatStyle.Flat;
            lblNguoiBan.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNguoiBan.Location = new Point(195, 93);
            lblNguoiBan.Margin = new Padding(4, 3, 4, 3);
            lblNguoiBan.Name = "lblNguoiBan";
            lblNguoiBan.Size = new Size(186, 39);
            lblNguoiBan.TabIndex = 41;
            lblNguoiBan.Text = "khách hàng";
            lblNguoiBan.UseVisualStyleBackColor = false;
            // 
            // lblKhachHang
            // 
            lblKhachHang.BackColor = Color.White;
            lblKhachHang.Enabled = false;
            lblKhachHang.FlatAppearance.BorderColor = Color.LightPink;
            lblKhachHang.FlatAppearance.BorderSize = 2;
            lblKhachHang.FlatAppearance.CheckedBackColor = Color.LightPink;
            lblKhachHang.FlatAppearance.MouseDownBackColor = Color.LightPink;
            lblKhachHang.FlatAppearance.MouseOverBackColor = Color.LightPink;
            lblKhachHang.FlatStyle = FlatStyle.Flat;
            lblKhachHang.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKhachHang.Location = new Point(195, 38);
            lblKhachHang.Margin = new Padding(4, 3, 4, 3);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(186, 39);
            lblKhachHang.TabIndex = 40;
            lblKhachHang.Text = "khách hàng";
            lblKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnThemKhach
            // 
            btnThemKhach.BackColor = Color.White;
            btnThemKhach.FlatAppearance.BorderColor = Color.LightPink;
            btnThemKhach.FlatAppearance.BorderSize = 2;
            btnThemKhach.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnThemKhach.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThemKhach.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThemKhach.FlatStyle = FlatStyle.Flat;
            btnThemKhach.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemKhach.Location = new Point(47, 278);
            btnThemKhach.Margin = new Padding(4, 3, 4, 3);
            btnThemKhach.Name = "btnThemKhach";
            btnThemKhach.Size = new Size(225, 44);
            btnThemKhach.TabIndex = 30;
            btnThemKhach.Text = "Thêm Khách Hàng";
            btnThemKhach.UseVisualStyleBackColor = false;
            btnThemKhach.Click += btnThemKhach_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.White;
            btnThanhToan.FlatAppearance.BorderColor = Color.LightPink;
            btnThanhToan.FlatAppearance.BorderSize = 2;
            btnThanhToan.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnThanhToan.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThanhToan.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThanhToan.Location = new Point(471, 278);
            btnThanhToan.Margin = new Padding(4, 3, 4, 3);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(164, 44);
            btnThanhToan.TabIndex = 29;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F);
            label11.Location = new Point(48, 40);
            label11.Name = "label11";
            label11.Size = new Size(140, 30);
            label11.TabIndex = 36;
            label11.Text = "Khách Hàng :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F);
            label10.Location = new Point(48, 147);
            label10.Name = "label10";
            label10.Size = new Size(111, 30);
            label10.TabIndex = 37;
            label10.Text = "Giảm Giá :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(48, 95);
            label9.Name = "label9";
            label9.Size = new Size(126, 30);
            label9.TabIndex = 38;
            label9.Text = "Người Bán :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(48, 205);
            label8.Name = "label8";
            label8.Size = new Size(121, 30);
            label8.TabIndex = 39;
            label8.Text = "Tổng Tiền :";
            // 
            // MaThuocCTHD
            // 
            MaThuocCTHD.DataPropertyName = "MaThuoc";
            MaThuocCTHD.HeaderText = "Mã Thuốc";
            MaThuocCTHD.Name = "MaThuocCTHD";
            MaThuocCTHD.ReadOnly = true;
            MaThuocCTHD.Visible = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "TenThuoc";
            Column1.HeaderText = "Tên Thuốc";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // ucBanThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucBanThuoc";
            Size = new Size(1343, 704);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCTHD).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgThuoc).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgCTHD;
        private Panel panel2;
        private DataGridView dgThuoc;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label lblGiaBan;
        private Label lblLoaiThuoc;
        private Label lblTenThuoc;
        private Label label4;
        private Button btnThemKhach;
        private Button btnThanhToan;
        private Button btnGiam;
        private Button btnTang;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn TenLoaiThuoc;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn GiaBan;
        private NumericUpDown nudSoLuong;
        private Button lblTongTien;
        private Button lblGiamGia;
        private Button lblNguoiBan;
        private Button lblKhachHang;
        private DataGridViewTextBoxColumn MaThuocCTHD;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}
