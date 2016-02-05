using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11._2
{
    class Program
    {

        public static void Main(string[] args)
        {
            ImprimeSerie();
            Console.ReadLine();
        }

        public static void ImprimeSerie()
        {
            int[,] numeros = new int[5, 5];
            int i, j;

            int valor = 1;

            for (i = 0; i < 5; i++) //rellenamos los valores
                for (j = 0; j < 5; j++)
                {
                    numeros[i, j] = valor++;
                }

            for (i = 0; i < 5; i++) //imprimimos el array
            { 
                for (j = 0; j < 5; j++)
                    Console.Write("{0}\t", numeros[i, j]);
                Console.WriteLine();
            }

        }
    }
}