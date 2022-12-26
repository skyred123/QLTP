using Library.Entity;

namespace QLKS.UserControls
{
    partial class UserControl_ThePhong
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
            this.components = new System.ComponentModel.Container();
            this.pbx_Image = new System.Windows.Forms.PictureBox();
            this.label_TenKH = new System.Windows.Forms.Label();
            this.label_TinhTrang = new System.Windows.Forms.Label();
            this.label_TenPhong = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datDichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Loai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Image)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbx_Image
            // 
            this.pbx_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbx_Image.Location = new System.Drawing.Point(22, 18);
            this.pbx_Image.Name = "pbx_Image";
            this.pbx_Image.Size = new System.Drawing.Size(109, 140);
            this.pbx_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Image.TabIndex = 0;
            this.pbx_Image.TabStop = false;
            // 
            // label_TenKH
            // 
            this.label_TenKH.AutoSize = true;
            this.label_TenKH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TenKH.Location = new System.Drawing.Point(158, 44);
            this.label_TenKH.Name = "label_TenKH";
            this.label_TenKH.Size = new System.Drawing.Size(66, 25);
            this.label_TenKH.TabIndex = 3;
            this.label_TenKH.Text = "Ten KH";
            // 
            // label_TinhTrang
            // 
            this.label_TinhTrang.AutoSize = true;
            this.label_TinhTrang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TinhTrang.Location = new System.Drawing.Point(158, 93);
            this.label_TinhTrang.Name = "label_TinhTrang";
            this.label_TinhTrang.Size = new System.Drawing.Size(88, 25);
            this.label_TinhTrang.TabIndex = 1;
            this.label_TinhTrang.Text = "TinhTrang";
            // 
            // label_TenPhong
            // 
            this.label_TenPhong.AutoSize = true;
            this.label_TenPhong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TenPhong.Location = new System.Drawing.Point(156, 0);
            this.label_TenPhong.Name = "label_TenPhong";
            this.label_TenPhong.Size = new System.Drawing.Size(90, 25);
            this.label_TenPhong.TabIndex = 0;
            this.label_TenPhong.Text = "TenPhong";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemToolStripMenuItem,
            this.suaToolStripMenuItem,
            this.xoaToolStripMenuItem,
            this.datDichVuToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(158, 100);
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.xemToolStripMenuItem.Text = "Xem";
            this.xemToolStripMenuItem.Click += new System.EventHandler(this.xemToolStripMenuItem_Click);
            // 
            // suaToolStripMenuItem
            // 
            this.suaToolStripMenuItem.Name = "suaToolStripMenuItem";
            this.suaToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.suaToolStripMenuItem.Text = "Sữa";
            this.suaToolStripMenuItem.Click += new System.EventHandler(this.suaToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // datDichVuToolStripMenuItem
            // 
            this.datDichVuToolStripMenuItem.Name = "datDichVuToolStripMenuItem";
            this.datDichVuToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.datDichVuToolStripMenuItem.Text = "Đặt Dịch Vụ";
            this.datDichVuToolStripMenuItem.Click += new System.EventHandler(this.đặtDịchVụToolStripMenuItem_Click);
            // 
            // label_Loai
            // 
            this.label_Loai.AutoSize = true;
            this.label_Loai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Loai.Location = new System.Drawing.Point(158, 133);
            this.label_Loai.Name = "label_Loai";
            this.label_Loai.Size = new System.Drawing.Size(44, 25);
            this.label_Loai.TabIndex = 4;
            this.label_Loai.Text = "Loại";
            // 
            // UserControl_ThePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.label_Loai);
            this.Controls.Add(this.pbx_Image);
            this.Controls.Add(this.label_TenKH);
            this.Controls.Add(this.label_TinhTrang);
            this.Controls.Add(this.label_TenPhong);
            this.DoubleBuffered = true;
            this.Name = "UserControl_ThePhong";
            this.Size = new System.Drawing.Size(364, 183);
            this.Load += new System.EventHandler(this.UserControl_ThePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Image)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Phong phong;
        private PictureBox pbx_Image;
        private Label label_TinhTrang;
        private Label label_TenPhong;
        private Label label_TenKH;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem xemToolStripMenuItem;
        private ToolStripMenuItem suaToolStripMenuItem;
        private ToolStripMenuItem xoaToolStripMenuItem;
        private ToolStripMenuItem datDichVuToolStripMenuItem;
        private Label label_Loai;
    }
}
