namespace Quanlyhieuthuoc.Nhacungcap
{
    partial class ucNhaCungCap
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgNhaCungCap = new DataGridView();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblTenNCC = new Label();
            lblDiaChi = new Label();
            lblMaNCC = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTaiKhoan = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgNhaCungCap).BeginInit();
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
            tableLayoutPanel1.Size = new Size(1065, 571);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgNhaCungCap);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 565);
            panel1.TabIndex = 0;
            // 
            // dgNhaCungCap
            // 
            dgNhaCungCap.AllowUserToAddRows = false;
            dgNhaCungCap.AllowUserToDeleteRows = false;
            dgNhaCungCap.AllowUserToResizeColumns = false;
            dgNhaCungCap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgNhaCungCap.BackgroundColor = Color.LightPink;
            dgNhaCungCap.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgNhaCungCap.ColumnHeadersHeight = 40;
            dgNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { MaNhaCungCap, TenNhaCungCap, DiaChi });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgNhaCungCap.DefaultCellStyle = dataGridViewCellStyle3;
            dgNhaCungCap.Dock = DockStyle.Fill;
            dgNhaCungCap.GridColor = Color.LightPink;
            dgNhaCungCap.Location = new Point(0, 0);
            dgNhaCungCap.MultiSelect = false;
            dgNhaCungCap.Name = "dgNhaCungCap";
            dgNhaCungCap.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgNhaCungCap.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgNhaCungCap.RowHeadersVisible = false;
            dgNhaCungCap.RowHeadersWidth = 40;
            dgNhaCungCap.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgNhaCungCap.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgNhaCungCap.Size = new Size(659, 565);
            dgNhaCungCap.TabIndex = 1;
            dgNhaCungCap.CellClick += dgNhaCungCap_CellClick;
            // 
            // MaNhaCungCap
            // 
            MaNhaCungCap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            MaNhaCungCap.HeaderText = "Mã NCC";
            MaNhaCungCap.Name = "MaNhaCungCap";
            MaNhaCungCap.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Tên NCC";
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(lblTenNCC);
            panel2.Controls.Add(lblDiaChi);
            panel2.Controls.Add(lblMaNCC);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTaiKhoan);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(668, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 565);
            panel2.TabIndex = 1;
            // 
            // lblTenNCC
            // 
            lblTenNCC.AutoSize = true;
            lblTenNCC.Font = new Font("Segoe UI", 16F);
            lblTenNCC.Location = new Point(203, 164);
            lblTenNCC.Name = "lblTenNCC";
            lblTenNCC.Size = new Size(112, 30);
            lblTenNCC.TabIndex = 20;
            lblTenNCC.Text = "Tên Thuốc";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 16F);
            lblDiaChi.Location = new Point(203, 230);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(112, 30);
            lblDiaChi.TabIndex = 19;
            lblDiaChi.Text = "Tên Thuốc";
            // 
            // lblMaNCC
            // 
            lblMaNCC.AutoSize = true;
            lblMaNCC.Font = new Font("Segoe UI", 16F);
            lblMaNCC.Location = new Point(203, 104);
            lblMaNCC.Name = "lblMaNCC";
            lblMaNCC.Size = new Size(112, 30);
            lblMaNCC.TabIndex = 16;
            lblMaNCC.Text = "Tên Thuốc";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.FlatAppearance.BorderColor = Color.LightPink;
            btnSua.FlatAppearance.BorderSize = 2;
            btnSua.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnSua.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnSua.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(215, 364);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(164, 44);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
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
            btnXoa.Location = new Point(22, 440);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(164, 44);
            btnXoa.TabIndex = 15;
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
            btnThem.Location = new Point(22, 364);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 44);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(39, 230);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 13;
            label3.Text = "Địa Chỉ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(39, 164);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 11;
            label2.Text = "Tên NCC :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(39, 104);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 10;
            label1.Text = "Mã NCC :";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 16F);
            lblTaiKhoan.Location = new Point(136, 29);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(153, 30);
            lblTaiKhoan.TabIndex = 9;
            lblTaiKhoan.Text = "Nhà Cung Cấp";
            // 
            // ucNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucNhaCungCap";
            Size = new Size(1065, 571);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgNhaCungCap).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgNhaCungCap;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn TenLoaiThuoc;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn GiaBan;
        private Panel panel2;
        private Label lblGiaBan;
        private Label label6;
        private Label lblDiaChi;
        private ComboBox cbLoaiThuoc;
        private Label lblMaNCC;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblTaiKhoan;
        private Label lblTenNCC;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn DiaChi;
    }
}
