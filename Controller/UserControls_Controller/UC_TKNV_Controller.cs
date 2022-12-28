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
    public class UC_TKNV_Controller
    {
        private static UC_TKNV_Controller instance;
        public static UC_TKNV_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_TKNV_Controller();
                }
                return instance;
            }
        }
        public UC_TKNV_Controller() 
        {
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
                            Server.Instance.UpdateData().UpdateUser(user);
                            return "Lưu Thành Công 1";
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
        public bool UpdateNhanVien(NhanVien nhanVien,NhanVien nv)
        {
            if (nhanVien.MaNV.Count() != 10 || System.Text.RegularExpressions.Regex.IsMatch(nhanVien.SDT, "^[0-9\x20]+$") == false)
            {
                MessageBox.Show("Sai Số CCCD");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(nhanVien.SDT, "^[0-9\x20]+$") == false || nhanVien.SDT.Count() != 10)
            {
                MessageBox.Show("Sai Số Điện Thoại");
                return false;
            }
            if (nhanVien.MaCV == Guid.Empty)
            {
                MessageBox.Show("Tên Chức Vụ Không Tồn Tại");
                return false;
            }
            if (ViewData.add == true)
            {
                if (Server.Instance.GetData().GetNhanVien(nhanVien.MaNV) != null)
                {
                    MessageBox.Show("CCCD Đã Tồn Tại");
                    return false;
                }
                User user = new User();
                user.MaNV = nhanVien.MaNV;
                user.Name = nhanVien.MaNV;
                user.Password = "1";
                Server.Instance.AddData().AddNhanVien(nhanVien);
                Server.Instance.AddData().AddUser(user);
                MessageBox.Show("Lưu Thành Công Tài Khoản Có Mật Khẩu Là 1");
                return true;
            }
            else if(ViewData.update== true && nv != null)
            {
                if (Server.Instance.GetData().GetNhanVien(nhanVien.MaNV)!= null && nhanVien.MaNV == nv.MaNV)
                {
                    Server.Instance.UpdateData().UpdateNV(nhanVien);
                }
                else
                {
                    User user = nv.Users.FirstOrDefault();
                    Server.Instance.DeleteData().DeleteNV(nv);
                    Server.Instance.DeleteData().DeleteUser(nv.Users.FirstOrDefault());
                    Server.Instance.AddData().AddNhanVien(nhanVien);
                    user.MaNV = nhanVien.MaNV;
                    Server.Instance.AddData().AddUser(user);
                }
                if(nv == ViewData.nhanVien)
                {
                    ViewData.nhanVien= Server.Instance.GetData().GetNhanVien(nhanVien.MaNV);
                }
                ViewData.nhanVienEdit = Server.Instance.GetData().GetNhanVien(nhanVien.MaNV);
                MessageBox.Show("Lưu Thành Công");
                return true;
            }
            return false;
        }
    }
}
