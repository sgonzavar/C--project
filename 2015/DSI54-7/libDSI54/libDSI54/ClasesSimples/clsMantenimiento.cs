using System;

namespace libDSI54.ClasesSimples
{
    public class clsMantenimiento
    {
        #region Atributos
        private int iValorManoObra;
        private int iValorMateriales;
        private int iValorIVA;
        private double dPorcentajeIVA;
        private int iSubtotal;
        private int iTotal;
        private string sError;
        #endregion

        #region Propiedades
        public int valorManoObra
        {
            get { return iValorManoObra; }
            set { iValorManoObra = value; }
        }

        public int valorMateriales
        {
            get { return iValorMateriales; }
            set { iValorMateriales = value; }
        }

        public int valorIVA
        {
            get { return iValorIVA; }
        }

        public int subtotal
        {
            get { return iSubtotal; }
        }

        public int total
        {
            get { return iTotal; }
        }

        public string error
        {
            get { return sError; }
        }
        #endregion

        #region Metodos
        public bool calcularTotal()
        {
            calcularSubtotal();
            iValorIVA = calcularIVA();
            iTotal = iSubtotal + iValorIVA;
            return true;
        }

        public void calcularSubtotal()
        {
            dPorcentajeIVA = 0.16;
            iSubtotal = Convert.ToInt32((iValorManoObra + iValorMateriales) / (1.0 + dPorcentajeIVA));
            return;
        }

        public int calcularIVA()
        {
            return Convert.ToInt32(iSubtotal * dPorcentajeIVA);
        }
        #endregion
    }
}
