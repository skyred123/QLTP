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
    public partial class UserControl_CT_HopDong : UserControl
    {
        public static UserControl_CT_HopDong instance;
        private Form form;
        private DateTime time;
        public UserControl_CT_HopDong(DateTime dateTime, Form form)
        {
            InitializeComponent();
            this.time = dateTime;
            this.form = form;
            Load_DGV();
        }
        public void Load_DGV()
        {
            List<Phong> phongList = new List<Phong>();
            foreach(Phong phong in GetData.Instance.GetPhongs())
            {
                if (phong.CT_HD.Count() == 0)
                {
                    phongList.Add(phong);
                }
                else
                {
                    if(phong.CT_HD.LastOrDefault().NgayTra < DateTime.Now)
                    {
                        phongList.Add(phong);
                    }
                }
            }
            foreach (Phong phong in phongList)
            {
                Controlss.Instance.AddDGV(dgv_PhongTrong, phong);
            }
        }
        private void dgv_PhongTrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_PhongTrong.Columns[e.ColumnIndex].ToolTipText == "Thêm")
            {
                Phong phong = GetData.Instance.GetPhong((Guid)dgv_PhongTrong.Rows[e.RowIndex].Cells[0].Value);
                dgv_PhongTrong.Rows.Remove(dgv_PhongTrong.Rows[e.RowIndex]);
                Controlss.Instance.AddDGV(dgv_PhongChon,phong);
                
            }
        }

        private void dgv_PhongChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_PhongChon.Columns[e.ColumnIndex].ToolTipText == "Xóa")
            {
                Phong phong = GetData.Instance.GetPhong((Guid)dgv_PhongChon.Rows[e.RowIndex].Cells[0].Value);
                dgv_PhongChon.Rows.Remove(dgv_PhongChon.Rows[e.RowIndex]);
                Controlss.Instance.AddDGV(dgv_PhongTrong, phong);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            UserControl_HopDong.instance.dataGridView.Rows.Clear();
            foreach (DataGridViewRow row in dgv_PhongChon.Rows)
            {
                Phong phong = GetData.Instance.GetPhong((Guid)row.Cells[0].Value);
                Controlss.Instance.AddDGV(UserControl_HopDong.instance.dataGridView, phong);
            }
            form.Hide();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            dgv_PhongChon.Rows.Clear();
        }
    }
}
