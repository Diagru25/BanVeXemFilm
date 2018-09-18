using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeXemFilm.Model.EF;
using VeXemFilm.Model.View;

namespace VeXemFilm.DAO
{
    public class DatVeDAO
    {
        VeXemPhimDbContext db = null;

        public DatVeDAO()
        {
            db = new VeXemPhimDbContext();
        }


        public List<string> LaySoGheDaDat(DateTime ngaychieu, long phongchieuid, string giochieu, long phimid)
        {
            var li = (from a in db.LichChieux
                             join b in db.Ves
                             on a.ID equals b.LichChieuID
                             where (a.NgayChieu == ngaychieu && a.PhongChieuID == phongchieuid
                             && a.PhimID == phimid && giochieu == (((TimeSpan)a.ThoiGianBatDau).ToString() + ((TimeSpan)a.ThoiGianKetThuc).ToString()))
                             select new
                             {
                                 b = b.SoGhe //ví dụ ghế A1, B3 ....
                             }).ToList();
            List<string> listSoGhe = new List<string>();
            foreach (var item in li)
            {
                listSoGhe.Add(item.ToString());
            }
            return listSoGhe;
        }

        public List<DatVeView> LichChieuTheoNgay(DateTime ngaychieu)
        {
            var list = (from a in db.LichChieux
                        join b in db.PhongChieux
                        on a.PhongChieuID equals b.ID
                        join c in db.Phims
                        on a.PhimID equals c.ID
                        where (a.NgayChieu == ngaychieu)
                        select new DatVeView()
                        {
                            ID = a.ID,
                            PhongChieuID = b.ID,
                            PhimID = c.ID,
                            TenPhim = c.TenPhim,
                            PhongChieu = b.TenPhongChieu,
                            GiaVe = a.GiaVe,
                            GioChieu = "",
                            TongSoVe = b.TongSoGhe,
                            SoVeConLai = b.TongSoGhe,
                            tgBatDau = a.ThoiGianBatDau,
                            tgKetThuc = a.ThoiGianKetThuc,
                        }).ToList();

            foreach(DatVeView item in list)
            {
                List<string> listSoGhe = LaySoGheDaDat(ngaychieu, item.PhongChieuID, item.GioChieu, item.PhimID);

                item.GioChieu = ((TimeSpan)item.tgBatDau).ToString(@"hh\:mm") + " - " + ((TimeSpan)item.tgKetThuc).ToString(@"hh\:mm");

                int soghedadat = listSoGhe.Count();
                item.SoVeConLai = item.SoVeConLai - soghedadat;
            }
            return list;
        }

    }
}
