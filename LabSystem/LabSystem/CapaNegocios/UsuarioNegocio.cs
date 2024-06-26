using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class UsuarioNegocio
    {

        public int IngresoUsuario(Usuario usuario) {
            UsuarioDatos ud = new UsuarioDatos();
            try{ return ud.IngresarUsuario(usuario); }catch(Exception ex) { throw; } }

        public Usuario UsuarioUpdate(int codUsu, string nombre, string clave) {
            UsuarioDatos ud = new UsuarioDatos();
            try { return ud.UsuarioUpadate(codUsu,nombre,clave); }catch(Exception ex) { throw; } 
        }
    }
}
