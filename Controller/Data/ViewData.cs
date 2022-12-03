using Controller.Form_Controller;
using Library.Entity;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Data
{
    public class ViewData
    {

        private static ViewData instance;
        public static ViewData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ViewData();
                }
                return instance;
            }
        }
        internal static NhanVien? nhanVien { get; set; }
        public NhanVien? GetNhanVien() => nhanVien;
        internal static ChucVu? chucVu { get; set; }
        public ChucVu? GetChucVu() => chucVu;
        internal static bool add { get; set; }
        public void SetAdd()
        {
            update = false;
            add = true;
        }
        public bool GetAdd => add;
        internal static bool update { get; set; }
        public void SetUpdate(NhanVien nv)
        {
            add = false;
            update = true;
            nhanVienEdit = nv;
        }
        public bool GetUpdate() => update;
        internal static NhanVien? nhanVienEdit { get; set; }
        public NhanVien? GetNhanVienEdit() => nhanVienEdit;
    }
}
