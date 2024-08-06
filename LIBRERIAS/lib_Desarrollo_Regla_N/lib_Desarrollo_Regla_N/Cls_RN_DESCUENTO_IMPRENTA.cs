using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lib_Desarrollo_Regla_N
{
    public class Cls_RN_DESCUENTO_IMPRENTA
    {
        #region "Atributos"

        private Int32 intCantidadLibros;
        private double dblPorsentajeDescuento;
        private string strError;

        #endregion

        #region "Constructor"
        public Cls_RN_DESCUENTO_IMPRENTA()
        {

        }
        #endregion

        #region "Propiedades"

        public int _CantidadLibros
        {
            get { return intCantidadLibros; }
            set { intCantidadLibros = value; }
        }

        public double _PorsentajeDescuento
        {
            get { return dblPorsentajeDescuento; }
            set { dblPorsentajeDescuento = value; }
        }

        public string _Error
        {
            get { return strError;  }
        }

        #endregion


        #region "Metodos"

        public bool calcularPorcentaje()
        {
            if (validar())
            {
                try
                {
                    //crear el objteto xmldocument
                    XmlDocument objXml = new XmlDocument();

                    //Se abre el archivo
                    objXml.Load(@"E:\lib_Desarrollo_Regla_N\lib_Desarrollo_Regla_N\XML\XML_imprenta.xml");

                    //se crea el nnodo para capturar la consulta del archivo xml
                    //es una clase estatica que solo se crea cuando se hace la consulta en el objeto xmldocument
                    XmlNodeList oNodoXml;

                    //se consulta en el xml con xpath, y se asigna al nodo condiciones entre corchetes
                    oNodoXml = objXml.SelectNodes("//porcentaje_descuento[@Cantidad_Minima<=" + intCantidadLibros + "and @Cantidad_Maxima>= " + intCantidadLibros + "]");

                    //en el objeto nodo, queda el nodo con los valores de la respuesta
                    dblPorsentajeDescuento = Convert.ToDouble(oNodoXml[0].InnerText) / 100;
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

        public bool validar()
        {
            if (intCantidadLibros < 0)
            {
                strError = "La cantidad de libros debe ser mayor a cero";
                return false;
            }
            return true;
        }


        #endregion
    }
}
