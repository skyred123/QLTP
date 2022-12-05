namespace QLKS.Forms
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_KhachHang = new System.Windows.Forms.Panel();
            this.btn_KhachHang2 = new System.Windows.Forms.Button();
            this.btn_KhachHang1 = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.panel_NhanVien = new System.Windows.Forms.Panel();
            this.btn_NhanVien3 = new System.Windows.Forms.Button();
            this.btn_NhanVien2 = new System.Windows.Forms.Button();
            this.btn_NhanVien1 = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_View = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_KhachHang.SuspendLayout();
            this.panel_NhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel_KhachHang);
            this.panel1.Controls.Add(this.btn_KhachHang);
            this.panel1.Controls.Add(this.panel_NhanVien);
            this.panel1.Controls.Add(this.btn_NhanVien);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 619);
            this.panel1.TabIndex = 0;
            // 
            // panel_KhachHang
            // 
            this.panel_KhachHang.Controls.Add(this.btn_KhachHang2);
            this.panel_KhachHang.Controls.Add(this.btn_KhachHang1);
            this.panel_KhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_KhachHang.Location = new System.Drawing.Point(0, 377);
            this.panel_KhachHang.Name = "panel_KhachHang";
            this.panel_KhachHang.Size = new System.Drawing.Size(220, 162);
            this.panel_KhachHang.TabIndex = 4;
            // 
            // btn_KhachHang2
            // 
            this.btn_KhachHang2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KhachHang2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KhachHang2.Location = new System.Drawing.Point(0, 45);
            this.btn_KhachHang2.Name = "btn_KhachHang2";
            this.btn_KhachHang2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_KhachHang2.Size = new System.Drawing.Size(220, 45);
            this.btn_KhachHang2.TabIndex = 1;
            this.btn_KhachHang2.Text = "Danh Sách KH";
            this.btn_KhachHang2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KhachHang2.UseVisualStyleBackColor = true;
            this.btn_KhachHang2.Click += new System.EventHandler(this.btn_KhachHang2_Click);
            // 
            // btn_KhachHang1
            // 
            this.btn_KhachHang1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KhachHang1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KhachHang1.Location = new System.Drawing.Point(0, 0);
            this.btn_KhachHang1.Name = "btn_KhachHang1";
            this.btn_KhachHang1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_KhachHang1.Size = new System.Drawing.Size(220, 45);
            this.btn_KhachHang1.TabIndex = 0;
            this.btn_KhachHang1.Text = "Tạo Tài Khoản";
            this.btn_KhachHang1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KhachHang1.UseVisualStyleBackColor = true;
            this.btn_KhachHang1.Click += new System.EventHandler(this.btn_KhachHang1_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KhachHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 327);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(220, 50);
            this.btn_KhachHang.TabIndex = 3;
            this.btn_KhachHang.Text = "Khách Hàng";
            this.btn_KhachHang.UseVisualStyleBackColor = true;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // panel_NhanVien
            // 
            this.panel_NhanVien.AutoSize = true;
            this.panel_NhanVien.Controls.Add(this.btn_NhanVien3);
            this.panel_NhanVien.Controls.Add(this.btn_NhanVien2);
            this.panel_NhanVien.Controls.Add(this.btn_NhanVien1);
            this.panel_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NhanVien.Location = new System.Drawing.Point(0, 192);
            this.panel_NhanVien.Name = "panel_NhanVien";
            this.panel_NhanVien.Size = new System.Drawing.Size(220, 135);
            this.panel_NhanVien.TabIndex = 2;
            // 
            // btn_NhanVien3
            // 
            this.btn_NhanVien3.AutoSize = true;
            this.btn_NhanVien3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhanVien3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanVien3.Location = new System.Drawing.Point(0, 90);
            this.btn_NhanVien3.Name = "btn_NhanVien3";
            this.btn_NhanVien3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_NhanVien3.Size = new System.Drawing.Size(220, 45);
            this.btn_NhanVien3.TabIndex = 2;
            this.btn_NhanVien3.Text = "Nhân Viên";
            this.btn_NhanVien3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien3.UseVisualStyleBackColor = true;
            this.btn_NhanVien3.Click += new System.EventHandler(this.btn_NhanVien3_Click);
            // 
            // btn_NhanVien2
            // 
            this.btn_NhanVien2.AutoSize = true;
            this.btn_NhanVien2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhanVien2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanVien2.Location = new System.Drawing.Point(0, 45);
            this.btn_NhanVien2.Name = "btn_NhanVien2";
            this.btn_NhanVien2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_NhanVien2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_NhanVien2.Size = new System.Drawing.Size(220, 45);
            this.btn_NhanVien2.TabIndex = 1;
            this.btn_NhanVien2.Text = "Cài Đặt Tài Khoản";
            this.btn_NhanVien2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien2.UseVisualStyleBackColor = true;
            this.btn_NhanVien2.Click += new System.EventHandler(this.btn_NhanVien2_Click);
            // 
            // btn_NhanVien1
            // 
            this.btn_NhanVien1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhanVien1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanVien1.Location = new System.Drawing.Point(0, 0);
            this.btn_NhanVien1.Name = "btn_NhanVien1";
            this.btn_NhanVien1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_NhanVien1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_NhanVien1.Size = new System.Drawing.Size(220, 45);
            this.btn_NhanVien1.TabIndex = 0;
            this.btn_NhanVien1.Text = "Thông Tin";
            this.btn_NhanVien1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien1.UseVisualStyleBackColor = true;
            this.btn_NhanVien1.Click += new System.EventHandler(this.btn_NhanVien1_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 142);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(220, 50);
            this.btn_NhanVien.TabIndex = 1;
            this.btn_NhanVien.Text = "Nhân Viên";
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 142);
            this.panel2.TabIndex = 0;
            // 
            // panel_View
            // 
            this.panel_View.AutoSize = true;
            this.panel_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_View.Location = new System.Drawing.Point(220, 0);
            this.panel_View.Name = "panel_View";
            this.panel_View.Size = new System.Drawing.Size(873, 619);
            this.panel_View.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 619);
            this.Controls.Add(this.panel_View);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_KhachHang.ResumeLayout(false);
            this.panel_NhanVien.ResumeLayout(false);
            this.panel_NhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btn_NhanVien;
        private Panel panel2;
        private Button btn_KhachHang;
        private Panel panel_View;
        private Button btn_NhanVien2;
        private Button btn_NhanVien1;
        private Panel panel_NhanVien;
        private Button btn_NhanVien3;
        private Panel panel_KhachHang;
        private Button btn_KhachHang1;
        private Button btn_KhachHang2;
    }
}