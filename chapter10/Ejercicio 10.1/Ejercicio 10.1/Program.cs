using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DecirHola("Pedro");
            DecirAdios();
        }

        private static void DecirAdios()
        {
            Console.WriteLine("Adiós");
        }

        private static void DecirHola(string v)
        {
            Console.WriteLine("Hola " + v);
        }
    }
}
