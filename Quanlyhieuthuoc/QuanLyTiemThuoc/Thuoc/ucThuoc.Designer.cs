namespace Quanlyhieuthuoc.Thuoc
{
    partial class ucThuoc
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
            dgThuoc = new DataGridView();
            panel2 = new Panel();
            lblMaThuoc = new Label();
            label5 = new Label();
            lblGiaBan = new Label();
            label6 = new Label();
            lblDonViTinh = new Label();
            cbLoaiThuoc = new ComboBox();
            lblTenThuoc = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblThuoc = new Label();
            MaThuoc = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            TenLoaiThuoc = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgThuoc).BeginInit();
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
            tableLayoutPanel1.Size = new Size(1137, 551);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgThuoc);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 545);
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
            dgThuoc.Size = new Size(731, 545);
            dgThuoc.TabIndex = 1;
            dgThuoc.CellClick += dgThuoc_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(lblMaThuoc);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblGiaBan);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblDonViTinh);
            panel2.Controls.Add(cbLoaiThuoc);
            panel2.Controls.Add(lblTenThuoc);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblThuoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(740, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 545);
            panel2.TabIndex = 1;
            // 
            // lblMaThuoc
            // 
            lblMaThuoc.AutoSize = true;
            lblMaThuoc.Font = new Font("Segoe UI", 16F);
            lblMaThuoc.Location = new Point(204, 93);
            lblMaThuoc.Name = "lblMaThuoc";
            lblMaThuoc.Size = new Size(112, 30);
            lblMaThuoc.TabIndex = 23;
            lblMaThuoc.Text = "Tên Thuốc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(40, 93);
            label5.Name = "label5";
            label5.Size = new Size(120, 30);
            label5.TabIndex = 22;
            label5.Text = "Mã Thuốc :";
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 16F);
            lblGiaBan.Location = new Point(204, 318);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(112, 30);
            lblGiaBan.TabIndex = 21;
            lblGiaBan.Text = "Tên Thuốc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(40, 318);
            label6.Name = "label6";
            label6.Size = new Size(97, 30);
            label6.TabIndex = 20;
            label6.Text = "Giá Bán :";
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Font = new Font("Segoe UI", 16F);
            lblDonViTinh.Location = new Point(204, 268);
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
            cbLoaiThuoc.Location = new Point(204, 202);
            cbLoaiThuoc.Name = "cbLoaiThuoc";
            cbLoaiThuoc.Size = new Size(146, 33);
            cbLoaiThuoc.TabIndex = 18;
            // 
            // lblTenThuoc
            // 
            lblTenThuoc.AutoSize = true;
            lblTenThuoc.Font = new Font("Segoe UI", 16F);
            lblTenThuoc.Location = new Point(204, 142);
            lblTenThuoc.Name = "lblTenThuoc";
            lblTenThuoc.Size = new Size(112, 30);
            lblTenThuoc.TabIndex = 16;
            lblTenThuoc.Text = "Tên Thuốc";
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
            label3.Location = new Point(40, 268);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 13;
            label3.Text = "Đơn Vị Tính :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(40, 202);
            label2.Name = "label2";
            label2.Size = new Size(128, 30);
            label2.TabIndex = 11;
            label2.Text = "Loại Thuốc :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(40, 142);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 10;
            label1.Text = "Tên Thuốc :";
            // 
            // lblThuoc
            // 
            lblThuoc.AutoSize = true;
            lblThuoc.Font = new Font("Segoe UI", 16F);
            lblThuoc.Location = new Point(170, 41);
            lblThuoc.Name = "lblThuoc";
            lblThuoc.Size = new Size(72, 30);
            lblThuoc.TabIndex = 9;
            lblThuoc.Text = "Thuốc";
            // 
            // MaThuoc
            // 
            MaThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaThuoc.DataPropertyName = "MaThuoc";
            MaThuoc.HeaderText = "Mã Thuốc";
            MaThuoc.Name = "MaThuoc";
            MaThuoc.ReadOnly = true;
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
            GiaBan.HeaderText = "Giá Bán";
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // ucThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucThuoc";
            Size = new Size(1137, 551);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgThuoc).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cbLoaiThuoc;
        private Label lblTenThuoc;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblThuoc;
        private Label lblGiaBan;
        private Label label6;
        private Label lblDonViTinh;
        private DataGridView dgThuoc;
        private Label lblMaThuoc;
        private Label label5;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn TenLoaiThuoc;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn GiaBan;
    }
}
