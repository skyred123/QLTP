using Controller;
using Controller.Data;
using Controller.UserControls_Controller;
using Library.Entity;
using QLKS.Forms;

namespace QLKS.UserControls
{
    public partial class UserControl_DSNV : UserControl
    {
        public static UserControl_DSNV instance;
        public DataGridView dataGridView;
        public UserControl_DSNV()
        {
            InitializeComponent();
            instance = this;
            dataGridView = dgv_NhanVien;
        }
        private void UserControl_QLNV_Load(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.AddDGVs(dgv_NhanVien, new NhanVien());
        }
        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dgv_NhanVien.Columns[e.ColumnIndex].ToolTipText == "Edit")
            {
                NhanVien nhanVien = GetData.Instance.GetNhanVien(dgv_NhanVien.Rows[e.RowIndex].Cells[0].Value.ToString());
                ViewData.Instance.SetUpdate(nhanVien);
                QLKS.Controlss.Instance.GetEditForm(new UserControl_TKNV(), new EditForm());
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
            else
            {

            }
            
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text != string.Empty) 
            {
                dgv_NhanVien = QLKS.Controlss.Instance.Search(dgv_NhanVien, txt_TimKiem.Text.ToLower(),new NhanVien()); 
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
            }
        }
    }
}
