using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado[] empleados = new Empleado[7];

            empleados[0] = new Empleado("1010", "Bob", "MArley", 14324.32M, new DateTime(2010, 2, 23));
            empleados[1] = new Empleado("1010", "Bob", "MArley", 14324.32M, new DateTime(2010, 2, 23));
            empleados[2] = new Empleado("1010", "Bob", "MArley", 14324.32M, new DateTime(2010, 2, 23));
            empleados[3] = new Empleado("1010", "Bob", "MArley", 14324.32M, new DateTime(2010, 2, 23));
            empleados[4] = new Empleado("1010", "Bob", "MArley", 14324.32M, new DateTime(2010, 2, 23));
            empleados[5] = new Empleado("1010", "Bob", "MArley", 14324.32M, new DateTime(2010, 2, 23));
            empleados[6] = new Empleado("1010", "Bob", "MArley", 14324.32M, new DateTime(2010, 2, 23));

            Console.WriteLine("Antes Del Aumento......: ");
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado);
            }

            Console.ReadKey();

            Console.WriteLine("Despues Del Aumento......: ");
            foreach (var empleado in empleados)
            {
                empleado.Salario = empleado.Salario * 1.1M;
                Console.WriteLine(empleado);
            }

            Console.ReadKey();
        }
    }
}
