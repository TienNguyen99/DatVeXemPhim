using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatVeXemPhim.Areas.Admin.Models;
namespace DatVeXemPhim.Dao
{
    
    public class BookingDao
    {
        BookingTicketEntities2 db = null;
        public BookingDao()
        {
            db = new BookingTicketEntities2();
        }
        public List<Cinema> ListAllCinema()
        {
            return db.Cinemas.Where(x => x.Status == 1).ToList();
        }
        public List<ShowTime> ListLichChieu()
        {
            return db.ShowTimes.Where(x => x.Status == 1).ToList();
        }
        public Film ViewDetail(long id)
        {
            return db.Films.Find(id);
        }
    }
}