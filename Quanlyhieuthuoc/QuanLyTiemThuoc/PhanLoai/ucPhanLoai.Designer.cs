namespace Quanlyhieuthuoc.PhanLoai
{
    partial class ucPhanLoai
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
            dgPhanLoai = new DataGridView();
            MaLoaiThuoc = new DataGridViewTextBoxColumn();
            TenLoaiThuoc = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblTenLoaiThuoc = new Label();
            lblMaLoaiThuoc = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPhanLoai).BeginInit();
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
            tableLayoutPanel1.Size = new Size(1006, 577);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgPhanLoai);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 571);
            panel1.TabIndex = 0;
            // 
            // dgPhanLoai
            // 
            dgPhanLoai.AllowUserToAddRows = false;
            dgPhanLoai.AllowUserToDeleteRows = false;
            dgPhanLoai.AllowUserToResizeColumns = false;
            dgPhanLoai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgPhanLoai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgPhanLoai.BackgroundColor = Color.LightPink;
            dgPhanLoai.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgPhanLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgPhanLoai.ColumnHeadersHeight = 40;
            dgPhanLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgPhanLoai.Columns.AddRange(new DataGridViewColumn[] { MaLoaiThuoc, TenLoaiThuoc });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgPhanLoai.DefaultCellStyle = dataGridViewCellStyle3;
            dgPhanLoai.Dock = DockStyle.Fill;
            dgPhanLoai.GridColor = Color.LightPink;
            dgPhanLoai.Location = new Point(0, 0);
            dgPhanLoai.MultiSelect = false;
            dgPhanLoai.Name = "dgPhanLoai";
            dgPhanLoai.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgPhanLoai.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgPhanLoai.RowHeadersVisible = false;
            dgPhanLoai.RowHeadersWidth = 40;
            dgPhanLoai.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgPhanLoai.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgPhanLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPhanLoai.Size = new Size(600, 571);
            dgPhanLoai.TabIndex = 1;
            dgPhanLoai.CellClick += dgPhanLoai_CellClick;
            // 
            // MaLoaiThuoc
            // 
            MaLoaiThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaLoaiThuoc.DataPropertyName = "MaLoaiThuoc";
            MaLoaiThuoc.HeaderText = "Mã Loại Thuốc";
            MaLoaiThuoc.Name = "MaLoaiThuoc";
            MaLoaiThuoc.ReadOnly = true;
            // 
            // TenLoaiThuoc
            // 
            TenLoaiThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoaiThuoc.DataPropertyName = "TenLoaiThuoc";
            TenLoaiThuoc.HeaderText = "Tên Loại Thuốc";
            TenLoaiThuoc.Name = "TenLoaiThuoc";
            TenLoaiThuoc.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(lblTenLoaiThuoc);
            panel2.Controls.Add(lblMaLoaiThuoc);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(609, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 571);
            panel2.TabIndex = 1;
            // 
            // lblTenLoaiThuoc
            // 
            lblTenLoaiThuoc.AutoSize = true;
            lblTenLoaiThuoc.Font = new Font("Segoe UI", 16F);
            lblTenLoaiThuoc.Location = new Point(248, 171);
            lblTenLoaiThuoc.Name = "lblTenLoaiThuoc";
            lblTenLoaiThuoc.Size = new Size(28, 30);
            lblTenLoaiThuoc.TabIndex = 19;
            lblTenLoaiThuoc.Text = "...";
            // 
            // lblMaLoaiThuoc
            // 
            lblMaLoaiThuoc.AutoSize = true;
            lblMaLoaiThuoc.Font = new Font("Segoe UI", 16F);
            lblMaLoaiThuoc.Location = new Point(248, 111);
            lblMaLoaiThuoc.Name = "lblMaLoaiThuoc";
            lblMaLoaiThuoc.Size = new Size(28, 30);
            lblMaLoaiThuoc.TabIndex = 16;
            lblMaLoaiThuoc.Text = "...";
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
            label2.Location = new Point(41, 171);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 11;
            label2.Text = "Tên Loại Thuốc :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(41, 111);
            label1.Name = "label1";
            label1.Size = new Size(165, 30);
            label1.TabIndex = 10;
            label1.Text = "Mã Loại Thuốc :";
            // 
            // ucPhanLoai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucPhanLoai";
            Size = new Size(1006, 577);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPhanLoai).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgPhanLoai;
        private Panel panel2;
        private Label lblTenLoaiThuoc;
        private Label lblMaLoaiThuoc;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn MaLoaiThuoc;
        private DataGridViewTextBoxColumn TenLoaiThuoc;
    }
}
