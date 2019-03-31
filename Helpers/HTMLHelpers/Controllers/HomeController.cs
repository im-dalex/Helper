using HTMLHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Personas()
        {
            return View();
        }

        public ActionResult DetallePersonas(datosPersona persona)
        {
            return View(persona);
        }
    }
}