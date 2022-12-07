using Controller;
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
    public partial class UserControl_DSKH : UserControl
    {
        public static UserControl_DSKH instance;
        public DataGridView dataGridView;
        public UserControl_DSKH()
        {
            InitializeComponent();
            instance= this;
            dataGridView = dgv_KhachHang;
        }

        private void UserControl_DSKH_Load(object sender, EventArgs e)
        {
            Controls_Controller.Instance.AddDGV_KhachHangs(dgv_KhachHang);
        }
        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_KhachHang.Columns[e.ColumnIndex].ToolTipText == "Edit")
            {
                KhachHang khachHang = GetData.Instance.GetKhachHang(dgv_KhachHang.Rows[e.RowIndex].Cells[0].Value.ToString());
                ViewData.Instance.SetUpdate(khachHang);
                Controls_Controller.Instance.GetEditForm(new UserControl_TKKH(), new EditForm());
            }
            else if (dgv_KhachHang.Columns[e.ColumnIndex].ToolTipText == "Delete")
            {
                if (MessageBox.Show("Thông Báo", "Bạn Muốn Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    KhachHang khachHang = GetData.Instance.GetKhachHang(dgv_KhachHang.Rows[e.RowIndex].Cells[0].Value.ToString());
                    DeleteData.Instance.DeleteKH(khachHang);
                    MessageBox.Show("Xóa Thành Công");
                }
            }
            dgv_KhachHang.Refresh();
        }
    }
}
