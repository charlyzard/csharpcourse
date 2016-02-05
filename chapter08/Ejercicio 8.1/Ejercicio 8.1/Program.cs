using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char tecla;
            Console.Write("Pulse un número : ");
            tecla = (char)Console.Read();
            switch (tecla)
            {
                case '0':
                    Console.WriteLine("Pulsaste el 0");
                    break;
                case '1':
                    Console.WriteLine("Pulsaste el 1");
                    break;
                case '2':
                    Console.WriteLine("Pulsaste el 2");
                    break;
                case '3':
                    Console.WriteLine("Pulsaste el 3");
                    break;
                case '4':
                    Console.WriteLine("Pulsaste el 4");
                    break;
                case '5':
                    Console.WriteLine("Pulsaste el 5");
                    break;
                case '6':
                    Console.WriteLine("Pulsaste el 6");
                    break;
                case '7':
                    Console.WriteLine("Pulsaste el 7");
                    break;
                case '8':
                    Console.WriteLine("Pulsaste el 8");
                    break;
                case '9':
                    Console.WriteLine("Pulsaste el 9");
                    break;
                default:
                    Console.WriteLine("Tecla no permitida");
                    break;

            }

            Console.ReadLine();
        }
    }
}
