using Controller.Data;
using Controller.Form_Controller;
using Library.Entity;
using Library.Servser;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserControls_Controller
{
    public class UC_ChinhSuaTT_Controller
    {
        private static UC_ChinhSuaTT_Controller instance;
        public static UC_ChinhSuaTT_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_ChinhSuaTT_Controller();
                }
                return instance;
            }
        }
        Server server;
        public UC_ChinhSuaTT_Controller() 
        {
            server= new Server();
        }
        public string UpdateUser(User user,string mkm1,string mkm2)
        {
            User? item = ViewData.nhanVien.Users.FirstOrDefault();
            if (user.Password != "" && user.Name != "" && mkm1 != "" && mkm2 != "")
            {
                if (mkm1 == mkm2)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(mkm2, "^[a-zA-Z0-9\x20]+$"))
                    {
                        if (user.Password == item.Password)
                        {
                            item.Name = user.Name;
                            item.Password = mkm2;
                            server.UpdateUser(item);
                            return "Lưu Thành Công";
                        }
                    }
                    else
                    {
                        return "Mật Khẩu Chứa Ký Tự Đặt Biệt";
                    }
                }
                else
                {
                    return "Nhập Sai Mật Khẩu";
                }
            }
            else
            {
                return "Bạn Nhập Thiếu Thông Tin";
            }
            return null;
        }
        public string UpdateNhanVien(NhanVien nhanVien,NhanVien nv)
        {
            if (nhanVien.MaNV.Count() != 10)
            {
                return "Sai Số CCCD";
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(nhanVien.SDT, "[0-9]") == false && nhanVien.SDT.Count() != 10)
            {
                return "Sai Số Điện Thoại";
            }
            if (nhanVien.MaCV == Guid.Empty)
            {
                return "Tên Chức Vụ Không Tồn Tại";
            }
            if (ViewData.add == true)
            {
                if (Server.Instance.GetData().GetNhanViens().FirstOrDefault(e => e.MaNV == nhanVien.MaNV) != null)
                {
                    return "CCCD Đã Tồn Tại";
                }
                User user = new User();
                user.MaNV = nhanVien.MaNV;
                user.Name = nhanVien.TenNV;
                user.Password = "1";
                Server.Instance.AddData().AddNhanVien(nhanVien);
                Server.Instance.AddData().AddUser(user);
                return "Lưu Thành Công Tài Khoản Có Mật Khẩu Là 1";
            }
            else if(ViewData.update== true && nv != null)
            {
                if (Server.Instance.GetData().GetNhanViens().FirstOrDefault(e => e.MaNV == nhanVien.MaNV) != null && nhanVien.MaNV == nv.MaNV)
                {
                    server.UpdateNV(nhanVien);
                    
                }
                else
                {
                    User user = nv.Users.FirstOrDefault();
                    Server.Instance.DeleteData().DeleteNV(nv);
                    Server.Instance.DeleteData().DeleteUser(nv.Users.FirstOrDefault());
                    Server.Instance.AddData().AddNhanVien(nhanVien);
                    user.MaNV = nhanVien.MaNV;
                    Server.Instance.AddData().AddUser(user);;
                }
                if(nv == ViewData.nhanVien)
                {
                    ViewData.nhanVien= nhanVien;
                }
                return "Lưu Thành Công";
            }
            return null;
        }
    }
}
