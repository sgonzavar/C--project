using System;
using libDSI54.ReglasNegocio.ReglasNegocio;

namespace libDSI54.ReglasNegocio.Clases
{
    public class clsImprenta
    {
        #region Constructor
        public clsImprenta()
        {
            iCantidadLibros = 0;
            dValorUnitario = 12500;
        }
        #endregion

        #region Atributos
        private int iCantidadLibros; // LyE
        private double dValorUnitario; // P
        private double dPorcentajeDescuento; // P
        private double dValorDescuento; // L
        private double dSubtotal; // L
        private double dTotal; // L
        private string sError; // L
        #endregion

        #region Propiedades
        public int cantidadLibros
        {
            get { return iCantidadLibros; }
            set { iCantidadLibros = value; }
        }

        public double valorDescuento
        {
            get { return dValorDescuento; }
        }

        public double subtotal
        {
            get { return dSubtotal; }
        }

        public double total
        {
            get { return dTotal; }
        }

        public string error
        {
            get { return sError; }
        }
        #endregion

        #region Metodos
        private bool validar()
        {
            if (iCantidadLibros <= 0)
            {
                sError = "La cantidad de libros debe ser mayor que cero";
                return false;
            }
            if (iCantidadLibros >= 100000000)
            {
                sError = "No podemos vender tantos libros";
                return false;
            }
            return true;
        }

        private bool calcularPorcentajeDescuento()
        {
            // Invocar la regla de negocio
            clsRNDescuentoImprenta oDescuento = new clsRNDescuentoImprenta();
            oDescuento.cantidadLibros = iCantidadLibros;
            if (oDescuento.calcularPorcentaje())
            {
                dPorcentajeDescuento = oDescuento.porcentajeDescuento;
                oDescuento = null;
                return true;
            }
            else
            {
                sError = oDescuento.error;
                oDescuento = null;
                return false;
            }
        }

        public bool calcularTotal()
        {
            if (validar())
            {
                if (calcularPorcentajeDescuento())
                {
                    dSubtotal = iCantidadLibros * dValorUnitario;
                    dValorDescuento = dSubtotal * dPorcentajeDescuento;
                    dTotal = dSubtotal - dValorDescuento;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
