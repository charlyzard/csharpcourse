using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] ahorcado = new char[,] {
                { '/', '-', '-', '-', '-' } ,
                { '|', ' ', ' ', '|', ' ' } ,
                { '|', ' ', ' ', 'O', ' ' } ,
                { '|', ' ', '/', '|', '\\' } ,
                { '|', ' ', ' ', '|', ' ' } ,
                { '|', ' ', '/', ' ', '\\' } ,
                { '|', ' ', ' ', ' ', ' ' }
            };

            ImprimeArrayBidimensional(ahorcado);

            Console.ReadLine();

        }

        private static void ImprimeArrayBidimensional(char[,] ahorcado)
        {
            for (int i = 0; i < ahorcado.GetLength(0); i++)
            {
                for (int j = 0; j < ahorcado.GetLength(1); j++)
                    Console.Write(ahorcado[i, j]);

                Console.WriteLine();
            }
        }
    }
}
