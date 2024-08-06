using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite Numero : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite Numero : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite Numero : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.Write("El Numero Mayor Es {0}", a);
            }
            else
            {
                if (b > a && b > c)
                {
                    Console.Write("El Numero Mayor Es {0}", b);
                }
                else
                {
                    Console.Write("El Numero Mayor Es {0}", c);
                }
            }
            Console.ReadKey();
        }
    }
}
