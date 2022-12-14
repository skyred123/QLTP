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
            if (phong.CT_HD.Count() ==0)
            {
                label_TinhTrang.Text = "Phòng Trống";
                label_TenKH.Text = "Phòng Trống";
            }
            else
            {
                foreach (CT_HD cT_HD in phong.CT_HD)
                {
                    if (cT_HD.NgayTra.Value > DateTime.Now)
                    {
                        label_TinhTrang.Text = "Phòng Đang Thuê";
                        label_TenKH.Text = GetData.Instance.GetCT_HD(cT_HD.MaHD).HopDong.KhachHang.TenKH;
                    }
                    else
                    {
                        label_TinhTrang.Text = "Phòng Trống";
                        label_TenKH.Text = "Phòng Trống";
                    }
                }
            }
            
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (phong.MaPhong != GetData.Instance.GetPhongs().LastOrDefault().MaPhong)
            {
                MessageBox.Show("Không thể xóa phòng này");
            }
            else
            {
                DeleteData.Instance.DeletePhong(phong);
                UserControl_DSPhong.instance.Panel = QLKS.Controlss.Instance.SettingControls(UserControl_DSPhong.instance.Panel, new Phong(), UserControl_DSPhong.instance.check);
            }
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
