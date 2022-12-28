namespace QLKS.UserControls
{
    partial class UserControl_TKPhong
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
            this.Link_LoaiPhong = new System.Windows.Forms.LinkLabel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbx_Tang = new System.Windows.Forms.ComboBox();
            this.link_Tang = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.cbx_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Link_LoaiPhong, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Xoa, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_TenPhong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Luu, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbx_Tang, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.link_Tang, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_TrangThai, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbx_LoaiPhong, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 507);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Link_LoaiPhong
            // 
            this.Link_LoaiPhong.AutoSize = true;
            this.Link_LoaiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.Link_LoaiPhong.Location = new System.Drawing.Point(3, 283);
            this.Link_LoaiPhong.Name = "Link_LoaiPhong";
            this.Link_LoaiPhong.Size = new System.Drawing.Size(245, 20);
            this.Link_LoaiPhong.TabIndex = 17;
            this.Link_LoaiPhong.TabStop = true;
            this.Link_LoaiPhong.Text = "Loại Phòng";
            this.Link_LoaiPhong.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LoaiPhong_LinkClicked);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Xoa.Location = new System.Drawing.Point(111, 408);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(137, 55);
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
            // txt_TenPhong
            // 
            this.txt_TenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TenPhong.Location = new System.Drawing.Point(254, 103);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(245, 27);
            this.txt_TenPhong.TabIndex = 6;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Luu.Location = new System.Drawing.Point(362, 408);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(137, 55);
            this.btn_Luu.TabIndex = 10;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cbx_Tang
            // 
            this.cbx_Tang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_Tang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Tang.FormattingEnabled = true;
            this.cbx_Tang.Location = new System.Drawing.Point(254, 164);
            this.cbx_Tang.Name = "cbx_Tang";
            this.cbx_Tang.Size = new System.Drawing.Size(245, 28);
            this.cbx_Tang.TabIndex = 12;
            this.cbx_Tang.SelectedIndexChanged += new System.EventHandler(this.cbx_Tang_SelectedIndexChanged);
            // 
            // link_Tang
            // 
            this.link_Tang.AutoSize = true;
            this.link_Tang.Dock = System.Windows.Forms.DockStyle.Top;
            this.link_Tang.Location = new System.Drawing.Point(3, 161);
            this.link_Tang.Name = "link_Tang";
            this.link_Tang.Size = new System.Drawing.Size(245, 20);
            this.link_Tang.TabIndex = 13;
            this.link_Tang.TabStop = true;
            this.link_Tang.Text = "Tầng";
            this.link_Tang.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Tang_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Trạng Thái";
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TrangThai.Location = new System.Drawing.Point(254, 225);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(245, 27);
            this.txt_TrangThai.TabIndex = 15;
            // 
            // cbx_LoaiPhong
            // 
            this.cbx_LoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_LoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LoaiPhong.FormattingEnabled = true;
            this.cbx_LoaiPhong.Location = new System.Drawing.Point(254, 286);
            this.cbx_LoaiPhong.Name = "cbx_LoaiPhong";
            this.cbx_LoaiPhong.Size = new System.Drawing.Size(245, 28);
            this.cbx_LoaiPhong.TabIndex = 16;
            // 
            // UserControl_TKPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl_TKPhong";
            this.Size = new System.Drawing.Size(502, 507);
            this.Load += new System.EventHandler(this.UserControl_TTPhong_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txt_TenPhong;
        private Button btn_Xoa;
        private Button btn_Luu;
        private ComboBox cbx_Tang;
        private LinkLabel link_Tang;
        private LinkLabel Link_LoaiPhong;
        private Label label2;
        private TextBox txt_TrangThai;
        private ComboBox cbx_LoaiPhong;
    }
}
