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
        public void AddHopDong(HopDong hd)
        {
            dbContext.HopDongs.Add(hd);
            dbContext.SaveChanges();
        }
        public void AddCT_HD(CT_HD ct_hd)
        {
            dbContext.CT_HD.Add(ct_hd);
            dbContext.SaveChanges();
        }
        public void AddDichVu(DichVu dichVu)
        {
            dbContext.DichVus.Add(dichVu);
            dbContext.SaveChanges();
        }
        public void AddHD_DichVu(HD_DichVu hddv)
        {
            dbContext.HD_DichVu.Add(hddv);
            dbContext.SaveChanges();
        }
        public void AddCT_HDDV(CT_HDDV ct_hddv)
        {
            dbContext.CT_HDDV.Add(ct_hddv);
            dbContext.SaveChanges();
        }
    }
}
