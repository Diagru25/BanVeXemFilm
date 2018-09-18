using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeXemFilm.Model.EF;
using VeXemFilm.Model.View;

namespace VeXemFilm.DAO
{
    public class LichChieuDAO
    {
        VeXemPhimDbContext db = null;
        public LichChieuDAO()
        {
            db = new VeXemPhimDbContext();
        }

        public List<LichChieuView> LichChieuDetails()
        {
            var data = from a in db.LichChieux
                       join b in db.Phims on a.PhimID equals b.ID
                       join c in db.PhongChieux on a.PhongChieuID equals c.ID
                       select new LichChieuView()
                       {
                           ID = a.ID,
                           TenPhim = b.TenPhim,
                           GiaVe = (Decimal)a.GiaVe,
                           NgayChieu = (DateTime)a.NgayChieu,
                           TenPhongChieu = c.TenPhongChieu,
                           ThoiGianBatDau = (TimeSpan)a.ThoiGianBatDau,
                           ThoiGianKetThuc = (TimeSpan)a.ThoiGianKetThuc,
                           IDPhim = (long)a.PhimID,
                           IDPhongChieu = (long)a.PhongChieuID
                       };
            return data.ToList();
        }
        public bool Insert(LichChieu item)
        {
            try
            {
                db.LichChieux.Add(item);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Edit(LichChieu item)
        {
            try
            {
                var dbEntry = db.LichChieux.SingleOrDefault(x => x.ID == item.ID);
                dbEntry.PhongChieuID = item.PhongChieuID;
                dbEntry.ThoiGianBatDau = item.ThoiGianBatDau;
                dbEntry.ThoiGianKetThuc = item.ThoiGianKetThuc;
                dbEntry.GiaVe = item.GiaVe;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(long id)
        {
            try
            {
                var dbEntry = db.LichChieux.SingleOrDefault(x => x.ID == id);
                db.LichChieux.Remove(dbEntry);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
