using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Materias
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AMorenoControlEscolarEntities1 context = new DL.AMorenoControlEscolarEntities1())
                {

                    var query = context.MateriaGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in query)
                        {
                            ML.materias Materias = new ML.materias();
                            Materias.IdMaterias = obj.IdMateria;
                            Materias.Nombre = obj.Nombre;
                            Materias.Costo = obj.Costo.Value;
                            result.Objects.Add(Materias);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se puedo obtener la tabla";
                    }

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;

        }
        public static ML.Result GetById(int IdMaterias)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AMorenoControlEscolarEntities1 context = new DL.AMorenoControlEscolarEntities1())
                {
                    var obj = context.MateriaGetById(IdMaterias).FirstOrDefault();
                    result.Object = new List<object>();
                    if (obj != null)
                    {

                        ML.materias Materias = new ML.materias();
                        Materias.IdMaterias = obj.IdMateria;
                        Materias.Nombre = obj.Nombre;
                        Materias.Costo = obj.Costo.Value;
                        result.Object = Materias;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se puedo obtener la tabla";
                    }
                }
            }
            catch
            {

            }
            return result;

        }
        public static ML.Result Add(ML.materias Materias)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AMorenoControlEscolarEntities1 context = new DL.AMorenoControlEscolarEntities1())
                {
                    int filasAfectadas = context.MateriaAdd(Materias.Nombre, Materias.Costo);
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }
            return result;
        }
        public static ML.Result Update(ML.materias Materias)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AMorenoControlEscolarEntities1 context = new DL.AMorenoControlEscolarEntities1())
                {
                    int query = context.MateriaUpDate(Materias.IdMaterias, Materias.Nombre, Materias.Costo);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error al modificar al usuario";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;
        }
        public static ML.Result Delete(int IdMateria)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL.AMorenoControlEscolarEntities1 context = new DL.AMorenoControlEscolarEntities1())
                {
                    var query = context.MateriaDelete(IdMateria);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error al eliminar al usuario";
                    }
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }
            return new ML.Result();

        }
    }
}
