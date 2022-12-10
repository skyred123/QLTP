using Controller.Data;
using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_TTPhong_Controller
    {
        private static UC_TTPhong_Controller instance;
        public static UC_TTPhong_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_TTPhong_Controller();
                }
                return instance;
            }
        }
        public bool UpdatePhong(Phong phong)
        {
             if(ViewData.add == true)
            {
                Server.Instance.AddData().AddPhong(phong);
            }
            else if(ViewData.update== true)
            {
                Server.Instance.UpdateData().UpdatePhong(phong);
            }
            MessageBox.Show("Thêm Thành Công");
            return true;
        }
    }
}
