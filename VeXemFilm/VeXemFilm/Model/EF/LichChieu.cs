namespace VeXemFilm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichChieu")]
    public partial class LichChieu
    {
        public long ID { get; set; }

        public TimeSpan? ThoiGianBatDau { get; set; }

        public TimeSpan? ThoiGianKetThuc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayChieu { get; set; }

        public decimal? GiaVe { get; set; }

        public long? PhongChieuID { get; set; }

        public long? PhimID { get; set; }
    }
}
