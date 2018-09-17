using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeXemFilm.Model.EF;

namespace VeXemFilm.DAO
{
    public class PhimDAO
    {
        VeXemPhimDbContext db = null;

        public PhimDAO()
        {
            db = new VeXemPhimDbContext();
        }

        public List<Phim> GetAll()
        {
            return db.Phims.ToList();
        }

        public bool AddPhim(Phim item)
        {
            try
            {
                db.Phims.Add(item);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditPhim(Phim item)
        {
            try
            {
                Phim temp = db.Phims.Find(item.ID);
                temp.TenPhim = item.TenPhim;
                temp.ThoiLuong = item.ThoiLuong;
                temp.MoTa = item.MoTa;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemovePhim(long id)
        {
            try
            {
                db.Phims.Remove(db.Phims.Find(id));

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
