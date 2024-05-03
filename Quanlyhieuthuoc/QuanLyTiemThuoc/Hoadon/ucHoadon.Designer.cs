namespace Quanlyhieuthuoc.Hoadon
{
    partial class ucHoadon
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
            panel2 = new Panel();
            dgThuoc = new DataGridView();
            dtpNgayBatDau = new DateTimePicker();
            dtpNgayKetThuc = new DateTimePicker();
            btnInHoaDon = new Button();
            lblNgayBatDau = new Label();
            lblNgayKetThuc = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgThuoc).BeginInit();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1110, 621);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(lblNgayKetThuc);
            panel1.Controls.Add(lblNgayBatDau);
            panel1.Controls.Add(btnInHoaDon);
            panel1.Controls.Add(dtpNgayKetThuc);
            panel1.Controls.Add(dtpNgayBatDau);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 74);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgThuoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 535);
            panel2.TabIndex = 1;
            // 
            // dgThuoc
            // 
            dgThuoc.AllowUserToAddRows = false;
            dgThuoc.AllowUserToDeleteRows = false;
            dgThuoc.AllowUserToResizeColumns = false;
            dgThuoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgThuoc.BackgroundColor = Color.LightPink;
            dgThuoc.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgThuoc.ColumnHeadersHeight = 40;
            dgThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgThuoc.DefaultCellStyle = dataGridViewCellStyle3;
            dgThuoc.Dock = DockStyle.Fill;
            dgThuoc.GridColor = Color.LightPink;
            dgThuoc.Location = new Point(0, 0);
            dgThuoc.MultiSelect = false;
            dgThuoc.Name = "dgThuoc";
            dgThuoc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgThuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgThuoc.RowHeadersVisible = false;
            dgThuoc.RowHeadersWidth = 40;
            dgThuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgThuoc.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgThuoc.Size = new Size(1104, 535);
            dgThuoc.TabIndex = 2;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Font = new Font("Segoe UI", 16F);
            dtpNgayBatDau.Location = new Point(175, 20);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(200, 36);
            dtpNgayBatDau.TabIndex = 0;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Font = new Font("Segoe UI", 16F);
            dtpNgayKetThuc.Location = new Point(566, 19);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(200, 36);
            dtpNgayKetThuc.TabIndex = 1;
            dtpNgayKetThuc.Value = new DateTime(2024, 5, 3, 0, 0, 0, 0);
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.White;
            btnInHoaDon.FlatAppearance.BorderColor = Color.LightPink;
            btnInHoaDon.FlatAppearance.BorderSize = 2;
            btnInHoaDon.FlatAppearance.CheckedBackColor = Color.LightPink;
            btnInHoaDon.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnInHoaDon.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInHoaDon.Location = new Point(905, 19);
            btnInHoaDon.Margin = new Padding(4, 3, 4, 3);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(164, 37);
            btnInHoaDon.TabIndex = 13;
            btnInHoaDon.Text = "In Hoá Đơn";
            btnInHoaDon.UseVisualStyleBackColor = false;
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Font = new Font("Tahoma", 16F);
            lblNgayBatDau.Location = new Point(22, 24);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(147, 27);
            lblNgayBatDau.TabIndex = 14;
            lblNgayBatDau.Text = "Ngày Bắt Đầu";
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Font = new Font("Tahoma", 16F);
            lblNgayKetThuc.Location = new Point(405, 24);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new Size(155, 27);
            lblNgayKetThuc.TabIndex = 15;
            lblNgayKetThuc.Text = "Ngày Kết Thúc";
            // 
            // ucHoadon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucHoadon";
            Size = new Size(1110, 621);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgThuoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private DataGridView dgThuoc;
        private Label lblNgayKetThuc;
        private Label lblNgayBatDau;
        private Button btnInHoaDon;
    }
}
