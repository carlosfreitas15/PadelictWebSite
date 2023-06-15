using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PadelictWebSite.Models;

namespace PadelictWebSite.Controllers
{
    public class PerfilController : Controller
    {
        private OurDbContext db = new OurDbContext();

        public ActionResult Perfil()
        {
            return View();
        }

        public ActionResult Avaliacao()
        {
            List<string> modonotifica = new List<string>()
            {
                "sms",
                "email"
            };


            ViewBag.ModoNotifica1 = new SelectList(modonotifica);

            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Avaliacao(Avaliacao ava)
        {
            if (ModelState.IsValid)
            {
                db.Avaliacao.Add(ava);
                db.SaveChanges();
                return RedirectToAction("Perfil", "Perfil");
            }
            else
            {
                return View();
            }
        }

    }
}