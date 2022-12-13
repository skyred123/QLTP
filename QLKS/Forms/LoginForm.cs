using Controller;
using Controller.Form_Controller;
using Library.Entity;
using Library.Servser;
using QLKS.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(LoginForm_Controller.Instance.DangNhap(txt_Ten.Text, txt_MatKhau.Text)) 
            {
                QLKS.Controlss.Instance.GetForm(this, new MainForm());
            }
            else
            {
                MessageBox.Show("Sai Tên Hoặc Mật Khẩu");
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_Ten.Text = "Admin";
            txt_MatKhau.Text = "Admin";
        }
    }
}
