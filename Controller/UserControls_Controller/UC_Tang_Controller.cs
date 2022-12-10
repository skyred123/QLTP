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
        public Tang AddTang()
        {
            Tang tang = new Tang();
            tang.SoTang = Server.Instance.GetData().GetTangs().Count +1;
            Server.Instance.AddData().AddTang(tang);
            MessageBox.Show("Thêm Thành Công");
            return tang;
        }
        public Tang DeleteTang()
        {
            if (Server.Instance.GetData().GetTangs().Count() ==0)
            {
                MessageBox.Show("Không Có Tầng Nào Để Xóa");
                return null;
            }
            Tang tang = Server.Instance.GetData().GetTangs().LastOrDefault();
            Server.Instance.DeleteData().DeleteTang(tang);
            MessageBox.Show("Xóa Thành Công");
            return tang;
        }
    }
}
