using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite Lado Del Cuadro..: ");
            double cuadro = Convert.ToDouble(Console.ReadLine());
            Cuadro CU = new Cuadro(cuadro);
            CU.Dibujar();
            Console.WriteLine("El Area Del Cuadrado Es {0}",CU.Area());
           
            Console.Write("Digite Radio Del Circulo..: ");
            double circulo = Convert.ToDouble(Console.ReadLine());
            var CI = new Circulo(circulo);
            CI.Dibujar();
            Console.WriteLine("Radio Del Circulo Es {0}", CI.Area());
            Console.ReadKey();
        }
    }
}
