namespace Quanlyhieuthuoc
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            pictureBox3 = new PictureBox();
            label1 = new Label();
            txtDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangnhap = new Button();
            btnThoat = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(530, 642);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightPink;
            label1.Location = new Point(164, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 37);
            label1.TabIndex = 7;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // txtDangNhap
            // 
            txtDangNhap.BackColor = SystemColors.Window;
            txtDangNhap.Cursor = Cursors.IBeam;
            txtDangNhap.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDangNhap.ForeColor = Color.Black;
            txtDangNhap.Location = new Point(71, 233);
            txtDangNhap.Margin = new Padding(4, 3, 4, 3);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(381, 35);
            txtDangNhap.TabIndex = 0;
            txtDangNhap.Text = "admin";
            txtDangNhap.Click += txtDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = Color.Black;
            txtMatKhau.Location = new Point(71, 320);
            txtMatKhau.Margin = new Padding(4, 3, 4, 3);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(381, 35);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.Text = "123";
            txtMatKhau.Click += txtMatKhau_Click;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = Color.White;
            btnDangnhap.Cursor = Cursors.Hand;
            btnDangnhap.FlatAppearance.BorderColor = Color.LightPink;
            btnDangnhap.FlatAppearance.BorderSize = 2;
            btnDangnhap.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnDangnhap.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnDangnhap.FlatStyle = FlatStyle.Flat;
            btnDangnhap.Font = new Font("Microsoft Sans Serif", 16F);
            btnDangnhap.Location = new Point(71, 391);
            btnDangnhap.Margin = new Padding(4, 3, 4, 3);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(382, 46);
            btnDangnhap.TabIndex = 2;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
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
            btnThoat.Font = new Font("Microsoft Sans Serif", 16F);
            btnThoat.Location = new Point(71, 467);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(382, 40);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(66, 202);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 26);
            label2.TabIndex = 8;
            label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 16F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(66, 288);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 26);
            label3.TabIndex = 9;
            label3.Text = "Mật Khẩu";
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 642);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMatKhau);
            Controls.Add(txtDangNhap);
            Controls.Add(btnDangnhap);
            Controls.Add(btnThoat);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

