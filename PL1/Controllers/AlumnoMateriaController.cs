using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL1.Controllers
{
    public class AlumnoMateriaController : Controller
    {
        // GET: AlumnoMateria
        public ActionResult GetAll()
        {
            return View();
        }
    }
}