using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeXemFilm.Model.EF;

namespace VeXemFilm.DAO
{
    public class PhongChieuDAO
    {
        VeXemPhimDbContext db = null;

        public PhongChieuDAO()
        {
            db = new VeXemPhimDbContext();
        }

        public List<PhongChieu> GetAll()
        {
            return db.PhongChieux.ToList();
        }

        public bool AddPhongChieu(PhongChieu item)
        {
            try
            {
                db.PhongChieux.Add(item);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditPhongChieu(PhongChieu item)
        {
            try
            {
                PhongChieu temp = db.PhongChieux.Find(item.ID);
                temp.TenPhongChieu = item.TenPhongChieu;
                temp.ViTri = item.ViTri;
                temp.TongSoGhe = item.TongSoGhe;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemovePhongChieu(long id)
        {
            try
            {
                db.PhongChieux.Remove(db.PhongChieux.Find(id));

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
