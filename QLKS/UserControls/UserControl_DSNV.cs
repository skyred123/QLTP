using Controller;
using Controller.Data;
using Library.Entity;
using QLKS.Forms;

namespace QLKS.UserControls
{
    public partial class UserControl_DSNV : UserControl
    {
        public UserControl_DSNV()
        {
            InitializeComponent();
        }
        private void UserControl_QLNV_Load(object sender, EventArgs e)
        {
            Controls_Controller.Instance.AddDGV_NhanVien(dgv_NhanVien);
            dgv_NhanVien.Refresh();
        }

        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dgv_NhanVien.Columns[e.ColumnIndex].ToolTipText == "Edit")
            {
                NhanVien nhanVien = GetData.Instance.GetNhanVien(dgv_NhanVien.Rows[e.RowIndex].Cells[0].Value.ToString());
                ViewData.Instance.SetUpdate(nhanVien);
                Controls_Controller.Instance.GetEditForm(new UserControl_TKNV(), new EditForm());
            }
            else if(dgv_NhanVien.Columns[e.ColumnIndex].ToolTipText == "Delete")
            {
                if (MessageBox.Show("Thông Báo","Bạn Muốn Xóa",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    NhanVien nhanVien = GetData.Instance.GetNhanVien(dgv_NhanVien.Rows[e.RowIndex].Cells[0].Value.ToString());
                    DeleteData.Instance.DeleteNV(nhanVien);
                    MessageBox.Show("Xóa Thành Công");
                }
            }
            dgv_NhanVien.Refresh();
        }

        private void btn_TaoNV_Click(object sender, EventArgs e)
        {
            ViewData.Instance.SetAdd();
            Controls_Controller.Instance.GetEditForm(new UserControl_TKNV(), new EditForm());
            dgv_NhanVien.Refresh();
        }
    }
}
