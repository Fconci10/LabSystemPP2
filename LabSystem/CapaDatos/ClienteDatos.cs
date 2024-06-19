using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ClienteDatos
    {
        public int InsertarCliDatos(Cliente c) {//metodo para insertar un nuevo cliente

            int idCliente = 0;

            string conexionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conexionString)) { 
                
                SqlCommand comando = new SqlCommand("ClientesInsert", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codPersona",c.getCodPersona());
                comando.Parameters.AddWithValue("@razonSocial",c.getRazoSocial());

                try {
                    conexion.Open();
                    idCliente = Convert.ToInt32(comando.ExecuteScalar());
                    Console.WriteLine(idCliente);
                }catch (Exception) {
                    throw;
                }
                conexion.Close();
                return idCliente;
            }

        }

        public List<Cliente> GetAll()//metodo para recibir a todos los clientes de la base de datos
        {
            List<Cliente> list = new List<Cliente>();
            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand("ClientesGetAll", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //recorra la bd y amaceno cada cliente en un objeto de tipo cliente, luego los cargo en una lista del mismo tipo
                    while (reader.Read())
                    {
                        Cliente cli = new Cliente();
                        cli.setIdCliente(Convert.ToInt32(reader["idCliente"]));
                        cli.setCodPersona(Convert.ToInt32(reader["codPersona"]));
                        //a los valores que son nulos, los almaceno como 0 cero o como ""
                        if (reader["DNI"].GetType() == typeof(DBNull)) { cli.setDni(0); } 
                        else 
                        {
                            cli.setDni(Convert.ToInt32(reader["DNI"]));
                        }

                        if (reader["cuit"].GetType()==typeof(DBNull)) { cli.setCuit(0); }
                        else
                        {
                            cli.setCuit((long)double.Parse(Convert.ToString(reader["cuit"])));
                        }

                        cli.setNombre(Convert.ToString(reader["nombre"]));

                        if (reader["apellido"].GetType() == typeof(DBNull)) { cli.setApellido(""); }
                        else
                        {
                            cli.setApellido(Convert.ToString(reader["apellido"]));
                        }

                        cli.setNombreCalle(Convert.ToString(reader["nombreCalle"]));

                        cli.setNumCalle(Convert.ToInt32(reader["numCalle"]));

                        if (reader["CondicionFiscal"].GetType() == typeof(DBNull)) { cli.setCondicionFiscal(""); }
                        else
                        {
                            cli.setCondicionFiscal(Convert.ToString(reader["CondicionFiscal"]));
                        }

                        if (reader["razonSocial"].GetType() == typeof(DBNull)) { cli.setRazonSocial(""); }
                        else
                        {
                            cli.setRazonSocial(Convert.ToString(reader["razonSocial"]));
                        }

                        cli.setTipo(Convert.ToInt32(reader["tipo"]));

                        list.Add(cli);
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return list;
        }

        public void Update(Cliente c) {
            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("ClienteUpdate", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@codpersona", c.getCodPersona());
                command.Parameters.AddWithValue("@razonsocial", c.getRazoSocial());
                try
                {
                    connection.Open();
                    //Realizo el update
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int Borrar(int IdCliente) {
            int resultado;
            string conexionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conexionString)) {

                SqlCommand comando = new SqlCommand("CientesDelete",conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idCiente",IdCliente);

                try { 
                    conexion.Open();
                    resultado=comando.ExecuteNonQuery();

                }catch (Exception) {
                    throw;
                }
                conexion.Close();
                return resultado;
            }
        }

    }
}
