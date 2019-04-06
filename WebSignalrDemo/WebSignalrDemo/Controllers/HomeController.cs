using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSignalrDemo.Models;

namespace WebSignalrDemo.Controllers
{
    public class HomeController : Controller
    {
        CharDb db = new CharDb();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var login = db.Users.Where(u => u.Username == user.Username).SingleOrDefault();
            if (login.Username==user.Username&&login.Password==user.Password)
            {
                Session["username"] = login.Username;
                Session["password"] = login.Password;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult Singin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Singin(User user,UserGroup userGroup)
        {
            if (ModelState.IsValid)
            {
                userGroup.UserId = user.UserId;
                userGroup.GroupId = 1;
                db.Users.Add(user);
                db.UserGroups.Add(userGroup);
                db.SaveChanges();
                Session["username"] = user.Username;
                Session["password"] = user.Password;
                
                return RedirectToAction("Index","Home");
                
            }
            return View(user);
        }
        public ActionResult UsernameList()
        {
            return View(db.Users.ToList());
        }
        public ActionResult deneme()
        {
            return View();
        }
    }
}