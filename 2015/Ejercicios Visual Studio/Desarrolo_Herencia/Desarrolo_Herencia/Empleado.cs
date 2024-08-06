using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrolo_Herencia
{
    abstract class Empleado
    {
        #region"Atributos"
        private string Cedula;
        private string Nombres; 
        private string Apellidos;
        #endregion

        #region"Constructor"
        public Empleado()
        {
            this.Cedula = "";
            this.Apellidos = "";
            this.Nombres = "";
        }


        public Empleado(string cedula, string nombres, string apellidos)
        {
            this.Cedula = cedula;
            this.Apellidos = apellidos;
            this.Nombres = nombres;
        }
        #endregion

        #region"Propiedades"
        public string Nombre
        {
            get { return Nombres;  }
            set { Nombres = value;  }
        }

        public string Apellido
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }

        public string CC
        {
            get { return Cedula; }
            set { Cedula = value; }
        }
        #endregion

        #region"Metodo Abstracto"
        public abstract double Ingresos();
        #endregion

        #region "Metodos Publicos"
        public override string ToString()
        {
           return string.Format("{0} {1}\n\tCedula............: "
           + "{2}", Nombres,Apellidos,Cedula); 
        }
        #endregion
    }
}
 