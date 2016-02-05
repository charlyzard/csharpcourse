using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            int y = 5;


            Console.WriteLine("valor de x\tvalor de y\texpresión\tresultado");

            Console.WriteLine("{0,10}\t{1,10}\tx+=y \t        x= {2}", x, y, x + y);
            Console.WriteLine("{0,10}\t{1,10}\tx-=y-2 \t        x= {2}", x, y, x - y + 2);
            Console.WriteLine("{0,10}\t{1,10}\tx*=y*5 \t        x= {2}", x, y, x * y * 5);
            Console.WriteLine("{0,10}\t{1,10}\tx=x/y \t        x= {2}", x, y, (float)x / (x / y));
            Console.WriteLine("{0,10}\t{1,10}\tx%=y \t        x= {2}", x, y, x % y);


            Console.ReadLine();
        }
    }
}
