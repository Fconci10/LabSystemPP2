using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class ClienteNegocio
    {
        public int Insertar(Cliente c) { 
            ClienteDatos cd = new ClienteDatos();
            return cd.InsertarCliDatos(c);
        }

        public List<Cliente> RecibirTodos() {
            ClienteDatos cd = new ClienteDatos();
            return cd.GetAll();
        }

        public void updateC(Cliente c) {
            ClienteDatos cd = new ClienteDatos();
            cd.Update(c);
        }

        public int BorrarC(int idCli) {
            ClienteDatos cd = new ClienteDatos();
            return cd.Borrar(idCli);
        }
    }
}
