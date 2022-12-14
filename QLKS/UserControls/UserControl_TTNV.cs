using Controller;
using Controller.Data;
using Library.Entity;
using QLKS.Forms;

namespace QLKS.UserControls
{
    public partial class UserControl_TTNV : UserControl
    {
        public UserControl_TTNV()
        {
            InitializeComponent();
        }

        private void UserControl_TTNhanVien_Load(object sender, EventArgs e)
        {
            txt_MaNV.Text = ViewData.Instance.GetNhanVien().MaNV;
            image_Avatar.Image = Image.FromStream(new MemoryStream(ViewData.Instance.GetNhanVien().Image));
            txt_Ten.Text = ViewData.Instance.GetNhanVien().TenNV;
            txt_SDT.Text = ViewData.Instance.GetNhanVien().SDT;
            txt_Email.Text = ViewData.Instance.GetNhanVien().Email;
            txt_CV.Text = ViewData.Instance.GetNhanVien().ChucVu.TenCV;
        }

        private void link_ChucVu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QLKS.Controlss.Instance.GetEditForm(new UserControl_ChucVu(), new EditForm());
        }
    }
}
