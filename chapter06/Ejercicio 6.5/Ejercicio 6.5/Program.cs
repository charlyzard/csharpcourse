using System;

namespace Ejercicio_6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int resultado;

            Console.WriteLine("Introduzca un número:");
            x = Convert.ToInt32(Console.ReadLine());
            // x = int.Parse(Console.ReadLine());  otra forma de hacerlo

            resultado = x * 1;
            Console.WriteLine("{0} x {1} = {2}", x, 1, resultado);
            resultado = x * 2;
            Console.WriteLine("{0} x {1} = {2}", x, 2, resultado);
            resultado = x * 3;
            Console.WriteLine("{0} x {1} = {2}", x, 3, resultado);
            resultado = x * 4;
            Console.WriteLine("{0} x {1} = {2}", x, 4, resultado);
            resultado = x * 5;
            Console.WriteLine("{0} x {1} = {2}", x, 5, resultado);
            resultado = x * 6;
            Console.WriteLine("{0} x {1} = {2}", x, 6, resultado);
            resultado = x * 7;
            Console.WriteLine("{0} x {1} = {2}", x, 7, resultado);
            resultado = x * 8;
            Console.WriteLine("{0} x {1} = {2}", x, 8, resultado);
            resultado = x * 9;
            Console.WriteLine("{0} x {1} = {2}", x, 9, resultado);
            resultado = x * 10;
            Console.WriteLine("{0} x {1} = {2}", x, 10, resultado);

            Console.ReadLine();
        }
    }
}
