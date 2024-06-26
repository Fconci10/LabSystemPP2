using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        private string nombreUsuario { get; set; }
        private string clave { get; set; }
        private int codigo { get; set; }

        //getters

        public string GetNombreUsuario() { return this.nombreUsuario; }
        public string GetClave() { return this.clave; }
        public int GetCodigo() {  return this.codigo; }

        //setters

        public void SetNombreUsuario(string nomUsu) { this.nombreUsuario = nomUsu; }
        public void SetCalve(string clave) { this.clave = clave; }
        public void SetCodigo(int codigo) { this.codigo = codigo; }
    }
}
