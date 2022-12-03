namespace Library.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CT_HDDV
    {
        [Column(TypeName = "date")]
        public DateTime? ThoiGianSD { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid MaDV { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MaHDDV { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual HD_DichVu HD_DichVu { get; set; }
    }
}
