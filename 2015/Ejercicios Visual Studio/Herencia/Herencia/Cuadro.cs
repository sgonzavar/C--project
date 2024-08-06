using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Cuadro : Figura // Hereda de Figura
    {
        private double _Lado;

        public Cuadro(double Lado)
        {
            _Lado = Lado;
        }

        public override void Dibujar()
        {
            Console.WriteLine("Dibujando Un Cuadro................");
        }

        public override double Area()
        {
            return _Lado * _Lado;       
        }
    }
}
