namespace Quanlyhieuthuoc.NhaCungCap
{
    partial class SuaNCC
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
            txtTenNCC = new TextBox();
            btnThoat = new Button();
            btnSua = new Button();
            txtMaNCC = new TextBox();
            label5 = new Label();
            label2 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
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
            tableLayoutPanel1.Size = new Size(528, 450);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(125, 6);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 1;
            label1.Text = "Sửa Nhà Cung Cấp";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTenNCC);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(txtMaNCC);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 396);
            panel2.TabIndex = 1;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Segoe UI", 14F);
            txtTenNCC.ForeColor = Color.Black;
            txtTenNCC.Location = new Point(238, 85);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(252, 32);
            txtTenNCC.TabIndex = 22;
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
            btnThoat.Location = new Point(321, 270);
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
            // txtMaNCC
            // 
            txtMaNCC.Font = new Font("Segoe UI", 14F);
            txtMaNCC.ForeColor = Color.Black;
            txtMaNCC.Location = new Point(238, 30);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.ReadOnly = true;
            txtMaNCC.Size = new Size(252, 32);
            txtMaNCC.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 84);
            label5.Name = "label5";
            label5.Size = new Size(204, 30);
            label5.TabIndex = 14;
            label5.Text = "Tên Nhà Cung Cấp :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(201, 30);
            label2.TabIndex = 11;
            label2.Text = "Mã Nhà Cung Cấp :";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 14F);
            txtDiaChi.ForeColor = Color.Black;
            txtDiaChi.Location = new Point(238, 148);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(252, 32);
            txtDiaChi.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(31, 147);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 23;
            label3.Text = "Địa Chỉ :";
            // 
            // SuaNCC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuaNCC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuaNCC";
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
        private TextBox txtTenNCC;
        private Button btnThoat;
        private Button btnSua;
        private TextBox txtMaNCC;
        private Label label5;
        private Label label2;
        private TextBox txtDiaChi;
        private Label label3;
    }
}