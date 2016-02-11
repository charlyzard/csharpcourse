using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14._1
{
    class Mision
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int RecompensaEnPuntosDeExperiencia { get; set; }
        public int RecompensaEnOro { get; set; }

        public Mision(string nombre, string descripcion, int recompensaEXP, int oro)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            RecompensaEnPuntosDeExperiencia = recompensaEXP;
            RecompensaEnOro = oro;
        }
    }
}
