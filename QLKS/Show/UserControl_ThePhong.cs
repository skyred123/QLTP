using Controller.Data;
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
    public partial class UserControl_ThePhong : UserControl
    {
        public UserControl_ThePhong(Phong p)
        {
            InitializeComponent();
            this.phong = p;
        }

        private void UserControl_ThePhong_Load(object sender, EventArgs e)
        {
            pbx_Image.Image = Image.FromFile("D:\\Eleaning\\Code\\QLKS\\QLKS\\Image\\house.jfif");
            label_TenPhong.Text = phong.TenPhong;
            if (phong.CT_HD.Count() != 0)
            {
                label_TinhTrang.Text = "Phòng Đang Thuê";
            }
            else
            {
                label_TinhTrang.Text = "Phòng Trống";
            }
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteData.Instance.DeletePhong(phong);
            UserControl_DSPhong.instance.Panel = QLKS.Controlss.Instance.SettingControls(UserControl_DSPhong.instance.Panel, new Phong());
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.phong.LoaiPhong.TenLoaiPhong);
        }

        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewData.Instance.SetUpdate(phong);
            QLKS.Controlss.Instance.GetEditForm(new UserControl_TKPhong(), new EditForm());
        }
    }
}
