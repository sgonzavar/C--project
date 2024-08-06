using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    class EmpleadoAsalariado : Empleado
    {
        #region "Atributos"
        private double SalarioSemanal;
        #endregion


        #region "Constructor"
        public EmpleadoAsalariado(string cedula, string nombres, string apellidos, double salarioSemanal)
            : base(cedula, nombres, apellidos)
        {
            this.SalarioSemanal = salarioSemanal;

        }
        #endregion


        #region "Propiedadr"
        public double Salario
        {
            get { return SalarioSemanal; }
            set { SalarioSemanal = value; }
        }
        #endregion


        #region "Metodos Publicos"
        
        

        public override string ToString()
        {
            return string.Format("Empleado Asalariado: {0}\n\t"
                + "Ingresos..........: ${1,10:N0}\n", base.ToString(), ObtenerMontoPago());
        }
        #endregion

        public override double ObtenerMontoPago()
        {
            return SalarioSemanal;
        }
    }
}
