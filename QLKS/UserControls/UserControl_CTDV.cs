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
    public partial class UserControl_CTDV : UserControl
    {
        private Form form;

        public UserControl_CTDV(Form f)
        {
            InitializeComponent();
            this.form = f;
        }

        private void dgv_DVChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DVChon.Columns[e.ColumnIndex].ToolTipText == "Xóa")
            {
                DichVu dichVu = GetData.Instance.GetDichVu((Guid)dgv_DVChon.Rows[e.RowIndex].Cells[0].Value);
                if( int.Parse(dgv_DVChon.Rows[e.RowIndex].Cells[2].Value.ToString()) > 1)
                {
                    dgv_DVChon.Rows[e.RowIndex].Cells[2].Value = int.Parse(dgv_DVChon.Rows[e.RowIndex].Cells[2].Value.ToString()) - 1;
                }
                else
                {
                    dgv_DVChon.Rows.Remove(dgv_DVChon.Rows[e.RowIndex]);
                }
            }
        }

        private void dgv_DichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool dk = false;
            long? tong = 0;
            if (dgv_DV.Columns[e.ColumnIndex].ToolTipText == "Thêm")
            {
                DichVu dichVu = GetData.Instance.GetDichVu((Guid)dgv_DV.Rows[e.RowIndex].Cells[0].Value);
                if (dgv_DVChon.Rows.Count == 0)
                {
                    dgv_DVChon.Rows.Add(dichVu.MaDV, dichVu.TenDV, 1, dichVu.GiaDV);
                    tong += dichVu.GiaDV;
                }
                else
                {

                    foreach (DataGridViewRow row in dgv_DVChon.Rows)
                    {
                        int s = 0;
                        if ((Guid)row.Cells[0].Value == (Guid)dgv_DV.Rows[e.RowIndex].Cells[0].Value)
                        {
                            dk = true;
                            s = int.Parse(row.Cells[2].Value.ToString()) + 1;
                            dgv_DVChon.Rows.Remove(row);
                            dgv_DVChon.Rows.Add(dichVu.MaDV, dichVu.TenDV, s, dichVu.GiaDV * s);
                            tong += dichVu.GiaDV * s;
                        }
                        else
                            tong += long.Parse(row.Cells[3].Value.ToString());
                    }
                    if (dk == false)
                    {
                        dgv_DVChon.Rows.Add(dichVu.MaDV, dichVu.TenDV, 1, dichVu.GiaDV);
                        tong += dichVu.GiaDV;
                    }
                }
            }
            label_TongTien.Text = tong.ToString();
        }

        private void UserControl_CTDV_Load(object sender, EventArgs e)
        {
            Controlss.Instance.AddDGVs(dgv_DV, new DichVu());
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            UserControl_CT_HDDV.instance.tongTien = long.Parse(label_TongTien.Text);
            UserControl_CT_HDDV.instance.dataGridView.Rows.Clear();
            foreach(DataGridViewRow row in dgv_DVChon.Rows)
            {
                UserControl_CT_HDDV.instance.dataGridView.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
            }
            form.Hide();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            dgv_DVChon.Rows.Clear();
        }
    }
}
