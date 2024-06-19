using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class VentaDatos
    {
        public List<Producto> GetListadoProducto() { 
            List<Producto> lista = new List<Producto>();

            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conString)) {

                SqlCommand comando = new SqlCommand("ProductoVenta",conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                try {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.SetCodProducto(Convert.ToInt32(reader["CodigoProducto"]));
                        producto.SetNombre(Convert.ToString(reader["nombreProducto"]));
                        producto.SetDescripcion(Convert.ToString(reader["descripProducto"]));
                        producto.SetPrecioVenta(Convert.ToDecimal(reader["PrecioVenta"]));
                        lista.Add(producto);
                    }
                }catch (Exception ex) { throw; }

                conexion.Close();
                return lista;
            }
        }

        public Stock GetListadoStock(int codProd)
        {
            Stock stock = new Stock();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conString))
            {

                SqlCommand comando = new SqlCommand("ProductoStock",conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@codProd",codProd);
                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        stock.SetIdStock(Convert.ToInt32(reader["IdStock"]));
                        stock.SetCantidad(Convert.ToInt32(reader["cantidadStock"]));
                        stock.SetCantidadMin(Convert.ToInt32(reader["cantMinStock"]));
                    }
                }
                catch (Exception ex) { throw; }

                conexion.Close();
                return stock;
            }
        }

        public void ActualizarStock(int idStock,int cantidad) {
            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand comando = new SqlCommand("StockUpdate", connection);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idStock", idStock);
                comando.Parameters.AddWithValue("@cantiARest", cantidad);

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

        public void ProductoAgotado(int idStock) {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand comando = new SqlCommand("ProductoAgotado", connection);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idStock", idStock);

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
    }
}
