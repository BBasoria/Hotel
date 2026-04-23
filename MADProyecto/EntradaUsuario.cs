using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MADProyectoEneJun2023
{
    public class EntradaUsuario
    {
        public class datocorreo
        {
            private string CorreoIniciador;
            public void AsignarCorreo(string elcorreoactual)
            {
                CorreoIniciador = elcorreoactual;
            }
            public string GetCorreoIniciador()
            {
                return CorreoIniciador;
            }
        }

        public bool ContraseñaValidar(string Contraseñapropuesta)
        {
            Regex letrasm = new Regex(@"[a-z]");
            Regex letrasM = new Regex(@"[A-Z]");
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");

            if (!letrasm.IsMatch(Contraseñapropuesta))
            {
                return false;
            }

            if (!letrasM.IsMatch(Contraseñapropuesta))
            {
                return false;
            }

            if (!caracEsp.IsMatch(Contraseñapropuesta))
            {
                return false;
            }

            return true;
        }

    }
}

