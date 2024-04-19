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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgCTPN = new DataGridView();
            panel2 = new Panel();
            btnThemNCC = new Button();
            txtNhaCungCap = new TextBox();
            label1 = new Label();
            btnThemThuoc = new Button();
            txtThuoc = new TextBox();
            txtSoLuong = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnThemPhieuNhap = new Button();
            btnThemCTPN = new Button();
            btnXoaCTPN = new Button();
            MaThuoc = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCTPN).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Controls.Add(dgCTPN);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 567);
            panel1.TabIndex = 0;
            // 
            // dgCTPN
            // 
            dgCTPN.AllowUserToAddRows = false;
            dgCTPN.AllowUserToDeleteRows = false;
            dgCTPN.AllowUserToResizeColumns = false;
            dgCTPN.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgCTPN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgCTPN.BackgroundColor = Color.LightPink;
            dgCTPN.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgCTPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgCTPN.ColumnHeadersHeight = 40;
            dgCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgCTPN.Columns.AddRange(new DataGridViewColumn[] { MaThuoc, TenThuoc, SoLuong });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgCTPN.DefaultCellStyle = dataGridViewCellStyle3;
            dgCTPN.Dock = DockStyle.Fill;
            dgCTPN.GridColor = Color.LightPink;
            dgCTPN.Location = new Point(0, 0);
            dgCTPN.MultiSelect = false;
            dgCTPN.Name = "dgCTPN";
            dgCTPN.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgCTPN.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgCTPN.RowHeadersVisible = false;
            dgCTPN.RowHeadersWidth = 40;
            dgCTPN.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgCTPN.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgCTPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCTPN.Size = new Size(476, 567);
            dgCTPN.TabIndex = 2;
            dgCTPN.CellClick += dgTaiKhoan_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(btnThemNCC);
            panel2.Controls.Add(txtNhaCungCap);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnThemThuoc);
            panel2.Controls.Add(txtThuoc);
            panel2.Controls.Add(txtSoLuong);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnThemPhieuNhap);
            panel2.Controls.Add(btnThemCTPN);
            panel2.Controls.Add(btnXoaCTPN);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(485, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 567);
            panel2.TabIndex = 1;
            // 
            // btnThemNCC
            // 
            btnThemNCC.BackColor = Color.White;
            btnThemNCC.FlatAppearance.BorderColor = Color.LightPink;
            btnThemNCC.FlatAppearance.BorderSize = 2;
            btnThemNCC.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnThemNCC.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThemNCC.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThemNCC.FlatStyle = FlatStyle.Flat;
            btnThemNCC.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemNCC.Location = new Point(416, 56);
            btnThemNCC.Margin = new Padding(4, 3, 4, 3);
            btnThemNCC.Name = "btnThemNCC";
            btnThemNCC.Size = new Size(41, 32);
            btnThemNCC.TabIndex = 29;
            btnThemNCC.Text = "+";
            btnThemNCC.UseVisualStyleBackColor = false;
            btnThemNCC.Click += btnThemNCC_Click;
            // 
            // txtNhaCungCap
            // 
            txtNhaCungCap.Font = new Font("Segoe UI", 14F);
            txtNhaCungCap.ForeColor = Color.Black;
            txtNhaCungCap.Location = new Point(224, 56);
            txtNhaCungCap.Name = "txtNhaCungCap";
            txtNhaCungCap.ReadOnly = true;
            txtNhaCungCap.Size = new Size(181, 32);
            txtNhaCungCap.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 55);
            label1.Name = "label1";
            label1.Size = new Size(153, 30);
            label1.TabIndex = 28;
            label1.Text = "Nhà Cung Cấp";
            // 
            // btnThemThuoc
            // 
            btnThemThuoc.BackColor = Color.White;
            btnThemThuoc.FlatAppearance.BorderColor = Color.LightPink;
            btnThemThuoc.FlatAppearance.BorderSize = 2;
            btnThemThuoc.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnThemThuoc.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThemThuoc.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThemThuoc.FlatStyle = FlatStyle.Flat;
            btnThemThuoc.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemThuoc.Location = new Point(416, 119);
            btnThemThuoc.Margin = new Padding(4, 3, 4, 3);
            btnThemThuoc.Name = "btnThemThuoc";
            btnThemThuoc.Size = new Size(41, 32);
            btnThemThuoc.TabIndex = 26;
            btnThemThuoc.Text = "+";
            btnThemThuoc.UseVisualStyleBackColor = false;
            btnThemThuoc.Click += btnThemThuoc_Click;
            // 
            // txtThuoc
            // 
            txtThuoc.Font = new Font("Segoe UI", 14F);
            txtThuoc.ForeColor = Color.Black;
            txtThuoc.Location = new Point(224, 119);
            txtThuoc.Name = "txtThuoc";
            txtThuoc.ReadOnly = true;
            txtThuoc.Size = new Size(181, 32);
            txtThuoc.TabIndex = 25;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 14F);
            txtSoLuong.ForeColor = Color.Black;
            txtSoLuong.Location = new Point(224, 189);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(181, 32);
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
            btnThemPhieuNhap.Click += btnThemPhieuNhap_Click;
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
            btnThemCTPN.Location = new Point(96, 345);
            btnThemCTPN.Margin = new Padding(4, 3, 4, 3);
            btnThemCTPN.Name = "btnThemCTPN";
            btnThemCTPN.Size = new Size(303, 44);
            btnThemCTPN.TabIndex = 14;
            btnThemCTPN.Text = "Thêm Chi Tiết Phiếu Nhập";
            btnThemCTPN.UseVisualStyleBackColor = false;
            btnThemCTPN.Click += btnThemCTPN_Click;
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
            btnXoaCTPN.Click += btnXoaCTPN_Click;
            // 
            // MaThuoc
            // 
            MaThuoc.DataPropertyName = "MaThuoc";
            MaThuoc.HeaderText = "Mã Thuốc";
            MaThuoc.Name = "MaThuoc";
            MaThuoc.ReadOnly = true;
            MaThuoc.Visible = false;
            // 
            // TenThuoc
            // 
            TenThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenThuoc.DataPropertyName = "TenThuoc";
            TenThuoc.HeaderText = "Tên Thuốc";
            TenThuoc.Name = "TenThuoc";
            TenThuoc.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // ThemPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 573);
            Controls.Add(tableLayoutPanel1);
            Name = "ThemPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemPhieuNhap";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCTPN).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgCTPN;
        private Button button3;
        private Button btnThemPhieuNhap;
        private Button btnThemCTPN;
        private Button btnXoaCTPN;
        private TextBox txtSoLuong;
        private Label label4;
        private Label label3;
        private TextBox txtThuoc;
        private Button btnThemThuoc;
        private Button btnThemNCC;
        private TextBox txtNhaCungCap;
        private Label label1;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn SoLuong;
    }
}