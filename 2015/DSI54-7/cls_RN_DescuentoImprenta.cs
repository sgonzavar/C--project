using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;                             //Se agrega esta libreria para leer y manipular archivos xml
namespace libDesarrollo_6_8.ReglasNegocio.ReglasNegocio
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
        private Int32 iCantidadLibros;
        private double dPorcentajeDescuento;
        private string sError;
        #endregion

        #region Propiedades
        public int CantidadLibros
        {
            get  { return iCantidadLibros;  }

            set  { iCantidadLibros = value; }
        }

        public double PorcentajeDescuento
        {
            get  { return dPorcentajeDescuento;}           
        }

        public string Error
        {
            get { return sError; }

        }
        #endregion

        #region Metodos
            public bool CalcularPorcentaje()
            {
                if(Validar())
                {

           
                    try
                    {                           
                    //Crear el documento XMLDocument
                    XmlDocument oDocumento = new XmlDocument();
                    //Se abre el archivo
                    oDocumento.Load(@"C:\Users\docenteitm\Documents\XMLDescuentoImprenta.xml");

                    //Se crea el objeto xmlNodoList para capturar la consulta del archivo xml
                    //Es una clase que solo se crea cuando se hace la consulta en el objeto xmlDocumento
                    XmlNodeList oNodo;
                    //Se consulta en el xml con xpath, y se le asigna al nodo
                    oNodo = oDocumento.SelectNodes("//PORCENTAJE_DESCUENTO[@Cantidad_Minima<="+ 
                                            iCantidadLibros + "and @Cantidad_Maxima>=" + 
                                            iCantidadLibros + "]");
                    //En el objeto nodo, queda el nodo con los valores de la respusta
                    dPorcentajeDescuento = Convert.ToDouble(oNodo[0].InnerText)/100.0;
                    oDocumento = null;
                    oNodo = null;
                    return true;
                    }//end ty
                    catch(Exception ex)
                    {
                        sError = ex.Message;
                        return false;
                    }//end catch
                }//end validar
                 else
                {          
                return false;
                }
            }//end definirPorcentaje

        private bool Validar()
        {
            if (iCantidadLibros <= 0)
            {
                sError = "La cantidad de libros debe ser mayor que cero";
                return false;
            }
            return true;
        }
        #endregion
    }//end class
}//end namespace
