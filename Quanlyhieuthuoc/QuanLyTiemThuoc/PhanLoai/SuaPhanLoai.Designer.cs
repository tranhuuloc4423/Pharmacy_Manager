namespace Quanlyhieuthuoc.PhanLoai
{
    partial class SuaPhanLoai
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
            txtTenLoaiThuoc = new TextBox();
            btnThoat = new Button();
            btnSua = new Button();
            txtMaLoaiThuoc = new TextBox();
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(522, 450);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(152, 6);
            label1.Name = "label1";
            label1.Size = new Size(197, 37);
            label1.TabIndex = 1;
            label1.Text = "Sửa Loại Thuốc";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(txtTenLoaiThuoc);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(txtMaLoaiThuoc);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 396);
            panel2.TabIndex = 1;
            // 
            // txtTenLoaiThuoc
            // 
            txtTenLoaiThuoc.Font = new Font("Segoe UI", 14F);
            txtTenLoaiThuoc.ForeColor = Color.Black;
            txtTenLoaiThuoc.Location = new Point(238, 85);
            txtTenLoaiThuoc.Name = "txtTenLoaiThuoc";
            txtTenLoaiThuoc.Size = new Size(252, 32);
            txtTenLoaiThuoc.TabIndex = 22;
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
            btnThoat.Location = new Point(287, 270);
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
            btnSua.Location = new Point(31, 270);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(169, 46);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtMaLoaiThuoc
            // 
            txtMaLoaiThuoc.Font = new Font("Segoe UI", 14F);
            txtMaLoaiThuoc.ForeColor = Color.Black;
            txtMaLoaiThuoc.Location = new Point(238, 30);
            txtMaLoaiThuoc.Name = "txtMaLoaiThuoc";
            txtMaLoaiThuoc.ReadOnly = true;
            txtMaLoaiThuoc.Size = new Size(252, 32);
            txtMaLoaiThuoc.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 84);
            label5.Name = "label5";
            label5.Size = new Size(168, 30);
            label5.TabIndex = 14;
            label5.Text = "Tên Loại Thuốc :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(165, 30);
            label2.TabIndex = 11;
            label2.Text = "Mã Loại Thuốc :";
            // 
            // SuaPhanLoai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "SuaPhanLoai";
            Text = "SuaPhanLoai";
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
        private TextBox txtTenLoaiThuoc;
        private Button btnThoat;
        private Button btnSua;
        private TextBox txtMaLoaiThuoc;
        private Label label5;
        private Label label2;
    }
}