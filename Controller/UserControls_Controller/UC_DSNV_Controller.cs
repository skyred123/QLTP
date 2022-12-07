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
        public DataGridView Search(DataGridView dataGridView,NhanVien nv)
        {
            dataGridView.Rows.Clear();
            if (nv.MaNV != string.Empty || nv.MaCV != Guid.Empty || nv.SDT != null || nv.TenNV != null)
            {
                foreach(NhanVien item in Server.Instance.GetData().GetNhanViens())
                {
                    if(nv.MaNV == item.MaNV || nv.TenNV == item.TenNV || nv.SDT == item.SDT || nv.MaCV == item.MaCV)
                    {
                        Controls_Controller.Instance.AddDGV_NhanVien(dataGridView, item);
                    }
                }
            }
            return dataGridView;
        }
    }
}
