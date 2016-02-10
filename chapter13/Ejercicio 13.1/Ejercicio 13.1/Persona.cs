using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13._1
{
    class Persona
    {
        public string Nombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + PrimerApellido + " " + SegundoApellido;
            }
        }

        public int Longitud
        {
            get
            {
                return NombreCompleto.Length;
            }
        }


    }
}
