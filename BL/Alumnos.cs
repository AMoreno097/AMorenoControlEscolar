using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Alumnos
    {
        public static ML.Result Delete(int IdAlumno)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "AlumnosDelete";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdAlumno", SqlDbType.TinyInt);
                        collection[0].Value = IdAlumno;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected >= 1)
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
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }
            return new ML.Result();


        }

        public static ML.Result Update(ML.alumnos Alumnos)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "AlumnoUpdate";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[4];

                        collection[0] = new SqlParameter("IdAlumno", SqlDbType.TinyInt);
                        collection[0].Value = Alumnos.IdAlumnos;

                        collection[1] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[1].Value = Alumnos.Nombre;

                        collection[2] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                        collection[2].Value = Alumnos.ApellidoPaterno;

                        collection[3] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                        collection[3].Value = Alumnos.ApellidoMaterno;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();


                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected >= 1)
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


            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;
        }
        public static ML.Result Add(ML.alumnos Alumnos)
        {
            ML.Result result = new ML.Result();

            try
            {

                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "AlumnoAdd";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;


                        SqlParameter[] collection = new SqlParameter[3];

                        collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[0].Value = Alumnos.Nombre;

                        collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                        collection[1].Value = Alumnos.ApellidoPaterno;

                        collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                        collection[2].Value = Alumnos.ApellidoMaterno;
                        
                        cmd.Parameters.AddRange(collection);

                        cmd.Connection.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected >= 1)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Ocurrió un error al ingresar al usuario";
                        }

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
        public static ML.Result GetById(int IdAlumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection contex = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    String query = "AlumnoGetById";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = contex;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdAlumno", SqlDbType.Int);
                        collection[0].Value = IdAlumno;
                        cmd.Parameters.AddRange(collection);

                        DataTable tableAlumno = new DataTable();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {


                            da.Fill(tableAlumno);
                            if (tableAlumno.Rows.Count > 0)
                            {

                                DataRow row = tableAlumno.Rows[0];

                                ML.alumnos Alumnos = new ML.alumnos();
                                Alumnos.IdAlumnos = int.Parse(row[0].ToString());
                                Alumnos.Nombre = row[1].ToString();
                                Alumnos.ApellidoPaterno = row[2].ToString();
                                Alumnos.ApellidoMaterno = row[3].ToString();
                                
                                result.Object = Alumnos;


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
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection contex = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "AlumnoGetAll";

                    using (SqlCommand cmd = contex.CreateCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = contex;
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable tableAlumno = new DataTable();


                            da.Fill(tableAlumno);
                            if (tableAlumno.Rows.Count > 0)
                            {
                                result.Objects = new List<object>();

                                foreach (DataRow row in tableAlumno.Rows)
                                {
                                    ML.alumnos Alumnos = new ML.alumnos();
                                    Alumnos.IdAlumnos = int.Parse(row[0].ToString());
                                    Alumnos.Nombre = row[1].ToString();
                                    Alumnos.ApellidoPaterno = row[2].ToString();
                                    Alumnos.ApellidoMaterno = row[3].ToString();

                                    result.Objects.Add(Alumnos);

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
