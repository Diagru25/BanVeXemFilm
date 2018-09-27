using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeXemFilm.Model.EF;

namespace VeXemFilm.DAO
{
    public class TheLoaiDAO
    {
        VeXemPhimDbContext db = null;

        public TheLoaiDAO()
        {
            db = new VeXemPhimDbContext();
        }

        public List<TheLoai> GetAll()
        {
            return db.TheLoais.ToList();
        }

        public bool AddTheLoai(TheLoai item)
        {
            try
            {
                db.TheLoais.Add(item);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditTheLoai(TheLoai item)
        {
            try
            {
                TheLoai temp = db.TheLoais.Find(item.ID);
                temp.TenTheLoai = item.TenTheLoai;
                temp.GhiChu = item.GhiChu;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveTheLoai(long id)
        {
            try
            {
                db.TheLoais.Remove(db.TheLoais.Find(id));

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
