using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            string vector_strings;

            Console.WriteLine("Introduce una serie de números: ");

            vector_strings = Console.ReadLine();

            int contador = 0;

            foreach (char i in vector_strings)
            {
                if(i == '7')
                {
                    contador++;
                }
            }

            Console.WriteLine("La cadena insertada tiene " + contador + " sietes");
            Console.ReadLine();

        }
    }
}
