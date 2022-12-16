namespace QLKS.UserControls
{
    partial class UserControl_TheDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_TheDichVu));
            this.label3 = new System.Windows.Forms.Label();
            this.image_Avatar = new System.Windows.Forms.PictureBox();
            this.label_Ten = new System.Windows.Forms.Label();
            this.label_Gia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // image_Avatar
            // 
            this.image_Avatar.BackColor = System.Drawing.Color.White;
            this.image_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image_Avatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("image_Avatar.ErrorImage")));
            this.image_Avatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("image_Avatar.InitialImage")));
            this.image_Avatar.Location = new System.Drawing.Point(3, 3);
            this.image_Avatar.Name = "image_Avatar";
            this.image_Avatar.Size = new System.Drawing.Size(155, 141);
            this.image_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_Avatar.TabIndex = 15;
            this.image_Avatar.TabStop = false;
            this.image_Avatar.WaitOnLoad = true;
            // 
            // label_Ten
            // 
            this.label_Ten.AutoSize = true;
            this.label_Ten.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_Ten.Location = new System.Drawing.Point(3, 147);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(50, 20);
            this.label_Ten.TabIndex = 16;
            this.label_Ten.Text = "label1";
            // 
            // label_Gia
            // 
            this.label_Gia.AutoSize = true;
            this.label_Gia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_Gia.Location = new System.Drawing.Point(3, 193);
            this.label_Gia.Name = "label_Gia";
            this.label_Gia.Size = new System.Drawing.Size(50, 20);
            this.label_Gia.TabIndex = 17;
            this.label_Gia.Text = "label2";
            // 
            // UserControl_TheDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.label_Gia);
            this.Controls.Add(this.label_Ten);
            this.Controls.Add(this.image_Avatar);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "UserControl_TheDichVu";
            this.Size = new System.Drawing.Size(164, 233);
            this.Load += new System.EventHandler(this.UserControl_TheDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private PictureBox image_Avatar;
        private Label label_Ten;
        private Label label_Gia;
    }
}
