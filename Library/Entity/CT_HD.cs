namespace Library.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CT_HD
    {
        [Column(TypeName = "date")]
        public DateTime? NgayThue { get; set; }
        public DateTime? NgayTra { get; set; }
        [Key]
        [Column(Order = 0)]
        public Guid MaPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MaHD { get; set; }

        public virtual HopDong HopDong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
