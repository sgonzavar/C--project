using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrolo_Herencia
{
    class EmpleadoPorHoras: Empleado
    {
        #region"Atributos"
        private double NumeroHoras;
        private double ValorDeHoras;
        #endregion

        #region "Constructor"

        public EmpleadoPorHoras()
        {
             this.NumeroHoras = 0;
             this.ValorDeHoras = 0;
        }

        public EmpleadoPorHoras(string cedula, string nombres, string apellidos, double numeroHoras, double valorDeHoras)
            : base(cedula, nombres, apellidos)
        {
            this.NumeroHoras = numeroHoras;
            this.ValorDeHoras = valorDeHoras;
        }
        #endregion


        #region "Propiedadr"
        public double numeroDeHora
        {
            get { return NumeroHoras; }
            set { NumeroHoras = value; }
        }

        public double valorDeHora
        {
            get { return ValorDeHoras; }
            set { ValorDeHoras = value; }
        }
        #endregion

        #region "Metodos Publicos"
        public override double Ingresos()
        {
            double horaExtra;
            if (NumeroHoras <= 40)
            {
                return NumeroHoras * ValorDeHoras;
            }
            else {               
                    horaExtra = NumeroHoras - 40;
                    return 40 * ValorDeHoras + (horaExtra * ValorDeHoras * 1.5);            
            }           
        }

        public override string ToString()
        {
            return string.Format("Empleado Por Horas: {0}\n\t"
                + "Ingresos..........: ${1,10:N0}\n", base.ToString(), Ingresos());
        }
        #endregion
    }
}
