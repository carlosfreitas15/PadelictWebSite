using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PadelictWebSite.Models;

namespace PadelictWebSite.Controllers
{
    public class HomeController : Controller
    {
        private OurDbContext db = new OurDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

       



    }
}