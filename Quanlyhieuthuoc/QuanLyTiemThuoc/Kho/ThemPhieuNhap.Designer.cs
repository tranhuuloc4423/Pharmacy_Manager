namespace Quanlyhieuthuoc.Kho
{
    partial class ThemPhieuNhap
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            dgTaiKhoan = new DataGridView();
            btnXoaCTPN = new Button();
            btnThemCTPN = new Button();
            btnThemPhieuNhap = new Button();
            txtMaPhieuNhap = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtSoLuong = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(964, 573);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgTaiKhoan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 567);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(txtSoLuong);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtMaPhieuNhap);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnThemPhieuNhap);
            panel2.Controls.Add(btnThemCTPN);
            panel2.Controls.Add(btnXoaCTPN);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(485, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 567);
            panel2.TabIndex = 1;
            // 
            // dgTaiKhoan
            // 
            dgTaiKhoan.AllowUserToAddRows = false;
            dgTaiKhoan.AllowUserToDeleteRows = false;
            dgTaiKhoan.AllowUserToResizeColumns = false;
            dgTaiKhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgTaiKhoan.BackgroundColor = Color.LightPink;
            dgTaiKhoan.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgTaiKhoan.ColumnHeadersHeight = 40;
            dgTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgTaiKhoan.DefaultCellStyle = dataGridViewCellStyle8;
            dgTaiKhoan.Dock = DockStyle.Fill;
            dgTaiKhoan.GridColor = Color.LightPink;
            dgTaiKhoan.Location = new Point(0, 0);
            dgTaiKhoan.MultiSelect = false;
            dgTaiKhoan.Name = "dgTaiKhoan";
            dgTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgTaiKhoan.RowHeadersVisible = false;
            dgTaiKhoan.RowHeadersWidth = 40;
            dgTaiKhoan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTaiKhoan.Size = new Size(476, 567);
            dgTaiKhoan.TabIndex = 2;
            // 
            // btnXoaCTPN
            // 
            btnXoaCTPN.BackColor = Color.White;
            btnXoaCTPN.FlatAppearance.BorderColor = Color.LightPink;
            btnXoaCTPN.FlatAppearance.BorderSize = 2;
            btnXoaCTPN.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnXoaCTPN.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnXoaCTPN.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnXoaCTPN.FlatStyle = FlatStyle.Flat;
            btnXoaCTPN.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaCTPN.Location = new Point(96, 421);
            btnXoaCTPN.Margin = new Padding(4, 3, 4, 3);
            btnXoaCTPN.Name = "btnXoaCTPN";
            btnXoaCTPN.Size = new Size(303, 44);
            btnXoaCTPN.TabIndex = 13;
            btnXoaCTPN.Text = "Xoá Chi Tiết Phiếu Nhập";
            btnXoaCTPN.UseVisualStyleBackColor = false;
            // 
            // btnThemCTPN
            // 
            btnThemCTPN.BackColor = Color.White;
            btnThemCTPN.FlatAppearance.BorderColor = Color.LightPink;
            btnThemCTPN.FlatAppearance.BorderSize = 2;
            btnThemCTPN.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnThemCTPN.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThemCTPN.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThemCTPN.FlatStyle = FlatStyle.Flat;
            btnThemCTPN.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemCTPN.Location = new Point(96, 335);
            btnThemCTPN.Margin = new Padding(4, 3, 4, 3);
            btnThemCTPN.Name = "btnThemCTPN";
            btnThemCTPN.Size = new Size(303, 44);
            btnThemCTPN.TabIndex = 14;
            btnThemCTPN.Text = "Thêm Chi Tiết Phiếu Nhập";
            btnThemCTPN.UseVisualStyleBackColor = false;
            // 
            // btnThemPhieuNhap
            // 
            btnThemPhieuNhap.BackColor = Color.White;
            btnThemPhieuNhap.FlatAppearance.BorderColor = Color.LightPink;
            btnThemPhieuNhap.FlatAppearance.BorderSize = 2;
            btnThemPhieuNhap.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnThemPhieuNhap.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThemPhieuNhap.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThemPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnThemPhieuNhap.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemPhieuNhap.Location = new Point(96, 494);
            btnThemPhieuNhap.Margin = new Padding(4, 3, 4, 3);
            btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            btnThemPhieuNhap.Size = new Size(303, 44);
            btnThemPhieuNhap.TabIndex = 15;
            btnThemPhieuNhap.Text = "Thêm Phiếu Nhập";
            btnThemPhieuNhap.UseVisualStyleBackColor = false;
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.Font = new Font("Segoe UI", 14F);
            txtMaPhieuNhap.ForeColor = Color.Black;
            txtMaPhieuNhap.Location = new Point(224, 59);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.Size = new Size(233, 32);
            txtMaPhieuNhap.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(32, 58);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 18;
            label2.Text = "Mã Phiếu Nhập";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(224, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 32);
            textBox1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 255);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 20;
            label1.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(32, 118);
            label3.Name = "label3";
            label3.Size = new Size(72, 30);
            label3.TabIndex = 22;
            label3.Text = "Thuốc";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 14F);
            txtSoLuong.ForeColor = Color.Black;
            txtSoLuong.Location = new Point(224, 189);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(233, 32);
            txtSoLuong.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(32, 188);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 24;
            label4.Text = "Số Lượng";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(224, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 31);
            comboBox1.TabIndex = 25;
            // 
            // ThemPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 573);
            Controls.Add(tableLayoutPanel1);
            Name = "ThemPhieuNhap";
            Text = "ThemPhieuNhap";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgTaiKhoan;
        private Button button3;
        private Button btnThemPhieuNhap;
        private Button btnThemCTPN;
        private Button btnXoaCTPN;
        private TextBox txtSoLuong;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtMaPhieuNhap;
        private Label label2;
        private ComboBox comboBox1;
    }
}