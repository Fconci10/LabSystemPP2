using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class EmpleadoDatos
    {
        public Empleado GetEmpleadoUsuario(int codUsuario) 
        {
            Empleado empleado = new Empleado();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(conString))
            {
                SqlCommand comando = new SqlCommand("LoginEmpleadoGet", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@codUsuario", codUsuario);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        empleado.setDni(Convert.ToInt32(reader["DNI"]));
                        empleado.setNombre(Convert.ToString(reader["nombre"]));
                        empleado.setApellido(Convert.ToString(reader["apellido"]));
                        empleado.setNombreCalle(Convert.ToString(reader["nombreCalle"]));
                        empleado.setNumCalle(Convert.ToInt32(reader["numCalle"]));
                        empleado.setCondicionFiscal(Convert.ToString(reader["CondicionFiscal"]));
                        empleado.SetHorarioIngreso(Convert.ToString(reader["horarioIngreso"]));
                        empleado.SetHorarioEngreso(Convert.ToString(reader["horarioEgreso"]));
                        empleado.SetEmpeladoID(Convert.ToInt32(reader["EmpleadoID"]));
                        empleado.setCodPersona(Convert.ToInt32(reader["codPersona"]));
                        empleado.SetcodUsuario(Convert.ToInt32(reader["codUsuarios"]));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }
                conexion.Close();
                return empleado;
            }
        }

        public void CargarTipo(Empleado empleado) 
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(conString))
            {
                SqlCommand comando = new SqlCommand("EmpleadoTipoGetAll", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idEmpleado", empleado.GetEmpleadoID());

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["descEmpleado"].GetType() != typeof(DBNull)) 
                        {
                            empleado.SetTipoEmpleado(Convert.ToString(reader["descEmpleado"]));
                        }
                        else { empleado.SetTipoEmpleado(""); }
                        
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }
                conexion.Close();
            }
        }
    }
}
