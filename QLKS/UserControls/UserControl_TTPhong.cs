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
    public partial class UserControl_TTPhong : UserControl
    {
        public UserControl_TTPhong()
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
            Controls_Controller.Instance.AddComboBox(cbx_Tang, new Tang());
            Form_Load();
        }
        private void cbx_Tang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form_Load();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txt_DienTich.Text = string.Empty;
            txt_TenPhong.Text = string.Empty;
            txt_Gia.Text = string.Empty;
            txt_TrangThai.Text = string.Empty;
        }

        private void link_Tang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controls_Controller.Instance.GetEditForm(new UserControl_Tang(), new EditForm());
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.TenPhong = txt_TenPhong.Text;
            if (txt_DienTich.Text == string.Empty || txt_Gia.Text == string.Empty)
            {
                MessageBox.Show("Thiếu dữ liệu");
                return;
            }
            else
            {
                phong.DienTich = int.Parse(txt_DienTich.Text);
                phong.Gia = int.Parse(txt_Gia.Text);
            }
            phong.TrangThai = txt_TrangThai.Text;
            phong.MaTang = ((Tang)cbx_Tang.SelectedItem).MaTang;
            if (ViewData.Instance.GetAdd() == true)
            {
                UC_TTPhong_Controller.Instance.UpdatePhong(phong);
            }
            else if(ViewData.Instance.GetUpdate() == true)
            {
                UC_TTPhong_Controller.Instance.UpdatePhong(phong);
            }
            Form_Load();
        }
    }
}
