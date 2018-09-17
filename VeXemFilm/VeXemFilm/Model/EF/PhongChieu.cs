namespace VeXemFilm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongChieu")]
    public partial class PhongChieu
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string TenPhongChieu { get; set; }

        [StringLength(50)]
        public string ViTri { get; set; }

        public int TongSoGhe { get; set; }
    }
}
