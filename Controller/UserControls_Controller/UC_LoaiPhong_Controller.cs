using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_LoaiPhong_Controller
    {
        private static UC_LoaiPhong_Controller instance;
        public static UC_LoaiPhong_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_LoaiPhong_Controller();
                }
                return instance;
            }
        }
        public bool AddLoaiPhong(LoaiPhong loaiPhong)
        {
            foreach (LoaiPhong item in Server.Instance.GetData().GetLoaiPhongs())
            {
                if (item.TenLoaiPhong.ToLower().Contains(loaiPhong.TenLoaiPhong.ToLower()) == true)
                {
                    MessageBox.Show("Loại Phòng Đã tồn tại");
                    return false;
                }
            }
            Server.Instance.AddData().AddLoaiPhong(loaiPhong);
            MessageBox.Show("Thêm Thành Công");
            return true;
        }
        public void UpdateLoaiPhong(LoaiPhong loaiPhong)
        {
            Server.Instance.UpdateData().UpdateLoaiPhong(loaiPhong);
        }
    }
}
