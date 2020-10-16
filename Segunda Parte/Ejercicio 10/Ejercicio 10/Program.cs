using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {

        static double Factorial(int numero)
        {
            double factorial = 1;

            while(numero != 0)
            {
                factorial = factorial * numero;
                numero--;
            }

            return factorial;
        }

        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Introduzca un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            double res = Factorial(numero);

            Console.WriteLine(res);

            Console.ReadLine();

        }
    }
}
