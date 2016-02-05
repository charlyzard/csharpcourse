using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuál es la forma correcta de declarar una variable que almacene un entero en C#?");
            Console.WriteLine("a. int 1x=10");
            Console.WriteLine("b. int x=10");
            Console.WriteLine("c. float x=10.0f");
            Console.WriteLine("d. string x=\"10\"");
            Console.WriteLine("Escoja la respuesta correcta: ");
            char respuesta = (char)Console.Read();
            switch (respuesta)
            {
                case 'a':
                    Console.WriteLine("¡Respuesta incorrecta!");
                    break;
                case 'b':
                    Console.WriteLine("¡Enhorabuena! Ganas un gallifante");
                    break;
                case 'c':
                    Console.WriteLine("¡Respuesta incorrecta!");
                    break;
                case 'd':
                    Console.WriteLine("¡Respuesta incorrecta!");
                    break;
                default:
                    Console.WriteLine("Has elegido una respuesta que no existe");
                    break;


            }
        }
    }
}
