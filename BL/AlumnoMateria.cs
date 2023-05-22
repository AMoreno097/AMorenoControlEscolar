using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AlumnoMateria
    {
        public static ML.Result GetMateriaAsignada(int IdAlumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection contex = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    String query = "AlumnoGetMateriaAsignada";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = contex;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdAlumno", SqlDbType.Int);
                        collection[0].Value = IdAlumno;
                        cmd.Parameters.AddRange(collection);

                        DataTable tableMaterias = new DataTable();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {


                            da.Fill(tableMaterias);
                            if (tableMaterias.Rows.Count > 0)
                            {
                                result.Objects = new List<object>();
                                foreach (DataRow row in tableMaterias.Rows)
                                {

                                    ML.materias Materias = new ML.materias();
                                    Materias.IdMaterias = int.Parse(row[0].ToString());
                                    Materias.Nombre = row[1].ToString();
                                    Materias.Costo = decimal.Parse(row[2].ToString());

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
                }
            }
            catch
            {

            }
            return result;
        }
        public static ML.Result GetMateriaNoAsiganda(int IdAlumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection contex = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    String query = "AlumnoGetMateriaNoAsignada";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = contex;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdAlumno", SqlDbType.Int);
                        collection[0].Value = IdAlumno;
                        cmd.Parameters.AddRange(collection);

                        DataTable tableMaterias = new DataTable();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {


                            da.Fill(tableMaterias);
                            if (tableMaterias.Rows.Count > 0)
                            {
                                result.Objects = new List<object>();
                                foreach (DataRow row in tableMaterias.Rows)
                                {

                                    ML.materias Materias = new ML.materias();
                                    Materias.IdMaterias = int.Parse(row[0].ToString());
                                    Materias.Nombre = row[1].ToString();
                                    Materias.Costo = decimal.Parse(row[2].ToString());

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
                }
            }
            catch
            {

            }
            return result;
        }
    }
}
