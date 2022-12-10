using Library.Entity;
using Library.Interfaces;
using Library.Servser;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Data
{
    public class GetData : GetData_Interface
    {
        private static GetData instance;
        public static GetData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GetData();
                }
                return instance;
            }
        }
        public GetData()
        {
        }

        public ChucVu? GetChucVu(Guid id)
        {
            return Server.Instance.GetData().GetChucVu(id);
        }

        public List<ChucVu> GetChucVus()
        {
            throw new NotImplementedException();
        }

        public NhanVien GetNhanVien(string id)
        {
            return Server.Instance.GetData().GetNhanVien(id);
        }

        public List<NhanVien> GetNhanViens()
        {
            throw new NotImplementedException();
        }

        public User? GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
        public KhachHang GetKhachHang(string id)
        {
            return Server.Instance.GetData().GetKhachHang(id);
        }
        public List<Tang> GetTangs()
        {
            return Server.Instance.GetData().GetTangs();
        }
        public Tang? GetTang(Guid id)
        {
            return Server.Instance.GetData().GetTang(id);
        }
        public List<Phong> GetPhongs()
        {
            return Server.Instance.GetData().GetPhongs();
        }
        public Phong? GetPhong(Guid id)
        {
            return Server.Instance.GetData().GetPhong(id);
        }
    }
}
