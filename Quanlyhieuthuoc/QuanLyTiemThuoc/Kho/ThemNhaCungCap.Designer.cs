namespace Quanlyhieuthuoc.Kho
{
    partial class ThemNhaCungCap
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
            dgNhaCungCap = new DataGridView();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgNhaCungCap);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 444);
            panel1.TabIndex = 0;
            // 
            // dgNhaCungCap
            // 
            dgNhaCungCap.AllowUserToAddRows = false;
            dgNhaCungCap.AllowUserToDeleteRows = false;
            dgNhaCungCap.AllowUserToResizeColumns = false;
            dgNhaCungCap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgNhaCungCap.BackgroundColor = Color.LightPink;
            dgNhaCungCap.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgNhaCungCap.ColumnHeadersHeight = 40;
            dgNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { MaNhaCungCap, TenNhaCungCap, DiaChi });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgNhaCungCap.DefaultCellStyle = dataGridViewCellStyle3;
            dgNhaCungCap.Dock = DockStyle.Fill;
            dgNhaCungCap.GridColor = Color.LightPink;
            dgNhaCungCap.Location = new Point(0, 0);
            dgNhaCungCap.MultiSelect = false;
            dgNhaCungCap.Name = "dgNhaCungCap";
            dgNhaCungCap.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgNhaCungCap.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgNhaCungCap.RowHeadersVisible = false;
            dgNhaCungCap.RowHeadersWidth = 40;
            dgNhaCungCap.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgNhaCungCap.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgNhaCungCap.Size = new Size(794, 444);
            dgNhaCungCap.TabIndex = 2;
            dgNhaCungCap.CellDoubleClick += dgNhaCungCap_CellDoubleClick;
            // 
            // MaNhaCungCap
            // 
            MaNhaCungCap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            MaNhaCungCap.HeaderText = "Mã NCC";
            MaNhaCungCap.Name = "MaNhaCungCap";
            MaNhaCungCap.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Tên NCC";
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
            // ThemNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThemNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemNhaCungCap";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgNhaCungCap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgNhaCungCap;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn DiaChi;
    }
}