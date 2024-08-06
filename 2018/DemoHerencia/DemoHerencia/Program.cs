using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoAsalariado asalariado = new 
                EmpleadoAsalariado("1010", "juan", "mata", 30000);
            EmpleadoPorHoras porHoras = new 
                EmpleadoPorHoras("1011", "Andres", "iniesta", 115F, 15.32M);
            EmpleadoPorComision porComision = new 
                EmpleadoPorComision("1100", "paul", "pogba", 0.04f, 92564.56m);
            EmpleadoBaseComision baseComision = new
                EmpleadoBaseComision("1110", "Cristiano", "Ronaldo",0.02f, 12000M, 480.56m);
            Empleado[] empleados = new Empleado[4];

            empleados[0] = asalariado;
            empleados[1] = porHoras;
            empleados[2] = porComision;
            empleados[3] = baseComision;

            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado);
            }

            Console.ReadKey();
        }
    }
}
