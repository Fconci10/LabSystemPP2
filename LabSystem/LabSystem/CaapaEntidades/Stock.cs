using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Stock
    {
        private int IdStock { get; set; }
        private Producto producto;
        private int IdProd { 
            get 
            {
              return producto.GetCodProducto();              
            } 
        }
        private int Cantidad { get; set; }

        private int? CantidadMin { get; set; }

        //geters
        public int GetIdStock() { return this.IdStock; }
        public int GetIdProd() { return this.IdProd; }
        public int GetCantidad() { return this.Cantidad; }
        public int? GetCantidadMin()
        {
            if (this.CantidadMin != null)
            {
                return this.CantidadMin;
            }
            else { return null; }
        }
        //seters
        public void SetIdStock(int idStock) { this.IdStock = idStock; }
        public void SetCantidad(int cantidad) { this.Cantidad = cantidad; }
        public void SetCantidadMin(int cantidadM) { this.CantidadMin = cantidadM; }
    }
}
