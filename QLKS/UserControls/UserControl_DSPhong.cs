using Controller;
using Controller.Data;
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

namespace QLKS.UserControls
{
    public partial class UserControl_DSPhong : UserControl
    {
        public static UserControl_DSPhong instance;
        public Panel Panel;
        public UserControl_DSPhong()
        {
            InitializeComponent();
            instance = this;
            Panel = this.panel_View;
        }

        private void UserControl_DSPhong_Load(object sender, EventArgs e)
        {
            panel_View = QLKS.Controlss.Instance.SettingControls(panel_View, new Phong());
        }
    }
}
