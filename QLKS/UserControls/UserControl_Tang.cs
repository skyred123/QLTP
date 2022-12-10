using Controller;
using Library.Entity;
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
    public partial class UserControl_Tang : UserControl
    {
        public UserControl_Tang()
        {
            InitializeComponent();
        }

        private void UserControl_Tang_Load(object sender, EventArgs e)
        {
            Controls_Controller.Instance.AddDGV(dgv_Tang, new Tang());
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {

        }
    }
}
