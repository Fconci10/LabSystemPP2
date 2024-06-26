using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class EmpleadoNegocio
    {
        EmpleadoDatos ED = new EmpleadoDatos();

        public Empleado GetUsuarioLogin(int codUsu) 
        {
            try { return ED.GetEmpleadoUsuario(codUsu); }catch (Exception ex) { throw; }
        }
        public void CargarTipo(Empleado empleado) {
            ED.CargarTipo(empleado);
        }
    }
}
