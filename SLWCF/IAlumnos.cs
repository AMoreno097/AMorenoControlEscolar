using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAlumnos" in both code and config file together.
    [ServiceContract]
    public interface IAlumnos
    {
        [OperationContract]
        SLWCF.Result GetAll();
        [OperationContract]
        SLWCF.Result GetById(int IdAlumno);
        [OperationContract]
        SLWCF.Result Add(ML.alumnos Alumnos);
        [OperationContract]
        SLWCF.Result Update(ML.alumnos Alumnos);
        [OperationContract]
        SLWCF.Result Delete(int IdAlumno);
    }
}
