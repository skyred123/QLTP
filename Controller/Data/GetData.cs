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
            return Server.Instance.GetData().GetChucVus();
        }

        public NhanVien GetNhanVien(string id)
        {
            return Server.Instance.GetData().GetNhanVien(id);
        }

        public List<NhanVien> GetNhanViens()
        {
            return Server.Instance.GetData().GetNhanViens();
        }

        public User? GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
        public List<KhachHang> GetKhachHangs()
        {
            return Server.Instance.GetData().GetKhachHangs();
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
        public List<LoaiPhong> GetLoaiPhongs()
        {
            return Server.Instance.GetData().GetLoaiPhongs();
        }
        public LoaiPhong? GetLoaiPhong(Guid id)
        {
            return Server.Instance.GetData().GetLoaiPhong(id);
        }
    }
}
