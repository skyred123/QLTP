using Library.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Servser
{
    public class DeleteData
    {
        private ApplicationDbContext dbContext;
        public DeleteData()
        {
            dbContext = new ApplicationDbContext();
        }
        public void DeleteUser(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
        public void DeleteNV(NhanVien nv)
        {
            dbContext.NhanViens.Remove(nv);
            dbContext.SaveChanges();
        }
        public void DeleteKhachHang(KhachHang khachHang)
        {
            dbContext.KhachHangs.Remove(khachHang);
            dbContext.SaveChanges();
        }
        public void DeleteChucVu(ChucVu chucVu)
        {
            dbContext.ChucVus.Remove(chucVu);
            dbContext.SaveChanges();
        }
        public void DeleteTang(Tang tang)
        {
            dbContext.Tangs.Remove(tang);
            dbContext.SaveChanges();
        }
        public void DeletePhong(Phong phong)
        {
            dbContext.Phongs.Remove(phong);
            dbContext.SaveChanges();
        }
        public void DeleteLoaiPhong(LoaiPhong loaihhong)
        {
            dbContext.LoaiPhongs.Remove(loaihhong);
            dbContext.SaveChanges();
        }
        public void DeleteHopDong(HopDong hopDong)
        {
            dbContext.HopDongs.Remove(hopDong);
            dbContext.SaveChanges();
        }
    }
}
