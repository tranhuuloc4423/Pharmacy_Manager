﻿namespace Quanlyhieuthuoc.Hoadon
{
    partial class InChiTietHoaDon
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
            label1 = new Label();
            panel2 = new Panel();
            lblNgayBan = new Label();
            label5 = new Label();
            lblMaHoaDon = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblNguoiBan = new Label();
            label9 = new Label();
            lblKhachHang = new Label();
            label7 = new Label();
            panel4 = new Panel();
            lblTongTien = new Label();
            label8 = new Label();
            lblGiamGia = new Label();
            label6 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            dgChiTiet = new DataGridView();
            TenThuoc = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgChiTiet).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 4);
            tableLayoutPanel1.Controls.Add(panel5, 0, 5);
            tableLayoutPanel1.Controls.Add(panel6, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(694, 695);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F);
            label1.Location = new Point(222, 14);
            label1.Name = "label1";
            label1.Size = new Size(227, 29);
            label1.TabIndex = 0;
            label1.Text = "Hoá Đơn Bán Thuốc";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(lblNgayBan);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblMaHoaDon);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(688, 54);
            panel2.TabIndex = 1;
            // 
            // lblNgayBan
            // 
            lblNgayBan.AutoSize = true;
            lblNgayBan.Font = new Font("Tahoma", 14F);
            lblNgayBan.Location = new Point(576, 16);
            lblNgayBan.Name = "lblNgayBan";
            lblNgayBan.Size = new Size(28, 23);
            lblNgayBan.TabIndex = 4;
            lblNgayBan.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14F);
            label5.Location = new Point(443, 16);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 3;
            label5.Text = "Ngày Bán :";
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Tahoma", 14F);
            lblMaHoaDon.Location = new Point(142, 16);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(28, 23);
            lblMaHoaDon.TabIndex = 2;
            lblMaHoaDon.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F);
            label2.Location = new Point(9, 16);
            label2.Name = "label2";
            label2.Size = new Size(127, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã Hoá Đơn :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Thistle;
            panel3.Controls.Add(lblNguoiBan);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(lblKhachHang);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(688, 54);
            panel3.TabIndex = 2;
            // 
            // lblNguoiBan
            // 
            lblNguoiBan.AutoSize = true;
            lblNguoiBan.Font = new Font("Tahoma", 14F);
            lblNguoiBan.Location = new Point(576, 18);
            lblNguoiBan.Name = "lblNguoiBan";
            lblNguoiBan.Size = new Size(28, 23);
            lblNguoiBan.TabIndex = 8;
            lblNguoiBan.Text = "...";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 14F);
            label9.Location = new Point(443, 18);
            label9.Name = "label9";
            label9.Size = new Size(111, 23);
            label9.TabIndex = 7;
            label9.Text = "Người Bán :";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Tahoma", 14F);
            lblKhachHang.Location = new Point(142, 18);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(28, 23);
            lblKhachHang.TabIndex = 6;
            lblKhachHang.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 14F);
            label7.Location = new Point(9, 18);
            label7.Name = "label7";
            label7.Size = new Size(126, 23);
            label7.TabIndex = 5;
            label7.Text = "Khách Hàng :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(lblTongTien);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(lblGiamGia);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 518);
            panel4.Name = "panel4";
            panel4.Size = new Size(688, 114);
            panel4.TabIndex = 3;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Tahoma", 14F);
            lblTongTien.Location = new Point(575, 56);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(28, 23);
            lblTongTien.TabIndex = 8;
            lblTongTien.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 14F);
            label8.Location = new Point(450, 56);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 7;
            label8.Text = "Tổng Tiền :";
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Font = new Font("Tahoma", 14F);
            lblGiamGia.Location = new Point(575, 12);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(28, 23);
            lblGiamGia.TabIndex = 6;
            lblGiamGia.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14F);
            label6.Location = new Point(450, 12);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 5;
            label6.Text = "Giảm Giá :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Thistle;
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 638);
            panel5.Name = "panel5";
            panel5.Size = new Size(688, 54);
            panel5.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F);
            label3.Location = new Point(239, 6);
            label3.Name = "label3";
            label3.Size = new Size(175, 46);
            label3.TabIndex = 1;
            label3.Text = "Cảm Ơn Quý Khách\r\nHẹn Gặp Lại";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgChiTiet);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 183);
            panel6.Name = "panel6";
            panel6.Size = new Size(688, 329);
            panel6.TabIndex = 5;
            // 
            // dgChiTiet
            // 
            dgChiTiet.AllowUserToAddRows = false;
            dgChiTiet.AllowUserToDeleteRows = false;
            dgChiTiet.AllowUserToResizeColumns = false;
            dgChiTiet.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgChiTiet.BackgroundColor = Color.LightPink;
            dgChiTiet.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgChiTiet.ColumnHeadersHeight = 40;
            dgChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgChiTiet.Columns.AddRange(new DataGridViewColumn[] { TenThuoc, DonViTinh, SoLuong, DonGia, ThanhTien });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgChiTiet.DefaultCellStyle = dataGridViewCellStyle8;
            dgChiTiet.Dock = DockStyle.Fill;
            dgChiTiet.GridColor = Color.LightPink;
            dgChiTiet.Location = new Point(0, 0);
            dgChiTiet.MultiSelect = false;
            dgChiTiet.Name = "dgChiTiet";
            dgChiTiet.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Tahoma", 14F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgChiTiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgChiTiet.RowHeadersVisible = false;
            dgChiTiet.RowHeadersWidth = 40;
            dgChiTiet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgChiTiet.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgChiTiet.Size = new Size(688, 329);
            dgChiTiet.TabIndex = 3;
            // 
            // TenThuoc
            // 
            TenThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenThuoc.DataPropertyName = "TenThuoc";
            TenThuoc.HeaderText = "Tên Thuốc";
            TenThuoc.Name = "TenThuoc";
            TenThuoc.ReadOnly = true;
            // 
            // DonViTinh
            // 
            DonViTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DonViTinh.DataPropertyName = "DonViTinh";
            DonViTinh.HeaderText = "Đơn Vị Tính";
            DonViTinh.Name = "DonViTinh";
            DonViTinh.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // InChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 695);
            Controls.Add(tableLayoutPanel1);
            Name = "InChiTietHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InChiTietHoaDon";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private Label lblNgayBan;
        private Label label5;
        private Label lblMaHoaDon;
        private Label label2;
        private Label lblNguoiBan;
        private Label label9;
        private Label lblKhachHang;
        private Label label7;
        private DataGridView dgChiTiet;
        private Label lblTongTien;
        private Label label8;
        private Label lblGiamGia;
        private Label label6;
        private Label label3;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}