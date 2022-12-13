using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_HopDong_Controller
    {
        private static UC_HopDong_Controller instance;
        public static UC_HopDong_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_HopDong_Controller();
                }
                return instance;
            }
        }
        public void AddHopdong(HopDong hd)
        {
            Server.Instance.AddData().AddHopDong(hd);
        }
        public void AddCTHD(CT_HD cT_HD)
        {
            Server.Instance.AddData().AddCT_HD(cT_HD);
        }
    }
}
