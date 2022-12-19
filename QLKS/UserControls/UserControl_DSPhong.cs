using Controller;
using Controller.Data;
using Library.Entity;
using QLKS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.UserControls
{
    public partial class UserControl_DSPhong : UserControl
    {
        public static UserControl_DSPhong instance;
        public Panel panel;
        public UserControl_DSPhong()
        {
            InitializeComponent();
            instance = this;
            panel = this.panel_View;
        }

        public void List_ThePhong()
        {
            Label label = new Label();
            FlowLayoutPanel flowLayout = new FlowLayoutPanel();
            panel_View.Controls.Clear();
            List<Tang> list = GetData.Instance.GetTangs();
            list.Reverse();

            List<UserControl_ThePhong> list_ThePhong = new List<UserControl_ThePhong>();
            int index = 0;
            foreach (Tang tang in list)
            {
                label = new Label();
                label.Dock = DockStyle.Top;
                label.Text = "Tầng " + tang.SoTang;

                flowLayout = new FlowLayoutPanel();
                flowLayout.AutoSize = true;
                flowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                flowLayout.Location = new System.Drawing.Point(46, 92);
                flowLayout.Name = "flowLayoutPanel1";
                flowLayout.Size = new System.Drawing.Size(0, 0);
                flowLayout.TabIndex = 5;
                flowLayout.Dock = DockStyle.Top;

                panel_View.Controls.Add(flowLayout);
                panel_View.Controls.Add(label);

                if (tang.Phongs.Count() >= 0)
                {
                    foreach (Phong phong in tang.Phongs)
                    {
                        list_ThePhong.Add(new UserControl_ThePhong(GetData.Instance.GetPhong(phong.MaPhong)));
                        flowLayout.Controls.Add(list_ThePhong[index]);
                        list_ThePhong[index].Click += new EventHandler(this.UserControl_Click);
                        index++;
                    }
                }
            }
        }
        private void UserControl_Click(object sender, EventArgs e)
        {
            UserControl_ThePhong ojb = (UserControl_ThePhong)sender;
            EditForm form = new EditForm();
            Controlss.Instance.GetEditForm(new UserControl_CT_HDDV(ojb.GetPhong()), form);
        }
        private void UserControl_DSPhong_Load(object sender, EventArgs e)
        {
            List_ThePhong();
        }

        private void check_List_CheckedChanged(object sender, EventArgs e)
        {
            List_ThePhong();
        }
    }
}
