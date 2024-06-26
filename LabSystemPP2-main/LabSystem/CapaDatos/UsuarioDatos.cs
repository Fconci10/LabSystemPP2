using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class UsuarioDatos
    {
        public int IngresarUsuario(Usuario usuario)
        {
            int codUsu=0;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(conString))
            {
                SqlCommand comando = new SqlCommand("LoginUsuario", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@usuario", usuario.GetNombreUsuario());
                comando.Parameters.AddWithValue("@clave", usuario.GetClave());

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        codUsu = Convert.ToInt32(reader["codUsuarios"]);
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                conexion.Close();
                return codUsu;
            }
        }

        public Usuario UsuarioUpadate(int codUsu,string nombre,string clave) { 
        
            Usuario usuario = new Usuario();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(conString))
            {
                SqlCommand comando = new SqlCommand("UsuarioUpdate", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@codUsuario", codUsu);
                comando.Parameters.AddWithValue("@nomUsu", nombre);
                comando.Parameters.AddWithValue("@clave", clave);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        usuario.SetNombreUsuario(Convert.ToString(reader["nombreUsuario"]));
                        usuario.SetCalve(Convert.ToString(reader["contrasenia"]));
                        usuario.SetCodigo(Convert.ToInt32(reader["codUsuarios"]));
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                conexion.Close();
                return usuario;
            }
        }
    }
}
