using Controller;
using Controller.Data;
using Controller.UserControls_Controller;
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
    public partial class UserControl_TKKH : UserControl
    {
        public UserControl_TKKH()
        {
            InitializeComponent();
        }
        public UserControl_TKKH(bool checks)
        {
            InitializeComponent();
        }
        private void UserControl_TKKH_Load(object sender, EventArgs e)
        {
            if(ViewData.Instance.GetKhachHangEdit() != null)
            {
                txt_MaKH.Text = ViewData.Instance.GetKhachHangEdit().MaKH;
                txt_TenKH.Text = ViewData.Instance.GetKhachHangEdit().TenKH;
                txt_SDT.Text = ViewData.Instance.GetKhachHangEdit().SDT;
                txt_Email.Text = ViewData.Instance.GetKhachHangEdit().Email;
            }
        }
        public void btn_Luu_Click(object sender, EventArgs e)
        {
            
            KhachHang kh = new KhachHang();
            kh.MaKH = txt_MaKH.Text;
            kh.TenKH= txt_TenKH.Text;
            kh.SDT = txt_SDT.Text;
            kh.Email = txt_Email.Text;
            if (ViewData.Instance.GetUpdate())
            {
                if(UC_TKKH_Controller.Instance.UpdateKhachHang(kh, ViewData.Instance.GetKhachHangEdit()))
                {
                    QLKS.Controlss.Instance.AddDGV(UserControl_DSKH.instance.dataGridView, new KhachHang());
                }
            }
            else if(ViewData.Instance.GetAdd() == true)
            {
                if(UC_TKKH_Controller.Instance.UpdateKhachHang(kh, null))
                {
                    MessageBox.Show("Lưu Thành Công");
                    //QLKS.Controlss.Instance.AddDGV(UserControl_DSKH.instance.dataGridView, new KhachHang());
                }
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_SDT.Text = "";
            txt_Email.Text = "";
        }
    }
}
