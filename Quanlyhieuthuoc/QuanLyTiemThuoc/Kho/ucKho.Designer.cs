namespace Quanlyhieuthuoc.Kho
{
    partial class ucKho
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgKhoThuoc = new DataGridView();
            Thang = new DataGridViewTextBoxColumn();
            Nam = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            DauKy = new DataGridViewTextBoxColumn();
            NhapTrongKy = new DataGridViewTextBoxColumn();
            XuatTrongThang = new DataGridViewTextBoxColumn();
            TonKho = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblTonKho = new Label();
            label4 = new Label();
            lblXuatTrongThang = new Label();
            label7 = new Label();
            lblNhapTrongKy = new Label();
            label6 = new Label();
            lblDauKy = new Label();
            lblTenThuoc = new Label();
            btnThem = new Button();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgKhoThuoc).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1132, 592);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgKhoThuoc);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 586);
            panel1.TabIndex = 0;
            // 
            // dgKhoThuoc
            // 
            dgKhoThuoc.AllowUserToAddRows = false;
            dgKhoThuoc.AllowUserToDeleteRows = false;
            dgKhoThuoc.AllowUserToResizeColumns = false;
            dgKhoThuoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgKhoThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgKhoThuoc.BackgroundColor = Color.LightPink;
            dgKhoThuoc.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgKhoThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgKhoThuoc.ColumnHeadersHeight = 40;
            dgKhoThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgKhoThuoc.Columns.AddRange(new DataGridViewColumn[] { Thang, Nam, TenThuoc, DauKy, NhapTrongKy, XuatTrongThang, TonKho });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgKhoThuoc.DefaultCellStyle = dataGridViewCellStyle3;
            dgKhoThuoc.Dock = DockStyle.Fill;
            dgKhoThuoc.GridColor = Color.LightPink;
            dgKhoThuoc.Location = new Point(0, 0);
            dgKhoThuoc.MultiSelect = false;
            dgKhoThuoc.Name = "dgKhoThuoc";
            dgKhoThuoc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgKhoThuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgKhoThuoc.RowHeadersVisible = false;
            dgKhoThuoc.RowHeadersWidth = 40;
            dgKhoThuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgKhoThuoc.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgKhoThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKhoThuoc.Size = new Size(726, 586);
            dgKhoThuoc.TabIndex = 1;
            dgKhoThuoc.CellClick += dgKhoThuoc_CellClick;
            // 
            // Thang
            // 
            Thang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Thang.DataPropertyName = "Thang";
            Thang.HeaderText = "Tháng";
            Thang.Name = "Thang";
            Thang.ReadOnly = true;
            // 
            // Nam
            // 
            Nam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nam.DataPropertyName = "Nam";
            Nam.HeaderText = "Năm";
            Nam.Name = "Nam";
            Nam.ReadOnly = true;
            // 
            // TenThuoc
            // 
            TenThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenThuoc.DataPropertyName = "TenThuoc";
            TenThuoc.HeaderText = "Tên Thuốc";
            TenThuoc.Name = "TenThuoc";
            TenThuoc.ReadOnly = true;
            // 
            // DauKy
            // 
            DauKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DauKy.DataPropertyName = "DauKy";
            DauKy.HeaderText = "Đầu Kỳ";
            DauKy.Name = "DauKy";
            DauKy.ReadOnly = true;
            // 
            // NhapTrongKy
            // 
            NhapTrongKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NhapTrongKy.DataPropertyName = "NhapTrongKy";
            NhapTrongKy.HeaderText = "Trong Kỳ";
            NhapTrongKy.Name = "NhapTrongKy";
            NhapTrongKy.ReadOnly = true;
            // 
            // XuatTrongThang
            // 
            XuatTrongThang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            XuatTrongThang.DataPropertyName = "XuatTrongThang";
            XuatTrongThang.HeaderText = "Xuất Trong Tháng";
            XuatTrongThang.Name = "XuatTrongThang";
            XuatTrongThang.ReadOnly = true;
            // 
            // TonKho
            // 
            TonKho.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TonKho.DataPropertyName = "TonKho";
            TonKho.HeaderText = "Tồn Kho";
            TonKho.Name = "TonKho";
            TonKho.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(lblTonKho);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblXuatTrongThang);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblNhapTrongKy);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblDauKy);
            panel2.Controls.Add(lblTenThuoc);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(735, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 586);
            panel2.TabIndex = 1;
            // 
            // lblTonKho
            // 
            lblTonKho.AutoSize = true;
            lblTonKho.Font = new Font("Tahoma", 16F);
            lblTonKho.Location = new Point(223, 238);
            lblTonKho.Name = "lblTonKho";
            lblTonKho.Size = new Size(33, 27);
            lblTonKho.TabIndex = 25;
            lblTonKho.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16F);
            label4.Location = new Point(18, 238);
            label4.Name = "label4";
            label4.Size = new Size(108, 27);
            label4.TabIndex = 24;
            label4.Text = "Tồn Kho :";
            // 
            // lblXuatTrongThang
            // 
            lblXuatTrongThang.AutoSize = true;
            lblXuatTrongThang.Font = new Font("Tahoma", 16F);
            lblXuatTrongThang.Location = new Point(223, 188);
            lblXuatTrongThang.Name = "lblXuatTrongThang";
            lblXuatTrongThang.Size = new Size(33, 27);
            lblXuatTrongThang.TabIndex = 23;
            lblXuatTrongThang.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 16F);
            label7.Location = new Point(18, 188);
            label7.Name = "label7";
            label7.Size = new Size(203, 27);
            label7.TabIndex = 22;
            label7.Text = "Xuất Trong Tháng :";
            // 
            // lblNhapTrongKy
            // 
            lblNhapTrongKy.AutoSize = true;
            lblNhapTrongKy.Font = new Font("Tahoma", 16F);
            lblNhapTrongKy.Location = new Point(223, 138);
            lblNhapTrongKy.Name = "lblNhapTrongKy";
            lblNhapTrongKy.Size = new Size(33, 27);
            lblNhapTrongKy.TabIndex = 21;
            lblNhapTrongKy.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 16F);
            label6.Location = new Point(18, 138);
            label6.Name = "label6";
            label6.Size = new Size(173, 27);
            label6.TabIndex = 20;
            label6.Text = "Nhập Trong Kỳ :";
            // 
            // lblDauKy
            // 
            lblDauKy.AutoSize = true;
            lblDauKy.Font = new Font("Tahoma", 16F);
            lblDauKy.Location = new Point(223, 88);
            lblDauKy.Name = "lblDauKy";
            lblDauKy.Size = new Size(33, 27);
            lblDauKy.TabIndex = 19;
            lblDauKy.Text = "...";
            // 
            // lblTenThuoc
            // 
            lblTenThuoc.AutoSize = true;
            lblTenThuoc.Font = new Font("Tahoma", 16F);
            lblTenThuoc.Location = new Point(223, 32);
            lblTenThuoc.Name = "lblTenThuoc";
            lblTenThuoc.Size = new Size(33, 27);
            lblTenThuoc.TabIndex = 16;
            lblTenThuoc.Text = "...";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatAppearance.BorderColor = Color.LightPink;
            btnThem.FlatAppearance.BorderSize = 2;
            btnThem.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnThem.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThem.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(27, 310);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 44);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F);
            label3.Location = new Point(18, 88);
            label3.Name = "label3";
            label3.Size = new Size(97, 27);
            label3.TabIndex = 13;
            label3.Text = "Đầu Kỳ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F);
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(130, 27);
            label1.TabIndex = 10;
            label1.Text = "Tên Thuốc :";
            // 
            // ucKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucKho";
            Size = new Size(1132, 592);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgKhoThuoc).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgKhoThuoc;
        private Panel panel2;
        private Label lblNhapTrongKy;
        private Label label6;
        private Label lblDauKy;
        private Label lblTenThuoc;
        private Button btnThem;
        private Label label3;
        private Label label1;
        private DataGridViewTextBoxColumn Thang;
        private DataGridViewTextBoxColumn Nam;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DauKy;
        private DataGridViewTextBoxColumn NhapTrongKy;
        private DataGridViewTextBoxColumn XuatTrongThang;
        private DataGridViewTextBoxColumn TonKho;
        private Label lblTonKho;
        private Label label4;
        private Label lblXuatTrongThang;
        private Label label7;
    }
}
