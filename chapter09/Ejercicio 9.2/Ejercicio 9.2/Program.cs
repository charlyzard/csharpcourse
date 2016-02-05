using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;

            for (i = 1; i <= 7; i++)
            {
                for (j = 1; j <= i; ++j)
                    Console.Write(j);

                for (k = 7 - i; k >= 1; k--)
                    Console.Write("*");

                Console.Write("\n");
            }


            Console.ReadLine();
        }
    }
}
