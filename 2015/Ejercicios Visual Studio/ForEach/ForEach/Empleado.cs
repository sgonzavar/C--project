using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Empleado
    {
        #region "Atributos"
        private string _IDempleado;
        private string _Nombres;
        private string _Apellidos;
        private long _Salario;
        private DateTime _FechaContrato;
        #endregion

        #region "Contructor"
        public Empleado(string IDempleado, string Nombres, string Apellidos, long Salario, DateTime FechaContrato)
        {
            _IDempleado = IDempleado;
            _Nombres = Nombres;
            _Apellidos = Apellidos;
            _Salario = Salario;
            _FechaContrato = FechaContrato;
        }

 

        public Empleado()
        { }
        #endregion

        #region "Propiedades"
        public string IDempleado
        {
            get { return _IDempleado; }
            set { _IDempleado = value; }
        }

        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        public long Salario
        {
            get { return _Salario; }
            set { _Salario = value; }
        }

        public DateTime FechaContrato
        {
            get { return _FechaContrato; }
            set { _FechaContrato = value; }
        }
        #endregion

        #region "Metodos"
        public override string ToString()
        {
            return "ID Empleado.....................: " + _IDempleado + "\n"
                 + "\tNombres.................: " + _Nombres + "\n"
                 + "\tApellidos...............: " + _Apellidos + "\n"
                 + "\tSalario.................: " + _Salario + "\n"
                 + "\tFecha De Contratacion...: " + _FechaContrato.ToShortDateString() + "\n";  //muestra la fecha sin hora            
        }



        #endregion
    }
}
