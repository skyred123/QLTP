using Controller;
using Controller.Data;
using Controller.UserControls_Controller;
using Library.Entity;
using Library.Servser;
using QLKS.Forms;

namespace QLKS.UserControls
{
    public partial class UserControl_TKNV : UserControl
    {
        public UserControl_TKNV()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            QLKS.Controlss.Instance.HidePanel(panel_DTTTK);
            QLKS.Controlss.Instance.HidePanel(panel_DMK);
            if(ViewData.Instance.GetNhanVien() == null)
            {

            }
            else if (ViewData.Instance.GetNhanVien().ChucVu.TenCV == "Quản Lý")
            {

            }
            else if (ViewData.Instance.GetNhanVien().ChucVu.TenCV == "Nhân Viên")
            {
                cbx_ChucVu.Enabled = false;
            }
        }
        private void Clear()
        {
            image_Avatar.Image = null;
            txt_CCCD.Text = "";
            txt_Ten.Text = "";
            txt_SDT.Text = "";
            txt_Email.Text = "";
            txt_TenMK.Text = "";
            txt_MKC.Text = "";
            txt_MKM1.Text = "";
            txt_MKM2.Text = "";
        }
        private void UserControl_ChinhSuaTT_Load(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.AddComboBox(cbx_ChucVu, new ChucVu());
            if (ViewData.Instance.GetAdd())
            {
                QLKS.Controlss.Instance.HidePanel(panel_DMK);
                QLKS.Controlss.Instance.HidePanel(panel_MK);
                QLKS.Controlss.Instance.ButtonText(btn_TTTK, "Tạo");
            }
                
        }
        private void btn_TTTK_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.ShowPanel(panel_DTTTK);
            if (ViewData.Instance.GetAdd() == true)
            {
                Clear();
            }
            else if (ViewData.Instance.GetUpdate())
            {
                NhanVien nhanVien = ViewData.Instance.GetNhanVienEdit();
                if (nhanVien.Image == null)
                {
                    image_Avatar.Image = null;
                }
                else
                {
                    image_Avatar.Image = Image.FromStream(new MemoryStream(nhanVien.Image));
                }
                txt_CCCD.Text = nhanVien.MaNV;
                txt_Ten.Text = nhanVien.TenNV;
                txt_SDT.Text = nhanVien.SDT;
                txt_Email.Text = nhanVien.Email;
                cbx_ChucVu.SelectedItem = nhanVien.ChucVu;
            }
        }

        private void btn_MK_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.ShowPanel(panel_DMK);
            if (ViewData.Instance.GetAdd())
            {

            }
            if (ViewData.Instance.GetUpdate())
            {
                if (ViewData.Instance.GetNhanVien() != null)
                {
                    txt_TenMK.Text = "Admin";
                }
                else
                {
                    txt_TenMK.Text = ViewData.Instance.GetNhanVienEdit().Users.FirstOrDefault().Name;
                }
            }
            
        }

        private void btn_LuuTTTK_Click(object sender, EventArgs e)
        {
            NhanVien item = new NhanVien();
            ImageConverter converter = new ImageConverter();
            item.MaNV = txt_CCCD.Text;
            item.TenNV = txt_Ten.Text;
            item.Email = txt_Email.Text;
            item.SDT = txt_SDT.Text;
            item.MaCV = ((ChucVu)cbx_ChucVu.SelectedItem).MaCV;
            if (image_Avatar.Image == null)
            {
                item.Image = (byte[])converter.ConvertTo(Image.FromFile("D:\\Eleaning\\Code\\QLKS\\QLKS\\Image\\AvatarRong.jpg"), typeof(byte[]));
            }
            else
            {
                item.Image = (byte[])converter.ConvertTo(image_Avatar.Image, typeof(byte[]));
            }
            if (ViewData.Instance.GetAdd() == true)
            {
                if(UC_TKNV_Controller.Instance.UpdateNhanVien(item,null) == true)
                {
                    QLKS.Controlss.Instance.AddDGVs(UserControl_DSNV.instance.dataGridView, new NhanVien());
                }
            }
            else if (ViewData.Instance.GetUpdate())
            {
                if (UC_TKNV_Controller.Instance.UpdateNhanVien(item, ViewData.Instance.GetNhanVienEdit()))
                {
                    QLKS.Controlss.Instance.HidePanel(panel_DTTTK);
                    QLKS.Controlss.Instance.AddDGVs(UserControl_DSNV.instance.dataGridView, new NhanVien());
                }
            }
        }
        private void btn_DoiAvatar_Click(object sender, EventArgs e)
        {
            QLKS.Controlss.Instance.OpenFile(image_Avatar);
        }

        private void btn_LuuMK_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txt_TenMK.Text;
            user.Password = txt_MKC.Text;
            MessageBox.Show(UC_TKNV_Controller.Instance.UpdateUser(user, txt_MKM1.Text, txt_MKM2.Text));
            QLKS.Controlss.Instance.HidePanel(panel_DMK);
        }

        private void cbx_ChucVu_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QLKS.Controlss.Instance.GetEditForm(new UserControl_ChucVu(), new EditForm());
        }

        private void link_ChucVu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QLKS.Controlss.Instance.GetEditForm(new UserControl_ChucVu(), new EditForm());
        }
    }
}
