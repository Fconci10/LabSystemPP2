using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class VentaNegocio
    {
        public List<Producto> GetListado() {
            try {
                VentaDatos vd = new VentaDatos();
                return vd.GetListadoProducto();
            } catch (Exception ex) { throw; } 
        }

        public Stock GetStock(int codProd)
        {
            try
            {
                VentaDatos vd = new VentaDatos();
                return vd.GetListadoStock(codProd);
            }
            catch (Exception ex) { throw; }
        }

        public void ActuStock(int idStock, int cantidad) {
            try
            {
                VentaDatos vd = new VentaDatos();
                vd.ActualizarStock(idStock,cantidad);
            }
            catch (Exception ex) { throw; }
        }

        public void ProducAgotado(int idStock) {
            try
            {
                VentaDatos vd = new VentaDatos();
                vd.ProductoAgotado(idStock);
            }
            catch (Exception ex) { throw; }
        }
    }
}
