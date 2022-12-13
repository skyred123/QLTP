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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLKS.UserControls
{
    public partial class UserControl_HopDong : UserControl
    {
        public static UserControl_HopDong instance;
        public DataGridView dataGridView;
        public UserControl_HopDong()
        {
            InitializeComponent();
            instance = this;
            dataGridView = dgv_Phong;
            dtp_NgayTra.Value = new DateTime(dtp_NgayTra.Value.Year, dtp_NgayTra.Value.Month, dtp_NgayTra.Value.Day +1);
        }

        private void btn_ChonPhong_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm();
            UserControl_CT_HopDong _CT_HopDong = new UserControl_CT_HopDong(form);
            _CT_HopDong.Dock= DockStyle.Fill;
            form.Controls.Add(_CT_HopDong);
            form.ShowDialog();

        }
    }
}
