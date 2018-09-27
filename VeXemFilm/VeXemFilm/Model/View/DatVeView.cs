using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeXemFilm.Model.View
{
    public class DatVeView
    {
        public long ID { get; set; }

        // giờ chiếu = tgbatdau + " - " + tgketthuc
        public string GioChieu { get; set; }

        public long PhongChieuID { get; set; }

        public string PhongChieu { get; set; }

        public long PhimID { get; set; }

        public string TenPhim { get; set; }

        public decimal? GiaVe { get; set; }

        public int? TongSoVe { get; set; }

        public int? SoVeConLai { get; set; }

        public TimeSpan? tgBatDau { get; set; }

        public TimeSpan? tgKetThuc { get; set; }
    }
}
