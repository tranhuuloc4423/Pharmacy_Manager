namespace Quanlyhieuthuoc.TaiKhoan
{
    partial class ucTaiKhoan
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgTaiKhoan = new DataGridView();
            TenTaiKhoan = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            VaiTro = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnCapNhat = new Button();
            button1 = new Button();
            btnThem = new Button();
            txtHoTen = new TextBox();
            txtVaiTro = new TextBox();
            txtTenTaiKhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTaiKhoan = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTaiKhoan).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1051, 587);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgTaiKhoan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 581);
            panel1.TabIndex = 0;
            // 
            // dgTaiKhoan
            // 
            dgTaiKhoan.AllowUserToAddRows = false;
            dgTaiKhoan.AllowUserToDeleteRows = false;
            dgTaiKhoan.BackgroundColor = Color.Thistle;
            dgTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { TenTaiKhoan, HoTen, VaiTro });
            dgTaiKhoan.Dock = DockStyle.Fill;
            dgTaiKhoan.Location = new Point(0, 0);
            dgTaiKhoan.Name = "dgTaiKhoan";
            dgTaiKhoan.ReadOnly = true;
            dgTaiKhoan.Size = new Size(624, 581);
            dgTaiKhoan.TabIndex = 0;
            // 
            // TenTaiKhoan
            // 
            TenTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            TenTaiKhoan.HeaderText = "Tên Tài Khoản";
            TenTaiKhoan.Name = "TenTaiKhoan";
            TenTaiKhoan.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ Tên";
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // VaiTro
            // 
            VaiTro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VaiTro.DataPropertyName = "VaiTro";
            VaiTro.HeaderText = "Vai Trò";
            VaiTro.Name = "VaiTro";
            VaiTro.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCapNhat);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(txtVaiTro);
            panel2.Controls.Add(txtTenTaiKhoan);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTaiKhoan);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(633, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 581);
            panel2.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.White;
            btnCapNhat.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCapNhat.FlatAppearance.BorderSize = 2;
            btnCapNhat.FlatAppearance.CheckedBackColor = Color.MediumSlateBlue;
            btnCapNhat.FlatAppearance.MouseDownBackColor = Color.MediumSlateBlue;
            btnCapNhat.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(224, 301);
            btnCapNhat.Margin = new Padding(4, 3, 4, 3);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(164, 44);
            btnCapNhat.TabIndex = 9;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.CheckedBackColor = Color.MediumSlateBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.MediumSlateBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(31, 398);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(164, 44);
            button1.TabIndex = 8;
            button1.Text = "Xoá";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnThem.FlatAppearance.BorderSize = 2;
            btnThem.FlatAppearance.CheckedBackColor = Color.MediumSlateBlue;
            btnThem.FlatAppearance.MouseDownBackColor = Color.MediumSlateBlue;
            btnThem.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(31, 301);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 44);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 16F);
            txtHoTen.Location = new Point(173, 158);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(215, 36);
            txtHoTen.TabIndex = 6;
            // 
            // txtVaiTro
            // 
            txtVaiTro.BorderStyle = BorderStyle.FixedSingle;
            txtVaiTro.Font = new Font("Segoe UI", 16F);
            txtVaiTro.Location = new Point(173, 224);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(215, 36);
            txtVaiTro.TabIndex = 5;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTenTaiKhoan.Font = new Font("Segoe UI", 16F);
            txtTenTaiKhoan.Location = new Point(173, 98);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(215, 36);
            txtTenTaiKhoan.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(21, 224);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 3;
            label3.Text = "Vai Trò";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(21, 158);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(21, 98);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 1;
            label1.Text = "Tên Tài Khoản";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 16F);
            lblTaiKhoan.Location = new Point(153, 37);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(106, 30);
            lblTaiKhoan.TabIndex = 0;
            lblTaiKhoan.Text = "Tài Khoản";
            // 
            // ucTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucTaiKhoan";
            Size = new Size(1051, 587);
            Load += ucTaiKhoan_Load;
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
        private Panel panel2;
        private Label lblTaiKhoan;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtHoTen;
        private TextBox txtVaiTro;
        private TextBox txtTenTaiKhoan;
        private Button btnCapNhat;
        private Button button1;
        private Button btnThem;
        private DataGridView dgTaiKhoan;
        private DataGridViewTextBoxColumn TenTaiKhoan;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn VaiTro;
    }
}
