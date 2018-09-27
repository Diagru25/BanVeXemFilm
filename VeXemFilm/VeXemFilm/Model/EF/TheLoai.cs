namespace VeXemFilm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheLoai")]
    public partial class TheLoai
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string TenTheLoai { get; set; }

        [Column(TypeName = "ntext")]
        public string GhiChu { get; set; }
    }
}
