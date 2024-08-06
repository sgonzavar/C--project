using System;

namespace libDesarrollo_6_8.ClasesBasicas
{
    public class clsMantenimiento
    {
        //Comentarios de una linea
        /*
         * Comentarios de varias lineas
         * El valor de los materiales y de los repuestos tienen el IVA incluido
        */
        #region Atributos
        private Int32 iValorManoObra;
        private Int32 iValorMateriales;
        private double dPorcentajeIVA;
        private Int32 iTotal;
        private Int32 iSubtotal;
        private Int32 iValorIVA;
        private string sError;
        #endregion

        #region Propiedades
        public Int32 ValorManoObra
        {
            get { return iValorManoObra; }
            set { iValorManoObra = value; }
        }
        public Int32 ValorMateriales
        {
            get { return iValorMateriales; }
            set { iValorMateriales = value; }
        }
        public Int32 Total
        {
            get { return iTotal; }
        }
        public Int32 Subtotal
        {
            get { return iSubtotal; }
        }
        public Int32 ValorIVA
        {
            get { return iValorIVA; }
        }
        public string Error
        {
            get { return sError; }
        }
        #endregion
        #region Metodos
        //Retornan un valor: private TipoDato NombreMetodo()
        //                   public
        //                   {
        //                   }
        //No retornan nada   private void NombreMetodo()
        //                   public
        //                   {
        //                   }
        public bool CalcularTotal()
        {
            //El llamado de los métodos se hace invocando el nombre del método
            //y si retornan un valor, se debe asignar a una variable:
            //Variable = NombreMetodo();
            //El subtotal no retorna nada, por eso no se asigna a una variable
            CalcularSubtotal();
            iValorIVA = CalcularIva();
            iTotal = iSubtotal + iValorIVA;
            return true;
        }
        private void CalcularSubtotal()
        {
            dPorcentajeIVA = 0.16;
            iSubtotal = Convert.ToInt32((iValorManoObra + iValorMateriales) / (1.0 + dPorcentajeIVA));
            return;
        }
        private Int32 CalcularIva()
        {
            return Convert.ToInt32 (iSubtotal * dPorcentajeIVA);
        }
        #endregion
    }
}
