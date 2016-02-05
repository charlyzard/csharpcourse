using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string eleccion;
            string continuar = "s";
            Console.WriteLine("¿Cuál es la palabra clave para salir de un bucle en C#?");
            Console.WriteLine("a.quit");
            Console.WriteLine("b.continue");
            Console.WriteLine("c.break");
            Console.WriteLine("d.exit");


            while (continuar == "s")
            {
                Console.Write("Elija una: ");
                eleccion = Console.ReadLine();

                if (eleccion == "c")
                {
                    Console.WriteLine("Enhorabuena!");
                }
                else if (eleccion == "q" || eleccion == "n") { Console.WriteLine("Saliendo...!"); break; }
                else Console.WriteLine("Incorrecto!");

                Console.Write("Probar de nuevo? pulse s para continuar: ");
                continuar = Console.ReadLine().ToString();

            }
        }
    }
}
