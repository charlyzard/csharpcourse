using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Número {0} =  ", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 4; i >= 0; i--)
                Console.Write("{0} ", numeros[i]);

            Console.ReadLine();
        }
    }
}
