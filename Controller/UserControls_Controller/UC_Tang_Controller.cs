using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_Tang_Controller
    {
        private static UC_Tang_Controller instance;
        public static UC_Tang_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_Tang_Controller();
                }
                return instance;
            }
        }
        public bool AddTang(Tang tang)
        {
            foreach (Tang item in Server.Instance.GetData().GetTangs())
            {
                if (item.SoTang == tang.SoTang)
                {
                    MessageBox.Show("Tang Đã tồn tại");
                    return false;
                }
            }
            Server.Instance.AddData().AddTang(tang);
            MessageBox.Show("Thêm Thành Công");
            return true;
        }
    }
}
