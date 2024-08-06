using System;
using System.Xml;

namespace libDSI54.ReglasNegocio.ReglasNegocio
{
    public class clsRNDescuentoImprenta
    {
        #region Constructor
        public clsRNDescuentoImprenta()
        {
            iCantidadLibros = 0;
        }
        #endregion

        #region Atributos
        private int iCantidadLibros;
        private double dPorcentajeDescuento;
        private string sError;
        #endregion

        #region Propiedades
        public int cantidadLibros
        {
            get { return iCantidadLibros; }
            set { iCantidadLibros = value; }
        }

        public double porcentajeDescuento
        {
            get { return dPorcentajeDescuento; }
        }

        public string error
        {
            get { return sError; }
        }
        #endregion

        #region Metodos
        public bool calcularPorcentaje()
        {
            if (validar()) {
                try
                {
                    // Crear un objeto XML
                    XmlDocument oDocumento = new XmlDocument();
                    // Abrir el archivo
                    oDocumento.Load(@"C:\Users\salan503\Documents\XMLDescuentoImprenta.xml");
                    // Crear un objeto nodo para capturar la consulta del archivo XML
                    XmlNode oNodo;
                    // Consultar el XML con XPath y se asigna al nodo
                    oNodo = oDocumento.SelectSingleNode("//PORCENTAJE_DESCUENTO[@Cantidad_Minima <=" +
                                                        iCantidadLibros + " and @Cantidad_Maxima >=" +
                                                        iCantidadLibros + "]");
                    // En el nodo queda el valor deseado, llevar a la variable
                    dPorcentajeDescuento = Convert.ToDouble(oNodo.InnerText) / 100.0;
                    oDocumento = null;
                    oNodo = null;
                    return true;
                }
                catch(Exception e)
                {
                    sError = e.Message;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool validar()
        {
            if (iCantidadLibros <= 0)
            {
                sError = "La cantidad de libros debe ser mayor que cero";
                return false;
            }
            if (iCantidadLibros >= 100000000)
            {
                sError = "No podemos vender tantos libros";
                return false;
            }
            return true;
        }
        #endregion
    }
}
