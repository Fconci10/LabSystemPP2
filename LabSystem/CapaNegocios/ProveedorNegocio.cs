using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ProveedorNegocio
    {
        public int Insertar(Proveedor p)
        {
            ProveedorDatos pr = new ProveedorDatos();
            return pr.InsertarProvDatos(p);
        }

        public List<Proveedor> RecibirTodos()
        {
            ProveedorDatos pr = new ProveedorDatos();
            return pr.GetAll();
        }

        public void UpdatePRV(Proveedor p)
        {
            ProveedorDatos pr = new ProveedorDatos();
            pr.Update(p);
        }

        public int BorrarPRV(int codProv)
        {
            ProveedorDatos pr = new ProveedorDatos();
            return pr.Borrar(codProv);
        }
    }
}
