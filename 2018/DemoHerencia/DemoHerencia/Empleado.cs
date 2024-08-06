using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    abstract class Empleado // apodo para que sea abstracta 
    {
        #region "Atributos"
        private string strCedula;
        private string strApellido;
        private string strNombre;
        #endregion

        #region "Propiedades"

        public string Cedula { get => strCedula; set => strCedula = value; }
        public string Apellido { get => strApellido; set => strApellido = value; }
        public string Nombre { get => strNombre; set => strNombre = value; }

        #endregion

        #region "Contructor"

        public Empleado(string cedula, string nombres, string apellidos)
        {
            this.strNombre = nombres;
            this.strCedula = cedula;
            this.strApellido = apellidos;

        }

        #endregion

        #region "Metodos"

        public override string ToString()
        {
            return String.Format(" {0} {1}\n\t Cedula.........: {2}", strNombre, strApellido, strCedula);
        }

        public abstract decimal Ingresos();

        #endregion

    }// end Class
}
