using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace libPersonasRN.LecturaXML
{
    public class LeerXml
    {

        #region "Atributos"

        private string strNombre, strApellido, strCargo, strTelCasa;
        private string strTelTrabajo, strTelCelular, strError;

        #endregion

        #region "Constructor"
        public LeerXml()
        {
            this.strNombre = string.Empty;
            this.strApellido = string.Empty;
            this.strCargo = string.Empty;
            this.strTelCasa = string.Empty;
            this.strTelTrabajo = string.Empty;
            this.strTelCelular = string.Empty;
            this.strError = string.Empty;
        }

        #endregion

        #region "Propiedades"

        public string _Nombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }


        public string _Apellido
        {
            get { return strApellido; }
            set { strApellido = value; }
        }


        public string _CArgo
        {
            get { return strCargo; }
            set { strCargo = value; }
        }


        public string _TelefonoCasa
        {
            get { return strTelCasa; }
            set { strTelCasa = value; }
        }


        public string _TelefonoCelular
        {
            get { return strTelCelular; }
            set { strTelCelular = value; }
        }

            
        public string _TelefonoOficina
        {
            get { return strTelTrabajo; }
            set { strTelTrabajo = value; }
        }

        
        public string _Error
        {
            get { return strError; }
            
        }

        
        

        


        

        #endregion

        #region "Metodos"
        
        public bool consulta()
        {
            try
            {
                XmlDocument objDoc = new XmlDocument();
                objDoc.Load(@"C:\Users\santiago\Desktop");

                XmlNode oNodo;
                oNodo = objDoc.SelectSingleNode("//NOMBRE");
                strNombre = oNodo.InnerText;

                XmlNode oNodo1;
                oNodo1 = objDoc.SelectSingleNode("//APELLIDOS");
                strNombre = oNodo.InnerText;

                XmlNode oNodo2;
                oNodo2 = objDoc.SelectSingleNode("//CARGO");
                strNombre = oNodo.InnerText;

                XmlNodeList oNodo3;
                oNodo3 = objDoc.SelectNodes("//TELEFONO");
                strNombre = oNodo.InnerText;

               

            }
            catch (Exception ex)
            {
                strError = ex.Message;
            }
        }

        #endregion



    }
}
