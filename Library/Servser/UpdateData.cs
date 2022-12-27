using Library.Entity;
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
        public void UpdateChucVu(ChucVu chucVu)
        {
            var item = dbContext.ChucVus.FirstOrDefault(p => p.MaCV == chucVu.MaCV);
            item.TenCV = chucVu.TenCV;
            item.Quyen= chucVu.Quyen;
            dbContext.SaveChanges();
        }
        public void UpdatePhong(Phong phong)
        {
            var item = dbContext.Phongs.FirstOrDefault(p => p.MaPhong == phong.MaPhong);
            item.TenPhong = phong.TenPhong;
            item.TrangThai = phong.TrangThai;
            item.LoaiPhong = phong.LoaiPhong;
            item.MaLoai= phong.MaLoai;
            dbContext.SaveChanges();
        }
        public void UpdateLoaiPhong(LoaiPhong loaiPhong)
        {
            var item = dbContext.LoaiPhongs.FirstOrDefault(p => p.MaLoai == loaiPhong.MaLoai);
            item.TenLoaiPhong = loaiPhong.TenLoaiPhong;
            item.Gia = loaiPhong.Gia;
            dbContext.SaveChanges();
        }
        public void UpdateDichVu(DichVu dichVu)
        {
            var item = dbContext.DichVus.FirstOrDefault(p => p.MaDV == dichVu.MaDV);
            item.TenDV = dichVu.TenDV;
            item.GiaDV = dichVu.GiaDV;
            dbContext.SaveChanges();
        }
        public void UpdateCTHD(CT_HD cT_HD)
        {
            var item = dbContext.CT_HD.FirstOrDefault(p=> p.MaHD== cT_HD.MaHD && p.MaPhong == cT_HD.MaPhong);
            item.NgayTra = cT_HD.NgayTra;
            item.NgayThue = cT_HD.NgayThue;
            item.TinhTrang = cT_HD.TinhTrang;
            dbContext.SaveChanges();
        }
    }
}
