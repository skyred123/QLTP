using Library.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<BangGia> BangGias { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HD_DichVu> HD_DichVu { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CT_HD> CT_HD { get; set; }
        public virtual DbSet<CT_HDDV> CT_HDDV { get; set; }
        public ApplicationDbContext()
            : base(getApplicationDbContext())
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);;
            // Customize the ASP.NET Core Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Core Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<CT_HD>().HasKey(x => new { x.MaHD, x.MaPhong });
            builder.Entity<CT_HDDV>().HasKey(x => new { x.MaDV, x.MaHDDV });
        }
        public static DbContextOptions<ApplicationDbContext> getApplicationDbContext()
        {
            String con= @"Server=DESKTOP-K5EGHTF\SQLEXPRESS;Database=QLTP;User Id=sa;Password=sa;";
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(con).Options;
            return contextOptions;
        }
    }
}
