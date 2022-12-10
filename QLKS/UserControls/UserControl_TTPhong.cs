using Controller;
using Library.Entity;
using QLKS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UserControls
{
    public partial class UserControl_TTPhong : UserControl
    {
        public UserControl_TTPhong()
        {
            InitializeComponent();
        }

        private void UserControl_TTPhong_Load(object sender, EventArgs e)
        {
            Controls_Controller.Instance.AddComboBox(cbx_Tang, new Tang());
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txt_DienTich.Text = string.Empty;
            txt_TenPhong.Text = string.Empty;
            txt_Gia.Text = string.Empty;
            cbx_Tang.Text = string.Empty;
        }

        private void link_Tang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controls_Controller.Instance.GetEditForm(new UserControl_Tang(), new EditForm());
        }
    }
}
