using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El doble de {0} es {1}", numero, Doblar(numero));
            Console.ReadLine();
        }

        private static int Doblar(int numero)
        {
            return numero * 2;
        }
    }
}
