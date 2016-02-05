using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7._2
{
    class Program
    {
        static void Main(string[] args)
        {

            float nota;
            Console.Write("Introduzca la nota del examen : ");
            nota = float.Parse(Console.ReadLine());

            if (nota > 10.0f)
                Console.WriteLine("Nota demasiado alta");
            else if (nota >= 9.0f)
                Console.WriteLine("Sobresaliente");
            else if (nota >= 7.0f)
                Console.WriteLine("Notable");
            else if (nota >= 6.0f)
                Console.WriteLine("Bien");
            else if (nota >= 5.0f)
                Console.WriteLine("Suficiente");
            else if (nota >= 0.0f)
                Console.WriteLine("Insuficiente");
            else
                Console.WriteLine("No llegas ni a un cero?");


            Console.ReadLine();
        }
    }
}
