using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Por favor, introduce tu nombre:");

            nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}! Me encanta tu nombre.", nombre);

            Console.ReadLine();
        }
    }
}
