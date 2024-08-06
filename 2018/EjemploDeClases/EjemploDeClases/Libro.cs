using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeClases
{
    class Libro
    {
        #region "Atributos Privados"
        private string strNombre;
        private decimal dcmPrecio;
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }

        //public decimal DcmPrecio { get => dcmPrecio; set => dcmPrecio = value; }

        public decimal Precio
        {
            get { return dcmPrecio; }
            set { dcmPrecio = value; }
        }
        #endregion

        #region "Constructores"
        public Libro() // constructor sin parametros
        {
            this.strNombre = "";
            this.dcmPrecio = 0.0M;
        }

        public Libro(string nombre, decimal precio) // constructor con parametros
        {
            this.strNombre = nombre;
            this.dcmPrecio = precio;
        }
        #endregion

        #region "Metodos Publicos"
        public override string ToString()
        {
            return String.Format("Nombre: {0,-25}  Precio: ${1,10:N2}", strNombre, dcmPrecio);
        }

        #endregion










    }
}
