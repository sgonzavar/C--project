using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro objLibro1 = new Libro();
            Libro objLibro2 = new Libro("La Biblia Del C#", 23.4M);
            Libro objLibro3 = new Libro("Aprendiendo Java 2EE", 45.12M);

            objLibro1.Nombre = "Critica a la Razon Pura";
            objLibro1.Precio = 12.03M;

            Libro[] objLibros = new Libro[3];
            objLibros[0] = objLibro1;
            objLibros[1] = objLibro2;
            objLibros[2] = objLibro3;

            foreach (var libro in objLibros)
            {
                Console.WriteLine(libro);
            }
            Console.ReadKey();


        }
    }
}
