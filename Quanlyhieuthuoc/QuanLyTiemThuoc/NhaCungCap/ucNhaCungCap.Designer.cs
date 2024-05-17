namespace Quanlyhieuthuoc.NhaCungCap
{
    partial class ucNhaCungCap
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
            dgNCC = new DataGridView();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblDiaChi = new Label();
            label4 = new Label();
            lblTenNCC = new Label();
            lblMaNCC = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgNCC).BeginInit();
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
            tableLayoutPanel1.Size = new Size(1026, 544);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgNCC);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 538);
            panel1.TabIndex = 0;
            // 
            // dgNCC
            // 
            dgNCC.AllowUserToAddRows = false;
            dgNCC.AllowUserToDeleteRows = false;
            dgNCC.AllowUserToResizeColumns = false;
            dgNCC.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgNCC.BackgroundColor = Color.LightPink;
            dgNCC.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgNCC.ColumnHeadersHeight = 40;
            dgNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgNCC.Columns.AddRange(new DataGridViewColumn[] { MaNhaCungCap, TenNhaCungCap, DiaChi });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgNCC.DefaultCellStyle = dataGridViewCellStyle3;
            dgNCC.Dock = DockStyle.Fill;
            dgNCC.GridColor = Color.LightPink;
            dgNCC.Location = new Point(0, 0);
            dgNCC.MultiSelect = false;
            dgNCC.Name = "dgNCC";
            dgNCC.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgNCC.RowHeadersVisible = false;
            dgNCC.RowHeadersWidth = 40;
            dgNCC.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgNCC.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgNCC.Size = new Size(620, 538);
            dgNCC.TabIndex = 1;
            dgNCC.CellClick += dgNCC_CellClick;
            // 
            // MaNhaCungCap
            // 
            MaNhaCungCap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            MaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            MaNhaCungCap.Name = "MaNhaCungCap";
            MaNhaCungCap.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Tên Nhà Cung Cấp";
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(lblDiaChi);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblTenNCC);
            panel2.Controls.Add(lblMaNCC);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(629, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 538);
            panel2.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 16F);
            lblDiaChi.Location = new Point(122, 186);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(28, 30);
            lblDiaChi.TabIndex = 21;
            lblDiaChi.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(24, 186);
            label4.Name = "label4";
            label4.Size = new Size(92, 30);
            label4.TabIndex = 20;
            label4.Text = "Địa Chỉ :";
            // 
            // lblTenNCC
            // 
            lblTenNCC.AutoSize = true;
            lblTenNCC.Font = new Font("Segoe UI", 16F);
            lblTenNCC.Location = new Point(231, 130);
            lblTenNCC.Name = "lblTenNCC";
            lblTenNCC.Size = new Size(28, 30);
            lblTenNCC.TabIndex = 19;
            lblTenNCC.Text = "...";
            // 
            // lblMaNCC
            // 
            lblMaNCC.AutoSize = true;
            lblMaNCC.Font = new Font("Segoe UI", 16F);
            lblMaNCC.Location = new Point(231, 70);
            lblMaNCC.Name = "lblMaNCC";
            lblMaNCC.Size = new Size(28, 30);
            lblMaNCC.TabIndex = 16;
            lblMaNCC.Text = "...";
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
            btnSua.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(217, 371);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(164, 44);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
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
            btnXoa.Location = new Point(24, 447);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(164, 44);
            btnXoa.TabIndex = 15;
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
            btnThem.Location = new Point(24, 371);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 44);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(24, 130);
            label2.Name = "label2";
            label2.Size = new Size(204, 30);
            label2.TabIndex = 11;
            label2.Text = "Tên Nhà Cung Cấp :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(24, 70);
            label1.Name = "label1";
            label1.Size = new Size(201, 30);
            label1.TabIndex = 10;
            label1.Text = "Mã Nhà Cung Cấp :";
            // 
            // ucNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucNhaCungCap";
            Size = new Size(1026, 544);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgNCC).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgNCC;
        private Panel panel2;
        private Label lblTenNCC;
        private Label lblMaNCC;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label2;
        private Label label1;
        private Label lblDiaChi;
        private Label label4;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn DiaChi;
    }
}
