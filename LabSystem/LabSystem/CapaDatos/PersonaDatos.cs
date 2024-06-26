using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class PersonaDatos
    {

        public static int Insert(Persona p)//metodo para insertar Persona
        {

            int codigoPersona;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conString))
            {

                SqlCommand comando = new SqlCommand("PersonaInsert", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@DNI", p.getDni());
                comando.Parameters.AddWithValue("@cuit", p.getCuit());
                comando.Parameters.AddWithValue("@nombre", p.getNombre());
                comando.Parameters.AddWithValue("@apellido", p.getApellido());
                comando.Parameters.AddWithValue("@nombreCalle",p.getNombreCalle());
                comando.Parameters.AddWithValue("@numCalle", p.getNumCalle());
                comando.Parameters.AddWithValue("@CondicionFiscal", p.getCondicionFiscal());
                comando.Parameters.AddWithValue("@tipo", p.getTipo());

                try {
                    conexion.Open();
                    codigoPersona = int.Parse(Convert.ToString(comando.ExecuteScalar()));
                } catch(Exception ex) {
                    throw;
                }
                conexion.Close();
                return codigoPersona;
            }
        }

        public void PersonaUpdate(Persona p, int cp) {//metodo para actualizar La persona

            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand comando = new SqlCommand("PersonaUpdate", connection);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codPersona", cp);
                comando.Parameters.AddWithValue("@DNI", p.getDni());
                comando.Parameters.AddWithValue("@cuit", p.getCuit());
                comando.Parameters.AddWithValue("@nombre", p.getNombre());
                comando.Parameters.AddWithValue("@apellido", p.getApellido());
                comando.Parameters.AddWithValue("@nombreCalle", p.getNombreCalle());
                comando.Parameters.AddWithValue("@numCalle", p.getNumCalle());
                comando.Parameters.AddWithValue("@CondicionFiscal", p.getCondicionFiscal());
                comando.Parameters.AddWithValue("@tipo", p.getTipo());

                try
                {
                    connection.Open();
                    //Realizo el update
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                }
            }

        public int Borrar(int codPersona)//metodo para borrar cliente
        {
            int resultado;
            string conexionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {

                SqlCommand comando = new SqlCommand("PersonaDelete", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@codPersona", codPersona);

                try
                {
                    conexion.Open();
                    resultado = comando.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    throw;
                }
                conexion.Close();
                return resultado;
            }
        }

        public long Unico(Persona p)//metodo para verificar que el DNI y Cuit sean unicos
        {

            long codigoPersona;
            string codTexto = "";
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conString))
            {

                SqlCommand comando = new SqlCommand("PersonaUnica", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@DNI", p.getDni());
                comando.Parameters.AddWithValue("@cuit", p.getCuit());

                try
                {
                    conexion.Open();
                    codTexto = Convert.ToString(comando.ExecuteScalar());
                    codigoPersona = int.Parse(codTexto);
                }
                catch (Exception ex)
                {
                    throw;
                }
                conexion.Close();
                return codigoPersona;
            }
        }
    }
}
