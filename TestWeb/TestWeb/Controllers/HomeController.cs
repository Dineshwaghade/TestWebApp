using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWeb.Models;

namespace TestWeb.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var data = db.Users.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User usr)
        {
            db.Users.Add(usr);
            db.SaveChanges();
            return View();
        }
    }
}