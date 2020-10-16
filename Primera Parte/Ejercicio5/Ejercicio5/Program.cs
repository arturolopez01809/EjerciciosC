using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {

        static int GenerarNumeroAleatorio()
        {
            int numero = 0;

            Random random = new Random();

            numero = random.Next(21);

            return numero;
        }

        static bool CompararNumeros(int numero_usuario, int numero_aleatorio)
        {
            bool resultado = false;

            if(numero_usuario == numero_aleatorio)
            {
                resultado = true;

                Console.WriteLine("ACERTASTE!!!!!!!");
            } else if(numero_usuario > numero_aleatorio)
            {
                Console.WriteLine("EL número es demasiado grande");
            } else if(numero_usuario < numero_aleatorio)
            {
                Console.WriteLine("El número es demasiado pequeño");
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            int numero_usuario = 0;
            int numero_aleatorio = 0;

            bool numero_encontrado = false;

            Console.WriteLine("Introduzca un número entero entre 0-20: ");
            numero_usuario = Convert.ToInt32(Console.ReadLine());

            numero_aleatorio = GenerarNumeroAleatorio();

            int contador = 0;

            do
            {

                Console.WriteLine("Introduzca un número entero entre 0-20: ");
                numero_usuario = Convert.ToInt32(Console.ReadLine());

                numero_encontrado = CompararNumeros(numero_usuario, numero_aleatorio);
                contador++;

            } while (!numero_encontrado || contador >= 5);

            Console.ReadLine();
        }
    }
}
