namespace VeXemFilm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phim")]
    public partial class Phim
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string TenPhim { get; set; }

        public int? ThoiLuong { get; set; }

        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }
    }
}
