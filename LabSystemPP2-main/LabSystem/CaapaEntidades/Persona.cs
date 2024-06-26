using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Persona
    {
        private int CodPersona { get; set; }
        private int? Dni { get; set; }
        private long? Cuit { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string NombreCalle { get; set; }
        private int NumCalle { get; set; }
        private string? CondicionFiscal { get; set; }
        private int Tipo { get; set; }

        //geters
        public int getCodPersona() { return this.CodPersona; }
        public long getDni() { if (this.Dni!= null) { return (long)this.Dni; } else { return 0; } }
        public long getCuit() { if (this.Cuit != null) { return (long)this.Cuit; } else { return 0; } }
        public string getNombre() { return this.Nombre; }
        public string getApellido() { if (this.Apellido != null) { return this.Apellido; } else { return ""; } }
        public string getNombreCalle() { return this.NombreCalle; }
        public int getNumCalle() { return this.NumCalle; }
        public string getCondicionFiscal() { if (this.CondicionFiscal != null) { return this.CondicionFiscal; } else { return ""; } }
        public int getTipo() { return this.Tipo; }

        //seters
        public void setCodPersona(int codP) { this.CodPersona=codP; }
        public void setDni(int dniP) { this.Dni = dniP; }
        public void setCuit(long cuit) { this.Cuit = cuit; }
        public void setNombre(string nom) { this.Nombre = nom; }
        public void setApellido(string ape) { this.Apellido = ape; }
        public void setNombreCalle(string nomC) { this.NombreCalle=nomC; }
        public void setNumCalle(int numC) { this.NumCalle=numC; }
        public void setCondicionFiscal(string cf) { this.CondicionFiscal=cf; }
        public void setTipo(int tipoC) { this.Tipo = tipoC; }
    }
}
