using System;
using System.Collections.Generic;
using System.Linq;
using DatVeXemPhim.Areas.Admin.Models;
using System.Web;

namespace DatVeXemPhim.Dao
{
    public class ProductDao
    {
        BookingTicketEntities1 db = null;

        public ProductDao()
        {
            db = new BookingTicketEntities1();
        }
        public List<Film> ListNewFilm()
        {
            return db.Films.Where(x=>x.Status == 1).ToList();
        }
    }

}