using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libDesarrollo_8_10.ReglasNegocio.ReglasNegocio;

namespace libDesarrollo_8_10.ReglasNegocio.Clases
{
    public class clsCelulares
    {
        #region "Atributos"
        private string sTipoEmpresa;
        private double dPorcentajeIncremento;
        private Int32 iValorPlan;
        private Int32 iCantidadMinutosPlan;
        private Int32 iCantidadMinutosAdicionales;
        private Int32 iCantidadMintutosTotales;
        private string sError;
        #endregion
        #region "Propiedades"
        public string TipoEmpresa
        {
            get { return sTipoEmpresa; }
            set { sTipoEmpresa = value; }
        }
        public double PorcentajeIncremento
        {
            get { return dPorcentajeIncremento; }
        }
        public Int32 ValorPlan
        {
            get { return iValorPlan; }
            set { iValorPlan = value; }
        }
        public Int32 CantidadMinutosPlan
        {
            get { return iCantidadMinutosPlan; }
        }
        public Int32 CantidadMinutosAdicionales
        {
            get { return iCantidadMinutosAdicionales; }
        }
        public Int32 CantidadMintutosTotales
        {
            get { return iCantidadMintutosTotales; }
        }
        public string Error
        {
            get { return sError; }
        }
        #endregion
        #region "Metodos"
        private bool CalcularPorcentajeIncremento()
        {
            //Invoca la regla de negocio
            cls_RN_Celulares oCelular = new cls_RN_Celulares();
            oCelular.TipoEmpresa = sTipoEmpresa;
            if (oCelular.CalcularPorcentajeIncremento())
            {
                dPorcentajeIncremento = oCelular.PorcentajeIncremento;
                oCelular = null;
                return true;
            }
            else
            {
                sError = oCelular.Error;
                oCelular = null;
                return false;
            }
        }
        private bool CalcularMinutosPlan()
        {
            if (iValorPlan == 50000 )
            {
                iCantidadMinutosPlan = 500;
                return true;
            }
            else
            {
                if (iValorPlan == 75000)
                {
                    iCantidadMinutosPlan = 1000;
                    return true;
                }
                else
                {
                    if (iValorPlan == 100000)
                    {
                        iCantidadMinutosPlan = 2000;
                        return true;
                    }
                    else
                    {
                        sError = "No definió un valor del plan definido";
                        return false;
                    }
                }
            }
        }
        public bool CalcularTotalMinutos()
        {
            if (CalcularPorcentajeIncremento())
            {
                if (CalcularMinutosPlan())
                {
                    iCantidadMinutosAdicionales = Convert.ToInt32(iCantidadMinutosPlan * dPorcentajeIncremento);
                    iCantidadMintutosTotales = iCantidadMinutosPlan + iCantidadMinutosAdicionales;
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
