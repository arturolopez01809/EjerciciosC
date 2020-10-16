using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program   
    {

        static void Meses(int mes, int year)
        {
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 31 días");
                    break;
                case 2:

                    if(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                    {
                        Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 29 días");
                    } else
                    {
                        Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 28 días");
                    }

                    break;
                case 3:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 31 días");
                    break;
                case 4:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 30 días");
                    break;
                case 5:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 31 días");
                    break;
                case 6:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 30 días");
                    break;
                case 7:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 31 días");
                    break;
                case 8:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 31 días");
                    break;
                case 9:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 31 días");
                    break;
                case 10:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 31 días");
                    break;
                case 11:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 30 días");
                    break;
                case 12:
                    Console.WriteLine("Enl mes: " + mes + " del año " + year + " tiene 31 días");
                    break;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca un mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el año: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Meses(mes, year);

            Console.ReadLine();

        }
    }
}
