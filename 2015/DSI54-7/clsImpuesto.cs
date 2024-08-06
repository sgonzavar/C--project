using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libDesarrollo_6_8.ClasesBasicas
{
    public class clsImpuesto
    {
        #region "Constructor"
        //public NombreClase()
        public clsImpuesto()
        {
            iIngresoAnual = 0;
            iRetencionFuente = -1;
        }
        #endregion
        #region "Atributos"
        private Int32 iIngresoAnual;
        private Int32 iRetencionFuente;
        private Int32 iValorImpuestoTeorico;
        private Int32 iValorPagar;
        private double dPorcentajeImpuesto;
        private string sError;
        #endregion
        #region "Propiedades"
        public Int32 IngresoAnual
        {
            get { return iIngresoAnual; }
            set { iIngresoAnual = value; }
        }
        public Int32 RetencionFuente
        {
            get { return iRetencionFuente; }
            set { iRetencionFuente = value; }
        }
        public Int32 ValorImpuestoTeorico
        {
            get { return iValorImpuestoTeorico; }
        }
        public Int32 ValorPagar
        {
            get { return iValorPagar; }
        }
        public string Error
        {
            get { return sError; }
        }
        #endregion
        #region "Metodos"
        private bool Validar()
        {
            //Se validan los datos de entrada
            if (iIngresoAnual <= 0)
            {
                sError = "No definió el ingreso anual";
                return false;
            }
            if (iRetencionFuente < 0)
            {
                sError = "No definió la retención del usuario";
                return false;
            }
            return true;
        }
        #endregion
    }
}
