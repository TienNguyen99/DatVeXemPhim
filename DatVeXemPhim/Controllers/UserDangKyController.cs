using DatVeXemPhim.Areas.Admin.Models;
using DatVeXemPhim.Common;
using DatVeXemPhim.Dao;
using DatVeXemPhim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatVeXemPhim.Controllers
{
    public class UserDangKyController : Controller
    {
        // GET: UserDangKy
        [HttpGet]
        public ActionResult Register()
        {
            
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult Logout()
        {
            Session[Constants.USER_SESSION] = null;
            return RedirectToAction("Index", "Home");
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Logon(model.UserName, model.Password);
                if(result){
                    var user = dao.GetByID(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.Username;
                    userSession.CusId = user.CusId;
                    Session.Add(Constants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không thành công");
                }
            }
            else
            {

            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Register(Dangky model)
        {
            if(ModelState.IsValid)
            {
                
                var dao = new UserDao();
                if (dao.CheckUserName(model.Username))
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if (dao.CheckEmail(model.Email))
                {
                    ModelState.AddModelError("", "Email đã tồn tại");
                }
                else
                {
                    var user = new Customer();
                    user.Username = model.Username;
                    user.FullName = model.Fullname;
                    user.Password = model.Password;
                    user.CreditCard = model.CreditCard;
                    user.Address = model.Address;
                    user.Bod = model.bod;
                    user.Status = 1;
                    user.Phone = model.Phone;
                    user.Avata = model.Avata;
                    user.Email = model.Email;
                    var result = dao.Insert(user);
                    if(result > 0)
                    {
                        ViewBag.Success = "Đăng ký thành công";
                        model = new Dangky();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký không thành công");
                    }
                }

            }
            return View(model);
        }

    }
}