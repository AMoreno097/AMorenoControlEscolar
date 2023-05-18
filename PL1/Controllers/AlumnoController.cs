using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class AlumnoController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.alumnos Alumnos = new ML.alumnos();
            ML.Result result = BL.Alumnos.GetAll();



            Alumnos.Alumnos = result.Objects;

            return View(Alumnos);
        }

    }
}