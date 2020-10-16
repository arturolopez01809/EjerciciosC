using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static int Resta (int a, int b)
        {
            return a - b;
        }

        static int Multiplicacion (int a, int b)
        {
            return a * b;
        }

        static double Division (int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            Console.WriteLine("Suma: " + Sumar(a, b));

            Console.WriteLine("Resta: " + Resta(a, b));

            Console.WriteLine("Multiplicación: " + Multiplicacion(a, b));

            Console.WriteLine("División: " + Division(a, b));

            Console.ReadLine();

        }
    }
}
