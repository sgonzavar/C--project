using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Primer Numero  : ");
            int NumeroA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Segundo Numero : ");
            int NumeroB = Convert.ToInt32(Console.ReadLine());
            multiplos(NumeroA, NumeroB);
        }           
            private static void multiplos(int a, int b)
            {
                if (a % b == 0)
                {
                    Console.Write("El Numero {0} Es Multiplo De {1} ", a, b);
                }
                else
                {
                    Console.Write("El Numero {0} No Es Multiplo De {1} ", a, b);
                }
                Console.ReadKey();
            } 
    }
}
