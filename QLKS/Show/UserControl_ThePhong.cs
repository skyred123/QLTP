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
        private CT_HD cT_HDs;
        public UserControl_ThePhong(Phong p)
        {
            InitializeComponent();
            this.phong = p;
        }

        public Phong GetPhong()
        {
            return this.phong;
        }
        private void UserControl_ThePhong_Load(object sender, EventArgs e)
        {
            pbx_Image.Image = Image.FromFile("D:\\Eleaning\\Code\\QLKS\\QLKS\\Image\\house.jfif");
            label_TenPhong.Text = phong.TenPhong;
            if (phong.CT_HD.Count() ==0)
            {
                label_TinhTrang.Text = "Phòng Trống";
                label_TenKH.Text = "Phòng Trống";
                datDichVuToolStripMenuItem.Visible = false;
                cT_HDs = null;
            }
            else
            {
                foreach (CT_HD cT_HD in phong.CT_HD)
                {
                    if (cT_HD.NgayTra.Value > DateTime.Now)
                    {
                        label_TinhTrang.Text = cT_HD.TinhTrang;
                        label_TenKH.Text = GetData.Instance.GetCT_HD(cT_HD.MaHD).HopDong.KhachHang.TenKH;
                        cT_HDs = cT_HD;
                    }
                    else
                    {
                        label_TinhTrang.Text = "Phòng Trống";
                        label_TenKH.Text = "Phòng Trống";
                        datDichVuToolStripMenuItem.Visible = false;
                        cT_HDs = null;
                    }
                }
            }
            
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (phong.MaPhong != GetData.Instance.GetTangs().LastOrDefault(e => e.MaTang == phong.Tang.MaTang).Phongs.LastOrDefault().MaPhong || phong.CT_HD.LastOrDefault().NgayTra > DateTime.Now)
            {
                MessageBox.Show("Không thể xóa phòng này");
            }
            else
            {
                if (MessageBox.Show("Thông Báo", "Bạn Muốn Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteData.Instance.DeletePhong(phong);
                    UserControl_DSPhong.instance.List_ThePhong();
                }
            }
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.phong.TenPhong);
        }

        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cT_HDs == null)
            {
                ViewData.Instance.SetUpdate(phong);
                QLKS.Controlss.Instance.GetEditForm(new UserControl_TKPhong(), new EditForm());
            }
            else
            {
                MessageBox.Show("Không thể sửa phòng này");
            }
        }

        private void đặtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
