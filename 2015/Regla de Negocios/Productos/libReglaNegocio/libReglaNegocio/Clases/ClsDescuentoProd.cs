using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace libReglaNegocio
{
    public class ClsDescuentoProd
    {
        #region "Atributos"

        private int intcodigo;
        private double dblPorcentajeDescuento;
        private string strError;
        #endregion

        #region "Propiedades"

        public int _Codigo
        {
            set { intcodigo = value; }
        }

        public double _Descuento
        {
            get { return dblPorcentajeDescuento; }
        }


        public string _Error
        {
            get { return strError; } 
        }
        #endregion

        #region "Metodos Privados"

        private bool LeerArchivo()
        {
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"ListaDescuento.txt";
                int intCantidad = 0;
                string[] vectorLinea;
                string strLines;
                string strCodigo;
                intCantidad = File.ReadAllLines(strPath).Length;
                if (intCantidad <= 0) return true;

                StreamReader Archivo = new StreamReader(@strPath);
                 while ((strLines = Archivo.ReadLine()) != null)
                 {
                     vectorLinea = strLines.Split('/');
                    strCodigo = vectorLinea[0];
                     if (strCodigo == intcodigo.ToString())
                     {
                          dblPorcentajeDescuento = Convert.ToDouble(vectorLinea[1]);
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

        #region "Metodos Publicos"
        public bool Cosnultar()
        {
            return LeerArchivo();
        }
        #endregion

    }
}
