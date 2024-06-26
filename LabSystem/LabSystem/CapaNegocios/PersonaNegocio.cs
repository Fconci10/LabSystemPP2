using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{   
    public class PersonaNegocio
    {
        public int Insertar(Persona p) {
            //try
            //{
                return PersonaDatos.Insert(p);
            //}catch (Exception ex) { throw; }
        }

       /* public int getCodPer(Persona p) {
            return PersonaDatos.getCodPersona(p);
        }*/

        public void Update(Persona p, int cp) {
            PersonaDatos per = new PersonaDatos();
            per.PersonaUpdate(p,cp);
        }

        public int BorrarP(int codPer) {
            PersonaDatos per = new PersonaDatos();
            return per.Borrar(codPer);
        }

        public long unicaP(Persona p)
        {
            PersonaDatos per = new PersonaDatos();
            return per.Unico(p);
        }

    }
}
