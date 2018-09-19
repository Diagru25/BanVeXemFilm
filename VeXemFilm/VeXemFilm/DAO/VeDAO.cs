﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeXemFilm.Model.EF;

namespace VeXemFilm.DAO
{
    public class VeDAO
    {
        VeXemPhimDbContext db = null;

        public VeDAO()
        {
            db = new VeXemPhimDbContext();
        }

        public bool AddVe(Ve item)
        {
            try
            {
                db.Ves.Add(item);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool RemoveVe(DateTime ngaychieu, long phongchieuid, TimeSpan tgBatDau, TimeSpan tgKetThuc, long phimid, string soghe)
        {
            try
            {
                var list = (from a in db.LichChieux
                            join b in db.Ves
                            on a.ID equals b.LichChieuID
                            where (a.NgayChieu == ngaychieu && a.PhimID == phimid && a.PhongChieuID == phongchieuid &&
                             a.ThoiGianBatDau == tgBatDau && a.ThoiGianKetThuc == tgKetThuc && b.SoGhe == soghe
                             )
                            select new
                            {
                                b.ID
                            }).ToList();

                foreach(var item in list)
                {
                    db.Ves.Remove(db.Ves.Find(item.ID));
                }
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
