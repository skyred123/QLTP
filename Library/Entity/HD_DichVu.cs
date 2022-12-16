namespace Library.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class HD_DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HD_DichVu()
        {
            CT_HDDV = new HashSet<CT_HDDV>();
        }

        [Key]
        public Guid MaHDDV { get; set; }

        public long? TongTien { get; set; }

        
        public Guid MaPhong { get; set; }

        [ForeignKey("MaPhong")]
        public virtual Phong Phong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HDDV> CT_HDDV { get; set; }

        
    }
}
