using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            do
            {
                Console.WriteLine("digite numero 1 :" );
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite numero 2 :");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Digiete Una Opcion suma = 1 , resta = 2 , multiplicacion = 3 , division = 4 :" );
                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    total = numero1 + numero2;
                }
                else {
                    if (opcion == 2)
                    {
                        total = numero1 - numero2;
                    }
                    else  
                    {
                        if (opcion == 3)
                        {
                            total = numero1 * numero2;
                        }
                        else 
                        {
                            total = numero1 / numero2;
                        }
                    
                    }
                }
                Console.Write("el resultado es {0}", total);
                Console.ReadKey();
            } while (true);
               
        }
    }
}
