using Library.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface DeleteData_Interface
    {
         void DeleteUser(User user);
         void DeleteNV(NhanVien nv);
    }
}
