using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Empleado
    {
        #region "Propiedades"
        public string IDEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
        #endregion

        public Empleado(string idEmplelado, string nombre, string apellidos,
            decimal salario, DateTime fechaDeContratacion)
        {
            IDEmpleado = idEmplelado;
            Nombres = nombre;
            Apellidos = apellidos;
            Salario = salario;
            FechaContratacion = fechaDeContratacion;
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, {1} {2}\n  Salario     : ${3,10:N2}\n  Fecha Contrato: {4:d} ",
                IDEmpleado, Nombres, Apellidos, Salario, FechaContratacion);
        }

    }
}
