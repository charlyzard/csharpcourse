using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra1, letra2, letra3;

            Console.Write("Introduzca una letra: ");
            letra1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Introduzca una letra: ");
            letra2 = char.Parse(Console.ReadLine());

            Console.Write("Introduzca una letra: ");
            letra3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letra3, letra2, letra1);

            Console.ReadLine();
        }
    }
}
