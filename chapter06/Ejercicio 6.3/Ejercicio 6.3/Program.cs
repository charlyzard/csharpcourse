using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6._3
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;

            Console.Write("Introduzca un valor para la variable a:");


            a = int.Parse(Console.ReadLine());

            Console.WriteLine("El valor de a es {0}.", a);

            b = ++a;

            Console.WriteLine("El valor de ++a es {0}.", b);

            Console.WriteLine("El valor de a es {0}.", a);
            b = a++;

            Console.WriteLine("El valor de a++ es {0}.", b);
            Console.WriteLine("El valor de a es {0}.", a);

            b = --a;

            Console.WriteLine("El valor de --a es {0}.", b);
            Console.WriteLine("El valor de a es {0}.", a);


            b = a--;

            Console.WriteLine("El valor de a-- es {0}.", b);
            Console.WriteLine("El valor de a es {0}.", a);


            Console.ReadLine();
        }
    }
}
