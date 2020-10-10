using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {

        static void CompararEsPar(int numero1, int numero2)
        {
            bool par_numero1 = false;
            bool par_numero2 = false;


            if(numero1 % 2 == 0)
            {
                par_numero1 = true;
            } 

            if(numero2 % 2 == 0)
            {
                par_numero2 = true;
            }

            if(par_numero1 && par_numero2){
                Console.WriteLine("Ambos números son pares");
            } else
            {
                Console.WriteLine("Ambos números NO son pares");
            }
        }
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Introduzca un número entero: ");

            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca otro número entero: ");

            numero2 = Convert.ToInt32(Console.ReadLine());

            CompararEsPar(numero1, numero2);

            Console.ReadLine(); 

        }
    }
}
