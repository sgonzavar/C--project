using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class EmpleadoPorComision: Empleado
    {
        private float fltTarifaComision;
        private decimal dcmVentasBruas;

        public float TarifaComision { get => fltTarifaComision; set => fltTarifaComision = value; }
        public decimal VentasBruas { get => dcmVentasBruas; set => dcmVentasBruas = value; }

        public EmpleadoPorComision(string celuda, string nombres, string apellidos,
             float tarifa, decimal ventasBrutas) :
            base(celuda, nombres, apellidos)
        {
            this.fltTarifaComision = tarifa;
            this.dcmVentasBruas = ventasBrutas;
        }

        public override decimal Ingresos()
        {
            return dcmVentasBruas * (decimal)fltTarifaComision; // casting
        }

        public override string ToString()
        {
            return String.Format(" Empleado por Comision: {0}\n\t Salario Mensual: ${1,10:N2}",
                base.ToString(), Ingresos());
        }
    }
}
