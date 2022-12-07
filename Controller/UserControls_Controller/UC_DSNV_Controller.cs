using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_DSNV_Controller
    {
        private static UC_DSNV_Controller instance;
        public static UC_DSNV_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_DSNV_Controller();
                }
                return instance;
            }
        }
        public DataGridView Search(DataGridView dataGridView,String str)
        {
            dataGridView.Rows.Clear();
            foreach (NhanVien item in Server.Instance.GetData().GetNhanViens())
            {
                if ((item.MaNV).Contains(str)  || item.TenNV.Contains(str) || item.SDT.Contains(str) ||item.ChucVu.TenCV.Contains(str) || item.Email.Contains(str))
                {
                    Controls_Controller.Instance.AddDGV_NhanVien(dataGridView, item);
                }
            }
            return dataGridView;
        }
    }
}
