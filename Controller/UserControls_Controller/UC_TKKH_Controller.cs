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
        public string UpdateKhachHang(KhachHang khachHang,KhachHang kh)
        {
            if(khachHang.MaKH != null && khachHang.TenKH != null && khachHang.SDT != null && khachHang.Email != null)
            {
                if (khachHang.MaKH.Count() != 10)
                {
                    return "Sai Số CCCD";
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(khachHang.SDT, "[0-9]") == false && khachHang.SDT.Count() != 10)
                {
                    return "Sai Số Điện Thoại";
                }
                if(ViewData.add == true)
                {
                    if (Server.Instance.GetData().GetKhachHang(khachHang.MaKH) != null)
                    {
                        return "CCCD Đã Tồn Tại";
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
            return "Lưu Thành Công";
        }
    }
}
