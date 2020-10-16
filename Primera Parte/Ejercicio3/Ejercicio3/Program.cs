using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {

        static void NumeroMayor(int a, int b)
        {
            if(a > b)
            {
                Console.WriteLine("El número " + a + " es mayor que " + b);
            } else if(a < b)
            {
                Console.WriteLine("El número " + b + " es mayor que " + a);
            }
        }

        static void Main(string[] args)
        {

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Introduzca un número entero: ");

            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            NumeroMayor(numero1, numero2);

            Console.ReadLine();

        }
    }
}