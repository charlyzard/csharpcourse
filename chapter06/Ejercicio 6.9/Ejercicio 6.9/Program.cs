using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double area, perimetro, diagonal;

            Console.Write("Introduzca la anchura: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduzca la altura: ");
            b = Convert.ToDouble(Console.ReadLine());

            area = a * b;
            Console.WriteLine("Área: {0}", area);

            perimetro = a * 2 + b * 2;
            Console.WriteLine("Perímetro: {0}", perimetro);
            
            diagonal = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Diagonal: {0}", diagonal);

            Console.ReadLine();

        }
    }
}
