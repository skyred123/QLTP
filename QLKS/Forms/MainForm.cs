using Controller;
using Controller.Data;
using Controller.Form_Controller;
using Library.Entity;
using Library.Servser;
using Microsoft.EntityFrameworkCore;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void HideMenu()
        {
            Controls_Controller.Instance.HidePanel(panel_NhanVien);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void MainForm_Load(object sender, EventArgs e)
        {
            string? tenCV = MainForm_Controller.Instance.GetData();
            if (tenCV == "Admin")
            {
                Controls_Controller.Instance.HideButton(btn_TTNhanVien);
                Controls_Controller.Instance.HideButton(btn_ChinhSuaTK);
            }
            else if (tenCV == "Nhân Viên")
            {
                Controls_Controller.Instance.HideButton(btn_QLNV);
            }
            else if(tenCV == "Quản Lý")
            {
            }
        }
        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            Controls_Controller.Instance.ShowPanel(panel_NhanVien);
        }

        private void btn_ChinhSuaTK_Click(object sender, EventArgs e)
        {
            ViewData.Instance.SetUpdate(ViewData.Instance.GetNhanVien());
            Controls_Controller.Instance.GetUserControl(panel_View,null, new UserControl_ChinhSuaTT());
        }

        private void btn_TTNhanVien_Click(object sender, EventArgs e)
        {
            Controls_Controller.Instance.GetUserControl(panel_View,null, new UserControl_TTNhanVien());
        }
        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            Controls_Controller.Instance.GetUserControl(panel_View,null, new UserControl_QLNV());
        }
    }
}
