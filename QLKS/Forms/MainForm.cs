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
            QLKS.Controlss.Instance.HidePanel(panel_NhanVien);
            QLKS.Controlss.Instance.HidePanel(panel_KhachHang);
            QLKS.Controlss.Instance.HidePanel(panel_Phong);
            QLKS.Controlss.Instance.HidePanel(panel_DichVu);
            QLKS.Controlss.Instance.HidePanel(panel_HopDong);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void MainForm_Load(object sender, EventArgs e)
        {
            string? tenCV;
            if (ViewData.Instance.GetNhanVien() == null) tenCV = "Admin";
            else tenCV = ViewData.Instance.GetNhanVien().ChucVu.TenCV;
            if (tenCV == "Admin")
            {
                QLKS.Controlss.Instance.HideButton(btn_NhanVien1);
                QLKS.Controlss.Instance.HideButton(btn_NhanVien2);
            }
            else
            {
                if (tenCV == "Nhân Viên")
                {
                    QLKS.Controlss.Instance.HideButton(btn_NhanVien3);
                    QLKS.Controlss.Instance.HideButton(btn_NhanVien4);
                }
                else  if(tenCV == "Quản Lý")
                {
                    
                }
                else
                {
                    QLKS.Controlss.Instance.HideButton(btn_NhanVien3);
                    QLKS.Controlss.Instance.HideButton(btn_NhanVien4);
                    QLKS.Controlss.Instance.HideButton(btn_KhachHang1);
                    QLKS.Controlss.Instance.HideButton(btn_Phong1);
                    QLKS.Controlss.Instance.HideButton(btn_DichVu2);
                    QLKS.Controlss.Instance.HideButton(btn_HopDong2);
                }
            }
            QLKS.Controlss.Instance.ButtonText(btn_NhanVien, tenCV);
        }
        #region Nhan Vien

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.ShowPanel(panel_NhanVien);
            
        }
        private void btn_NhanVien1_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.GetUserControl(panel_View, null, new UserControl_TTNV());
        }

        private void btn_NhanVien2_Click(object sender, EventArgs e)
        {

            ViewData.Instance.SetUpdate(ViewData.Instance.GetNhanVien());
            QLKS.Controlss.Instance.GetUserControl(panel_View, null, new UserControl_TKNV());
        }

        private void btn_NhanVien3_Click(object sender, EventArgs e)
        {
            ViewData.Instance.SetAdd();
            QLKS.Controlss.Instance.GetUserControl(panel_View, null, new UserControl_TKNV());
        }
        private void btn_NhanVien4_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.GetUserControl(panel_View, null, new UserControl_DSNV());
        }
        #endregion

        #region Khach Hang
        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.ShowPanel(panel_KhachHang);
            
        }

        private void btn_KhachHang1_Click(object sender, EventArgs e)
        {
            ViewData.Instance.SetAdd();
            QLKS.Controlss.Instance.GetUserControl(panel_View, null, new UserControl_TKKH());
        }

        private void btn_KhachHang2_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.GetUserControl(panel_View, null, new UserControl_DSKH());
        }
        #endregion

        #region Phong
        private void btn_Phong_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.ShowPanel(panel_Phong);

        }

        private void btn_Phong1_Click(object sender, EventArgs e)
        {
            ViewData.Instance.SetAdd();
            QLKS.Controlss.Instance.GetUserControl(panel_View, null, new UserControl_TKPhong());
        }

        private void btn_Phong2_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.GetUserControl(panel_View, null, new UserControl_DSPhong());
        }
        #endregion

        #region Dich Vu
        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.ShowPanel(panel_DichVu);
        }

        private void btn_DichVu1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DichVu2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Hop Dong
        private void btn_HopDong_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.ShowPanel(panel_HopDong);
        }

        private void btn_HopDong1_Click(object sender, EventArgs e)
        {

        }

        private void btn_HopDong2_Click(object sender, EventArgs e)
        {
            Controlss.Instance.GetUserControl(panel_View, null, new UserControl_HopDong());
        }

        private void btn_HopDong3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.GetForm(this, new LoginForm());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
