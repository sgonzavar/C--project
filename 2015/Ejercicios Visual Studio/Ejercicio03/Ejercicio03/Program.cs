using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
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
                Console.WriteLine("El Numero Mayor Es {0}", a);

                if (b > c)
                {
                    Console.WriteLine("El Numero Medio Es {0}", b);
                    Console.WriteLine("El Numero Menor Es {0}", c);
                }
                else
                {
                    Console.WriteLine("El Numero Medio Es {0}", c);
                    Console.WriteLine("El Numero Menor Es {0}", b);
                }
            }
            else
            {
                if (b > a && b > c)
                {
                    Console.WriteLine("El Numero Mayor Es {0}", a);

                    if (a > c)
                    {
                        Console.WriteLine("El Numero Medio Es {0}", a);
                        Console.WriteLine("El Numero Menor Es {0}", c);
                    }
                    else
                    {
                        Console.WriteLine("El Numero Medio Es {0}", c);
                        Console.WriteLine("El Numero Menor Es {0}", b);
                    }
                }
            }
            if (c > b && c > a)
            {
                Console.WriteLine("El Numero Mayor Es {0}", c);

                if (b > a)
                {
                    Console.WriteLine("El Numero Medio Es {0}", b);
                    Console.WriteLine("El Numero Menor Es {0}", a);
                }
                else
                {
                    Console.WriteLine("El Numero Medio Es {0}", a);
                    Console.WriteLine("El Numero Menor Es {0}", b);
                }
            }


            Console.ReadKey();
            
        }
    }
}
