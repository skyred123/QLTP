namespace Library.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DichVu")]
    public partial class DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVu()
        {
            CT_HDDV = new HashSet<CT_HDDV>();
        }

        [Key]
        public Guid MaDV { get; set; }

        [StringLength(50)]
        public string TenDV { get; set; }

        public long? GiaDV { get; set; }

        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HDDV> CT_HDDV { get; set; }
    }
}
