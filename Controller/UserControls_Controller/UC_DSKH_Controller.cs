using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_DSKH_Controller
    {
        private static UC_DSKH_Controller instance;
        public static UC_DSKH_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_DSKH_Controller();
                }
                return instance;
            }
        }
        public DataGridView Search(DataGridView dataGridView, String str)
        {
            dataGridView.Rows.Clear();
            
            return dataGridView;
        }
    }
}
