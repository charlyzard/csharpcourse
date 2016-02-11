using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17._1
{
    class SerVivo
    {
        public int VidaActual { get; set; }
        public int VidaMaxima { get; set; }

        public SerVivo(int vactual, int vmaxima)
        {
            VidaActual = vactual;
            VidaMaxima = vmaxima;
        }
    }
}
