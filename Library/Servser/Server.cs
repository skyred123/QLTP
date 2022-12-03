using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entity;
using Microsoft.EntityFrameworkCore;

namespace Library.Servser
{
    public class Server
    {
        private static Server instance;
        public static Server Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Server();
                }
                return instance;
            }
        }

        private ApplicationDbContext dbContext;
        public Server() { 
            dbContext= new ApplicationDbContext();
        }
        public AddData AddData() => new AddData();
        public DeleteData DeleteData() => new DeleteData();
        public GetData GetData() => new GetData();





















        public void UpdateNV(NhanVien nv)
        {
            var nhanvien = dbContext.NhanViens.Where(p => p.MaNV == nv.MaNV).FirstOrDefault();
            nhanvien.TenNV = nv.TenNV;
            nhanvien.SDT = nv.SDT;
            nhanvien.Email = nv.Email;
            nhanvien.MaCV = nv.MaCV;
            nhanvien.Image = nv.Image;
            dbContext.NhanViens.Update(nhanvien);
            dbContext.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            var item = dbContext.Users.FirstOrDefault(p => p.MaUser == user.MaUser);
            item.Name = user.Name;
            item.Password = user.Password;
            dbContext.Users.Update(item);
            dbContext.SaveChanges();
        }
    }
}
