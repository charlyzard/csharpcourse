using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11._4
{
    class Program
    {
        static void Main(string[] args)
        {

            ImprimeAhorcado(0);
            ImprimeAhorcado(1);
            ImprimeAhorcado(2);
            ImprimeAhorcado(3);
            ImprimeAhorcado(4);
            ImprimeAhorcado(5);



            Console.ReadLine();

        }

        private static void ImprimeAhorcado(int errores)
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

            // Pierna izquierda
            if (errores < 5)
            {
                ahorcado[5, 2] = ' ';
            }

            // Pierna derecha
            if (errores < 4)
            {
                ahorcado[5, 4] = ' ';
            }

            // Brazo izquierdo
            if (errores < 3)
            {
                ahorcado[3, 2] = ' ';
            }

            // Brazo derecho
            if (errores < 2)
            {
                ahorcado[3, 4] = ' ';
            }

            // Cuerpo y cabeza
            if (errores < 1)
            {
                ahorcado[2, 3] = ' ';
                ahorcado[3, 3] = ' ';
                ahorcado[4, 3] = ' ';
            }


            Console.WriteLine("{0} errores", errores);
            ImprimeArrayBidimensional(ahorcado);
            Console.WriteLine();
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
