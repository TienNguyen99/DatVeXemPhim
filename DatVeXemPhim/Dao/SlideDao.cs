using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatVeXemPhim.Areas.Admin.Models;
namespace DatVeXemPhim.Dao
{
    
    public class SlideDao
    {
        BookingTicketEntities1 db = null;
        public SlideDao()
        {
            db = new BookingTicketEntities1();

        }
        public List<Slide> ListAll()
        {
            return db.Slides.Where(x => x.Status == 1).ToList();
        }
    }
}