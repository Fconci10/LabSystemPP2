using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDatos
    {
        public int Insert(Producto p,int codProv,int codPer)//metodo para insertar Persona
        {

            int codProd;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conString))
            {

                SqlCommand comando = new SqlCommand("ProductoInsert", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codProd", p.GetCodProducto());
                comando.Parameters.AddWithValue("@nombre", p.GetNombre());
                comando.Parameters.AddWithValue("@dia", p.GetDia());
                comando.Parameters.AddWithValue("@mes", p.GetMes());
                comando.Parameters.AddWithValue("@anio", p.GetAnio());
                comando.Parameters.AddWithValue("@desc", p.GetDescripcion());
                comando.Parameters.AddWithValue("@preVent", p.GetPrecioVenta());
                comando.Parameters.AddWithValue("@preComp", p.GetPrecioCompra());
                comando.Parameters.AddWithValue("@tipo", p.GetTipo());
                comando.Parameters.AddWithValue("@cantidad", p.GetCantidad());
                comando.Parameters.AddWithValue("@codProv", codProv);
                comando.Parameters.AddWithValue("@codPer", codPer);

                try
                {
                    conexion.Open();
                    codProd =Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw;
                }
                conexion.Close();
                return codProd;
            }
        }

        public List<Producto> GetAllProv(int codProv)//metodo para recibir a todos los clientes de la base de datos
        {
            List<Producto> list = new List<Producto>();
            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand("ProductoProveedorGetAll", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@codProv",codProv);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //recorra la bd y amaceno cada cliente en un objeto de tipo cliente, luego los cargo en una lista del mismo tipo
                    while (reader.Read())
                    {
                        Producto prod = new Producto();
                        prod.SetCodProducto(Convert.ToInt32(reader["CodigoProducto"]));
                        prod.SetNombre(Convert.ToString(reader["nombreProducto"]));
                        prod.SetDia(Convert.ToInt32(reader["VenciDia"]));
                        prod.SetMes(Convert.ToInt32(reader["VenciMes"]));
                        prod.SetAnio(Convert.ToInt32(reader["VenciAnio"]));
                        prod.SetDescripcion(Convert.ToString(reader["descripProducto"]));
                        prod.SetPrecioVenta( Convert.ToInt32(reader["PrecioVenta"]));
                        prod.SetPrecioCompra(Convert.ToInt32(reader["PrecioDeCompra"]));
                        prod.SetCantidad(Convert.ToInt32(reader["cantidadStock"]));
                        prod.SetTipo(Convert.ToInt32(reader["tipo"]));
                        list.Add(prod);
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

        public void ProductoUpdate(Producto p)
        {//metodo para actualizar La persona

            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand comando = new SqlCommand("ProductoUpdate", connection);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codProd", p.GetCodProducto());
                comando.Parameters.AddWithValue("@nombre", p.GetNombre());
                comando.Parameters.AddWithValue("@dia", p.GetDia());
                comando.Parameters.AddWithValue("@mes", p.GetMes());
                comando.Parameters.AddWithValue("@anio", p.GetAnio());
                comando.Parameters.AddWithValue("@desc", p.GetDescripcion());
                comando.Parameters.AddWithValue("@preVent", p.GetPrecioVenta());
                comando.Parameters.AddWithValue("@preComp", p.GetPrecioCompra());
                comando.Parameters.AddWithValue("@tipo", p.GetTipo());
                comando.Parameters.AddWithValue("@cantidad", p.GetCantidad());
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



        public int Borrar(int codProducto)//metodo para borrar cliente
        {
            int resultado;
            string conexionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {

                SqlCommand comando = new SqlCommand("ProductoDelete", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@codProducto", codProducto);

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

        public int ProductoUnico(int codProd) {

            int resultado;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conString))
            {

                SqlCommand comando = new SqlCommand("ProductoUnico", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codProd", codProd);

                try
                {
                    conexion.Open();
                    resultado = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw;
                }
                conexion.Close();
                return resultado;
            }
        }
    
    }
}
