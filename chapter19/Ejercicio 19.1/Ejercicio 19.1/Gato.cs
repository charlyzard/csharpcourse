using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19._1
{
    class Gato : IAnimal, IMascota
    {
        public string Nombre
        {
            get; set;
        }

        public void Expresarse()
        {
            Console.WriteLine("Miaaaaaaau!");
        }

        public void Jugar()
        {
            Console.WriteLine("Juego con la madeja");
        }
    }
}
