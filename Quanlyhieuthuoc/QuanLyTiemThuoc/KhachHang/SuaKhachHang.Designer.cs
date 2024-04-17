namespace Quanlyhieuthuoc.KhachHang
{
    partial class SuaKhachHang
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
            txtMaKhachHang = new TextBox();
            label6 = new Label();
            btnThoat = new Button();
            btnSua = new Button();
            cba = new ComboBox();
            txtKHTT = new TextBox();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
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
            tableLayoutPanel1.Size = new Size(484, 467);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(136, 6);
            label1.Name = "label1";
            label1.Size = new Size(211, 37);
            label1.TabIndex = 1;
            label1.Text = "Sửa Khách Hàng";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(txtMaKhachHang);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(cba);
            panel2.Controls.Add(txtKHTT);
            panel2.Controls.Add(txtSoDienThoai);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 401);
            panel2.TabIndex = 1;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Segoe UI", 14F);
            txtMaKhachHang.ForeColor = Color.Black;
            txtMaKhachHang.Location = new Point(203, 31);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(253, 32);
            txtMaKhachHang.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(31, 30);
            label6.Name = "label6";
            label6.Size = new Size(166, 30);
            label6.TabIndex = 21;
            label6.Text = "Mã Khách Hàng";
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
            btnThoat.Location = new Point(287, 328);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(169, 46);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderColor = Color.LightPink;
            btnSua.FlatAppearance.BorderSize = 2;
            btnSua.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnSua.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Microsoft Sans Serif", 16F);
            btnSua.Location = new Point(31, 328);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(169, 46);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // cba
            // 
            cba.Font = new Font("Segoe UI", 14F);
            cba.ForeColor = Color.Black;
            cba.FormattingEnabled = true;
            cba.Location = new Point(203, 251);
            cba.Name = "cba";
            cba.Size = new Size(253, 33);
            cba.TabIndex = 18;
            // 
            // txtKHTT
            // 
            txtKHTT.Font = new Font("Segoe UI", 14F);
            txtKHTT.ForeColor = Color.Black;
            txtKHTT.Location = new Point(203, 195);
            txtKHTT.Name = "txtKHTT";
            txtKHTT.Size = new Size(253, 32);
            txtKHTT.TabIndex = 17;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 14F);
            txtSoDienThoai.ForeColor = Color.Black;
            txtSoDienThoai.Location = new Point(203, 140);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(253, 32);
            txtSoDienThoai.TabIndex = 16;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 14F);
            txtHoTen.ForeColor = Color.Black;
            txtHoTen.Location = new Point(203, 86);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(253, 32);
            txtHoTen.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 140);
            label5.Name = "label5";
            label5.Size = new Size(71, 30);
            label5.TabIndex = 14;
            label5.Text = "Số ĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(31, 198);
            label4.Name = "label4";
            label4.Size = new Size(66, 30);
            label4.TabIndex = 13;
            label4.Text = "KHTT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(31, 250);
            label3.Name = "label3";
            label3.Size = new Size(140, 30);
            label3.TabIndex = 12;
            label3.Text = "Mua Tích Luỹ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(31, 85);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 11;
            label2.Text = "Họ Tên";
            // 
            // SuaKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 467);
            Controls.Add(tableLayoutPanel1);
            Name = "SuaKhachHang";
            Text = "SuaKhachHang";
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
        private TextBox txtMaKhachHang;
        private Label label6;
        private Button btnThoat;
        private Button btnSua;
        private ComboBox cba;
        private TextBox txtKHTT;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}