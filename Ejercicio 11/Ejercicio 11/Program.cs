using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {

        static void MostrarMultiplos(int numero)
        {
            for(int i = 5; i <= 36; i++)
            {
                if(i % numero == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca un número entre 5 y 36: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if ((numero >= 5) && (numero <= 36))
            {
                MostrarMultiplos(numero);
            } else
            {
                Console.WriteLine("El número no está dentro de los parámetros establecidos");
            }

            Console.ReadLine();
        }
    }
}
