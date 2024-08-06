using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class EmpleadoPorHoras : Empleado
    {
        #region "Atributos"

        private float fltNumeroHoras;
        private decimal dcmValorHora;

        #endregion

        #region "Propiedades"

        public float NumeroHoras { get => fltNumeroHoras; set => fltNumeroHoras = value; }
        public decimal ValorHora { get => dcmValorHora; set => dcmValorHora = value; }

        #endregion

        #region "Constructor"

        public EmpleadoPorHoras(string celuda, string nombres, string apellidos,
             float numeroHora, decimal valorHora) :
            base(celuda, nombres, apellidos)
        {
            this.dcmValorHora = valorHora;
            this.fltNumeroHoras = numeroHora;

        }

        #endregion


        #region "Constructor"

        public override decimal Ingresos()
        {
            return (decimal)fltNumeroHoras * dcmValorHora; // casting por q un float no multiplica por un decimal
        }

        public override string ToString()
        {
            return String.Format(" Empleado Por Horas: {0}\n\t Salario mensual: ${1,10:N2}",
                base.ToString(), Ingresos());
        }

        #endregion

    }// end class
}
