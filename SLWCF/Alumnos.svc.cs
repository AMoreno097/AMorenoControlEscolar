using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Alumnos" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Alumnos.svc or Alumnos.svc.cs at the Solution Explorer and start debugging.
    
    public class Alumnos : IAlumnos
    {
        public SLWCF.Result GetAll()
        {
            ML.Result result = BL.Alumnos.GetAll();

            return new SLWCF.Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Object = result.Object,
                Objects = result.Objects
            };
        }

        public SLWCF.Result GetById(int IdAlumno)
        {
            ML.Result result = BL.Alumnos.GetById(IdAlumno);

            return new SLWCF.Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Object = result.Object,
                Objects = result.Objects
            };
        }

        public SLWCF.Result Add(ML.alumnos Alumnos)
        {
            ML.Result result = BL.Alumnos.Add(Alumnos);

            return new SLWCF.Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Object = result.Object,
                Objects = result.Objects
            };
        }
        public SLWCF.Result Update(ML.alumnos Alumnos)
        {
            ML.Result result = BL.Alumnos.Update(Alumnos);

            return new SLWCF.Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Object = result.Object,
                Objects = result.Objects
            };
        }
        public SLWCF.Result Delete(int IdAlumno)
        {
            ML.Result result = BL.Alumnos.Delete(IdAlumno);

            return new SLWCF.Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Object = result.Object,
                Objects = result.Objects
            };
        }

    }
}
