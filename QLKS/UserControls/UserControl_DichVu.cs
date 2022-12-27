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
using static System.Resources.ResXFileRef;

namespace QLKS.UserControls
{
    public partial class UserControl_DichVu : UserControl
    {
        public int index = 0;
        public List<UserControl_TheDichVu> list_DichDu;
        private DichVu dichVu;
        public UserControl_DichVu()
        {
            list_DichDu = new List<UserControl_TheDichVu>();
            InitializeComponent();
        }

        private void UserControl_DichVu_Load(object sender, EventArgs e)
        {
            List_DichVu();
        }

        private void Clears()
        {
            pictureBox_Image.Image = null;
            txt_Gia.Text = null;
            txt_TenMA.Text = null;
        }
        public void List_DichVu()
        {
            flowLayoutPanel_DV.Controls.Clear();
            index= 0;
            list_DichDu = new List<UserControl_TheDichVu>();
            foreach (DichVu item in GetData.Instance.GetDichVus())
            {
                AddList_DichVu(item);
            }
        }
        public void AddList_DichVu(DichVu dv)
        {
            list_DichDu.Add(new UserControl_TheDichVu(dv));
            list_DichDu[index].Click += new EventHandler(this.UserControl_Click);
            flowLayoutPanel_DV.Controls.Add(list_DichDu[index]);
            index++;
        }
        private void UserControl_Click(object sender, EventArgs e)
        {
            UserControl_TheDichVu ojb = (UserControl_TheDichVu)sender;
            dichVu = ojb.GetDichVu();
            if (dichVu != null)
            {
                pictureBox_Image.Image = Image.FromStream(new MemoryStream(dichVu.Image));
                txt_Gia.Text = dichVu.GiaDV.ToString();
                txt_TenMA.Text = dichVu.TenDV;
            }
        }
        private void btn_Image_Click(object sender, EventArgs e)
        {
            Controlss.Instance.OpenFile(pictureBox_Image);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DichVu dichVu = new DichVu();
            ImageConverter converter = new ImageConverter();
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Gia.Text, "^[0-9\x20]+$") == true && pictureBox_Image.Image != null && txt_Gia.Text != string.Empty)
            {
                dichVu.GiaDV = int.Parse(txt_Gia.Text);
                dichVu.TenDV = txt_TenMA.Text;
                dichVu.Image = (byte[])converter.ConvertTo(pictureBox_Image.Image, typeof(byte[]));
                if (UC_DichVu_Controller.Instance.AddDichVu(dichVu))
                {
                    AddList_DichVu(dichVu);
                    MessageBox.Show("Lưu thành công");
                }
            }
            else
            {
                MessageBox.Show("Thiếu Dữ Liệu");
            }
        }
        
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Gia.Text, "^[0-9\x20]+$") == true || pictureBox_Image != null)
            {
                if (MessageBox.Show("Thông Báo", "Bạn Muốn Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dichVu.CT_HDDV.Count != 0)
                    {
                        DeleteData.Instance.DeleteDichVu(dichVu);
                        List_DichVu();
                        Clears();
                        MessageBox.Show("Xóa thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Thiếu Dữ Liệu");
            }
        }

        private void btnSua__Click(object sender, EventArgs e)
        {
            ImageConverter converter = new ImageConverter();
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Gia.Text, "^[0-9\x20]+$") == true || pictureBox_Image != null)
            {
                dichVu.GiaDV = int.Parse(txt_Gia.Text);
                dichVu.TenDV = txt_TenMA.Text;
                dichVu.Image = (byte[])converter.ConvertTo(pictureBox_Image.Image, typeof(byte[]));
                if (UC_DichVu_Controller.Instance.UpdateDichVu(dichVu))
                {
                    List_DichVu();
                    Clears();
                    MessageBox.Show("Lưu thành công");
                }
            }
            else
            {
                MessageBox.Show("Thiếu Dữ Liệu");
            }
        }
    }
}
