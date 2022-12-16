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
    public partial class UserControl_TheDichVu : UserControl
    {
        private DichVu dichVu;
        public UserControl_TheDichVu(DichVu dv)
        {
            InitializeComponent();
            this.dichVu = dv;
        }

        private void UserControl_TheDichVu_Load(object sender, EventArgs e)
        {
            image_Avatar.Image = Image.FromStream(new MemoryStream(dichVu.Image));
            label_Ten.Text = dichVu.TenDV;
            label_Gia.Text = dichVu.GiaDV.ToString();
        }
        public DichVu GetDichVu()
        {
            return this.dichVu;
        }
    }
}
