namespace Library.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ChucVu")]
    public partial class ChucVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        public Guid MaCV { get; set; }

        public bool Quyen { get; set; }

        [StringLength(50)]
        public string TenCV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
