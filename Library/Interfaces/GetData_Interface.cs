using Library.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface GetData_Interface
    {
        List<ChucVu> GetChucVus();
        ChucVu? GetChucVu(Guid id);
        List<NhanVien> GetNhanViens();
        NhanVien? GetNhanVien(string id);
        List<User> GetUsers();
        User? GetUser(Guid id);
    }
}
