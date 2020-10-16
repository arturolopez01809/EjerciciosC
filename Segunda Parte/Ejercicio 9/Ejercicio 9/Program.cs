using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static double Dividir(int a, int b)
        {

            double res = 0;
            try
            {
                res = a/b;
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Se intentó dividir entre 0");
            }
            finally
            {
                Console.WriteLine("Terminada división");
            }


            return res;
            
        }

        static void Main(string[] args)
        {
            
            double res = Dividir(a, -3);

            Console.WriteLine(res);

            Convert.ToInt32(Console.ReadLine());
        }
    }
}
