using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19._1
{
    class Perro : IAnimal, IMascota
    {
        public string Nombre
        {
            get; set;
        }

        public void Expresarse()
        {
            Console.WriteLine("Guaaaaaaaau!");
        }

        public void Jugar()
        {
            Console.WriteLine("Échame la pelota!");
        }
    }
}
