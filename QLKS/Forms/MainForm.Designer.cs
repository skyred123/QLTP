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
            this.button2 = new System.Windows.Forms.Button();
            this.panel_NhanVien = new System.Windows.Forms.Panel();
            this.btn_QLNV = new System.Windows.Forms.Button();
            this.btn_ChinhSuaTK = new System.Windows.Forms.Button();
            this.btn_TTNhanVien = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_View = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_NhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel_NhanVien);
            this.panel1.Controls.Add(this.btn_NhanVien);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 619);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel_NhanVien
            // 
            this.panel_NhanVien.Controls.Add(this.btn_QLNV);
            this.panel_NhanVien.Controls.Add(this.btn_ChinhSuaTK);
            this.panel_NhanVien.Controls.Add(this.btn_TTNhanVien);
            this.panel_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NhanVien.Location = new System.Drawing.Point(0, 192);
            this.panel_NhanVien.Name = "panel_NhanVien";
            this.panel_NhanVien.Size = new System.Drawing.Size(182, 160);
            this.panel_NhanVien.TabIndex = 2;
            // 
            // btn_QLNV
            // 
            this.btn_QLNV.AutoSize = true;
            this.btn_QLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QLNV.Location = new System.Drawing.Point(0, 109);
            this.btn_QLNV.Name = "btn_QLNV";
            this.btn_QLNV.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_QLNV.Size = new System.Drawing.Size(182, 50);
            this.btn_QLNV.TabIndex = 2;
            this.btn_QLNV.Text = "Nhân Viên";
            this.btn_QLNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLNV.UseVisualStyleBackColor = true;
            this.btn_QLNV.Click += new System.EventHandler(this.btn_QLNV_Click);
            // 
            // btn_ChinhSuaTK
            // 
            this.btn_ChinhSuaTK.AutoSize = true;
            this.btn_ChinhSuaTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ChinhSuaTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ChinhSuaTK.Location = new System.Drawing.Point(0, 50);
            this.btn_ChinhSuaTK.Name = "btn_ChinhSuaTK";
            this.btn_ChinhSuaTK.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_ChinhSuaTK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ChinhSuaTK.Size = new System.Drawing.Size(182, 59);
            this.btn_ChinhSuaTK.TabIndex = 1;
            this.btn_ChinhSuaTK.Text = "Chỉnh Sửa Tài Khoản";
            this.btn_ChinhSuaTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChinhSuaTK.UseVisualStyleBackColor = true;
            this.btn_ChinhSuaTK.Click += new System.EventHandler(this.btn_ChinhSuaTK_Click);
            // 
            // btn_TTNhanVien
            // 
            this.btn_TTNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TTNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TTNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btn_TTNhanVien.Name = "btn_TTNhanVien";
            this.btn_TTNhanVien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_TTNhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_TTNhanVien.Size = new System.Drawing.Size(182, 50);
            this.btn_TTNhanVien.TabIndex = 0;
            this.btn_TTNhanVien.Text = "Thông Tin";
            this.btn_TTNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TTNhanVien.UseVisualStyleBackColor = true;
            this.btn_TTNhanVien.Click += new System.EventHandler(this.btn_TTNhanVien_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 142);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(182, 50);
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
            this.panel2.Size = new System.Drawing.Size(182, 142);
            this.panel2.TabIndex = 0;
            // 
            // panel_View
            // 
            this.panel_View.AutoSize = true;
            this.panel_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_View.Location = new System.Drawing.Point(182, 0);
            this.panel_View.Name = "panel_View";
            this.panel_View.Size = new System.Drawing.Size(754, 619);
            this.panel_View.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 619);
            this.Controls.Add(this.panel_View);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel_NhanVien.ResumeLayout(false);
            this.panel_NhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btn_NhanVien;
        private Panel panel2;
        private Button button2;
        private Panel panel_View;
        private Button btn_ChinhSuaTK;
        private Button btn_TTNhanVien;
        private Panel panel_NhanVien;
        private Button btn_QLNV;
    }
}