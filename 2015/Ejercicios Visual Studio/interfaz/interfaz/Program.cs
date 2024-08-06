using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura("000001", "Llantas Good Year", 4, 175000);
            Factura f2 = new Factura("000002", "Camisate Polo", 14, 30000);
            Factura f3 = new Factura("000003", "Aguardiente Antioqueño", 7, 45000);
            EmpleadoAsalariado e1 = new EmpleadoAsalariado("546567655","Homero", "Simpson", 750000);
            EmpleadoAsalariado e2 = new EmpleadoAsalariado("8968689689", "Peter", "Pan", 15000);
            EmpleadoAsalariado e3 = new EmpleadoAsalariado("8968968968", "Gustabo", "Gomez", 1500000);

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.ReadKey();
        }
    }
}
