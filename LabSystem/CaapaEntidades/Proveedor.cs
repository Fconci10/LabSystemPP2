using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Proveedor:Persona
    {
        private int CodProveedor { get; set; }
        //private int CodPersona { get; set; }
        private string? RazonSocial { get; set; }
        private string Descripcion { get; set; }

        //geters
        public int GetCodProveedor() { return this.CodProveedor; }
        //public int getCodPersona() { return this.CodPersona; }
        public string GetRazonSocial() { if (this.RazonSocial != null) { return this.RazonSocial; } else { return ""; } }
        public string GetDescripcion() {  return this.Descripcion; }

        //seters
        //public void SetCodPersona(long cp) { codPersona = cp; }
        public void SetCodProveedor(int cdProv) { this.CodProveedor = cdProv; }
        public void SetRazonSocial(string rs) { this.RazonSocial = rs; }
        public void SetDescripcion(string desc) { this.Descripcion = desc; }
    }
}
