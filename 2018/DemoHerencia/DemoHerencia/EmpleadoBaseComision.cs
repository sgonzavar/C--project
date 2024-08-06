using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class EmpleadoBaseComision : EmpleadoPorComision
    {
        private decimal dcmSalarioBase;

        public decimal DcmSalarioBase { get => dcmSalarioBase; set => dcmSalarioBase = value; }


        public EmpleadoBaseComision(string celuda, string nombres, string apellidos,
        float tarifa, decimal ventasBrutas, decimal salario) :
        base(celuda, nombres, apellidos, tarifa, ventasBrutas)
        {
            this.dcmSalarioBase = salario;
        }

        public override decimal Ingresos()
        {
            return base.Ingresos() + dcmSalarioBase;
        }
        

        public override string ToString()
        {
            return String.Format(" Empleado Base mas Comision: {0} {1}\n\tCedula..........: {2}\n\t " +
                "Salario Mensual: ${3,10:N2}",
               Nombre, Apellido, Cedula, Ingresos());
        }



    }
}
