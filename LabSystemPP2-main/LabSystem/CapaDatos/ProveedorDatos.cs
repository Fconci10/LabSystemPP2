using CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProveedorDatos
    {
        public int InsertarProvDatos(Proveedor pro)
        {//metodo para insertar un nuevo proveedor

            int codProv = 0;

            string conexionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {

                SqlCommand comando = new SqlCommand("ProveedorInsert", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codPersona", pro.getCodPersona());
                comando.Parameters.AddWithValue("@razonSocial", pro.GetRazonSocial());
                comando.Parameters.AddWithValue("descripcion",pro.GetDescripcion());

                try
                {
                    conexion.Open();
                    codProv = Convert.ToInt32(comando.ExecuteScalar());
                    Console.WriteLine(codProv);
                }
                catch (Exception)
                {
                    throw;
                }
                conexion.Close();
                return codProv;
            }

        }

        public List<Proveedor> GetAll()//metodo para recibir a todos los clientes de la base de datos
        {
            List<Proveedor> list = new List<Proveedor>();
            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand("ProveedorGetAll", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //recorra la bd y amaceno cada cliente en un objeto de tipo cliente, luego los cargo en una lista del mismo tipo
                    while (reader.Read())
                    {
                        Proveedor prov = new Proveedor();
                        prov.SetCodProveedor(Convert.ToInt32(reader["codProveedor"]));
                        prov.setCodPersona(Convert.ToInt32(reader["codPersona"]));
                        //a los valores que son nulos, los almaceno como 0 cero o como ""
                        if (reader["DNI"].GetType() == typeof(DBNull)) { prov.setDni(0); }
                        else
                        {
                            prov.setDni(Convert.ToInt32(reader["DNI"]));
                        }

                        if (reader["cuit"].GetType() == typeof(DBNull)) { prov.setCuit(0); }
                        else
                        {
                            prov.setCuit((long)double.Parse(Convert.ToString(reader["cuit"])));
                        }

                        prov.setNombre(Convert.ToString(reader["nombre"]));

                        if (reader["apellido"].GetType() == typeof(DBNull)) { prov.setApellido(""); }
                        else
                        {
                            prov.setApellido(Convert.ToString(reader["apellido"]));
                        }

                        prov.setNombreCalle(Convert.ToString(reader["nombreCalle"]));

                        prov.setNumCalle(Convert.ToInt32(reader["numCalle"]));

                        if (reader["CondicionFiscal"].GetType() == typeof(DBNull)) { prov.setCondicionFiscal(""); }
                        else
                        {
                            prov.setCondicionFiscal(Convert.ToString(reader["CondicionFiscal"]));
                        }

                        if (reader["razonSocial"].GetType() == typeof(DBNull)) { prov.SetRazonSocial(""); }
                        else
                        {
                            prov.SetRazonSocial(Convert.ToString(reader["razonSocial"]));
                        }

                        prov.setTipo(Convert.ToInt32(reader["tipo"]));
                        prov.SetDescripcion(Convert.ToString(reader["descripcionProveedor"]));

                        list.Add(prov);
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

        public void Update(Proveedor p)
        {
            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("ProveedorUpdate", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@codpersona", p.getCodPersona());
                command.Parameters.AddWithValue("@razonsocial", p.GetRazonSocial());
                command.Parameters.AddWithValue("@descripcion", p.GetDescripcion());
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

        public int Borrar(int codProv)
        {
            int resultado;
            string conexionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {

                SqlCommand comando = new SqlCommand("ProveedorDelete", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@cdProv", codProv);

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

        public Proveedor BuscarProveedor(long dniOCuit) {
            Proveedor prov = new Proveedor();
            string conString = System.Configuration.ConfigurationManager.
           ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand("BuscarProveedor", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DNI",dniOCuit);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //recorra la bd y amaceno cada cliente en un objeto de tipo cliente, luego los cargo en una lista del mismo tipo
                    while (reader.Read())
                    {
                        if (reader["codProveedor"].GetType() == typeof(DBNull))
                        {
                            return prov;
                        }
                        else { prov.SetCodProveedor(Convert.ToInt32(reader["codProveedor"])); }
                    
                        prov.setCodPersona(Convert.ToInt32(reader["codPersona"]));
                        //a los valores que son nulos, los almaceno como 0 cero o como ""
                        if (reader["DNI"].GetType() == typeof(DBNull)) { prov.setDni(0); }
                        else
                        {
                            prov.setDni(Convert.ToInt32(reader["DNI"]));
                        }

                        if (reader["cuit"].GetType() == typeof(DBNull)) { prov.setCuit(0); }
                        else
                        {
                            prov.setCuit((long)double.Parse(Convert.ToString(reader["cuit"])));
                        }

                        prov.setNombre(Convert.ToString(reader["nombre"]));

                        if (reader["apellido"].GetType() == typeof(DBNull)) { prov.setApellido(""); }
                        else
                        {
                            prov.setApellido(Convert.ToString(reader["apellido"]));
                        }

                        prov.setNombreCalle(Convert.ToString(reader["nombreCalle"]));

                        prov.setNumCalle(Convert.ToInt32(reader["numCalle"]));

                        if (reader["CondicionFiscal"].GetType() == typeof(DBNull)) { prov.setCondicionFiscal(""); }
                        else
                        {
                            prov.setCondicionFiscal(Convert.ToString(reader["CondicionFiscal"]));
                        }

                        if (reader["razonSocial"].GetType() == typeof(DBNull)) { prov.SetRazonSocial(""); }
                        else
                        {
                            prov.SetRazonSocial(Convert.ToString(reader["razonSocial"]));
                        }

                        prov.setTipo(Convert.ToInt32(reader["tipo"]));
                        prov.SetDescripcion(Convert.ToString(reader["descripcionProveedor"]));
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return prov;
        }
    }
}
