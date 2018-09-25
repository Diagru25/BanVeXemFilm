using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeXemFilm.Model.View
{
    public class ThongKeView
    {
        public long PhimID { get; set; }
        public string TenPhim { get; set; }
        public int ThoiLuong { get; set; }
        public DateTime KhoiChieu { get; set; }
        public string s_KhoiChieu { get; set; }
        public decimal DoanhThu { get; set; }
        public string sDoanhThu { get; set; }

    }
}
