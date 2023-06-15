using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PadelictWebSite.Models;


namespace PadelictWebSite.Controllers
{


    

    public class RegistosController : Controller
    {




        private OurDbContext db1 = new OurDbContext();


        // GET: Registos
        public ActionResult registaratleta()
        {


            var concelhoslist = db1.Concelhos.ToList();
            ViewBag.ConcelhosList = new SelectList(concelhoslist, "IdConcelhos", "NomeConcelhos");



            






            List<string> direcoes = new List<string>()
            {
                "Direita",
                "Esquerda"
            };

            ViewBag.Direcoes = new SelectList(direcoes);
            

            List<string> pancadas = new List<string>()
            {
                "Retire",
                "Direita ou Traseira sem Parede",
                "Tomadas de parede",
                "Globo",
                "Chiquita",
                "Contraparede",
                "Vôlei",
                "Bandeja",
                "Viper",
                "Remate"

            };

            ViewBag.Pancadas = new SelectList(pancadas);

            List<string> tipojogo = new List<string>()
            {
                "Ofensivo",
                "Defensivo",
                "Misto"
                

            };

            ViewBag.Tipojogo = new SelectList(tipojogo);


            List<string> raquetes = new List<string>()
            {
                "Adidas",
                "Babolat",
                "Boomerang",
                "Bullpadel",
                "Drop shot",
                "Dunlop",
                "Endless",
                "Head",
                "Paddle Coach",
                "Puma",
                "Starvie",
                "Vibora",
                "VOLT PADEL",
                "Wilson"


            };
            ViewBag.Raquetes1 = new SelectList(raquetes);

            List<string> frequencia = new List<string>()
            {
                "1 vez por semana",
                "2 vezes por semana",
                "3 vezes por semana",
                "4 vezes por semana",
                "5 vezes por semana",
                "6 vezes por semana",
                "7 vezes por semana"



            };
            ViewBag.Frequencia1 = new SelectList(frequencia);

            List<string> diasemana = new List<string>()
            {
                "Segunda-Feira",
                "Terça-Feira",
                "Quarta-Feira",
                "Quinta-Feira",
                "Sexta-Feira",
                "Sábado",
                "Domingo",



            };
            ViewBag.DiaSemana = new SelectList(diasemana);

            List<string> altura = new List<string>()
            {
                "1,60",
                "1,61",
                "1,62",
                "1,63",
                "1,64",
                "1,65",
                "1,66",
                "1,67",
                "1,68",
                "1,69",
                "1,70",
                "1,71",
                "1,72",
                "1,73",
                "1,74",
                "1,75",
                "1,76",
                "1,77",
                "1,78",
                "1,79",
                "1,80",
                "1,81",
                "1,82",
                "1,83",
                "1,84",
                "1,85",
                "1,86",
                "1,87",
                "1,88",
                "1,89",
                "1,90",
                "1,91",
                "1,92",
                "1,93",
                "1,94",
                "1,95",
                "1,96",
                "1,97",
                "1,98",
                "1,99",
                "2,00",
                "2,01",
                "2,02",
                "2,03",
                "2,04",
                "2,05",
                "2,06",
                "2,07",
                "2,08",
                "2,09",
                "2,10"





            };
            ViewBag.Altura = new SelectList(altura);

            List<string> peso = new List<string>()
            {
                "60 kg",
                "61 kg",
                "62 kg",
                "63 kg",
                "64 kg",
                "65 kg",
                "66 kg",
                "67 kg",
                "68 kg",
                "69 kg",
                "70 kg",
                "71 kg",
                "72 kg",
                "73 kg",
                "74 kg",
                "75 kg",
                "76 kg",
                "77 kg",
                "78 kg",
                "79 kg",
                "80 kg",
                "81 kg",
                "82 kg",
                "83 kg",
                "84 kg",
                "85 kg",
                "86 kg",
                "87 kg",
                "88 kg",
                "89 kg",
                "90 kg",
                "91 kg",
                "92 kg",
                "93 kg",
                "94 kg",
                "95 kg",
                "96 kg",
                "97 kg",
                "98 kg",
                "99 kg",
                "100 kg",
                "101 kg",
                "102 kg",
                "103 kg",
                "104 kg",
                "105 kg",
                "106 kg",
                "107 kg",
                "108 kg",
                "109 kg",
                "110 kg",





            };
            ViewBag.Peso = new SelectList(peso);


            return View();
        }

        public ActionResult registartreinador()
        {

            var concelhoslist = db1.Concelhos.ToList();
            ViewBag.ConcelhosList = new SelectList(concelhoslist, "IdConcelhos", "NomeConcelhos");

            List<string> direcoes2 = new List<string>()
            {
                "Direita",
                "Esquerda"
            };

            ViewBag.Direcoes2 = new SelectList(direcoes2);



            List<string> pancadas2 = new List<string>()
            {
                "Retire",
                "Direita ou Traseira sem Parede",
                "Tomadas de parede",
                "Globo",
                "Chiquita",
                "Contraparede",
                "Vôlei",
                "Bandeja",
                "Viper",
                "Remate"

            };

            ViewBag.Pancadas2 = new SelectList(pancadas2);

            List<string> tipojogo2 = new List<string>()
            {
                "Ofensivo",
                "Defensivo",
                "Misto"


            };

            ViewBag.Tipojogo2 = new SelectList(tipojogo2);


            List<string> raquetes2 = new List<string>()
            {
                "Adidas",
                "Babolat",
                "Boomerang",
                "Bullpadel",
                "Drop shot",
                "Dunlop",
                "Endless",
                "Head",
                "Paddle Coach",
                "Puma",
                "Starvie",
                "Vibora",
                "VOLT PADEL",
                "Wilson"


            };
            ViewBag.Raquetes2 = new SelectList(raquetes2);

            List<string> frequencia2 = new List<string>()
            {
                "1x/semana",
                "2x/semana",
                "3x/semana",
                "4x/semana",
                "5x/semana",
                "6x/semana",
                "7x/semana",



            };

            ViewBag.Frequencia2 = new SelectList(frequencia2);

            List<string> diasemana = new List<string>()
            {
                "Segunda-Feira",
                "Terça-Feira",
                "Quarta-Feira",
                "Quinta-Feira",
                "Sexta-Feira",
                "Sábado",
                "Domingo",



            };
            ViewBag.DiaSemana = new SelectList(diasemana);

            List<string> altura = new List<string>()
            {
                "1,60",
                "1,61",
                "1,62",
                "1,63",
                "1,64",
                "1,65",
                "1,66",
                "1,67",
                "1,68",
                "1,69",
                "1,70",
                "1,71",
                "1,72",
                "1,73",
                "1,74",
                "1,75",
                "1,76",
                "1,77",
                "1,78",
                "1,79",
                "1,80",
                "1,81",
                "1,82",
                "1,83",
                "1,84",
                "1,85",
                "1,86",
                "1,87",
                "1,88",
                "1,89",
                "1,90",
                "1,91",
                "1,92",
                "1,93",
                "1,94",
                "1,95",
                "1,96",
                "1,97",
                "1,98",
                "1,99",
                "2,00",
                "2,01",
                "2,02",
                "2,03",
                "2,04",
                "2,05",
                "2,06",
                "2,07",
                "2,08",
                "2,09",
                "2,10"





            };
            ViewBag.Altura = new SelectList(altura);

            List<string> peso = new List<string>()
            {
                "60 kg",
                "61 kg",
                "62 kg",
                "63 kg",
                "64 kg",
                "65 kg",
                "66 kg",
                "67 kg",
                "68 kg",
                "69 kg",
                "70 kg",
                "71 kg",
                "72 kg",
                "73 kg",
                "74 kg",
                "75 kg",
                "76 kg",
                "77 kg",
                "78 kg",
                "79 kg",
                "80 kg",
                "81 kg",
                "82 kg",
                "83 kg",
                "84 kg",
                "85 kg",
                "86 kg",
                "87 kg",
                "88 kg",
                "89 kg",
                "90 kg",
                "91 kg",
                "92 kg",
                "93 kg",
                "94 kg",
                "95 kg",
                "96 kg",
                "97 kg",
                "98 kg",
                "99 kg",
                "100 kg",
                "101 kg",
                "102 kg",
                "103 kg",
                "104 kg",
                "105 kg",
                "106 kg",
                "107 kg",
                "108 kg",
                "109 kg",
                "110 kg",





            };
            ViewBag.Peso = new SelectList(peso);

            return View();
        }

        public ActionResult registarclube()
        {

            var concelhoslist = db1.Concelhos.ToList();
            ViewBag.ConcelhosList = new SelectList(concelhoslist, "IdConcelhos", "NomeConcelhos");

            List<string> numerario = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20"




            };
            ViewBag.Numerario = new SelectList(numerario);


            return View();
        }

        [HttpPost]
        public ActionResult registaratleta(registos regatl)
        {

            

            if (ModelState.IsValid)
            {
                db1.Registos.Add(regatl);
                db1.SaveChanges();
                return RedirectToAction("Login", "Home");
            }
            else
            {
                return View();
            }

           
        }

        [HttpPost]
        public ActionResult registartreinador(registos regtrei)
        {
            if (ModelState.IsValid)
            {
                db1.Registos.Add(regtrei);
                db1.SaveChanges();
                return RedirectToAction("Login", "Home");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult registarclube(registos regclub)
        {
            if (ModelState.IsValid)
            {
                db1.Registos.Add(regclub);
                db1.SaveChanges();
                return RedirectToAction("Login", "Home");
            }
            else
            {
                return View();
            }
        }
       




    }
}