using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.Write((char)i + "\t");
                if (i % 10 == 0)
                    Console.Write("\n");

                i++;
            } while (i <= 122);

            Console.ReadLine();
        }
    }
}
