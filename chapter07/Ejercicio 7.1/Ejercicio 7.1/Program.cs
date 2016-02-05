using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, z;

            Console.Write("Introduzca el valor 1: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el valor 2: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el valor 3: ");
            z = int.Parse(Console.ReadLine());


            if (x > y)
                if (x > z)
                    Console.Write("El valor mayor es: {0}.", x);
                else
                    Console.Write("El valor mayor es: {0}.", z);
            else if (y > z)
                Console.Write("El valor mayor es: {0}.", y);
            else
                Console.Write("El valor mayor es: {0}.", z);



            Console.ReadLine();
        }
    }
}
