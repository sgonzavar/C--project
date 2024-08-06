using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace libRN
{
    public class clsRN
    {
        #region "Atributos"
        private string strCargo;
        private int intHora;
        private double dblPrecioHora, dblRetencion, dblRecargo;
        private string strError;
        #endregion
          
        
        
        #region "Constructor"
        public clsRN()
        {
            strCargo = "";
            intHora = 0;
            dblPrecioHora = 0;
            dblRecargo = 0;
            dblRetencion = 0;
            strError = string.Empty;
        }
           #endregion

        #region "Propiedades"

        public string Cargo
        { get {  return strCargo; } }

        public int Hora
        { set { intHora = value; } }
      
        public double PrecioHora
        { set { dblPrecioHora = value; } }

        public double Recargo
        { set { dblRecargo = value; } }

        public double Retencion
        { set { dblRetencion = value; } }
        
        public string error
        { get { return strError; } }
        #endregion


       
        
        #region "Metodos Privados"

        private bool LeerArchivo()
        {
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"Parcial2.txt";
                int intCant = 0;
                string[] vectorLinea;
                string strlinea,strCargo;
                intCant = File.ReadAllLines(strPath).Length;
                if (intCant <= 0)
                    return true;
                StreamReader Archivo = new StreamReader(@strPath); // crea el objeto para leer el archivo
                while ((strlinea = Archivo.ReadLine()) != null)  // leer Linea por linea el archivo
                {
                    vectorLinea = strlinea.Split('?');
                    strCargo = vectorLinea[0]; // Nombre dato
                    if (strCargo == Cargo )
                    {
                        dblRecargo = Convert.ToDouble(vectorLinea[1]); // valor Dato
                        dblPrecioHora = Convert.ToDouble(vectorLinea[2]); // valor Dato
                        dblRetencion = Convert.ToDouble(vectorLinea[3]); // valor Dato
                        
                         
                        break;
                    }
                }
                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion

        #region"Metodos Publicos"
        public bool Consultar()
        {
            return LeerArchivo();
        }
        #endregion





    }
}
