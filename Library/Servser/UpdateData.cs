﻿using Library.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Servser
{
    public class UpdateData
    {
        private ApplicationDbContext dbContext;
        public UpdateData()
        {
            dbContext = new ApplicationDbContext();
        }
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
        public void UpdateKhacHang(KhachHang khachHang)
        {
            var item = dbContext.KhachHangs.FirstOrDefault(p => p.MaKH == khachHang.MaKH);
            item.TenKH = khachHang.TenKH;
            item.SDT = khachHang.SDT;
            item.Email = khachHang.Email;
            dbContext.SaveChanges();
        }
    }
}