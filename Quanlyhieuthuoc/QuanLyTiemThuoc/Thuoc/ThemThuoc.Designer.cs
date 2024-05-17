namespace Quanlyhieuthuoc.Thuoc
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            cbNCC = new ComboBox();
            label6 = new Label();
            btnThoat = new Button();
            btnThem = new Button();
            cbLoaiThuoc = new ComboBox();
            txtGiaBan = new TextBox();
            txtDonViTinh = new TextBox();
            txtTenThuoc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(525, 452);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(172, 6);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 1;
            label1.Text = "Thêm Thuốc";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(cbNCC);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(cbLoaiThuoc);
            panel2.Controls.Add(txtGiaBan);
            panel2.Controls.Add(txtDonViTinh);
            panel2.Controls.Add(txtTenThuoc);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 396);
            panel2.TabIndex = 1;
            // 
            // cbNCC
            // 
            cbNCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNCC.Font = new Font("Segoe UI", 14F);
            cbNCC.ForeColor = Color.Black;
            cbNCC.FormattingEnabled = true;
            cbNCC.Location = new Point(208, 248);
            cbNCC.Name = "cbNCC";
            cbNCC.Size = new Size(273, 33);
            cbNCC.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(41, 251);
            label6.Name = "label6";
            label6.Size = new Size(153, 30);
            label6.TabIndex = 21;
            label6.Text = "Nhà Cung Cấp";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.LightPink;
            btnThoat.FlatAppearance.BorderSize = 2;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Microsoft Sans Serif", 16F);
            btnThoat.Location = new Point(312, 321);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(169, 46);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderColor = Color.LightPink;
            btnThem.FlatAppearance.BorderSize = 2;
            btnThem.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThem.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Microsoft Sans Serif", 16F);
            btnThem.Location = new Point(41, 321);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(169, 46);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cbLoaiThuoc
            // 
            cbLoaiThuoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiThuoc.Font = new Font("Segoe UI", 14F);
            cbLoaiThuoc.ForeColor = Color.Black;
            cbLoaiThuoc.FormattingEnabled = true;
            cbLoaiThuoc.Location = new Point(208, 189);
            cbLoaiThuoc.Name = "cbLoaiThuoc";
            cbLoaiThuoc.Size = new Size(273, 33);
            cbLoaiThuoc.TabIndex = 18;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 14F);
            txtGiaBan.ForeColor = Color.Black;
            txtGiaBan.Location = new Point(208, 133);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(273, 32);
            txtGiaBan.TabIndex = 17;
            txtGiaBan.KeyPress += txtGiaBan_KeyPress;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Segoe UI", 14F);
            txtDonViTinh.ForeColor = Color.Black;
            txtDonViTinh.Location = new Point(208, 78);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(273, 32);
            txtDonViTinh.TabIndex = 16;
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Font = new Font("Segoe UI", 14F);
            txtTenThuoc.ForeColor = Color.Black;
            txtTenThuoc.Location = new Point(208, 24);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(273, 32);
            txtTenThuoc.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(41, 78);
            label5.Name = "label5";
            label5.Size = new Size(125, 30);
            label5.TabIndex = 14;
            label5.Text = "Đơn Vị Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 136);
            label4.Name = "label4";
            label4.Size = new Size(86, 30);
            label4.TabIndex = 13;
            label4.Text = "Giá Bán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(41, 188);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 12;
            label3.Text = "Loại Thuốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(41, 23);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 11;
            label2.Text = "Tên Thuốc";
            // 
            // ThemThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 452);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThemThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemThuoc";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnThoat;
        private Button btnThem;
        private ComboBox cbLoaiThuoc;
        private TextBox txtGiaBan;
        private TextBox txtDonViTinh;
        private TextBox txtTenThuoc;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private ComboBox cbNCC;
    }
}