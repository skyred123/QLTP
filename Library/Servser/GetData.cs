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
            dbContext.Phongs.Include(e => e.HD_DichVu).Include(e => e.CT_HD).Include(e => e.LoaiPhong).Include(e => e.Tang).Load();
            dbContext.KhachHangs.Include(e => e.HopDongs).Load();
            dbContext.NhanViens.Include(e => e.ChucVu).Include(e => e.HopDongs).Include(e => e.Users).Load();
            dbContext.ChucVus.Include(e => e.NhanViens).Load();
            dbContext.Users.Include(e => e.NhanVien).Load();
            dbContext.KhachHangs.Include(e => e.HopDongs).Load();
            dbContext.Tangs.Include(e => e.Phongs).Load();
            dbContext.LoaiPhongs.Include(e => e.Phongs).Load();
            dbContext.CT_HD.Include(e => e.HopDong).Include(e => e.Phong).Load();
            dbContext.HD_DichVu.Include(e=>e.HopDong).Include(e=>e.CT_HDDV).Include(e=>e.Phong).Load();
            dbContext.HopDongs.Include(e=>e.HD_DichVu).Include(e=>e.NhanVien).Include(e=>e.KhachHang).Include(e=>e.CT_HD).Load();
            dbContext.CT_HDDV.Include(e=>e.DichVu).Include(e=>e.HD_DichVu).Load();
        }
        public List<ChucVu> GetChucVus()
        {
            return dbContext.ChucVus.ToList();
        }
        public ChucVu? GetChucVu(Guid id)
        {
            return GetChucVus().FirstOrDefault(e => e.MaCV == id);
        }
        public List<NhanVien> GetNhanViens()
        {
            return dbContext.NhanViens.ToList();
        }
        public NhanVien? GetNhanVien(string id)
        {
            return GetNhanViens().FirstOrDefault(e => e.MaNV == id);
        }
        public List<User> GetUsers()
        {
            return dbContext.Users.ToList();
        }
        public User? GetUser(Guid id)
        {
            return GetUsers().FirstOrDefault(e=>e.MaUser == id);
        }
        public List<KhachHang> GetKhachHangs() 
        {
            return dbContext.KhachHangs.ToList();
        }
        public KhachHang? GetKhachHang(string id)
        {
            return GetKhachHangs().FirstOrDefault(e => e.MaKH == id);
        }
        public List<Tang> GetTangs()
        {
            return dbContext.Tangs.ToList();
        }
        public Tang? GetTang(Guid id)
        {
            return GetTangs().FirstOrDefault(e=>e.MaTang == id);
        }
        public List<Phong> GetPhongs()
        {
            return dbContext.Phongs.ToList();
        }
        public Phong? GetPhong(Guid id)
        {
            return GetPhongs().FirstOrDefault(e => e.MaPhong == id);
        }
        public List<LoaiPhong> GetLoaiPhongs()
        {
            return dbContext.LoaiPhongs.ToList();
        }
        public LoaiPhong? GetLoaiPhong(Guid id)
        {
            return GetLoaiPhongs().FirstOrDefault(e => e.MaLoai == id);
        }
        public List<HopDong> GetHopDongs()
        {
            return dbContext.HopDongs.Include(e => e.NhanVien).Include(e => e.KhachHang).Include(e => e.CT_HD).ToList();
        }
        public HopDong GetHopDong(Guid id)
        {
            return GetHopDongs().FirstOrDefault(e => e.MaHD == id);
        }
        public List<CT_HD> GetCT_HDs()
        {
            return dbContext.CT_HD.ToList();
        }
        public CT_HD GetCT_HD(Guid id)
        {
            return GetCT_HDs().FirstOrDefault(e => e.MaHD == id);
        }
        public List<DichVu> GetDichVus()
        {
            return dbContext.DichVus.ToList();
        }
        public DichVu GetDichVu(Guid id)
        {
            return GetDichVus().FirstOrDefault(e => e.MaDV == id);
        }
    }
}
