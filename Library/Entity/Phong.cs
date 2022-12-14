namespace Library.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            HD_DichVu = new HashSet<HD_DichVu>();
            CT_HD = new HashSet<CT_HD>();
        }

        [Key]
        public Guid MaPhong { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        public Guid MaTang { get; set; }

        public string TrangThai { get; set; }

        public Guid? MaLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HD_DichVu> HD_DichVu { get; set; }
        [ForeignKey("MaLoai")]
        public virtual LoaiPhong LoaiPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HD> CT_HD { get; set; }
        [ForeignKey("MaTang")]
        public virtual Tang Tang { get; set; }


    }
}
