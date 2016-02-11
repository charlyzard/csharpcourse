using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17._1
{
    class Monstruo : SerVivo
    {
        public string Nombre { get; set; }
        public int RecompensaEnPuntosDeExperienca { get; set; }
        public int RecompenaEnOro { get; set; }

        public Monstruo(string nombre, int recEXP, int recOro, int pvActuales, int pvMax) 
            : base(pvActuales, pvMax)
        {

            Nombre = nombre;
            RecompensaEnPuntosDeExperienca = recEXP;
            RecompenaEnOro = recOro;
        }
    }
}
