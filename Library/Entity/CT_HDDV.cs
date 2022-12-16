namespace Library.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CT_HDDV
    {
        [Column(TypeName = "date")]
        public DateTime? NgayDat { get; set; }

        [Column(TypeName = "int")]
        public int SoLuong { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid MaDV { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MaHDDV { get; set; }

        [ForeignKey("MaDV")]
        public virtual DichVu DichVu { get; set; }
        [ForeignKey("MaHDDV")]
        public virtual HD_DichVu HD_DichVu { get; set; }
    }
}
