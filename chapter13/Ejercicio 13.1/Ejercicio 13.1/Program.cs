using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona chavalin = new Persona();
            chavalin.Nombre = "Miguel";
            chavalin.PrimerApellido = "Sánchez";
            chavalin.SegundoApellido = "Herrera";

            Console.WriteLine("Nombre completo : {0}", chavalin.NombreCompleto);
            Console.WriteLine("Longitud del nombre completo : {0}", chavalin.Longitud);

            Console.ReadLine();
        }
    }
}
