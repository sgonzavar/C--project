using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class EmpleadoAsalariado : Empleado
    {
        #region "Atributos"

        private decimal dcmSalario;

        #endregion



        #region "Propiedades"

        public decimal Salario { get => dcmSalario; set => dcmSalario = value; }

        #endregion

        #region "Contructor"

        public EmpleadoAsalariado(string celuda, string nombres, string apellidos, decimal salario) :
            base(celuda, nombres, apellidos)
        {
            this.dcmSalario = salario;

        }

        #endregion


        #region "Metodos"

        public override decimal Ingresos()
        {
            return dcmSalario; 

        }

        public override string ToString()
        {
            return String.Format(" Empleado Asalariado.: {0}\n\t Salario Mensual: ${1,10:N2}",
                base.ToString(), Ingresos() );
        }

        #endregion



    } // end class
}
