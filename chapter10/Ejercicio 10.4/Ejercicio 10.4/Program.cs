using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Doblar(ref numero);
            Console.WriteLine("El doble es {0}", numero);
            Console.ReadLine();
        }

        private static void Doblar(ref int numero)
        {
            numero = numero * 2;
        }
    }
}
