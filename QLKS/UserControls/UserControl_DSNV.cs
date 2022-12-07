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
            Controls_Controller.Instance.AddDGV_NhanViens(dgv_NhanVien);
            Controls_Controller.Instance.AddComboBox(cbx_ChucVu, new ChucVu());
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
            else
            {

            }
            
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txt_CCCD.Text= string.Empty;
            txt_SDT.Text= string.Empty;
            txt_TenNV.Text= string.Empty;
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.SDT = txt_SDT.Text;
            nv.MaNV = txt_CCCD.Text;
            nv.TenNV= txt_TenNV.Text;
            if (((ChucVu)cbx_ChucVu.SelectedItem) == null)
            {
                nv.MaCV = Guid.Empty;
            }
            else
            {
                nv.MaCV = ((ChucVu)cbx_ChucVu.SelectedItem).MaCV;
            }
            dgv_NhanVien = UC_DSNV_Controller.Instance.Search(dgv_NhanVien, nv);
        }
    }
}
