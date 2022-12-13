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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLKS.UserControls
{
    public partial class UserControl_HopDong : UserControl
    {
        public static UserControl_HopDong instance;
        public DataGridView dataGridView;
        private KhachHang khachhang;
        public UserControl_HopDong()
        {
            InitializeComponent();
            instance = this;
            dataGridView = dgv_Phong;
            dtp_NgayTra.Value = new DateTime(dtp_NgayTra.Value.Year, dtp_NgayTra.Value.Month, dtp_NgayTra.Value.Day +1);
        }
        private void UserControl_HopDong_Load(object sender, EventArgs e)
        {
            ViewData.Instance.SetAdd();
        }
        private void btn_ChonPhong_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm();
            UserControl_CT_HopDong _CT_HopDong = new UserControl_CT_HopDong(form);
            _CT_HopDong.Dock= DockStyle.Fill;
            form.Controls.Add(_CT_HopDong);
            form.ShowDialog();

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txt_MaKH.Text;
            kh.TenKH = txt_TenKH.Text;
            kh.SDT = txt_SDT.Text;
            kh.Email = txt_Email.Text;
            if (GetData.Instance.GetKhachHang(txt_MaKH.Text) == null)
            {
                if (UC_TKKH_Controller.Instance.UpdateKhachHang(kh, null))
                {
                    MessageBox.Show("Lưu Khách Hàng Thành Công");
                }
                else
                {
                    return;
                }
            }
            khachhang = GetData.Instance.GetKhachHang(txt_MaKH.Text);
            HopDong hd = new HopDong();
            hd.MaNV = ViewData.Instance.GetNhanVien().MaNV;
            hd.MaKH = khachhang.MaKH;
            hd.TongGia = 999999;
            UC_HopDong_Controller.Instance.AddHopdong(hd);
            foreach (DataGridViewRow row in dgv_Phong.Rows)
            {
                CT_HD cT_HD = new CT_HD();
                cT_HD.MaHD = hd.MaHD;
                cT_HD.NgayThue = dtp_NgayNhan.Value;
                cT_HD.NgayTra = dtp_NgayTra.Value;
                if (dtp_NgayNhan.Value.Day == DateTime.Now.Day && dtp_NgayNhan.Value.Month == DateTime.Now.Month && dtp_NgayNhan.Value.Month == DateTime.Now.Month)
                {
                    cT_HD.TinhTrang = "Đã nhận phòng";
                }
                else
                {
                    cT_HD.TinhTrang = "Đã đặt phòng";
                }
                cT_HD.MaPhong = (Guid)row.Cells[0].Value;
                UC_HopDong_Controller.Instance.AddCTHD(cT_HD);
            }
            MessageBox.Show("Lưu Thành Công");
        }
    }
}
