namespace Quanlyhieuthuoc.TrangChu
{
    partial class ucTrangChu
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnThoat = new Button();
            label1 = new Label();
            btnDangXuat = new Button();
            btnDoi = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tableLayoutPanel1.Size = new Size(1217, 737);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnDoi);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 731);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.LightPink;
            btnThoat.FlatAppearance.BorderSize = 2;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Microsoft Sans Serif", 14F);
            btnThoat.Location = new Point(144, 379);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(153, 38);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(54, 23);
            label1.Name = "label1";
            label1.Size = new Size(351, 90);
            label1.TabIndex = 19;
            label1.Text = "Chào mừng đến với \r\nTiệm Thuốc Pharmacity";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.White;
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.FlatAppearance.BorderColor = Color.LightPink;
            btnDangXuat.FlatAppearance.BorderSize = 2;
            btnDangXuat.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Microsoft Sans Serif", 14F);
            btnDangXuat.Location = new Point(144, 287);
            btnDangXuat.Margin = new Padding(4, 3, 4, 3);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(153, 38);
            btnDangXuat.TabIndex = 18;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDoi
            // 
            btnDoi.BackColor = Color.White;
            btnDoi.Cursor = Cursors.Hand;
            btnDoi.FlatAppearance.BorderColor = Color.LightPink;
            btnDoi.FlatAppearance.BorderSize = 2;
            btnDoi.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnDoi.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnDoi.FlatStyle = FlatStyle.Flat;
            btnDoi.Font = new Font("Microsoft Sans Serif", 14F);
            btnDoi.Location = new Point(144, 201);
            btnDoi.Margin = new Padding(4, 3, 4, 3);
            btnDoi.Name = "btnDoi";
            btnDoi.Size = new Size(153, 38);
            btnDoi.TabIndex = 17;
            btnDoi.Text = "Đổi thông tin";
            btnDoi.UseVisualStyleBackColor = false;
            btnDoi.Click += btnDoi_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.trangchu_image;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1211, 731);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ucTrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucTrangChu";
            Size = new Size(1217, 737);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnDangXuat;
        private Button btnDoi;
        private Label label1;
        private Button btnThoat;
    }
}
