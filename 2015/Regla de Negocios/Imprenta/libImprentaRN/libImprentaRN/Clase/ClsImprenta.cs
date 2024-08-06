using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libImprentaRN.ReglaDeNegocio; // Referencia para poder acceder a la cls de lectura de Regla de Negocio

namespace libImprentaRN
{
    public class ClsImprenta
    {
        #region "Atributos"

        private Int32 intValorPasta, intValorPapel, intValorImprecion, intCantidadCopias;
        private double dblTotal, dblSubtotal, dblDescuento;
        private string stError;

        #endregion


        #region "Constructor"
        public ClsImprenta()
        {
            this.dblDescuento = 0.0;
            this.dblSubtotal = 0.0;
            this.dblTotal = 0.0;
            this.intCantidadCopias = 0;
            this.intValorImprecion = 0;
            this.intValorPapel = 0;
            this.intValorPasta = 0;
            this.stError = string.Empty;
        }

        #endregion


        #region "Propiedades"

        public int _Cantidad
        {
            get { return intCantidadCopias; }
            set { intCantidadCopias = value; }
        }

        public int _Pasta
        {
            get { return intValorPasta; }
            set { intValorPasta = value; }
        }

        public int _Papel
        {
            get { return intValorPapel; }
            set { intValorPapel = value; }
        }

        public int _Imprecion
        {
            get { return intValorImprecion; }
            set { intValorImprecion = value; }
        }

        public double _ValorDescuento
        {
            get { return dblDescuento; }
        }

        public double _ValorTotal
        {
            get { return dblTotal; }
        }

        public double _SubTotal
        {
            get { return dblSubtotal; }
        }

        public string _Error
        {
            get { return stError; }
        }

        #endregion

        #region "Metodos Privados"

        private bool validar()
        {
            if (intCantidadCopias < 0 || intCantidadCopias > 1000000)
            {
                stError = "Debe definir una cantidad Entre 1'000.000";
                return false;
            }
            return true;
        }

        private bool calcularPorcentajeDescuento()
        {
            // invocar la regla de negocio
            ClsLecturaXML objDescuento = new ClsLecturaXML();

            objDescuento._CantidadCopia = intCantidadCopias;
            if (objDescuento.calcularPorcentaje())
            {
                dblDescuento = objDescuento._PorsentajeDescuento;
                objDescuento = null;
                return true;
            }
            else
            {
                stError = objDescuento._Error;
                objDescuento = null;
                return false;
            }
        }

        private double calcularSubtotal(double x)
        {
            x = intValorPasta + (intValorPapel * intCantidadCopias) + (intValorImprecion * intCantidadCopias);
            dblSubtotal = x;
            return x;
        }

        #endregion


        #region "Metodos Publicos"

        public bool calcularTotal()
        {
            double SubTotal;

            if (validar() && calcularPorcentajeDescuento())
            {
                //se calculan los valores
                SubTotal = calcularSubtotal(dblSubtotal);
                dblDescuento = SubTotal * dblDescuento / 100;
                dblTotal = SubTotal - dblDescuento;
                return true;
            }
            else
            {
                
                stError = "Hubo Un Error";
                return false;
            }                
        }
        #endregion

    }
}
