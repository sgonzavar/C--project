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
            Empleado empleado1 = new Empleado("1010", "Laura", "Quintero", 1200000, new DateTime(2001, 2, 12));
            Empleado empleado2 = new Empleado("1011", "Bob", "Marley", 1205000, new DateTime(2011, 5, 9));
            Empleado empleado3 = new Empleado("1012", "Freddy", "Mercuri", 1100000, new DateTime(2009, 2, 12));
            Empleado empleado4 = new Empleado("1013", "Hector", "Lavoe", 200000, new DateTime(2003, 3, 26));
            Empleado empleado5 = new Empleado("1014", "Celia", "Cruz", 12000, new DateTime(2000, 7, 15));
            Empleado empleado6 = new Empleado();
            
            empleado6.IDempleado = "1015";
            empleado6.Nombres = "Antonio";
            empleado6.Apellidos = "Nariño";
            empleado6.Salario = 500000;
            empleado6.FechaContrato = new DateTime(2015, 12, 2);

            Empleado[] empleados = new Empleado[6];
            empleados[0] = empleado1;
            empleados[1] = empleado2;
            empleados[2] = empleado3;
            empleados[3] = empleado4;
            empleados[4] = empleado5;
            empleados[5] = empleado6;

            //muestro los empleados
            Console.WriteLine(" Empleado Sin El Aumento ========================= \n");
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.ToString());
            }

            //Incremento elSalario
            Console.WriteLine(" Empleado Con El Aumento ========================= \n"); 
            foreach (var empleado in empleados)
            {             
                empleado.Salario = (long)(empleado.Salario  * 1.25);                
                Console.WriteLine(empleado.ToString());
            }
            Console.ReadKey();
            
        }
    }
}
