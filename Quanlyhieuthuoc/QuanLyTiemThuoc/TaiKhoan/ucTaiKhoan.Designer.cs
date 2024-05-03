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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgTaiKhoan = new DataGridView();
            TenTaiKhoan = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            cbQuyen = new ComboBox();
            lblHoTen = new Label();
            lblTenTaiKhoan = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTaiKhoan).BeginInit();
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
            tableLayoutPanel1.Size = new Size(1228, 610);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgTaiKhoan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 604);
            panel1.TabIndex = 0;
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
            dgTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { TenTaiKhoan, HoTen, MoTa });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
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
            dgTaiKhoan.Size = new Size(822, 604);
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
            // MoTa
            // 
            MoTa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Vai Trò";
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(cbQuyen);
            panel2.Controls.Add(lblHoTen);
            panel2.Controls.Add(lblTenTaiKhoan);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(831, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 604);
            panel2.TabIndex = 1;
            // 
            // cbQuyen
            // 
            cbQuyen.Enabled = false;
            cbQuyen.Font = new Font("Segoe UI", 14F);
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Items.AddRange(new object[] { "admin", "user" });
            cbQuyen.Location = new Point(185, 165);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(146, 33);
            cbQuyen.TabIndex = 8;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Tahoma", 16F);
            lblHoTen.Location = new Point(185, 102);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(83, 27);
            lblHoTen.TabIndex = 7;
            lblHoTen.Text = "Họ Tên";
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.AutoSize = true;
            lblTenTaiKhoan.Font = new Font("Tahoma", 16F);
            lblTenTaiKhoan.Location = new Point(214, 42);
            lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            lblTenTaiKhoan.Size = new Size(154, 27);
            lblTenTaiKhoan.TabIndex = 6;
            lblTenTaiKhoan.Text = "Tên Tài Khoản";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.FlatAppearance.BorderColor = Color.LightPink;
            btnSua.FlatAppearance.BorderSize = 2;
            btnSua.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnSua.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnSua.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Tahoma", 16F);
            btnSua.Location = new Point(214, 313);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(164, 44);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnCapNhat_Click;
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
            btnXoa.Font = new Font("Tahoma", 16F);
            btnXoa.Location = new Point(21, 389);
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
            btnThem.Font = new Font("Tahoma", 16F);
            btnThem.Location = new Point(21, 313);
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
            label3.Font = new Font("Tahoma", 16F);
            label3.Location = new Point(21, 168);
            label3.Name = "label3";
            label3.Size = new Size(97, 27);
            label3.TabIndex = 3;
            label3.Text = "Vai Trò :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F);
            label2.Location = new Point(21, 102);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F);
            label1.Location = new Point(21, 42);
            label1.Name = "label1";
            label1.Size = new Size(169, 27);
            label1.TabIndex = 1;
            label1.Text = "Tên Tài Khoản :";
            // 
            // ucTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucTaiKhoan";
            Size = new Size(1228, 610);
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
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DataGridView dgTaiKhoan;
        private Label lblHoTen;
        private Label lblTenTaiKhoan;
        private ComboBox cbQuyen;
        private DataGridViewTextBoxColumn TenTaiKhoan;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn MoTa;
    }
}
