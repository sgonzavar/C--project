using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libDSI54.ReglasNegocio.ReglasNegocio;

namespace libDSI54.ReglasNegocio.Clases
{
    public class clsPlanesCorporativos
    {
        #region Constructor
        public clsPlanesCorporativos()
        {
            sTipoCliente = "REGULAR";
            iValorPlan = 0;
        }
        #endregion

        #region Atributos
        private string sTipoCliente;
        private double dPorcentajeIncremento;
        private int iValorPlan;
        private int iCantidadMinutosPlan;
        private int iCantidadMinutosAdicionales;
        private int iCantidadMinutosTotales;
        private string sError;
        #endregion

        #region Propiedades
        public string tipoCliente
        {
            get { return sTipoCliente; }
            set { sTipoCliente = value; }
        }
        
        public int valorPlan
        {
            get { return iValorPlan; }
            set { iValorPlan = value; }
        }

        public int cantidadMinutosPlan
        {
            get { return iCantidadMinutosPlan; }
        }

        public int cantidadMinutosAdicionales
        {
            get { return iCantidadMinutosAdicionales; }
        }

        public int cantidadMinutosTotales
        {
            get { return cantidadMinutosTotales; }
        }

        public string error
        {
            get { return sError; }
        }
        #endregion

        #region Metodos
        private bool calcularPorcentajeIncremento()
        {
            // Invoca la regla de negocio
            clsRNPlanesCorporativos oIncremento = new clsRNPlanesCorporativos();
            oIncremento.tipoCliente = sTipoCliente;
            if (oIncremento.calcularPorcentaje())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool calcularMinutosPlan()
        {
            switch (iValorPlan)
            {
                case 50000:
                    iCantidadMinutosPlan = 500;
                    return true;
                case 75000:
                    iCantidadMinutosPlan = 1000;
                    return true;
                case 100000:
                    iCantidadMinutosPlan = 2000;
                    return true;
                default:
                    iCantidadMinutosPlan = 0;
                    return false;
            }
        }

        public bool calcularMinutos()
        {

            return false;
        }
        #endregion

    }
}
