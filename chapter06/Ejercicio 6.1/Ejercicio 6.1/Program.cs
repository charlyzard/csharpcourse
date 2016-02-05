using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            int y = 5;

            Console.WriteLine("valor de x\tvalor de y\texpresión\tresultado");

            Console.WriteLine("{0,-10}\t{1,-10}\tx=y+3 \t \tx={2,-10}", x, y, y + 3);
            Console.WriteLine("{0,-10}\t{1,-10}\tx=y-2 \t \tx={2,-10}", x, y, y - 2);
            Console.WriteLine("{0,-10}\t{1,-10}\tx=y*5 \t \tx={2,-10}", x, y, y * 5);
            Console.WriteLine("{0,-10}\t{1,-10}\tx=x/y \t \tx={2,-10}", x, y, (float)x / y);
            Console.WriteLine("{0,-10}\t{1,-10}\tx=x%y \t \tx={2,-10}", x, y, x % y);


            Console.ReadLine();
        }
    }
}
