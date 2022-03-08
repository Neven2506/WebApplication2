using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class MojPrviController : Controller
    {
        // GET: MojPrvi
        public ActionResult Index()
        {
            ViewBag.Lokacija = "Međimursko veleučilište u Čakovcu";
            return View();
        }

        public ActionResult Druga()
        {
            ViewBag.Ustanova = "Međimursko veleučilište";
            ViewData["Lokacija"] = "Čakovec";
            return View();
        }
        public ActionResult Treca(string poruka, int broj=1)
        {
            ViewBag.Poruka = poruka;

        }
        public ActionResult Student(string ime, string prezime, int GodinaRrodenja)
        {
            ViewBag.Ime = ime;
            ViewBag.Prezime = prezime;
            ViewBag
        }
    }
}