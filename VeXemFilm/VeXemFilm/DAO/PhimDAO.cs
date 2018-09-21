using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeXemFilm.Model.EF;
using VeXemFilm.Model.View;

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
                temp.KhoiChieu = item.KhoiChieu;

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
        public List<ThongKeView> ThongKe(DateTime _start, DateTime _end)
        {
            var LichChieu = (from a in db.Ves
                             join b in db.LichChieux on a.LichChieuID equals b.ID
                             join c in db.Phims on b.PhimID equals c.ID 
                             where a.NgayMua >= _start && a.NgayMua <= _end
                             select new ThongKeView()
                             {
                                 PhimID = (long)b.PhimID,
                                 DoanhThu = (decimal)b.GiaVe,
                                 KhoiChieu = (DateTime)c.KhoiChieu,
                                 TenPhim = c.TenPhim,
                                 ThoiLuong = (int)c.ThoiLuong
                             }).OrderBy(x=>x.PhimID).ToList();
            List<ThongKeView> res = new List<ThongKeView>();
            ThongKeView temp = new ThongKeView();
            foreach (var item in LichChieu)
            {
                item.s_KhoiChieu = item.KhoiChieu.ToString("dd-MM-yyyy");
                if(temp.PhimID == 0)
                {
                    temp = item;
                }
                else if(item.PhimID == temp.PhimID)
                {
                    temp.DoanhThu += item.DoanhThu;
                }
                else
                {
                    temp.sDoanhThu = String.Format("{0:C}", temp.DoanhThu).Replace("$", "").Split('.')[0] + "đ";
                    res.Add(temp);
                    temp = item;
                }
            }
            temp.sDoanhThu = String.Format("{0:C}", temp.DoanhThu).Replace("$", "").Split('.')[0] + "đ";
            res.Add(temp);
            return res;
        }
    }
}
