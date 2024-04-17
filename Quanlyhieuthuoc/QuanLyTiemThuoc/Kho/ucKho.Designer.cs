namespace Quanlyhieuthuoc.Kho
{
    partial class ucKho
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgTaiKhoan = new DataGridView();
            panel2 = new Panel();
            lblGiaBan = new Label();
            label6 = new Label();
            lblDonViTinh = new Label();
            cbLoaiThuoc = new ComboBox();
            lblTenThuoc = new Label();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblKhoThuoc = new Label();
            Thang = new DataGridViewTextBoxColumn();
            Nam = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            DauKy = new DataGridViewTextBoxColumn();
            NhapTrongKy = new DataGridViewTextBoxColumn();
            XuatTrongThang = new DataGridViewTextBoxColumn();
            TonKho = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTaiKhoan).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1132, 592);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgTaiKhoan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 586);
            panel1.TabIndex = 0;
            // 
            // dgTaiKhoan
            // 
            dgTaiKhoan.AllowUserToAddRows = false;
            dgTaiKhoan.AllowUserToDeleteRows = false;
            dgTaiKhoan.AllowUserToResizeColumns = false;
            dgTaiKhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgTaiKhoan.BackgroundColor = Color.LightPink;
            dgTaiKhoan.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgTaiKhoan.ColumnHeadersHeight = 40;
            dgTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { Thang, Nam, TenThuoc, DauKy, NhapTrongKy, XuatTrongThang, TonKho });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgTaiKhoan.DefaultCellStyle = dataGridViewCellStyle8;
            dgTaiKhoan.Dock = DockStyle.Fill;
            dgTaiKhoan.GridColor = Color.LightPink;
            dgTaiKhoan.Location = new Point(0, 0);
            dgTaiKhoan.MultiSelect = false;
            dgTaiKhoan.Name = "dgTaiKhoan";
            dgTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgTaiKhoan.RowHeadersVisible = false;
            dgTaiKhoan.RowHeadersWidth = 40;
            dgTaiKhoan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTaiKhoan.Size = new Size(726, 586);
            dgTaiKhoan.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(lblGiaBan);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblDonViTinh);
            panel2.Controls.Add(cbLoaiThuoc);
            panel2.Controls.Add(lblTenThuoc);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblKhoThuoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(735, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 586);
            panel2.TabIndex = 1;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 16F);
            lblGiaBan.Location = new Point(203, 280);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(112, 30);
            lblGiaBan.TabIndex = 21;
            lblGiaBan.Text = "Tên Thuốc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(39, 280);
            label6.Name = "label6";
            label6.Size = new Size(97, 30);
            label6.TabIndex = 20;
            label6.Text = "Giá Bán :";
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Font = new Font("Segoe UI", 16F);
            lblDonViTinh.Location = new Point(203, 230);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(112, 30);
            lblDonViTinh.TabIndex = 19;
            lblDonViTinh.Text = "Tên Thuốc";
            // 
            // cbLoaiThuoc
            // 
            cbLoaiThuoc.Enabled = false;
            cbLoaiThuoc.Font = new Font("Segoe UI", 14F);
            cbLoaiThuoc.FormattingEnabled = true;
            cbLoaiThuoc.Items.AddRange(new object[] { "admin", "user" });
            cbLoaiThuoc.Location = new Point(203, 164);
            cbLoaiThuoc.Name = "cbLoaiThuoc";
            cbLoaiThuoc.Size = new Size(146, 33);
            cbLoaiThuoc.TabIndex = 18;
            // 
            // lblTenThuoc
            // 
            lblTenThuoc.AutoSize = true;
            lblTenThuoc.Font = new Font("Segoe UI", 16F);
            lblTenThuoc.Location = new Point(203, 104);
            lblTenThuoc.Name = "lblTenThuoc";
            lblTenThuoc.Size = new Size(112, 30);
            lblTenThuoc.TabIndex = 16;
            lblTenThuoc.Text = "Tên Thuốc";
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
            btnThem.Location = new Point(39, 356);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 44);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(39, 230);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 13;
            label3.Text = "Đơn Vị Tính :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(39, 164);
            label2.Name = "label2";
            label2.Size = new Size(128, 30);
            label2.TabIndex = 11;
            label2.Text = "Loại Thuốc :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(39, 104);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 10;
            label1.Text = "Tên Thuốc :";
            // 
            // lblKhoThuoc
            // 
            lblKhoThuoc.AutoSize = true;
            lblKhoThuoc.Font = new Font("Segoe UI", 16F);
            lblKhoThuoc.Location = new Point(170, 41);
            lblKhoThuoc.Name = "lblKhoThuoc";
            lblKhoThuoc.Size = new Size(116, 30);
            lblKhoThuoc.TabIndex = 9;
            lblKhoThuoc.Text = "Kho Thuốc";
            // 
            // Thang
            // 
            Thang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Thang.DataPropertyName = "Thang";
            Thang.HeaderText = "Tháng";
            Thang.Name = "Thang";
            Thang.ReadOnly = true;
            // 
            // Nam
            // 
            Nam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nam.DataPropertyName = "Nam";
            Nam.HeaderText = "Năm";
            Nam.Name = "Nam";
            Nam.ReadOnly = true;
            // 
            // TenThuoc
            // 
            TenThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenThuoc.DataPropertyName = "TenThuoc";
            TenThuoc.HeaderText = "Tên Thuốc";
            TenThuoc.Name = "TenThuoc";
            TenThuoc.ReadOnly = true;
            // 
            // DauKy
            // 
            DauKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DauKy.DataPropertyName = "DauKy";
            DauKy.HeaderText = "Đầu Kỳ";
            DauKy.Name = "DauKy";
            DauKy.ReadOnly = true;
            // 
            // NhapTrongKy
            // 
            NhapTrongKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NhapTrongKy.DataPropertyName = "NhapTrongKy";
            NhapTrongKy.HeaderText = "Trong Kỳ";
            NhapTrongKy.Name = "NhapTrongKy";
            NhapTrongKy.ReadOnly = true;
            // 
            // XuatTrongThang
            // 
            XuatTrongThang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            XuatTrongThang.DataPropertyName = "XuatTrongThang";
            XuatTrongThang.HeaderText = "Xuất Trong Tháng";
            XuatTrongThang.Name = "XuatTrongThang";
            XuatTrongThang.ReadOnly = true;
            // 
            // TonKho
            // 
            TonKho.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TonKho.DataPropertyName = "TonKho";
            TonKho.HeaderText = "Tồn Kho";
            TonKho.Name = "TonKho";
            TonKho.ReadOnly = true;
            // 
            // ucKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucKho";
            Size = new Size(1132, 592);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTaiKhoan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgTaiKhoan;
        private Panel panel2;
        private Label lblGiaBan;
        private Label label6;
        private Label lblDonViTinh;
        private ComboBox cbLoaiThuoc;
        private Label lblTenThuoc;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblKhoThuoc;
        private DataGridViewTextBoxColumn Thang;
        private DataGridViewTextBoxColumn Nam;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DauKy;
        private DataGridViewTextBoxColumn NhapTrongKy;
        private DataGridViewTextBoxColumn XuatTrongThang;
        private DataGridViewTextBoxColumn TonKho;
    }
}
