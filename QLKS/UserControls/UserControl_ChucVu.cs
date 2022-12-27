using Controller;
using Controller.Data;
using Controller.UserControls_Controller;
using Library.Entity;
using QLKS.Forms;
using QLKS.UserControls;
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
    public partial class UserControl_ChucVu : UserControl
    {
        public UserControl_ChucVu()
        {
            InitializeComponent();
        }

        private void UserControl_ChucVu_Load(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.AddDGVs(dgv_ChucVu, new ChucVu());
        }

        private void dgv_ChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ChucVu.Columns[e.ColumnIndex].ToolTipText == "Delete")
            {
                if(MessageBox.Show("Thông Báo", "Bạn Muốn Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ChucVu? chucVu = GetData.Instance.GetChucVu((Guid)dgv_ChucVu.Rows[e.RowIndex].Cells[0].Value);
                    if (chucVu != null || chucVu.NhanViens.Count() == 0)
                    {
                        DeleteData.Instance.DeleteChucVu(chucVu);
                        QLKS.Controlss.Instance.AddDGVs(dgv_ChucVu, new ChucVu());
                    }
                    else
                    {
                        MessageBox.Show("Đang có nhân viên nhận chức vụ này");
                    }
                }
            }
            else
            {
                Guid id = (Guid)dgv_ChucVu.Rows[e.RowIndex].Cells[0].Value;
                txt_ChucVu.Text = dgv_ChucVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                cb_Quyen.Checked = bool.Parse(dgv_ChucVu.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_ChucVu.Text != string.Empty)
            {
                dgv_ChucVu = QLKS.Controlss.Instance.Search(dgv_ChucVu, txt_ChucVu.Text.ToLower(), new KhachHang());
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ChucVu chucVu = new ChucVu();
            chucVu.MaCV = (Guid)dgv_ChucVu.SelectedCells[0].OwningRow.Cells[0].Value;
            chucVu.TenCV = txt_ChucVu.Text;
            chucVu.Quyen = cb_Quyen.Checked;
            UC_ChucVu_Controller.Instance.UpdateChucVu(chucVu);
            QLKS.Controlss.Instance.AddDGVs(dgv_ChucVu, new ChucVu());
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            ChucVu chucVu = new ChucVu();
            chucVu.TenCV = txt_ChucVu.Text; 
            chucVu.Quyen = cb_Quyen.Checked;
            if(UC_ChucVu_Controller.Instance.AddChucVu(chucVu))
                QLKS.Controlss.Instance.AddDGV(dgv_ChucVu, chucVu);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_Quyen.Checked )
            {
                cb_Quyen.Text = "True";
            }
            else
            {
                cb_Quyen.Text = "False";
            }
        }
    }
}
