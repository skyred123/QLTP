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
    public partial class UserControl_DSHopDong : UserControl
    {
        public UserControl_DSHopDong()
        {
            InitializeComponent();
            Controlss.Instance.AddDGVs(dgv_HopDong, new HopDong());
        }

        private void dgv_HopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_HopDong.Columns[e.ColumnIndex].ToolTipText == "Chi Tiết")
            {
                HopDong hd = GetData.Instance.GetHopDong((Guid)dgv_HopDong.Rows[e.RowIndex].Cells[0].Value);
                Controlss.Instance.GetEditForm(new UserControl_DSCT_HD(hd), new EditForm());
            }
        }
    }
}
