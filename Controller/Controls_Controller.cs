using Controller.Form_Controller;
using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class Controls_Controller
    {
        private static Controls_Controller? instance;
        public static Controls_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controls_Controller();
                }
                return instance;
            }
        }
        public Controls_Controller(){ }
        public void GetUserControl(Panel panel,Form form, UserControl userControl)
        {
            if(form== null)
            {
                panel.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            else
            {
                form.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            
        }
        public void GetForm(Form formHide, Form formShow)
        {
            if(formHide == null)
            {
                formShow.ShowDialog();
            }
            else
            {
                formHide.Hide();
                formShow.ShowDialog();
            }
        }
        public void GetEditForm(UserControl userControl,Form form)
        {
            GetUserControl(null, form, userControl);
            GetForm(null, form);
        }
        public void HidePanel(Panel panel)
        {
            panel.Hide();
        }
        public void ShowPanel(Panel panel)
        {
            if (panel.Visible == false)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }
        public void HideButton(Button button) => button.Visible = false;
        public void OpenFile(PictureBox pictureBox)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        public void AddComboBox(ComboBox comboBox,Object ojb)
        {
            if (ojb.GetType() == typeof(ChucVu))
            {
                comboBox.DataSource = Server.Instance.GetData().GetChucVus();
                comboBox.DisplayMember = "TenCV";
                comboBox.ValueMember = "MaCV";
            }
        }
        public DataGridView AddDGV_NhanViens(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            foreach (NhanVien nv in Server.Instance.GetData().GetNhanViens())
            {
                dataGridView = AddDGV_NhanVien(dataGridView, nv);
            }
            return dataGridView;
        }
        public DataGridView AddDGV_NhanVien(DataGridView dataGridView,NhanVien nv)
        {
            nv = Server.Instance.GetData().GetNhanVien(nv.MaNV);
            dataGridView.Rows.Add(nv.MaNV, nv.TenNV, Image.FromStream(new MemoryStream(nv.Image)), nv.SDT, nv.Email, nv.ChucVu.TenCV);
            return dataGridView;
        }
        public DataGridView AddDGV_KhachHangs(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            foreach (KhachHang kh in Server.Instance.GetData().GetKhachHangs())
            {
                dataGridView.Rows.Add(kh.MaKH, kh.TenKH, kh.SDT, kh.Email);
            }
            return dataGridView;
        }
        public DataGridView AddDGV_KhachHang(DataGridView dataGridView, KhachHang kh)
        {
            dataGridView.Rows.Add(kh.MaKH, kh.TenKH, kh.SDT, kh.Email);
            return dataGridView;
        }
        public void ButtonText(Button button,string str)
        {
            button.Text = str;
        }
    }
}
