using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRenovacionLicencia
{
    public class clsLicencia
    {
        #region "Atributos"
        Int32 intCantidadClasesPracticas, intValorPracticas, intCantidadClasesPracticasMinimas;
        bool boolTomarCurso;
        Int32 intValorCursoTeorico, intValorExamenSuficia, intValorLicencia;
        Int32 intSubtotal, intValorIva, intValorpagar, intValorClasePractica;
        double dblPorcentajeIva;
        string strError;
        #endregion

        #region "Contructor"

        public clsLicencia()
        {
            dblPorcentajeIva = 0.16;
            intCantidadClasesPracticasMinimas =  8;
            intValorExamenSuficia = 50000;
            intValorClasePractica = 30000;
            intCantidadClasesPracticas = -1;
            intValorCursoTeorico = 75000;
            intValorLicencia = 125000;
        }
        #endregion

        #region "Propiedades"
        public Int32 _CantidadPracticas
        {
            get { return intCantidadClasesPracticas; }
            set { intCantidadClasesPracticas = value; }
        }

        public Int32 _subtotal
        {
            get { return intSubtotal; }          
        }

        public Int32 _ValorIva
        {
            get { return intValorIva; }
        }

        public string _Error
        {
            get { return strError; }
        }

        public bool _tomarCurso
        {
            get { return boolTomarCurso; }
            set { boolTomarCurso = value; }
        }

        #endregion

        #region " Metodos "

        private bool validar()
        {
            if (intCantidadClasesPracticas < intCantidadClasesPracticasMinimas && intCantidadClasesPracticas != 0)
            {
                strError = "No definio Cantida De Clases Practicas Correctas";
                return false;
            }
            return true;
        }

        private void CalcularIva()
        {
            CalcularSubtotal();
            intValorIva =  Convert.ToInt32(intValorpagar / (1 + dblPorcentajeIva));
        }

        private void CalcularSubtotal()
        {

            intSubtotal = intValorpagar - intValorIva;
        }

        public bool CalcularPagar()
        {

            if (!validar())
            {
                intValorPracticas = intCantidadClasesPracticas * intValorClasePractica;
                if (boolTomarCurso)
                {
                    intValorpagar = intValorPracticas + intValorCursoTeorico + intValorLicencia;
                }
                else
                {
                    intValorpagar = intValorPracticas + intValorLicencia + intValorExamenSuficia;
                }
                CalcularIva();
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion
    }
}
