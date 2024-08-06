using System;
using System.Xml;

namespace libDesarrollo_8_10.ReglasNegocio.ReglasNegocio
{
    public class cls_RN_Celulares
    {
        #region "Atributos"
        private string sTipoEmpresa;
        private double dPorcentajeIncremento;
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
        public string Error
        {
            get { return sError; }
        }
        #endregion
        #region "Metodos"
        public bool CalcularPorcentajeIncremento()
        {
            if (Validar())
            {
                try
                {
                    XmlDocument oDocumento = new XmlDocument();
                    oDocumento.Load(@"C:\Users\docenteitm\Documents\XMLRNCelulares.xml");
                    XmlNodeList oNodo;
                    oNodo = oDocumento.SelectNodes("//PORCENTAJE_INCREMENTO[@Tipo_Empresa='" + sTipoEmpresa + "']");
                    dPorcentajeIncremento = Convert.ToDouble(oNodo[0].InnerText) / 100.0;
                    //dPorcentajeIncremento = Convert.ToDouble(oNodo[0].Attributes["Valor"]);
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
            else
            {
                return false;
            }
        }
        private bool Validar()
        {
            return true;
        }
        #endregion
    }
}
