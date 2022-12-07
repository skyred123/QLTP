using Library.Entity;
using Library.Interfaces;
using Library.Servser;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace Controller.Data
{
    public class DeleteData : DeleteData_Interface
    {
        private static DeleteData instance;
        public static DeleteData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeleteData();
                }
                return instance;
            }
        }
        public void DeleteNV(NhanVien nv)
        {
            Server.Instance.DeleteData().DeleteUser(nv.Users.FirstOrDefault());
            Server.Instance.DeleteData().DeleteNV(nv);
        }

        public void DeleteUser(Library.Entity.User user)
        {
            throw new NotImplementedException();
        }
        public void DeleteKH(KhachHang kh)
        {
            Server.Instance.DeleteData().DeleteKhachHang(kh);
        }
        public void DeleteChucVu(ChucVu cv)
        {
            Server.Instance.DeleteData().DeleteChucVu(cv);
        }
    }
}
