using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empleado:Persona
    {
        private int EmpleadoID { get; set; }
        private string horarioIngreso { get; set; }
        private string horarioEgreso { get; set; }
        private List<string> tipoEmpleado { get; set; }=new List<string>();
        private int codUsuario { get; set; }

        //getters

        public int GetEmpleadoID() { return this.EmpleadoID; }
        public string GetHorariroIngreso() {  return this.horarioIngreso; }
        public string GetEmpleadoEgreso() { return this.horarioEgreso; }  
        public List<string> GetTipoEmpleado() { return this.tipoEmpleado; }
        public int GetcodUsuario() { return this.codUsuario; }

        //setters
        public void SetEmpeladoID(int empId) { this.EmpleadoID = empId; }
        public void SetHorarioIngreso(string hi) { this.horarioIngreso = hi; }
        public void SetHorarioEngreso(string he) { this.horarioEgreso = he; }
        public void SetTipoEmpleado(string te) { this.tipoEmpleado.Add(te); }
        public void SetcodUsuario(int cu) { this.codUsuario = cu; }

    }
}
