using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace libMinutos
{
    public class clsMinutos
    {
        #region "Atributos"

        private Int32 intValorRecarga,  intTotal;
        private Int32 intValorMinuto, intTotalMinutos, intTotalMinutosAdicionales;
        private string strError;

        #endregion

        #region "Constructor"

        public clsMinutos()
        {
            this.intTotal = 0;            
            this.intValorMinuto = 200;
            this.intValorRecarga = 0;
            this.intTotalMinutosAdicionales = 0;
            this.intTotalMinutos = 0;
            this.strError = string.Empty;
        }

        #endregion

        #region "Propiedades"

        public Int32 _ValorRecarga
        {
            set { intValorRecarga = value; }
            get { return intValorRecarga; }
        }

        public Int32 _TotalMinutos
        {
            get { return intTotalMinutos; }
        }

        public Int32 _TotalMinutosAdicionales
        {
            get { return intTotalMinutosAdicionales; }
        }

        public Int32 _Total
        {
            get { return intTotal; }
        }

        public string _Error
        {
            get { return strError; }
        }

        #endregion

        #region "Metodos"

        public bool CalcularMinutosAdicionales()
        {
            if (!Validar())           
                return false;           
            try
            {
                if (intValorRecarga < 5000)
                {
                    intTotalMinutosAdicionales = 0;
                }
                else
                {
                    if (intValorRecarga >= 5001 && intValorRecarga <= 10000)
                    {
                        intTotalMinutosAdicionales = 20;
                    }
                    else
                    {
                        if (intValorRecarga >= 10001 && intValorRecarga <= 50000)
                        {
                            intTotalMinutosAdicionales = 100;
                        }
                        else
                        {
                            if (intValorRecarga > 50000)
                            {
                                intTotalMinutosAdicionales = 500;
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;

            }
        }

        public bool CalcularMinuto()
        {
            if(!Validar())
               return false;
            try
            {
                intTotalMinutos = intValorRecarga / intValorMinuto;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }

        }

        public bool CalcularTotal()
        {
            try
            {
                intTotal = intTotalMinutos + intTotalMinutosAdicionales;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }


        #endregion

        #region "Metodos Personalizados"

        private bool Validar()
        {
            try
            {
                if (intValorRecarga < 0)
                {
                    strError = " Digite Un Valor Correcto ";
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

    }
}
