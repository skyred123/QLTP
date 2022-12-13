using Controller.Data;
using Controller.UserControls_Controller;
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
using GetData = Controller.Data.GetData;

namespace QLKS.UserControls
{
    public partial class UserControl_LoaiPhong : UserControl
    {
        public UserControl_LoaiPhong()
        {
            InitializeComponent();
        }
        private void UserControl_LoaiPhong_Load(object sender, EventArgs e)
        {
            Controlss.Instance.AddDGVs(dgv_LoaiPhong, new LoaiPhong());
        }
        private void dgv_LoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_LoaiPhong.Columns[e.ColumnIndex].ToolTipText == "Delete")
            {
                if (MessageBox.Show("Thông Báo", "Bạn Muốn Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LoaiPhong? loaiPhong = GetData.Instance.GetLoaiPhong((Guid)dgv_LoaiPhong.Rows[e.RowIndex].Cells[0].Value);
                    if (loaiPhong != null || loaiPhong.Phongs.Count() == 0)
                    {
                        DeleteData.Instance.DeleteLoaiPhong(loaiPhong);
                        dgv_LoaiPhong.Rows.Remove(dgv_LoaiPhong.Rows[e.RowIndex]);
                    }
                    else
                    {
                        MessageBox.Show("Đang có phòng loại " + loaiPhong.TenLoaiPhong);
                    }
                }
            }
            else
            {
                txt_LoaiPhong.Text = dgv_LoaiPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Gia.Text = dgv_LoaiPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            LoaiPhong loaiPhong = new LoaiPhong();
            if(txt_LoaiPhong.Text != string.Empty && txt_Gia.Text != string.Empty)
            {
                loaiPhong.TenLoaiPhong = txt_LoaiPhong.Text;
                loaiPhong.Gia = int.Parse(txt_Gia.Text);
            }
            if (UC_LoaiPhong_Controller.Instance.AddLoaiPhong(loaiPhong))
                QLKS.Controlss.Instance.AddDGV(dgv_LoaiPhong, loaiPhong);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            LoaiPhong loaiPhong = new LoaiPhong();
            loaiPhong.MaLoai = (Guid)dgv_LoaiPhong.SelectedCells[0].OwningRow.Cells[0].Value;
            loaiPhong.TenLoaiPhong = txt_LoaiPhong.Text;
            loaiPhong.Gia = int.Parse(txt_Gia.Text);
            UC_LoaiPhong_Controller.Instance.UpdateLoaiPhong(loaiPhong);
            Controlss.Instance.AddDGVs(dgv_LoaiPhong, new LoaiPhong());
        }
    }
}
