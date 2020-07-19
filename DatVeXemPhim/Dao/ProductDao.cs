using System;
using System.Collections.Generic;
using System.Linq;
using DatVeXemPhim.Areas.Admin.Models;
using System.Web;

namespace DatVeXemPhim.Dao
{
    public class ProductDao
    {
        BookingTicketEntities2 db = null;

        public ProductDao()
        {
            db = new BookingTicketEntities2();
        }
        public List<Film> ListNewFilm()
        {
            return db.Films.Where(x=>x.Status == 1).ToList();
        }
        public List<Film> ListPhimSapChieu()
        {
            return db.Films.Where(x => x.Status == 1).OrderByDescending(x => x.CreatedDate).ToList();
        }
        public Film ViewDetail(long id)
        {
            return db.Films.Find(id);
        }
    }

}