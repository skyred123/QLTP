using Controller.Data;
using Library.Entity;
using Library.Servser;

namespace Controller.Form_Controller
{
    public class LoginForm_Controller
    {
        private static LoginForm_Controller instance;
        public static LoginForm_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginForm_Controller();
                }
                return instance;
            }
        }
        public LoginForm_Controller()
        {
        }
        public bool DangNhap(string username, string password)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "^[a-zA-Z0-9\x20]+$") == false)
            {
                return false;
            }
            else
            {
                foreach (User item in Server.Instance.GetData().GetUsers())
                {
                    if (item.Name == username && item.Password == password)
                    {
                        if (item.Name == "Admin")
                        {
                            ViewData.nhanVien = null;
                            return true;
                        }
                        else
                        {
                            ViewData.nhanVien = Server.Instance.GetData().GetNhanVien(item.MaNV);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}