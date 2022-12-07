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
        public void AddComboBox(ComboBox comboBox,object ojb)
        {
            if (ojb.GetType() == typeof(ChucVu))
            {
                comboBox.DataSource = Server.Instance.GetData().GetChucVus();
                comboBox.DisplayMember = "TenCV";
                comboBox.ValueMember = "MaCV";
            }
        }
        public DataGridView AddDGV(DataGridView dataGridView, object ojb)
        {
            if(ojb.GetType() == typeof(ChucVu)) 
            {
                ChucVu cv = (ChucVu)ojb;
                dataGridView.Rows.Add(cv.MaCV,cv.TenCV);
            }
            else if(ojb.GetType() == typeof(NhanVien))
            {
                NhanVien? nv = Server.Instance.GetData().GetNhanVien(((NhanVien)ojb).MaNV);
                dataGridView.Rows.Add(nv.MaNV, nv.TenNV, Image.FromStream(new MemoryStream(nv.Image)), nv.SDT, nv.Email, nv.ChucVu.TenCV);
            }
            else if(ojb.GetType() == typeof(KhachHang))
            {
                KhachHang kh = (KhachHang)ojb;
                dataGridView.Rows.Add(kh.MaKH, kh.TenKH, kh.SDT, kh.Email);
            }
            return dataGridView;
        }
        public DataGridView AddDGVs(DataGridView dataGridView,object ojb)
        {
            dataGridView.Rows.Clear();
            if (ojb.GetType() == typeof(ChucVu))
            {
                foreach (ChucVu cv in Server.Instance.GetData().GetChucVus())
                {
                    dataGridView = AddDGV(dataGridView, cv);
                }
            }
            else if (ojb.GetType() == typeof(NhanVien))
            {
                foreach (NhanVien nv in Server.Instance.GetData().GetNhanViens())
                {
                    dataGridView = AddDGV(dataGridView, nv);
                }
            }
            else if (ojb.GetType() == typeof(KhachHang))
            {
                foreach (KhachHang kh in Server.Instance.GetData().GetKhachHangs())
                {
                    dataGridView = AddDGV(dataGridView,kh);
                }
            }
            return dataGridView;
        }
        public DataGridView Search(DataGridView dataGridView, String str,object ojb)
        {
            dataGridView.Rows.Clear();
            if(ojb.GetType() == typeof(ChucVu))
            {

            }
            else if(ojb.GetType() == typeof(NhanVien))
            {
                foreach (NhanVien item in Server.Instance.GetData().GetNhanViens())
                {
                    if (item.MaNV.Contains(str) || item.TenNV.ToLower().Contains(str) || item.SDT.Contains(str) || item.ChucVu.TenCV.ToLower().Contains(str) || item.Email.ToLower().Contains(str))
                    {
                        AddDGVs(dataGridView, item);
                    }
                }
            }
            else if (ojb.GetType() == typeof(KhachHang))
            {
                foreach (KhachHang item in Server.Instance.GetData().GetKhachHangs())
                {
                    if (item.MaKH.Contains(str) || item.TenKH.ToLower().Contains(str) || item.SDT.Contains(str) || item.Email.ToLower().Contains(str))
                    {
                        AddDGV(dataGridView, item);
                    }
                }
            }
            return dataGridView;
        }
        public void ButtonText(Button button,string str)
        {
            button.Text = str;
        }
    }
}
