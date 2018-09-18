using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeXemFilm.Model.View
{
    public class LichChieuView
    {
        public long ID { get; set; }
        public TimeSpan ThoiGianBatDau { get; set; }
        public TimeSpan ThoiGianKetThuc { get; set; }
        public DateTime NgayChieu { get; set; }
        public long IDPhim { get; set; }
        public string TenPhim { get; set; }
        public long IDPhongChieu { get; set; }
        public string TenPhongChieu { get; set; }
        public Decimal GiaVe { get; set; }
    }
}
