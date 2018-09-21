using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeXemFilm.Model.View
{
    public class VeView
    {
        public long ID { get; set; }
        public string TenPhim { get; set; }
        public DateTime Ngay { get; set; }
        public string PhongChieu { get; set; }
        public string SoGhe { get; set; }
        public TimeSpan BatDau { get; set; }
        public Decimal GiaVe { get; set; }
    }
}
