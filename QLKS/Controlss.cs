using Controller.Data;
using Controller.Form_Controller;
using Library.Entity;
using Library.Servser;
using QLKS.UserControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GetData = Controller.Data.GetData;

namespace QLKS
{
    public class Controlss
    {
        private static Controlss? instance;
        public static Controlss Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controlss();
                }
                return instance;
            }
        }
        public Controlss(){ }
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
                comboBox.DataSource = GetData.Instance.GetChucVus();
                comboBox.DisplayMember = "TenCV";
                comboBox.ValueMember = "MaCV";
            }
            else if (ojb.GetType() == typeof(Tang))
            {
                comboBox.DataSource = GetData.Instance.GetTangs();
                comboBox.DisplayMember = "SoTang";
                comboBox.ValueMember = "MaTang";
            }
            else if (ojb.GetType() == typeof(LoaiPhong))
            {
                comboBox.DataSource = GetData.Instance.GetLoaiPhongs();
                comboBox.DisplayMember = "TenLoaiPhong";
                comboBox.ValueMember = "MaLoai";
                comboBox.ValueMember = "Gia";
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
            else if (ojb.GetType() == typeof(Phong))
            {
                Phong p = (Phong)ojb;
                dataGridView.Rows.Add(p.MaPhong,p.TenPhong,p.Tang.SoTang);
            }
            else if (ojb.GetType() == typeof(LoaiPhong))
            {
                LoaiPhong lp = (LoaiPhong)ojb;
                dataGridView.Rows.Add(lp.MaLoai,lp.TenLoaiPhong,lp.Gia);
            }
            else if (ojb.GetType() == typeof(HopDong))
            {
                HopDong hd = (HopDong)ojb;
                dataGridView.Rows.Add(hd.MaNV,hd.KhachHang.TenKH,hd.NhanVien.TenNV,hd.TongGia);
            }
            else if (ojb.GetType() == typeof(DichVu))
            {
                DichVu dv = (DichVu)ojb;
                dataGridView.Rows.Add(dv.MaDV,dv.TenDV,dv.GiaDV);
            }
            return dataGridView;
        }
        public DataGridView AddDGVs(DataGridView dataGridView,object ojb)
        {
            dataGridView.Rows.Clear();
            if (ojb.GetType() == typeof(ChucVu))
            {
                foreach (ChucVu cv in GetData.Instance.GetChucVus())
                {
                    dataGridView = AddDGV(dataGridView, cv);
                }
            }
            else if (ojb.GetType() == typeof(NhanVien))
            {
                foreach (NhanVien nv in GetData.Instance.GetNhanViens())
                {
                    dataGridView = AddDGV(dataGridView, nv);
                }
            }
            else if (ojb.GetType() == typeof(KhachHang))
            {
                foreach (KhachHang kh in GetData.Instance.GetKhachHangs())
                {
                    dataGridView = AddDGV(dataGridView,kh);
                }
            }
            else if(ojb.GetType() == typeof(Tang))
            {
                if(GetData.Instance.GetPhongs().Count() != 0)
                {
                    foreach (Tang tang in GetData.Instance.GetTangs())
                    {
                        dataGridView = AddDGV(dataGridView, tang);
                    }
                }
            }
            else if (ojb.GetType() == typeof(Phong))
            {
                if (GetData.Instance.GetPhongs().Count() != 0)
                {
                    foreach (Phong phong in GetData.Instance.GetPhongs())
                    {
                        dataGridView = AddDGV(dataGridView, phong);
                    }
                }
            }
            else if (ojb.GetType() == typeof(LoaiPhong))
            {
                if (GetData.Instance.GetLoaiPhongs().Count() != 0)
                {
                    foreach (LoaiPhong phong in GetData.Instance.GetLoaiPhongs())
                    {
                        dataGridView = AddDGV(dataGridView, phong);
                    }
                }
            }
            else if(ojb.GetType() == typeof(HopDong))
            {
                if (GetData.Instance.GetHopDongs().Count() != 0)
                {
                    foreach (HopDong hopDong in GetData.Instance.GetHopDongs())
                    {
                        dataGridView = AddDGV(dataGridView, hopDong);
                    }
                }
            }
            else if (ojb.GetType() == typeof(DichVu))
            {
                if (GetData.Instance.GetDichVus().Count() != 0)
                {
                    foreach (DichVu dichVu in GetData.Instance.GetDichVus())
                    {
                        dataGridView = AddDGV(dataGridView, dichVu);
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
                foreach (NhanVien item in GetData.Instance.GetNhanViens())
                {
                    if (item.MaNV.Contains(str) || item.TenNV.ToLower().Contains(str) || item.SDT.Contains(str) || item.ChucVu.TenCV.ToLower().Contains(str) || item.Email.ToLower().Contains(str))
                    {
                        AddDGV(dataGridView, item);
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
/*
                    panel = new panel();
                    panel.Dock = DockStyle.Top;
                    panel.AutoSize = true;
                    panel_View.Controls.Add(panel);

                    FlowLayoutPanel flowLayout = new FlowLayoutPanel();
                    flowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                    flowLayout.Location = new System.Drawing.Point(46, 92);
                    flowLayout.Dock = DockStyle.Top;
                    flowLayout.AutoSize = true;
                    //flowLayout.AutoScroll = true;
                    //flowLayout.Size = new Size(panel_View.Width, 210);
                    panel.Controls.Add(flowLayout);

                    label = new Label();
                    label.Dock = DockStyle.Top;
                    label.Text = "Tầng " + tang.SoTang;
                    panel.Controls.Add(label);
                    if (tang.Phongs.Count() >= 0)
                    {
                        foreach (Phong phong in tang.Phongs)
                        {
                            flowLayout.Controls.Add(new UserControl_ThePhong(GetData.Instance.GetPhong(phong.MaPhong)));
                        }
                    }                    
 */