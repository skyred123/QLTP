using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_CT_HDDV_Controller
    {
        private static UC_CT_HDDV_Controller instance;
        public static UC_CT_HDDV_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_CT_HDDV_Controller();
                }
                return instance;
            }
        }
        public void AddCT_HDDV(CT_HDDV cT_HDDV)
        {
            Server.Instance.AddData().AddCT_HDDV(cT_HDDV);
        }
        public void AddHD_DichVu(HD_DichVu hD_DichVu)
        {
            Server.Instance.AddData().AddHD_DichVu(hD_DichVu);
        }
        public void UpdateCTHD(CT_HD cT_HD)
        {
            Server.Instance.UpdateData().UpdateCTHD(cT_HD);
        }
    }
}
