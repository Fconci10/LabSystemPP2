using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente:Persona
    {
        private long? codPersona { get; set; }
        private int? idCliente { get; set; }
        private string? razonSocial { get; set; }

        //geters
        public long? getCodPersona() { return this.codPersona; }
        public int? getIdCliente() {  return this.idCliente; }
        public string getRazoSocial() { if (this.razonSocial != null) { return this.razonSocial; }else { return ""; } }

        //seters
        public void setCodPersona(long cp) { codPersona = cp; }
        public void setIdCliente(int idCl) { idCliente = idCl; }
        public void setRazonSocial(string rz) { razonSocial = rz; }

    }
}
