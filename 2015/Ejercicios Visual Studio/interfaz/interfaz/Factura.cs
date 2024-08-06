using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    class Factura : PorPagar
    {
        private string Codigo;
        private string Descripcion;
        private double Cantidad, Precio;

        public Factura(string codigo, string descripcion, double cantidad, double precio)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        public string Cod
        {
            get { return Codigo; }
            set { Codigo = value; }
        
        }

        public string Des
        {
            get { return Descripcion; }
            set { Descripcion = value; }

        }

        public double Can
        {
            get { return Cantidad; }
            set { Cantidad = value; }

        }

        public double Pre
        {
            get { return Precio; }
            set { Precio = value; }

        }
        public double ObtenerMontoPago()
        {
            return Cantidad * Precio;
        }

        public override string ToString()
        {
            return string.Format("Factura: {0}\n\t"
                + "Descripcion ....:  {1}\n\t"
                + "Precio .........: ${2,10:N0}\n\t"
                + "Cantidad .......:  {3,10:N0}\n\t"
                + "Valor ..........: ${4,10:N0}\n\t",
                Codigo, Descripcion, Precio, Cantidad, ObtenerMontoPago());
        }
    }
}
