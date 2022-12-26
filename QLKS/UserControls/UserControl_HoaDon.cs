using Controller.Data;
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
    public partial class UserControl_HoaDon : UserControl
    {
        private Phong phong;
        public UserControl_HoaDon(Phong p)
        {
            InitializeComponent();
            this.phong = p;
        }

        private void UserControl_HoaDon_Load(object sender, EventArgs e)
        {
            CT_HD cT_HD = phong.CT_HD.LastOrDefault();
            label_TenNV.Text = "NV: "+ cT_HD.HopDong.NhanVien.TenNV;
            label_TenKH.Text = "KH: " + cT_HD.HopDong.KhachHang.TenKH;
            label_TenPhong.Text = phong.TenPhong;
            label_NgayDat.Text = cT_HD.NgayThue.ToString();
            label_NgayTra.Text = cT_HD.NgayTra.ToString();
            TimeSpan time = (cT_HD.NgayTra - cT_HD.NgayThue);
            Time.Text = "Thời Gian Thuê: "+ ((int)time.TotalHours).ToString();
            Load_DGV();
        }
        private void Load_DGV()
        {
            CT_HD item = phong.CT_HD.LastOrDefault();
            dgv_DV.Rows.Clear();
            long? s = 0;
            if ((item.NgayTra.Hour - item.NgayThue.Hour) < 1 && (item.NgayTra.Day - item.NgayThue.Day) == 0)
            {
                dgv_DV.Rows.Add(phong.TenPhong, phong.LoaiPhong.Gia, 1, phong.LoaiPhong.Gia);
                s += phong.LoaiPhong.Gia;
            }
            else
            {
                var time = item.NgayTra - item.NgayThue;
                long? tong =phong.LoaiPhong.Gia * (int)time.TotalHours;
                dgv_DV.Rows.Add(phong.TenPhong, phong.LoaiPhong.Gia, ((int)time.TotalHours).ToString(), tong.ToString());
                s += tong;
            }
            foreach (HD_DichVu hD_DichVu in phong.HD_DichVu)
            {
                CT_HD cT_HD = phong.CT_HD.LastOrDefault();
                if (hD_DichVu.MaHD == cT_HD.MaHD && hD_DichVu.MaPhong == cT_HD.MaPhong)
                {
                    foreach (CT_HDDV cT_HDDV in hD_DichVu.CT_HDDV)
                    {
                        DichVu dv = GetData.Instance.GetDichVu(cT_HDDV.MaDV);
                        dgv_DV.Rows.Add(dv.TenDV,dv.GiaDV, cT_HDDV.SoLuong, (dv.GiaDV*cT_HDDV.SoLuong));
                        s += (dv.GiaDV * cT_HDDV.SoLuong);
                    }
                }
            }
            label_TongTien.Text = s.ToString();
        }
        Bitmap bitmap;
        public void print()
        {
            bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
