using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class ProductoNegocio
    {
        public int Insertar(Producto p,int codProv,int codPer) {
            ProductoDatos productoDatos = new ProductoDatos();
            try { return productoDatos.Insert(p, codProv, codPer); } catch (Exception e) { throw; }         
        }

        public void Update(Producto p)
        {
            ProductoDatos productoDatos = new ProductoDatos();
            try {productoDatos.ProductoUpdate(p); } catch (Exception e) { throw; }
        }

        public List<Producto> ObtenerProductosProv(int codProv)
        {
            ProductoDatos productoDatos = new ProductoDatos();
            try { return productoDatos.GetAllProv(codProv); } catch (Exception e) { throw; }
        }

        public int BorrarProd(int codPrd) {
            ProductoDatos productoDatos = new ProductoDatos();
            try { return productoDatos.Borrar(codPrd); } catch (Exception e) { throw; }
        }

        public int Unico(int codPrd)
        {
            ProductoDatos productoDatos = new ProductoDatos();
            try { return productoDatos.ProductoUnico(codPrd); } catch (Exception e) { throw; }
        }
    }
}
