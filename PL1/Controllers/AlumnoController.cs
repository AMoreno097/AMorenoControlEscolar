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
        [HttpGet]
        public ActionResult GetMateriaAsignada(int? IdAlumno)
        {
           
                ML.Result result = BL.AlumnoMateria.GetMateriaAsignada(IdAlumno.Value);
                ML.AlumnoMateria alumnoMateria = new ML.AlumnoMateria();
                if (result.Correct)
                {
                ML.Result resultAlumno = BL.Alumnos.GetById(IdAlumno.Value);
                alumnoMateria.AlumnoMaterias = result.Objects;
                    alumnoMateria.Alumnos = ((ML.alumnos)resultAlumno.Object);
                    return View(alumnoMateria);
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al hacer la consulta del usuario " + result.ErrorMessage;
                    return View("Modal");
                }
            
        }

        [HttpGet]
        public ActionResult GetMateriaNoAsignada(int? IdAlumno)
        {
            ML.Result result = BL.AlumnoMateria.GetMateriaNoAsiganda(IdAlumno.Value);
            ML.AlumnoMateria alumnomateria = new ML.AlumnoMateria();

            ML.Result resultalumno = BL.Alumnos.GetById(IdAlumno.Value);

            alumnomateria.AlumnoMaterias = result.Objects;
            alumnomateria.Alumnos = ((ML.alumnos)resultalumno.Object);

            return View(alumnomateria);
        }
        //[HttpPost]

        //public ActionResult GetMateriaSinAsignar(ML.AlumnoMateria alumnomateria)
        //{
        //    ML.Result result = new ML.Result();
        //    if (alumnomateria.AlumnoMaterias != null)
        //    {
        //        foreach (string IdMateria in alumnomateria.AlumnoMaterias)
        //        {
        //            ML.AlumnoMateria alumnomateriaItem = new ML.AlumnoMateria();

        //            alumnomateriaItem.Alumno = new ML.Alumno();
        //            alumnomateriaItem.Alumno.IdAlumno = alumnomateria.Alumno.IdAlumno;

        //            alumnomateriaItem.Materia = new ML.Materia();
        //            alumnomateriaItem.Materia.IdMateria = int.Parse(IdMateria);

        //            ML.Result resul = BL.AlumnoMateria.Add(alumnomateriaItem);
        //        }
        //        result.Correct = true;
        //        ViewBag.Message = "Se ha actualizado al alumno";
        //        ViewBag.MateriasAsignadas = true;
        //        ViewBag.IdAlumno = alumnomateria.Alumno.IdAlumno;
        //    }
        //    else
        //    {
        //        result.Correct = false;
        //    }
        //    return PartialView("Modal");
        //}

    }
}