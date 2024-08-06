using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Circulo : Figura //hereda de figura
    {
        private double _Radio;

        public Circulo(double Radio)
        {
            _Radio = Radio;
        }

        public override void Dibujar()
        {
            Console.WriteLine(" Dibujando Un Circulo............. ");    
        }

        public override double Area()
        {
            return  Math.PI * Math.Pow(_Radio,2);
        }
    }
}
