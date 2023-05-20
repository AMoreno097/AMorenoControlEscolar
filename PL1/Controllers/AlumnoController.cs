using PL1.ServiceAlumno;
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
            ML.alumnos Alumno = new ML.alumnos();  
            AlumnosClient alumnoClient = new AlumnosClient();
            var resultGetAll = alumnoClient.GetAll();
            Alumno.Alumnos = resultGetAll.Objects.ToList();
            return View(Alumno);
        }

    }
}