using Library.Entity;
using Library.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Servser
{
    public class GetData : GetData_Interface
    {
        private ApplicationDbContext dbContext;
        public GetData()
        {
            dbContext = new ApplicationDbContext();
        }
        public List<ChucVu> GetChucVus()
        {
            return dbContext.ChucVus.Include(e => e.NhanViens).ToList();
        }
        public ChucVu? GetChucVu(Guid id)
        {
            return GetChucVus().FirstOrDefault(e => e.MaCV == id);
        }
        public List<NhanVien> GetNhanViens()
        {
            return dbContext.NhanViens.Include(e => e.ChucVu).Include(e=>e.HopDongs).Include(e=>e.Users).ToList();
        }
        public NhanVien? GetNhanVien(string id)
        {
            return GetNhanViens().FirstOrDefault(e => e.MaNV == id);
        }
        public List<User> GetUsers()
        {
            return dbContext.Users.Include(e => e.NhanVien).ToList();
        }
        public User? GetUser(Guid id)
        {
            return GetUsers().FirstOrDefault(e=>e.MaUser == id);
        }
        public List<KhachHang> GetKhachHangs() 
        {
            return dbContext.KhachHangs.Include(e => e.HopDongs).ToList();
        }
        public KhachHang? GetKhachHang(string id)
        {
            return GetKhachHangs().FirstOrDefault(e => e.MaKH == id);
        }
        public List<Tang> GetTangs()
        {
            return dbContext.Tangs.Include(e=>e.Phongs).ToList();
        }
        public Tang? GetTang(Guid id)
        {
            return GetTangs().FirstOrDefault(e=>e.MaTang == id);
        }
    }
}
