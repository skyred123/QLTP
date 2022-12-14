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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UserControls
{
    public partial class UserControl_TKPhong : UserControl
    {
        public UserControl_TKPhong()
        {
            InitializeComponent();
        }
        public void Form_Load()
        {
            int index = GetData.Instance.GetTangs().FirstOrDefault(e=> e.MaTang == ((Tang)cbx_Tang.SelectedItem).MaTang).Phongs.Count();
            txt_TenPhong.Text = "Phòng "+((Tang)cbx_Tang.SelectedItem).SoTang + "0" + (index +1);
        }
        private void UserControl_TTPhong_Load(object sender, EventArgs e)
        {
            txt_TenPhong.Enabled= false;
            QLKS.Controlss.Instance.AddComboBox(cbx_Tang, new Tang());
            Controlss.Instance.AddComboBox(cbx_LoaiPhong, new LoaiPhong());
            Form_Load();
            if(ViewData.Instance.GetAdd() == true)
            {

            }
            else if (ViewData.Instance.GetUpdate() == true)
            {
                var x = ViewData.Instance.GetPhongEdit();
                cbx_Tang.Enabled = false;
                cbx_Tang.Text = ViewData.Instance.GetPhongEdit().Tang.SoTang.ToString();
                cbx_LoaiPhong.Text = ViewData.Instance.GetPhongEdit().LoaiPhong.TenLoaiPhong.ToString();
                txt_TenPhong.Text = ViewData.Instance.GetPhongEdit().TenPhong;
                txt_TrangThai.Text = ViewData.Instance.GetPhongEdit().TrangThai;
            }
        }
        private void cbx_Tang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form_Load();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txt_TrangThai.Text = string.Empty;
        }

        private void link_Tang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QLKS.Controlss.Instance.GetEditForm(new UserControl_Tang(), new EditForm());
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.TenPhong = txt_TenPhong.Text;
            phong.MaLoai = ((LoaiPhong)cbx_LoaiPhong.SelectedItem).MaLoai;
            phong.TrangThai = txt_TrangThai.Text;
            phong.MaTang = ((Tang)cbx_Tang.SelectedItem).MaTang;
            if (ViewData.Instance.GetAdd() == true)
            {
                UC_TTPhong_Controller.Instance.UpdatePhong(phong);
                Form_Load();
            }
            else if(ViewData.Instance.GetUpdate() == true)
            {
                phong.MaPhong = ViewData.Instance.GetPhongEdit().MaPhong;
                UC_TTPhong_Controller.Instance.UpdatePhong(phong);
                UserControl_DSPhong.instance.Panel = QLKS.Controlss.Instance.SettingControls(UserControl_DSPhong.instance.Panel, new Phong(), UserControl_DSPhong.instance.check);
            }
        }

        private void Link_LoaiPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controlss.Instance.GetEditForm(new UserControl_LoaiPhong(), new EditForm());
        }
    }
}
