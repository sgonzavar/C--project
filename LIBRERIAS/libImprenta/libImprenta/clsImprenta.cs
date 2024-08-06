using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libImprenta
{
    public class clsImprenta
    {
        #region "Atributos"

        private Int32 intCantidadHojas, intValorPapel, intValorImpresion;
        private Int32 intValorPasta, IntValorTotal, intPasta, intImpresion, intPapel;
        private string strError;

        #endregion


        #region "Constructor"

        public clsImprenta()
        {
            intCantidadHojas = 0;
            intValorPapel = 0;
            intValorImpresion = 0;
            intValorPasta = 0;
            IntValorTotal = 0;
            intPasta = 0;
            intImpresion = 0;
            intPapel = 0;
            strError = string.Empty; 
        }

        #endregion




        #region "Propiedades"

        public Int32 _CantidadHojas
        {
            set { intCantidadHojas = value; }
            get { return intCantidadHojas; }
        }

        public Int32 _Papel
        {
            set { intPapel = value; }
            get { return intPapel; }
        }

        public Int32 _Impresion
        {
            set { intImpresion = value; }
            get { return intImpresion; }
        }

        public Int32 _Pasta
        {
            set { intPasta = value; }
            get { return intPasta; }
        }

        public Int32 _ValorPapel
        {
            get { return intValorPapel; }
        }

        public Int32 _ValorImpresion
        {
            get { return intValorImpresion; }
        }

        public Int32 _ValorPaste
        {
            get { return intValorPasta; }
        }

        public Int32 _ValorTotal
        {
            get { return IntValorTotal; }
        }

        public string _Error
        {
            get { return strError; }
        }

        #endregion 

        #region " Metodos Personalizados "

        private bool validar()
        {
            try
            {
                if (intCantidadHojas < 0)
                {
                    strError = "Digite Un Valor Correcto";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        #endregion

        #region "Metodos Privados"

        public bool calcularPapel()
        {
            if (!validar())
                return false;
            try
            {
                intValorPapel = intPapel * intCantidadHojas;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        public bool calcularPasta()
        {
            if (!validar())
                return false;
            try
            {
                intValorPasta = intPasta * intCantidadHojas;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        public bool calcularimpresion()
        {
            if (!validar())
                return false;
            try
            {
                intValorImpresion = intImpresion * intCantidadHojas;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        #endregion 

        #region"Metodos Publicos"

        public bool Facturar()
        {
            try
            {
                IntValorTotal = this.intValorImpresion +this.intValorPapel + this.intValorPasta;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }


        #endregion

    }
}
