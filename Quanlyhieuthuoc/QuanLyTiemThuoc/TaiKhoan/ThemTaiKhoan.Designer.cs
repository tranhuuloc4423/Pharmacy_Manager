﻿namespace Quanlyhieuthuoc.TaiKhoan
{
    partial class ThemTaiKhoan
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
            label6 = new Label();
            txtNhapLaiMK = new TextBox();
            btnThoat = new Button();
            btnThem = new Button();
            cbQuyen = new ComboBox();
            txtMatKhau = new TextBox();
            txtHoTen = new TextBox();
            txtTenTaiKhoan = new TextBox();
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
            tableLayoutPanel1.Size = new Size(549, 489);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(135, 6);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 1;
            label1.Text = "Thêm Tài Khoản";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtNhapLaiMK);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(cbQuyen);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(txtTenTaiKhoan);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 435);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(27, 202);
            label6.Name = "label6";
            label6.Size = new Size(195, 30);
            label6.TabIndex = 16;
            label6.Text = "Nhập Lại Mật Khẩu";
            // 
            // txtNhapLaiMK
            // 
            txtNhapLaiMK.Font = new Font("Segoe UI", 14F);
            txtNhapLaiMK.ForeColor = Color.Black;
            txtNhapLaiMK.Location = new Point(245, 200);
            txtNhapLaiMK.Name = "txtNhapLaiMK";
            txtNhapLaiMK.Size = new Size(273, 32);
            txtNhapLaiMK.TabIndex = 15;
            txtNhapLaiMK.TextChanged += txtNhapLaiMK_TextChanged;
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
            btnThoat.Location = new Point(310, 340);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(169, 46);
            btnThoat.TabIndex = 6;
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
            btnThem.Location = new Point(53, 340);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(169, 46);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cbQuyen
            // 
            cbQuyen.Font = new Font("Segoe UI", 14F);
            cbQuyen.ForeColor = Color.Black;
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Location = new Point(245, 256);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(273, 33);
            cbQuyen.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 14F);
            txtMatKhau.ForeColor = Color.Black;
            txtMatKhau.Location = new Point(245, 144);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(273, 32);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 14F);
            txtHoTen.ForeColor = Color.Black;
            txtHoTen.Location = new Point(245, 88);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(273, 32);
            txtHoTen.TabIndex = 2;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Font = new Font("Segoe UI", 14F);
            txtTenTaiKhoan.ForeColor = Color.Black;
            txtTenTaiKhoan.Location = new Point(245, 31);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(273, 32);
            txtTenTaiKhoan.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(27, 88);
            label5.Name = "label5";
            label5.Size = new Size(82, 30);
            label5.TabIndex = 14;
            label5.Text = "Họ Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(27, 146);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 13;
            label4.Text = "Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(27, 259);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 12;
            label3.Text = "Vai Trò";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(27, 33);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 11;
            label2.Text = "Tên Tài Khoản";
            // 
            // ThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 489);
            Controls.Add(tableLayoutPanel1);
            Name = "ThemTaiKhoan";
            Text = "ThemTaiKhoan";
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
        private ComboBox cbQuyen;
        private TextBox txtMatKhau;
        private TextBox txtHoTen;
        private TextBox txtTenTaiKhoan;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox txtNhapLaiMK;
    }
}