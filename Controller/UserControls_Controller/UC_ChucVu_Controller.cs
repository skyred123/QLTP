using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_ChucVu_Controller
    {
        private static UC_ChucVu_Controller instance;
        public static UC_ChucVu_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_ChucVu_Controller();
                }
                return instance;
            }
        }
        public bool AddChucVu(ChucVu chucVu)
        {
            foreach (ChucVu item in Server.Instance.GetData().GetChucVus())
            {
                if(item.TenCV.ToLower().Contains(chucVu.TenCV.ToLower()) == true)
                {
                    MessageBox.Show("Chức Vụ Đã tồn tại");
                    return false;
                }
            }
            Server.Instance.AddData().AddChucVu(chucVu);
            MessageBox.Show("Thêm Thành Công");
            return true;
        }
        public void UpdateChucVu(ChucVu chucVu)
        {
            Server.Instance.UpdateData().UpdateChucVu(chucVu);
        }
    }
}
