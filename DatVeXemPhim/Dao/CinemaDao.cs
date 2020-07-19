using DatVeXemPhim.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatVeXemPhim.Dao
{
    public class CinemaDao
    {
        BookingTicketEntities2 db = null;
        public CinemaDao()
        {
            db = new BookingTicketEntities2();
        }
        public List<Cinema> ListRap()
        {
            return db.Cinemas.Where(x => x.Status == 1).ToList();
        }
        public Cinema XemChiTiet(int id)
        {
            return db.Cinemas.Find(id);
        }
    }
}