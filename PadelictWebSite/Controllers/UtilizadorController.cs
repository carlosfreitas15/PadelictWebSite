using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PadelictWebSite.Models;

namespace PadelictWebSite.Controllers
{
    public class UtilizadorController : Controller
    {
        private OurDbContext db = new OurDbContext();



        public ActionResult Registo()
        {
            return View();
        }

    }
}