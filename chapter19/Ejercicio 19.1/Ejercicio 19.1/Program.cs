using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19._1
{
    interface IAnimal
    {
        string Nombre { get; set; }
        void Expresarse();
    }

    interface IMascota
    {
        void Jugar();
    }


    class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] animales = new IAnimal[2];

            animales[0] = new Perro();
            animales[0].Nombre = "Scooby";

            animales[1] = new Gato();
            animales[1].Nombre = "Perla";

            foreach (IAnimal animal in animales)
            {
                Console.WriteLine("Soy {0}", animal.Nombre);
                animal.Expresarse();
            }

            Console.ReadLine();

        }
    }
}
