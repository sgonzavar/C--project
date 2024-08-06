using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.Write("El Numero {0} Es Par.", n);
            }
            else
            {
                Console.Write("El Numero {0} Es Impar.", n);
            }
            Console.ReadKey(); 
        }
    }
}
