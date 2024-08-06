using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace libDSI54.ReglasNegocio.ReglasNegocio
{
    public class cls_RN_DescuentoImprenta
    {
        #region Constructor
        public cls_RN_DescuentoImprenta()
        {
            iCantidadLibros = 0;
        }
        #endregion

        #region Atributos
        private int iCantidadLibros;
        private double dPorcentajeDescuento;
        private string sError;

        public int CantidadLibros
        {
            get { return iCantidadLibros; }
            set { iCantidadLibros = value; }
        }

        public double PorcentajeDescuento
        {
            get { return dPorcentajeDescuento; }
        }

        public string Error
        {
            get { return sError; }
        }
        #endregion

        #region Propiedades

        #endregion

        #region Metodos
        #endregion
    }
}
