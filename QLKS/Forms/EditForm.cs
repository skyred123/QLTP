using Controller;
using Controller.Data;
using QLKS.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.Forms
{
    public partial class EditForm : Form
    {
        private static EditForm instance;
        public static EditForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EditForm();
                }
                return instance;
            }
        }
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
        }
        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
