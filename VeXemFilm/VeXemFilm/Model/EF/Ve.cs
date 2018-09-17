namespace VeXemFilm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ve")]
    public partial class Ve
    {
        public long ID { get; set; }

        public long? LichChieuID { get; set; }

        [StringLength(50)]
        public string SoGhe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMua { get; set; }
    }
}
