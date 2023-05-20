using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SLWebApi.Controllers
{
    public class MateriaController : ApiController
    {
        // GET: Materia
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/Materia/GetAll")]
        public IHttpActionResult GetAll()
        {

            ML.Result result = BL.Materias.GetAll();
            if (result.Correct)
            {
                return Ok(result.Objects);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result.ErrorMessage);
            }
            //return View();
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Materia/Delete")]
        public IHttpActionResult Delete([FromBody] int IdUsuario)
        {

            ML.Result result = BL.Materias.Delete(IdUsuario);
            if (result.Correct)
            {
                return Ok(result.Objects);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result.ErrorMessage);
            }
            //return View();
        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Materia/Add")]
        public IHttpActionResult Add([FromBody] ML.materias Materias)
        {

            ML.Result result = BL.Materias.Add(Materias);
            if (result.Correct)
            {
                return Ok(result.Objects);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result.ErrorMessage);
            }
            //return View();
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/Materia/GetById/{id}")]
        public IHttpActionResult GetById(int id)
        {

            ML.Result result = BL.Materias.GetById(id);
            if (result.Correct)
            {
                return Ok(result.Object);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result.ErrorMessage);
            }
            //return View();
        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Materia/Update/{id}")]
        public IHttpActionResult Update(int id, [FromBody] ML.materias Materias)
        {
            Materias.IdMaterias = id;

            ML.Result result = BL.Materias.Update(Materias);
            if (result.Correct)
            {
                return Ok(result.Objects);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result.ErrorMessage);
            }
            //return View();
        }
    }
}