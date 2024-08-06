using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace libDSI54.ReglasNegocio.ReglasNegocio
{
    public class clsRNPlanesCorporativos
    {
        #region Constructor
        public clsRNPlanesCorporativos()
        {
            sTipoCliente = "REGULAR";
        }
        #endregion

        #region Atributos
        private string sTipoCliente;
        private double dPorcentajeIncremento;
        private string sError;
        #endregion

        #region Propiedades
        public string tipoCliente
        {
            get { return sTipoCliente; }
            set { sTipoCliente = value; }
        }

        public double porcentajeIncremento
        {
            get { return dPorcentajeIncremento; }
        }

        public string error
        {
            get { return sError; }
        }
        #endregion

        #region Metodos
        public bool calcularPorcentaje()
        {
            if (validar())
            {
                try
                {
                    XmlDocument oDocument = new XmlDocument();
                    oDocument.Load(@"C:\Users\salan503\Documents\XMLPlanesCorporativos.xml");
                    XmlNode oNode;
                    oNode = oDocument.SelectSingleNode("//PORCENTAJE_INCREMENTO[@TipoCliente='" + sTipoCliente + "']");
                    dPorcentajeIncremento = Convert.ToDouble(oNode.InnerText) / 100.0;
                    oNode = null;
                    oDocument = null;
                    return true;
                }
                catch (Exception e)
                {
                    sError = e.Message;
                    return false;
                }
            } else
            {
                return false;
            }
        }

        private bool validar()
        {
            if (sTipoCliente.ToUpper().Equals("GOLD") ||
                sTipoCliente.ToUpper().Equals("SILVER") ||
                sTipoCliente.ToUpper().Equals("BRONZE") ||
                sTipoCliente.ToUpper().Equals("REGULAR"))
            {
                return true;
            }
            else
            {
                sError = "Tipo de cliente errado.";
                return false;
            }
        }
        #endregion
    }
}
