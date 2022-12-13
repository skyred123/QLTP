using Library.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Servser
{
    public class AddData
    {
        private ApplicationDbContext dbContext;
        public AddData()
        {
            dbContext = new ApplicationDbContext();
        }
        public void AddNhanVien(NhanVien nv)
        {
            dbContext.NhanViens.Add(nv);
            dbContext.SaveChanges();
        }
        public void AddUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
        public void AddKhachHang(KhachHang nv)
        {
            dbContext.KhachHangs.Add(nv);
            dbContext.SaveChanges();
        }
        public void AddChucVu(ChucVu cv)
        {
            dbContext.ChucVus.Add(cv);
            dbContext.SaveChanges();
        }
        public void AddTang(Tang t)
        {
            dbContext.Tangs.Add(t);
            dbContext.SaveChanges();
        }
        public void AddPhong(Phong p)
        {
            dbContext.Phongs.Add(p);
            dbContext.SaveChanges();
        }
        public void AddLoaiPhong(LoaiPhong lp)
        {
            dbContext.LoaiPhongs.Add(lp);
            dbContext.SaveChanges();
        }
    }
}
