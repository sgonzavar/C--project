using System;

namespace libDSI54.ClasesSimples
{
    public class clsImpuesto
    {
        #region Constructor
        public clsImpuesto()
        {
            iIngresoAnual = 0;
            iRetencionFuente = -1;
        }
        #endregion

        #region Atributos
        private int iIngresoAnual;
        private int iRetencionFuente;
        private int iValorImpuestoTeorico;
        private int iValorPagar;
        private double dPorcentajeImpuesto;
        private string sError;
        #endregion

        #region Propiedades
        public int ingresoAnual
        {
            get { return iIngresoAnual; }
            set { iIngresoAnual = value; }
        }

        public int retencionFuente
        {
            get { return iRetencionFuente; }
            set { iRetencionFuente = value; }
        }

        public int valorImpuestoTeorico
        {
            get { return iValorImpuestoTeorico; }
        }

        public int valorPagar
        {
            get { return iValorPagar; }
        }
        public string error
        {
            get { return sError; }
        }
        #endregion

        #region Metodos
        public bool calcularPagoImpuesto()
        {
            if (esValido())
            {
                calcularImpuestoTeorico();
                iValorPagar = iValorImpuestoTeorico - iRetencionFuente;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void calcularImpuestoTeorico()
        {
            if (iIngresoAnual < 30000000)
            {
                dPorcentajeImpuesto = 0.0;
            }
            else if (iIngresoAnual < 50000000)
            {
                dPorcentajeImpuesto = 0.06;
            }
            else
            {
                dPorcentajeImpuesto = 0.12;
            }
            iValorImpuestoTeorico = Convert.ToInt32(iIngresoAnual * dPorcentajeImpuesto);
        }

        private bool esValido()
        {
            // Se validan los datos de entrada
            if (iIngresoAnual <= 0)
            {
                sError = "Ingreso anual no definido";
                return false;
            }
            if (iRetencionFuente < 0)
            {
                sError = "Rentención no definida";
                return false;
            }
            if (iRetencionFuente >= iIngresoAnual)
            {
                sError = "El ingreso anual debe ser mayor que la retención";
                return false;
            }
            return true;
        }
        #endregion
    }
}
