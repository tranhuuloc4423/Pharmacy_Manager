namespace Quanlyhieuthuoc.TaiKhoan
{
    partial class ucTaiKhoan
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgTaiKhoan = new DataGridView();
            TenTaiKhoan = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            VaiTro = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            cbQuyen = new ComboBox();
            lblHoTen = new Label();
            lblTenTaiKhoan = new Label();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTaiKhoan = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTaiKhoan).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1228, 610);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgTaiKhoan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 604);
            panel1.TabIndex = 0;
            // 
            // dgTaiKhoan
            // 
            dgTaiKhoan.AllowUserToAddRows = false;
            dgTaiKhoan.AllowUserToDeleteRows = false;
            dgTaiKhoan.AllowUserToResizeColumns = false;
            dgTaiKhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgTaiKhoan.BackgroundColor = Color.LightPink;
            dgTaiKhoan.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgTaiKhoan.ColumnHeadersHeight = 40;
            dgTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { TenTaiKhoan, HoTen, VaiTro });
            dgTaiKhoan.Dock = DockStyle.Fill;
            dgTaiKhoan.GridColor = Color.LightPink;
            dgTaiKhoan.Location = new Point(0, 0);
            dgTaiKhoan.MultiSelect = false;
            dgTaiKhoan.Name = "dgTaiKhoan";
            dgTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgTaiKhoan.RowHeadersWidth = 40;
            dgTaiKhoan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTaiKhoan.Size = new Size(730, 604);
            dgTaiKhoan.TabIndex = 0;
            dgTaiKhoan.CellClick += dgTaiKhoan_CellClick;
            // 
            // TenTaiKhoan
            // 
            TenTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            TenTaiKhoan.HeaderText = "Tên Tài Khoản";
            TenTaiKhoan.Name = "TenTaiKhoan";
            TenTaiKhoan.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ Tên";
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // VaiTro
            // 
            VaiTro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VaiTro.DataPropertyName = "VaiTro";
            VaiTro.HeaderText = "Vai Trò";
            VaiTro.Name = "VaiTro";
            VaiTro.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(cbQuyen);
            panel2.Controls.Add(lblHoTen);
            panel2.Controls.Add(lblTenTaiKhoan);
            panel2.Controls.Add(btnCapNhat);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTaiKhoan);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(739, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 604);
            panel2.TabIndex = 1;
            // 
            // cbQuyen
            // 
            cbQuyen.Enabled = false;
            cbQuyen.Font = new Font("Segoe UI", 14F);
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Items.AddRange(new object[] { "admin", "user" });
            cbQuyen.Location = new Point(249, 232);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(146, 33);
            cbQuyen.TabIndex = 8;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 16F);
            lblHoTen.Location = new Point(249, 169);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(82, 30);
            lblHoTen.TabIndex = 7;
            lblHoTen.Text = "Họ Tên";
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.AutoSize = true;
            lblTenTaiKhoan.Font = new Font("Segoe UI", 16F);
            lblTenTaiKhoan.Location = new Point(249, 109);
            lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            lblTenTaiKhoan.Size = new Size(146, 30);
            lblTenTaiKhoan.TabIndex = 6;
            lblTenTaiKhoan.Text = "Tên Tài Khoản";
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.White;
            btnCapNhat.FlatAppearance.BorderColor = Color.LightPink;
            btnCapNhat.FlatAppearance.BorderSize = 2;
            btnCapNhat.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnCapNhat.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnCapNhat.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(255, 315);
            btnCapNhat.Margin = new Padding(4, 3, 4, 3);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(164, 44);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.FlatAppearance.BorderColor = Color.LightPink;
            btnXoa.FlatAppearance.BorderSize = 2;
            btnXoa.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnXoa.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnXoa.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(62, 391);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(164, 44);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
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
            btnThem.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(62, 315);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 44);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(85, 235);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 3;
            label3.Text = "Vai Trò :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(85, 169);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(85, 109);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 1;
            label1.Text = "Tên Tài Khoản :";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 16F);
            lblTaiKhoan.Location = new Point(198, 52);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(106, 30);
            lblTaiKhoan.TabIndex = 0;
            lblTaiKhoan.Text = "Tài Khoản";
            // 
            // ucTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucTaiKhoan";
            Size = new Size(1228, 610);
            Load += ucTaiKhoan_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTaiKhoan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label lblTaiKhoan;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnThem;
        private DataGridView dgTaiKhoan;
        private DataGridViewTextBoxColumn TenTaiKhoan;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn VaiTro;
        private Label lblHoTen;
        private Label lblTenTaiKhoan;
        private ComboBox cbQuyen;
    }
}
