using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libComunes.CapaDatos;

namespace libDesarrollo_6_8.BaseDatos
{
    public class clsNacionalidad
    {
        #region "Atributos"
        private Int32 iCodigo;
        private string sNombre;
        private bool bActivo;
        private string sSQL;
        private string sError;
        #endregion
        #region "Propiedades"
        public Int32 Codigo
        {
            get { return iCodigo; }
            set { iCodigo = value; }
        }
        public string Nombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }
        public bool Activo
        {
            get { return bActivo; }
            set { bActivo = value; }
        }
        public string Error
        {
            get { return sError; }
        }
        #endregion
        #region "Metodos"
        public bool Grabar()
        {
            Int16 iActivo;
            if (bActivo) iActivo = 1;
            else iActivo = 0;
            //Ejecuta la instrucción INSERT
            sSQL = "INSERT INTO tblNacionalidad (Nombre, Activo) " +
                   "VALUES ('" + sNombre + "', " + iActivo + ")";

            //Se crea la instancia de la clase conexion
            clsConexion oConexion = new clsConexion();
            //Se pasa el SQL y se ejecuta
            oConexion.SQL = sSQL;
            if (oConexion.EjecutarSentencia())
            {
                //Se libera memoria y se retorna
                oConexion = null;
                return true;
            }
            else
            {
                //Se captura el error, se libera y se retorna
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }
        public bool Actualizar()
        {
            Int16 iActivo;
            if (bActivo) iActivo = 1;
            else iActivo = 0;
            //Ejecuta la instrucción INSERT
            sSQL = "UPDATE  tblNacionalidad " +
                   "SET     Nombre = '" + sNombre + "', " +
                           "Activo = " + iActivo +
                   " WHERE   idNacionalidad = " + iCodigo;

            //Se crea la instancia de la clase conexion
            clsConexion oConexion = new clsConexion();
            //Se pasa el SQL y se ejecuta
            oConexion.SQL = sSQL;
            if (oConexion.EjecutarSentencia())
            {
                //Se libera memoria y se retorna
                oConexion = null;
                return true;
            }
            else
            {
                //Se captura el error, se libera y se retorna
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }
        public bool Borrar()
        {
            //Ejecuta la instrucción INSERT
            sSQL = "DELETE FROM tblNacionalidad " +
                   "WHERE   idNacionalidad = " + iCodigo; 

            //Se crea la instancia de la clase conexion
            clsConexion oConexion = new clsConexion();
            //Se pasa el SQL y se ejecuta
            oConexion.SQL = sSQL;
            if (oConexion.EjecutarSentencia())
            {
                //Se libera memoria y se retorna
                oConexion = null;
                return true;
            }
            else
            {
                //Se captura el error, se libera y se retorna
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }
        public bool Consultar()
        {
            sSQL = " SELECT      Nombre, Activo " +
                   " FROM        tblNacionalidad " +
                   " WHERE      idNacionalidad = " + iCodigo;

            //Se crea el objeto conexion y se pasa el sql
            clsConexion oConexion = new clsConexion();
            oConexion.SQL = sSQL;
            if(oConexion.Consultar())
            {

            }
            else
            {

            }
        }
        #endregion
    }
}
