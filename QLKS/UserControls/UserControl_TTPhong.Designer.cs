namespace QLKS.UserControls
{
    partial class UserControl_TTPhong
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            this.txt_DienTich = new System.Windows.Forms.TextBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbx_Tang = new System.Windows.Forms.ComboBox();
            this.link_Tang = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Xoa, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_TenPhong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_DienTich, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Gia, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Luu, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbx_Tang, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.link_Tang, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.70346F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.98861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.98861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.98861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.3307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 502);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Xoa.Location = new System.Drawing.Point(111, 357);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(137, 40);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diện tích";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá";
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TenPhong.Location = new System.Drawing.Point(254, 103);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(245, 27);
            this.txt_TenPhong.TabIndex = 6;
            // 
            // txt_DienTich
            // 
            this.txt_DienTich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_DienTich.Location = new System.Drawing.Point(254, 225);
            this.txt_DienTich.Name = "txt_DienTich";
            this.txt_DienTich.Size = new System.Drawing.Size(245, 27);
            this.txt_DienTich.TabIndex = 8;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Gia.Location = new System.Drawing.Point(254, 291);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(245, 27);
            this.txt_Gia.TabIndex = 9;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Luu.Location = new System.Drawing.Point(362, 357);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(137, 40);
            this.btn_Luu.TabIndex = 10;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // cbx_Tang
            // 
            this.cbx_Tang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_Tang.FormattingEnabled = true;
            this.cbx_Tang.Location = new System.Drawing.Point(254, 159);
            this.cbx_Tang.Name = "cbx_Tang";
            this.cbx_Tang.Size = new System.Drawing.Size(245, 28);
            this.cbx_Tang.TabIndex = 12;
            // 
            // link_Tang
            // 
            this.link_Tang.AutoSize = true;
            this.link_Tang.Dock = System.Windows.Forms.DockStyle.Top;
            this.link_Tang.Location = new System.Drawing.Point(3, 156);
            this.link_Tang.Name = "link_Tang";
            this.link_Tang.Size = new System.Drawing.Size(245, 20);
            this.link_Tang.TabIndex = 13;
            this.link_Tang.TabStop = true;
            this.link_Tang.Text = "Tầng";
            this.link_Tang.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Tang_LinkClicked);
            // 
            // UserControl_TTPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl_TTPhong";
            this.Size = new System.Drawing.Size(502, 502);
            this.Load += new System.EventHandler(this.UserControl_TTPhong_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txt_TenPhong;
        private TextBox txt_DienTich;
        private TextBox txt_Gia;
        private Button btn_Xoa;
        private Button btn_Luu;
        private ComboBox cbx_Tang;
        private LinkLabel link_Tang;
    }
}
