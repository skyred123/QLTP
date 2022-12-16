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
    public partial class UserControl_CT_HDDV : UserControl
    {
        private Phong phong;
        public UserControl_CT_HDDV(Phong p)
        {
            InitializeComponent();
            this.phong = p;
        }

        private void UserControl_CT_HDDV_Load(object sender, EventArgs e)
        {
            label_TenPhong.Text = phong.TenPhong;
            if (phong.CT_HD.Count != 0)
            {
                if (phong.CT_HD.LastOrDefault().NgayTra >= DateTime.Now)
                {
                    label_TenKH.Text = phong.CT_HD.LastOrDefault().HopDong.KhachHang.TenKH;
                    label_NgayNhan.Text = phong.CT_HD.LastOrDefault().NgayThue.ToString();
                    label_NgayTra.Text = phong.CT_HD.LastOrDefault().NgayTra.ToString();
                }
            }
            else
            {
                label_TenKH.Text = "Phòng Trống";
                label_NgayNhan.Text = "Phòng Trống";
                label_NgayTra.Text = "Phòng Trống";
                btn_LuuDV.Visible = false;
            }
            Controlss.Instance.AddDGVs(dgv_DichVu, new DichVu());
        }
    }
}
