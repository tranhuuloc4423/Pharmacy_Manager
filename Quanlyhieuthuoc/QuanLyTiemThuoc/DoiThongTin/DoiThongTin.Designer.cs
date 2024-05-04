namespace Quanlyhieuthuoc.DoiThongTin
{
    partial class DoiThongTin
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
            txtNhapLaiMatKhauMoi = new TextBox();
            txtMatKhauMoi = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCapNhat = new Button();
            txtHoTen = new TextBox();
            txtTenTaiKhoan = new TextBox();
            label5 = new Label();
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
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(590, 532);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(102, 18);
            label1.Name = "label1";
            label1.Size = new Size(377, 37);
            label1.TabIndex = 1;
            label1.Text = "Cập Nhật Thông Tin Tài Khoản";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(txtNhapLaiMatKhauMoi);
            panel2.Controls.Add(txtMatKhauMoi);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnCapNhat);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(txtTenTaiKhoan);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 84);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 535);
            panel2.TabIndex = 1;
            // 
            // txtNhapLaiMatKhauMoi
            // 
            txtNhapLaiMatKhauMoi.Font = new Font("Segoe UI", 14F);
            txtNhapLaiMatKhauMoi.ForeColor = Color.Black;
            txtNhapLaiMatKhauMoi.Location = new Point(238, 255);
            txtNhapLaiMatKhauMoi.Margin = new Padding(3, 4, 3, 4);
            txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            txtNhapLaiMatKhauMoi.Size = new Size(289, 32);
            txtNhapLaiMatKhauMoi.TabIndex = 24;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 14F);
            txtMatKhauMoi.ForeColor = Color.Black;
            txtMatKhauMoi.Location = new Point(238, 182);
            txtMatKhauMoi.Margin = new Padding(3, 4, 3, 4);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(289, 32);
            txtMatKhauMoi.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 257);
            label3.Name = "label3";
            label3.Size = new Size(195, 30);
            label3.TabIndex = 22;
            label3.Text = "Nhập Lại Mật Khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(35, 184);
            label4.Name = "label4";
            label4.Size = new Size(149, 30);
            label4.TabIndex = 21;
            label4.Text = "Mật Khẩu Mới";
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.White;
            btnCapNhat.Cursor = Cursors.Hand;
            btnCapNhat.FlatAppearance.BorderColor = Color.LightPink;
            btnCapNhat.FlatAppearance.BorderSize = 2;
            btnCapNhat.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnCapNhat.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 16F);
            btnCapNhat.Location = new Point(220, 382);
            btnCapNhat.Margin = new Padding(5, 4, 5, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(159, 47);
            btnCapNhat.TabIndex = 19;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 14F);
            txtHoTen.ForeColor = Color.Black;
            txtHoTen.Location = new Point(238, 118);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(289, 32);
            txtHoTen.TabIndex = 16;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Font = new Font("Segoe UI", 14F);
            txtTenTaiKhoan.ForeColor = Color.Black;
            txtTenTaiKhoan.Location = new Point(238, 48);
            txtTenTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(289, 32);
            txtTenTaiKhoan.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(35, 120);
            label5.Name = "label5";
            label5.Size = new Size(82, 30);
            label5.TabIndex = 14;
            label5.Text = "Họ Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 47);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 11;
            label2.Text = "Tên Tài Khoản";
            // 
            // DoiThongTin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 532);
            Controls.Add(tableLayoutPanel1);
            Name = "DoiThongTin";
            Text = "DoiThongTin";
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
        private TextBox txtNhapLaiMatKhauMoi;
        private TextBox txtMatKhauMoi;
        private Label label3;
        private Label label4;
        private Button btnCapNhat;
        private TextBox txtHoTen;
        private TextBox txtTenTaiKhoan;
        private Label label5;
        private Label label2;
    }
}