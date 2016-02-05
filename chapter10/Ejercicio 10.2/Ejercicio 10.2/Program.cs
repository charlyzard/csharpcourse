using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La frase \"Hola, ¿cómo estás?\" contiene {0} espacios en blanco", CuentaEspacios2("Hola, ¿cómo estás?"));
            Console.ReadLine();
        }

        private static int CuentaEspacios(string v)
        {
            return v.Count(Char.IsWhiteSpace);
        }

        private static int CuentaEspacios2(string v)
        {
            int espacios = 0;
            foreach (char c in v)
            {
                if (c == ' ')
                    espacios++;
            }
            return espacios;
        }
    }
}
