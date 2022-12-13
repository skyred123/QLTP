using Controller;
using Controller.UserControls_Controller;
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
            QLKS.Controlss.Instance.AddDGVs(dgv_Tang, new Tang());
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            Tang t = UC_Tang_Controller.Instance.AddTang();
            QLKS.Controlss.Instance.AddDGV(dgv_Tang, t);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thông Báo", "Bạn Muốn Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(UC_Tang_Controller.Instance.DeleteTang() != null) {
                    QLKS.Controlss.Instance.AddDGVs(dgv_Tang, new Tang());
                }
            }
        }
    }
}
