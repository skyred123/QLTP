using Controller.Data;
using Library.Entity;
using QLKS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UserControls
{
    public partial class UserControl_DSCT_HD : UserControl
    {
        private HopDong hopDong;
        public UserControl_DSCT_HD(HopDong hd)
        {
            InitializeComponent();
            hopDong = hd;
        }
        public void LoadDGV()
        {
            if (hopDong != null)
            {
                foreach(CT_HD item in hopDong.CT_HD)
                {
                    Controlss.Instance.AddDGV(dgv_CTHD,item);
                }
            }
        }

        private void UserControl_DSCT_HD_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgv_CTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_CTHD.Columns[e.ColumnIndex].ToolTipText == "Dịch Vụ")
            {
                Guid idPhong = (Guid)dgv_CTHD.Rows[e.RowIndex].Cells[0].Value;
                foreach(HD_DichVu hD_DichVu in hopDong.HD_DichVu)
                {
                    if (hD_DichVu.MaPhong == idPhong)
                    {
                        foreach(CT_HDDV cT_HDDV in hD_DichVu.CT_HDDV)
                        {
                            dgv_CTHDDV.Rows.Add(cT_HDDV.DichVu.TenDV,cT_HDDV.SoLuong);
                        }
                        return;
                    }
                }
            }
        }
    }
}
