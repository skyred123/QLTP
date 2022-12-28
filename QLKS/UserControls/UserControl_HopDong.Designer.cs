using Library.Entity;

namespace QLKS.UserControls
{
    partial class UserControl_HopDong
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Phong = new System.Windows.Forms.DataGridView();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ChonPhong = new System.Windows.Forms.Button();
            this.dtp_NgayNhan = new System.Windows.Forms.DateTimePicker();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 547);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_MaKH, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_TenKH, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_SDT, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_Email, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btn_Delete, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(486, 541);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Khách Hàng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 180);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 270);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Điện Thoại ";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_MaKH.Location = new System.Drawing.Point(246, 93);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(237, 27);
            this.txt_MaKH.TabIndex = 4;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TenKH.Location = new System.Drawing.Point(246, 183);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(237, 27);
            this.txt_TenKH.TabIndex = 5;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SDT.Location = new System.Drawing.Point(246, 273);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(237, 27);
            this.txt_SDT.TabIndex = 6;
            // 
            // txt_Email
            // 
            this.txt_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Email.Location = new System.Drawing.Point(246, 363);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(237, 27);
            this.txt_Email.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 360);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Delete.Location = new System.Drawing.Point(246, 453);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(237, 42);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_Phong, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtp_NgayTra, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_ChonPhong, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtp_NgayNhan, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_Luu, 2, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(495, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.45102F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01479F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24809F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24809F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24809F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.79879F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.96076F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(487, 541);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dgv_Phong
            // 
            this.dgv_Phong.AllowUserToAddRows = false;
            this.dgv_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.tableLayoutPanel2.SetColumnSpan(this.dgv_Phong, 3);
            this.dgv_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Phong.Location = new System.Drawing.Point(3, 234);
            this.dgv_Phong.Name = "dgv_Phong";
            this.dgv_Phong.RowHeadersWidth = 51;
            this.tableLayoutPanel2.SetRowSpan(this.dgv_Phong, 3);
            this.dgv_Phong.RowTemplate.Height = 29;
            this.dgv_Phong.Size = new System.Drawing.Size(357, 211);
            this.dgv_Phong.TabIndex = 4;
            // 
            // dtp_NgayTra
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.dtp_NgayTra, 2);
            this.dtp_NgayTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_NgayTra.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayTra.Location = new System.Drawing.Point(124, 157);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(236, 31);
            this.dtp_NgayTra.TabIndex = 1;
            this.dtp_NgayTra.ValueChanged += new System.EventHandler(this.dtp_NgayTra_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày Trả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btn_ChonPhong
            // 
            this.btn_ChonPhong.Location = new System.Drawing.Point(366, 234);
            this.btn_ChonPhong.Name = "btn_ChonPhong";
            this.btn_ChonPhong.Size = new System.Drawing.Size(118, 41);
            this.btn_ChonPhong.TabIndex = 7;
            this.btn_ChonPhong.Text = "Chọn Phòng";
            this.btn_ChonPhong.UseVisualStyleBackColor = true;
            this.btn_ChonPhong.Click += new System.EventHandler(this.btn_ChonPhong_Click);
            // 
            // dtp_NgayNhan
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.dtp_NgayNhan, 2);
            this.dtp_NgayNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_NgayNhan.Enabled = false;
            this.dtp_NgayNhan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_NgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayNhan.Location = new System.Drawing.Point(124, 92);
            this.dtp_NgayNhan.Name = "dtp_NgayNhan";
            this.dtp_NgayNhan.Size = new System.Drawing.Size(236, 31);
            this.dtp_NgayNhan.TabIndex = 0;
            // 
            // btn_Luu
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btn_Luu, 2);
            this.btn_Luu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Luu.Location = new System.Drawing.Point(245, 451);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(239, 44);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // UserControl_HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl_HopDong";
            this.Size = new System.Drawing.Size(985, 547);
            this.Load += new System.EventHandler(this.UserControl_HopDong_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DateTimePicker dtp_NgayTra;
        private DateTimePicker dtp_NgayNhan;
        private Label label2;
        private DataGridView dgv_Phong;
        private Button btn_ChonPhong;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_MaKH;
        private TextBox txt_TenKH;
        private TextBox txt_SDT;
        private TextBox txt_Email;
        private Label label6;
        private Button btn_Delete;
        private System.Windows.Forms.Timer timer;
        private Button btn_Luu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
