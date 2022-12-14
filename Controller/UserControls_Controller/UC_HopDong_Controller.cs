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
        public bool AddHopdong(HopDong hd)
        {
            if (hd.MaKH != string.Empty && hd.TongGia != 0)
            {
                Server.Instance.AddData().AddHopDong(hd);
                return true;
            }
            else
            {
                //MessageBox.Show("Nhập không thành công");
                return false;
            }
        }
        public bool AddCTHD(CT_HD cT_HD)
        {
            if (cT_HD.MaHD != Guid.Empty && cT_HD.MaPhong != Guid.Empty )
            {
                Server.Instance.AddData().AddCT_HD(cT_HD);
                return true;
            }
            else
            {
                //MessageBox.Show("Nhập không thành công");
                return false;
            }
        }
    }
}
