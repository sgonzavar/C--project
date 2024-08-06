using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace libCelular
{
    public class clsRNCelular
    {
        #region "Atrributo"

        private string strTipoEmpresa, strError;
        private double dblPorcentajeIncremento;

        #endregion


        #region "Propiedades"

        public string _TipoEmpresa
        {
            get { return strTipoEmpresa; }
            set { strTipoEmpresa = value; }
        }

        public double _TPorcentajeIncremento
        {
            get { return dblPorcentajeIncremento; }
            set { dblPorcentajeIncremento = value; }
        }

        public string _Error
        {
            get { return strError; }         
        }
        #endregion


        #region "Constructor"

        public clsRNCelular()
        {
 
        }

        #endregion



        public bool calcularPorcentajeIncremento()
        {
            try
            {
                if (validar())
                {
                    XmlDocument oDocumt = new XmlDocument();
                    oDocumt.Load(@"E:\desarrollo software marte jueves\XMLRNCelulares.xml");
                    XmlNodeList oNodo;
                    oNodo = oDocumt.SelectNodes("//PORCENTAJE_INCREMENTO[@Tipo_Empresa = '" + strTipoEmpresa +  "']");
                    dblPorcentajeIncremento = Convert.ToDouble(oNodo[0].InnerText) / 100.0;
                    oNodo = null;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool validar()
        {
            return true;

        }
    }
}
