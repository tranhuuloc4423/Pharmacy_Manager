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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            dgThuoc = new DataGridView();
            MaThuoc = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            TenLoaiThuoc = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dgCTHD = new DataGridView();
            MaThuocCTHD = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            lblNguoiBan = new Label();
            lblTongTien = new Label();
            lblKhachHang = new Label();
            nudSoLuong = new NumericUpDown();
            btnGiam = new Button();
            btnTang = new Button();
            btnThemKhach = new Button();
            lblGiaBan = new Label();
            btnThanhToan = new Button();
            lblLoaiThuoc = new Label();
            label11 = new Label();
            lblTenThuoc = new Label();
            label4 = new Label();
            label9 = new Label();
            label1 = new Label();
            label8 = new Label();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgThuoc).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCTHD).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1360, 617);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1354, 302);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgThuoc);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 296);
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
            dgThuoc.Columns.AddRange(new DataGridViewColumn[] { MaThuoc, TenThuoc, TenLoaiThuoc, DonViTinh, GiaBan });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgThuoc.DefaultCellStyle = dataGridViewCellStyle4;
            dgThuoc.Dock = DockStyle.Fill;
            dgThuoc.GridColor = Color.LightPink;
            dgThuoc.Location = new Point(0, 0);
            dgThuoc.MultiSelect = false;
            dgThuoc.Name = "dgThuoc";
            dgThuoc.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgThuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgThuoc.RowHeadersVisible = false;
            dgThuoc.RowHeadersWidth = 40;
            dgThuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgThuoc.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgThuoc.Size = new Size(738, 296);
            dgThuoc.TabIndex = 3;
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
            // TenThuoc
            // 
            TenThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenThuoc.DataPropertyName = "TenThuoc";
            TenThuoc.HeaderText = "Tên Thuốc";
            TenThuoc.Name = "TenThuoc";
            TenThuoc.ReadOnly = true;
            // 
            // TenLoaiThuoc
            // 
            TenLoaiThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoaiThuoc.DataPropertyName = "TenLoaiThuoc";
            TenLoaiThuoc.HeaderText = "Tên Loại Thuốc";
            TenLoaiThuoc.Name = "TenLoaiThuoc";
            TenLoaiThuoc.ReadOnly = true;
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
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            GiaBan.DefaultCellStyle = dataGridViewCellStyle3;
            GiaBan.HeaderText = "Giá Bán";
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgCTHD);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(747, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(604, 296);
            panel2.TabIndex = 1;
            // 
            // dgCTHD
            // 
            dgCTHD.AllowUserToAddRows = false;
            dgCTHD.AllowUserToDeleteRows = false;
            dgCTHD.AllowUserToResizeColumns = false;
            dgCTHD.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgCTHD.BackgroundColor = Color.LightPink;
            dgCTHD.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgCTHD.ColumnHeadersHeight = 40;
            dgCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgCTHD.Columns.AddRange(new DataGridViewColumn[] { MaThuocCTHD, Column1, SoLuong, DonGia, ThanhTien });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgCTHD.DefaultCellStyle = dataGridViewCellStyle12;
            dgCTHD.Dock = DockStyle.Fill;
            dgCTHD.GridColor = Color.LightPink;
            dgCTHD.Location = new Point(0, 0);
            dgCTHD.MultiSelect = false;
            dgCTHD.Name = "dgCTHD";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgCTHD.RowHeadersVisible = false;
            dgCTHD.RowHeadersWidth = 40;
            dgCTHD.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgCTHD.RowsDefaultCellStyle = dataGridViewCellStyle14;
            dgCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCTHD.Size = new Size(604, 296);
            dgCTHD.TabIndex = 3;
            dgCTHD.CellEndEdit += dgCTHD_CellEndEdit;
            dgCTHD.CellValidating += dgCTHD_CellValidating;
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
            dataGridViewCellStyle9.Format = "N0";
            SoLuong.DefaultCellStyle = dataGridViewCellStyle9;
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            DonGia.DefaultCellStyle = dataGridViewCellStyle10;
            DonGia.HeaderText = "Đơn Giá";
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle11.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle11;
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Thistle;
            panel3.Controls.Add(lblNguoiBan);
            panel3.Controls.Add(lblTongTien);
            panel3.Controls.Add(lblKhachHang);
            panel3.Controls.Add(nudSoLuong);
            panel3.Controls.Add(btnGiam);
            panel3.Controls.Add(btnTang);
            panel3.Controls.Add(btnThemKhach);
            panel3.Controls.Add(lblGiaBan);
            panel3.Controls.Add(btnThanhToan);
            panel3.Controls.Add(lblLoaiThuoc);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(lblTenThuoc);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 311);
            panel3.Name = "panel3";
            panel3.Size = new Size(1354, 303);
            panel3.TabIndex = 1;
            // 
            // lblNguoiBan
            // 
            lblNguoiBan.AutoSize = true;
            lblNguoiBan.Font = new Font("Segoe UI", 16F);
            lblNguoiBan.Location = new Point(866, 88);
            lblNguoiBan.Name = "lblNguoiBan";
            lblNguoiBan.Size = new Size(28, 30);
            lblNguoiBan.TabIndex = 68;
            lblNguoiBan.Text = "...";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 16F);
            lblTongTien.Location = new Point(866, 144);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(28, 30);
            lblTongTien.TabIndex = 67;
            lblTongTien.Text = "...";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 16F);
            lblKhachHang.Location = new Point(866, 33);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(28, 30);
            lblKhachHang.TabIndex = 66;
            lblKhachHang.Text = "...";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Font = new Font("Segoe UI", 16F);
            nudSoLuong.Location = new Point(253, 125);
            nudSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(70, 36);
            nudSoLuong.TabIndex = 58;
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
            btnGiam.Location = new Point(205, 126);
            btnGiam.Margin = new Padding(4, 3, 4, 3);
            btnGiam.Name = "btnGiam";
            btnGiam.Size = new Size(36, 33);
            btnGiam.TabIndex = 56;
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
            btnTang.Location = new Point(338, 127);
            btnTang.Margin = new Padding(4, 3, 4, 3);
            btnTang.Name = "btnTang";
            btnTang.Size = new Size(36, 33);
            btnTang.TabIndex = 55;
            btnTang.Text = "+";
            btnTang.UseVisualStyleBackColor = false;
            btnTang.Click += btnTang_Click;
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
            btnThemKhach.Location = new Point(645, 224);
            btnThemKhach.Margin = new Padding(4, 3, 4, 3);
            btnThemKhach.Name = "btnThemKhach";
            btnThemKhach.Size = new Size(225, 44);
            btnThemKhach.TabIndex = 52;
            btnThemKhach.Text = "Thêm Khách Hàng";
            btnThemKhach.UseVisualStyleBackColor = false;
            btnThemKhach.Click += btnThemKhach_Click;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 16F);
            lblGiaBan.Location = new Point(200, 179);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(28, 30);
            lblGiaBan.TabIndex = 54;
            lblGiaBan.Text = "...";
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
            btnThanhToan.Location = new Point(889, 224);
            btnThanhToan.Margin = new Padding(4, 3, 4, 3);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(164, 44);
            btnThanhToan.TabIndex = 51;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lblLoaiThuoc
            // 
            lblLoaiThuoc.AutoSize = true;
            lblLoaiThuoc.Font = new Font("Segoe UI", 16F);
            lblLoaiThuoc.Location = new Point(200, 69);
            lblLoaiThuoc.Name = "lblLoaiThuoc";
            lblLoaiThuoc.Size = new Size(28, 30);
            lblLoaiThuoc.TabIndex = 53;
            lblLoaiThuoc.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F);
            label11.Location = new Point(645, 33);
            label11.Name = "label11";
            label11.Size = new Size(140, 30);
            label11.TabIndex = 57;
            label11.Text = "Khách Hàng :";
            // 
            // lblTenThuoc
            // 
            lblTenThuoc.AutoSize = true;
            lblTenThuoc.Font = new Font("Segoe UI", 16F);
            lblTenThuoc.Location = new Point(200, 14);
            lblTenThuoc.Name = "lblTenThuoc";
            lblTenThuoc.Size = new Size(28, 30);
            lblTenThuoc.TabIndex = 50;
            lblTenThuoc.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(38, 179);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 49;
            label4.Text = "Giá Bán :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(645, 88);
            label9.Name = "label9";
            label9.Size = new Size(126, 30);
            label9.TabIndex = 60;
            label9.Text = "Người Bán :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(38, 69);
            label1.Name = "label1";
            label1.Size = new Size(128, 30);
            label1.TabIndex = 48;
            label1.Text = "Loại Thuốc :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(645, 144);
            label8.Name = "label8";
            label8.Size = new Size(121, 30);
            label8.TabIndex = 61;
            label8.Text = "Tổng Tiền :";
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
            btnXoa.Location = new Point(253, 224);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(164, 44);
            btnXoa.TabIndex = 47;
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
            btnThem.Location = new Point(38, 224);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 44);
            btnThem.TabIndex = 45;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(38, 121);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 46;
            label3.Text = "Số Lượng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(38, 14);
            label2.Name = "label2";
            label2.Size = new Size(123, 30);
            label2.TabIndex = 44;
            label2.Text = "Tên Thuốc :";
            // 
            // ucBanThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucBanThuoc";
            Size = new Size(1360, 617);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgThuoc).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCTHD).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private DataGridView dgThuoc;
        private Panel panel2;
        private DataGridView dgCTHD;
        private Panel panel3;
        private NumericUpDown nudSoLuong;
        private Button btnGiam;
        private Button btnTang;
        private Button btnThemKhach;
        private Label lblGiaBan;
        private Button btnThanhToan;
        private Label lblLoaiThuoc;
        private Label label11;
        private Label lblTenThuoc;
        private Label label4;
        private Label label9;
        private Label label1;
        private Label label8;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label lblNguoiBan;
        private Label lblTongTien;
        private Label lblKhachHang;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn TenLoaiThuoc;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn MaThuocCTHD;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}
