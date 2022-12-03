namespace Library.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User")]
    public partial class User
    {
        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? Password { get; set; }

        [Key]
        public Guid MaUser { get; set; }

        [StringLength(10)]
        public string? MaNV { get; set; }

        [ForeignKey("MaNV")]
        public virtual NhanVien? NhanVien { get; set; }
    }
}
