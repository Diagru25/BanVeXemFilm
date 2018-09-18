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

<<<<<<< HEAD
        public DateTime KhoiChieu { get; set; }

=======
        public DateTime? KhoiChieu { get; set; }
>>>>>>> 0469441bf9d2a9fa09746f0dc7d1a789a7fd3573
    }
}
