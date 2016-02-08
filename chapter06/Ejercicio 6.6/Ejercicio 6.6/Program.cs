using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            Console.Write("Introduzca el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el tercer número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el cuarto número: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            int resultado = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("La media de {0}, {1}, {2}, {3} es: {4} ", num1, num2, num3, num4, resultado);

            Console.ReadLine();
        }
    }
}
