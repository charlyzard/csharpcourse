using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Introduzca un número: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}{0}{0}", x);
            Console.WriteLine("{0}   {0}", x);
            Console.WriteLine("{0}   {0}", x);
            Console.WriteLine("{0}   {0}", x);
            Console.WriteLine("{0}{0}{0}{0}{0}", x);

            Console.ReadLine();
        }
    }
}
