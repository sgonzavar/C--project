using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referenciar y usar
using System.IO; // para leer el archivo plano 

namespace LibRn
{
    public class clsRNDscProd
    {
        #region "Atributos"
        private int intCodigo;
        private double dblPorcDescto;
        private string strError;
        #endregion

        #region "Constructor"
        public clsRNDscProd()
        {
            intCodigo = 0;
            dblPorcDescto = 0;
            strError = string.Empty;
        }

        #endregion

        #region "Propiedades"

        public int Codigo
        { set { intCodigo = value; } }

        public double PorcDscto
        { get { return dblPorcDescto; } }

        public string Error
        { get { return strError; } }

        #endregion

        #region "Metodos Privados"

        private bool LeerArchivo()
        {
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"ListaDescuento.txt";
                int intCant = 0;
                string[] vectorLinea;
                string strlinea, strCodigo;
                intCant = File.ReadAllLines(strPath).Length;
                if (intCant <= 0)
                    return true;
                StreamReader Archivo = new StreamReader(@strPath); // crea el objeto para leer el archivo
                while ((strlinea = Archivo.ReadLine()) != null)  // leer Linea por linea el archivo
                {
                    vectorLinea = strlinea.Split(':');
                    strCodigo = vectorLinea[0]; // Nombre dato
                    if (strCodigo == intCodigo.ToString())
                    {
                        dblPorcDescto = Convert.ToDouble(vectorLinea[1]); // valor Dato
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
