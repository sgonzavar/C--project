using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace libAgencia.Xml
{
    public class cls_RN_Agencia
    {
        #region "Constructor"
        public cls_RN_Agencia()
        {
            this.dPorcentajeDescuento = 0.0;
            this.iCantidadAnios = 0;
            this.sError = string.Empty;
        }
        #endregion

        #region "Atributos"
        private Int32 iCantidadAnios;
        private double dPorcentajeDescuento;
        private string sError;
        #endregion

        #region "Propiedades"
        public Int32 CantidadAnos
        {
            get
            {
                return iCantidadAnios;
            }
            set
            {
                iCantidadAnios = value;
            }
        }
        public double PorcentajeDescuento
        {
            get
            {
                return dPorcentajeDescuento;
            }
        }
        public string Error
        {
            get
            {
                return sError;
            }
        }
        #endregion

        #region "Metodos"
        public bool CalcularPorcentajeDescuento()
        {
            try
            {
                //Consulta del porcentaje
                XmlDocument oDocumento = new XmlDocument();
                oDocumento.Load(@"E:\libAgencia\libAgencia\Xml\xml_Examen2.xml");
                XmlNodeList oNodo;
                oNodo = oDocumento.SelectNodes("//Descuentos[@AnosMinimo<=" + iCantidadAnios +
                                    " and @AnosMaximo>=" + iCantidadAnios + "]");
                dPorcentajeDescuento = Convert.ToDouble(oNodo[0].InnerText) / 100.0;

                oNodo = null;
                oDocumento = null;
                return true;
            }

            catch (Exception ex)
            {
                sError = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
