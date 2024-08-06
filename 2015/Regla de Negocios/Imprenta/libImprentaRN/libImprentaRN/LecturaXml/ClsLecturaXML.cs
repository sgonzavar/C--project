using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//para Poder Leer XML
using System.Xml;

namespace libImprentaRN.ReglaDeNegocio
{
    public class ClsLecturaXML
    {
        #region "Atributos"

        private Int32 intCantidadCopia;
        private double dblPorsentajeDescuento;
        private string strError;

        #endregion

        #region "Constructor"
        public ClsLecturaXML()
        {
            this.dblPorsentajeDescuento = 0.0;
            this.intCantidadCopia = 0;
            this.strError = string.Empty;
        }

        #endregion

        #region "Propiedades"

        public int _CantidadCopia
        {
            get { return intCantidadCopia; }
            set { intCantidadCopia = value; }
        }

        public double _PorsentajeDescuento
        {
            get { return dblPorsentajeDescuento; }
            set { dblPorsentajeDescuento = value; }
        }

        public string _Error
        {
            get { return strError; }
        }

        #endregion


        #region "Metodos Privados"
        private bool validar()
        {
            if (intCantidadCopia < 0)
            {
                strError = "La cantidad de Copias debe ser mayor a cero";
                return false;
            }
            return true;
        }

        #endregion


        #region "Metodos Publicos"

        public bool calcularPorcentaje()
        {
            if (validar())
            {
                try
                {
                    //crear el objteto xmldocument
                    XmlDocument objXml = new XmlDocument();

                    //Se abre el archivo
                    objXml.Load("C:\\Users\\santiago\\Desktop\\libImprentaRN\\libImprentaRN\\XML\\XMLImprenta.xml");

                    //se crea el nnodo para capturar la consulta del archivo xml
                    //es una clase estatica que solo se crea cuando se hace la consulta en el objeto xmldocument
                    XmlNodeList oNodoXml;

                    //se consulta en el xml con xpath, y se asigna al nodo condiciones entre corchetes
                    oNodoXml = objXml.SelectNodes("//porcentaje_descuento[@Cantidad_Minima<=" + intCantidadCopia + "and @Cantidad_Maxima>= " + intCantidadCopia + "]");

                    // En el nodo queda el valor deseado, llevar a la variable
                    dblPorsentajeDescuento = Convert.ToDouble(oNodoXml[0].InnerText);

                    oNodoXml = null;
                    objXml = null;
                    return true;
                }
                catch (Exception ex)
                {
                    strError = ex.Message;
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
