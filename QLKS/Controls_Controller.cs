using Controller.Data;
using Controller.Form_Controller;
using Library.Entity;
using Library.Servser;
using QLKS.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetData = Controller.Data.GetData;

namespace QLKS
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
            else if (ojb.GetType() == typeof(Tang))
            {
                comboBox.DataSource = Server.Instance.GetData().GetTangs();
                comboBox.DisplayMember = "SoTang";
                comboBox.ValueMember = "MaTang";
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
            else if (ojb.GetType() == typeof(Tang))
            {
                Tang t = (Tang)ojb;
                dataGridView.Rows.Add(t.MaTang, t.SoTang, t.Phongs.Count());
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
            else if(ojb.GetType() == typeof(Tang))
            {
                if(Server.Instance.GetData().GetTangs().Count() != 0)
                {
                    foreach (Tang tang in Server.Instance.GetData().GetTangs())
                    {
                        dataGridView = AddDGV(dataGridView, tang);
                    }
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
        public Panel SettingControls(Panel panel_View,object ojb)
        {
            panel_View.Controls.Clear();
            Panel panel = new Panel();
            Label label = new Label();
            List<Tang> list = GetData.Instance.GetTangs();
            list.Reverse();


            foreach (Tang tang in list)
            {


                panel = new Panel();
                panel.Dock = DockStyle.Top;
                panel.AutoSize = true;
                panel_View.Controls.Add(panel);

                FlowLayoutPanel flowLayout = new FlowLayoutPanel();
                flowLayout.Dock = DockStyle.Top;
                flowLayout.AutoScroll = true;
                flowLayout.Size = new Size(panel_View.Width, 210);
                panel.Controls.Add(flowLayout);

                label = new Label();
                label.Dock = DockStyle.Top;
                label.Text = "Tầng " + tang.SoTang;
                panel.Controls.Add(label);

                foreach (Phong phong in tang.Phongs)
                {
                    flowLayout.Controls.Add(new UserControl_ThePhong(phong));

                }
            }
            return panel_View;
        }
    }
}
