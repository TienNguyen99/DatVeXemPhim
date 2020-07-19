using DatVeXemPhim.Areas.Admin.Models;
using DatVeXemPhim.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace DatVeXemPhim.Dao
{
    
    public class UserDao
    {
        BookingTicketEntities2 db = null;
        public UserDao()
        {
            db = new BookingTicketEntities2();
        }
        public bool Logon(string userName , string passWord)
        {
            var result = db.Customers.Count(x => x.Username == userName && x.Password == passWord);
            if (result > 0){
                return true;
            }
            else
            {
                return false;
            }
        }
        public Customer GetByID(string userName)
        {
            return db.Customers.SingleOrDefault(x => x.Username == userName);
        }
        public bool CheckUserName (string userName)
        {
            return db.Customers.Count(x => x.Username == userName) > 0;
        }
        public bool CheckEmail(string email)
        {
            return db.Customers.Count(x => x.Email == email) > 0;
        }
        public int Insert(Customer entity)
        {
            try
            {
                db.Customers.Add(entity);
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }



            return entity.CusId;
        }
    }
}