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
    public partial class UserControl_CT_HDDV : UserControl
    {
        public static UserControl_CT_HDDV instance;
        public DataGridView dataGridView;
        public long tongTien;
        private Phong phong;

        public UserControl_CT_HDDV(Phong p)
        {
            InitializeComponent();
            tongTien = 0;
            instance= this;
            dataGridView = dgv_DVChon;
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
                btn_ThanhToan.Visible = false;
                dgv_DichVu.Enabled= false;
                dgv_DVChon.Enabled= false;
            }
            Load_DataGridView();
        }
        public void Load_DataGridView()
        {
            dgv_DichVu.Rows.Clear();
            foreach (HD_DichVu hD_DichVu in phong.HD_DichVu)
            {
                CT_HD cT_HD = phong.CT_HD.LastOrDefault();
                if (hD_DichVu.MaHD == cT_HD.MaHD && cT_HD.NgayTra >= DateTime.Now)
                {
                    foreach (CT_HDDV cT_HDDV in hD_DichVu.CT_HDDV)
                    {
                        DichVu dv = GetData.Instance.GetDichVu(cT_HDDV.MaDV);
                        dgv_DichVu.Rows.Add(dv.MaDV, dv.TenDV, cT_HDDV.SoLuong, dv.GiaDV, cT_HDDV.NgayDat);
                    }
                }
            }
        }
        private void dgv_DichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_LuuDV_Click(object sender, EventArgs e)
        {
            try
            {
                HD_DichVu hD_DichVu = new HD_DichVu();
                hD_DichVu.MaHDDV = Guid.NewGuid();
                hD_DichVu.MaPhong = phong.MaPhong;
                hD_DichVu.TongTien = tongTien;
                hD_DichVu.MaHD = phong.CT_HD.LastOrDefault().MaHD;
                UC_CT_HDDV_Controller.Instance.AddHD_DichVu(hD_DichVu);
                CT_HDDV cT_HDDV = new CT_HDDV();
                foreach (DataGridViewRow row in dgv_DVChon.Rows)
                {
                    cT_HDDV = new CT_HDDV();
                    cT_HDDV.MaHDDV = hD_DichVu.MaHDDV;
                    cT_HDDV.NgayDat = DateTime.Now;
                    cT_HDDV.MaDV = Guid.Parse(row.Cells[0].Value.ToString());
                    cT_HDDV.SoLuong = int.Parse(row.Cells[2].Value.ToString());
                    UC_CT_HDDV_Controller.Instance.AddCT_HDDV(cT_HDDV);
                }
                phong = GetData.Instance.GetPhong(phong.MaPhong);
                Load_DataGridView();
                MessageBox.Show("Lưu Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_ChonDV_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm();
            Controlss.Instance.GetEditForm(new UserControl_CTDV(form), form);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Parse(label_NgayNhan.Text);
            if(time >= DateTime.Now) 
            {
                CT_HD cT_HD = phong.CT_HD.LastOrDefault();
                cT_HD.NgayThue = DateTime.Now;
                cT_HD.TinhTrang = "Đã Nhận Phòng";
            }
        }

        private void btn_NhanPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
