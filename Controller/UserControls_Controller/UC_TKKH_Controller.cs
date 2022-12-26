using Controller.Data;
using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_TKKH_Controller
    {
        private static UC_TKKH_Controller instance;
        public static UC_TKKH_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_TKKH_Controller();
                }
                return instance;
            }
        }
        public bool UpdateKhachHang(KhachHang khachHang,KhachHang kh)
        {
            if(khachHang.MaKH != null && khachHang.TenKH != null && khachHang.SDT != null && khachHang.Email != null)
            {
                if (khachHang.MaKH.Count() != 10 || System.Text.RegularExpressions.Regex.IsMatch(khachHang.MaKH, "^[0-9\x20]+$") == false)
                {
                    MessageBox.Show("Sai Số CCCD");
                    return false;

                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(khachHang.SDT, "[0-9]") == false || khachHang.SDT.Count() != 10)
                {
                    MessageBox.Show("Sai Số Điện Thoại");
                    return false;
                }
                if(ViewData.add == true)
                {
                    if (Server.Instance.GetData().GetKhachHang(khachHang.MaKH) != null)
                    {
                        MessageBox.Show("CCCD Đã Tồn Tại");
                        return false;
                    }
                    Server.Instance.AddData().AddKhachHang(khachHang);
                }
                else if(ViewData.update== true && kh != null)
                {
                    if(Server.Instance.GetData().GetKhachHang(khachHang.MaKH) != null && khachHang.MaKH == kh.MaKH)
                    {
                        Server.Instance.UpdateData().UpdateKhacHang(khachHang);
                    }
                    else
                    {
                        Server.Instance.DeleteData().DeleteKhachHang(kh);
                        Server.Instance.AddData().AddKhachHang(khachHang);
                    }
                }
            }
            ViewData.khachHangEdit = khachHang;
            return true;
        }
    }
}
