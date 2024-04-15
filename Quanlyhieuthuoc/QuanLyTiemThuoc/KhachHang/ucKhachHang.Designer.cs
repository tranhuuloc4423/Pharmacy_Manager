namespace Quanlyhieuthuoc.KhachHang
{
    partial class ucKhachHang
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
            dgKhachHang = new DataGridView();
            MaKhachHang = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            KhachHangThanThiet = new DataGridViewTextBoxColumn();
            MuaTichLuy = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblMuaTL = new Label();
            label7 = new Label();
            lblKHTT = new Label();
            label5 = new Label();
            lblSoDienThoai = new Label();
            lblHoTen = new Label();
            lblMaKhachHang = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNCC = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgKhachHang).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1136, 529);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgKhachHang);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 523);
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
            dgKhachHang.Size = new Size(676, 523);
            dgKhachHang.TabIndex = 1;
            dgKhachHang.CellClick += dgKhachHang_CellClick;
            // 
            // MaKhachHang
            // 
            MaKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaKhachHang.DataPropertyName = "MaKhachHang";
            MaKhachHang.HeaderText = "Mã Khách Hàng";
            MaKhachHang.Name = "MaKhachHang";
            MaKhachHang.ReadOnly = true;
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
            // 
            // MuaTichLuy
            // 
            MuaTichLuy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MuaTichLuy.DataPropertyName = "MuaTichLuy";
            MuaTichLuy.HeaderText = "Mua Tích Luỹ";
            MuaTichLuy.Name = "MuaTichLuy";
            MuaTichLuy.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(lblMuaTL);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblKHTT);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblSoDienThoai);
            panel2.Controls.Add(lblHoTen);
            panel2.Controls.Add(lblMaKhachHang);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblNCC);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(685, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 523);
            panel2.TabIndex = 1;
            // 
            // lblMuaTL
            // 
            lblMuaTL.AutoSize = true;
            lblMuaTL.Font = new Font("Segoe UI", 16F);
            lblMuaTL.Location = new Point(270, 290);
            lblMuaTL.Name = "lblMuaTL";
            lblMuaTL.Size = new Size(112, 30);
            lblMuaTL.TabIndex = 25;
            lblMuaTL.Text = "Tên Thuốc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(53, 290);
            label7.Name = "label7";
            label7.Size = new Size(151, 30);
            label7.TabIndex = 24;
            label7.Text = "Mua Tích Luỹ :";
            // 
            // lblKHTT
            // 
            lblKHTT.AutoSize = true;
            lblKHTT.Font = new Font("Segoe UI", 16F);
            lblKHTT.Location = new Point(270, 234);
            lblKHTT.Name = "lblKHTT";
            lblKHTT.Size = new Size(112, 30);
            lblKHTT.TabIndex = 23;
            lblKHTT.Text = "Tên Thuốc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(53, 234);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 22;
            label5.Text = "KHTT :";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 16F);
            lblSoDienThoai.Location = new Point(270, 183);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(112, 30);
            lblSoDienThoai.TabIndex = 21;
            lblSoDienThoai.Text = "Tên Thuốc";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 16F);
            lblHoTen.Location = new Point(270, 132);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(112, 30);
            lblHoTen.TabIndex = 19;
            lblHoTen.Text = "Tên Thuốc";
            // 
            // lblMaKhachHang
            // 
            lblMaKhachHang.AutoSize = true;
            lblMaKhachHang.Font = new Font("Segoe UI", 16F);
            lblMaKhachHang.Location = new Point(270, 82);
            lblMaKhachHang.Name = "lblMaKhachHang";
            lblMaKhachHang.Size = new Size(112, 30);
            lblMaKhachHang.TabIndex = 16;
            lblMaKhachHang.Text = "Tên Thuốc";
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
            btnSua.Font = new Font("Tahoma", 16F);
            btnSua.Location = new Point(231, 367);
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
            btnXoa.Font = new Font("Tahoma", 16F);
            btnXoa.Location = new Point(38, 443);
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
            btnThem.Font = new Font("Tahoma", 16F);
            btnThem.Location = new Point(38, 367);
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
            label3.Location = new Point(53, 183);
            label3.Name = "label3";
            label3.Size = new Size(158, 30);
            label3.TabIndex = 13;
            label3.Text = "Số Điện Thoại :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(53, 132);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 11;
            label2.Text = "Họ Tên : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(53, 82);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 10;
            label1.Text = "Mã Khách Hàng :";
            // 
            // lblNCC
            // 
            lblNCC.AutoSize = true;
            lblNCC.Font = new Font("Tahoma", 24F);
            lblNCC.Location = new Point(161, 20);
            lblNCC.Name = "lblNCC";
            lblNCC.Size = new Size(189, 39);
            lblNCC.TabIndex = 9;
            lblNCC.Text = "Khách Hàng";
            // 
            // ucKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucKhachHang";
            Size = new Size(1136, 529);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgKhachHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgKhachHang;
        private Panel panel2;
        private Label lblSoDienThoai;
        private Label lblHoTen;
        private Label lblMaKhachHang;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblNCC;
        private Label lblMuaTL;
        private Label label7;
        private Label lblKHTT;
        private Label label5;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn KhachHangThanThiet;
        private DataGridViewTextBoxColumn MuaTichLuy;
    }
}
