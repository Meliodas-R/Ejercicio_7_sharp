using System;

namespace Ejercicio_7_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca una palabra: ");
            string palabra1 = Console.ReadLine();
            Console.Write("Introduzca otra palabra: ");
            string palabra2 = Console.ReadLine();

            string resultado = palabra1 + " - " + palabra2;

            Console.WriteLine("\n" + resultado);
        }
    }
}
