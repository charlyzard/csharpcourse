using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 0; i <= 6; i++)
            {
                for (j = 1; j <= 7 - i; j++) Console.Write("*");
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
