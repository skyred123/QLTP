using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_DichVu_Controller
    {
        private static UC_DichVu_Controller instance;
        public static UC_DichVu_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_DichVu_Controller();
                }
                return instance;
            }
        }
        public bool AddDichVu(DichVu dichVu)
        {
            if(dichVu.Image != null || dichVu.TenDV != string.Empty || dichVu.GiaDV != 0)
            {
                Server.Instance.AddData().AddDichVu(dichVu);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateDichVu(DichVu dichVu)
        {
            if (dichVu.Image != null || dichVu.TenDV != string.Empty || dichVu.GiaDV != 0)
            {
                Server.Instance.UpdateData().UpdateDichVu(dichVu);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
