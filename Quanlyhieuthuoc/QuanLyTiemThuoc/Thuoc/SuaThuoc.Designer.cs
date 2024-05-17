namespace Quanlyhieuthuoc.Thuoc
{
    partial class SuaThuoc
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
            txtMaThuoc = new TextBox();
            label6 = new Label();
            btnThoat = new Button();
            btnSua = new Button();
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
            tableLayoutPanel1.Size = new Size(499, 462);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(172, 6);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 1;
            label1.Text = "Sửa Thuốc";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(txtMaThuoc);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnSua);
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
            panel2.Size = new Size(493, 396);
            panel2.TabIndex = 1;
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.Font = new Font("Segoe UI", 14F);
            txtMaThuoc.ForeColor = Color.Black;
            txtMaThuoc.Location = new Point(183, 15);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.ReadOnly = true;
            txtMaThuoc.Size = new Size(273, 32);
            txtMaThuoc.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(31, 14);
            label6.Name = "label6";
            label6.Size = new Size(109, 30);
            label6.TabIndex = 21;
            label6.Text = "Mã Thuốc";
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
            btnThoat.Location = new Point(287, 315);
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
            btnSua.Location = new Point(31, 315);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(169, 46);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // cbLoaiThuoc
            // 
            cbLoaiThuoc.Font = new Font("Segoe UI", 14F);
            cbLoaiThuoc.ForeColor = Color.Black;
            cbLoaiThuoc.FormattingEnabled = true;
            cbLoaiThuoc.Location = new Point(183, 236);
            cbLoaiThuoc.Name = "cbLoaiThuoc";
            cbLoaiThuoc.Size = new Size(273, 33);
            cbLoaiThuoc.TabIndex = 18;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 14F);
            txtGiaBan.ForeColor = Color.Black;
            txtGiaBan.Location = new Point(183, 180);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(273, 32);
            txtGiaBan.TabIndex = 17;
            txtGiaBan.KeyPress += txtGiaBan_KeyPress;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Segoe UI", 14F);
            txtDonViTinh.ForeColor = Color.Black;
            txtDonViTinh.Location = new Point(183, 125);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(273, 32);
            txtDonViTinh.TabIndex = 16;
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Font = new Font("Segoe UI", 14F);
            txtTenThuoc.ForeColor = Color.Black;
            txtTenThuoc.Location = new Point(183, 71);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(273, 32);
            txtTenThuoc.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 125);
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
            label4.Location = new Point(31, 183);
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
            label3.Location = new Point(31, 235);
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
            label2.Location = new Point(31, 70);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 11;
            label2.Text = "Tên Thuốc";
            // 
            // SuaThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 462);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuaThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuaThuoc";
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
        private Panel panel2;
        private Button btnThoat;
        private Button btnSua;
        private ComboBox cbLoaiThuoc;
        private TextBox txtGiaBan;
        private TextBox txtDonViTinh;
        private TextBox txtTenThuoc;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMaThuoc;
        private Label label6;
    }
}