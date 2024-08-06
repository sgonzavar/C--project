using System;
using System.Xml;
using System.Globalization;

namespace libDesarrollo_8_10.ReglasNegocio.ReglasNegocio
{
    public class cls_RN_RecargaCelular
    {
        #region "Atributos"
        private string sDia;
        private string sNumeroCelular;
        private double dPorcentajeIncremento;
        private string sError;
        #endregion

        #region "Propiedades"
        public string NumeroCelular
        {
            get { return sNumeroCelular; }
            set { sNumeroCelular = value; }
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
            try
            {
                string sUltimoDigito = sNumeroCelular.Substring(sNumeroCelular.Length - 1, 1);
                CultureInfo ci = new CultureInfo("Es-ES");
                sDia = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);

                //string sDiaSemana = DateTime.Now.DayOfWeek.ToString();
                //Consulta del porcentaje por empresa
                XmlDocument oDocumento = new XmlDocument();
                oDocumento.Load(@"C:\Users\docenteitm\Documents\XML_RN_RecargaCelular.xml");
                XmlNodeList oNodo;
                oNodo = oDocumento.SelectNodes("Porcentaje_Incremento[@Ultimo_Digito='" + sUltimoDigito +
                                "' and @Dia='" + sDia + "']");
                dPorcentajeIncremento = Convert.ToDouble(oNodo[0].InnerText) / 100.0;

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
