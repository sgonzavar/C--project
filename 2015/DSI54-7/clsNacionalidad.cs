using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libComunes.CapaDatos;

namespace libDSI54.BaseDatos
{
    public class clsNacionalidad
    {
        #region Atributos
        private int iCodigo;
        private string sNombre;
        private bool bActivo;
        private string sSQL;
        private string sError;
        #endregion

        #region Propiedades
        public int codigo
        {
            get { return iCodigo; }
            set { iCodigo = value; }
        }

        public string nombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }

        public bool activo
        {
            get { return bActivo; }
            set { bActivo = value; }
        }

        public string error
        {
            get { return sError; }
            set { sError = value; }
        }
        #endregion

        #region Metodos
        public bool Insertar()
        {
            // Método que ejecuta la instrucción INSERT
            //int iActivo;
            //if (bActivo) iActivo = 1;
            //else iActivo = 0;

            // Crear la instrucción SQL
            sSQL = " INSERT INTO tblNacionalidad (Nombre, Activo) " +
                   " VALUES ('" + sNombre + "', " + Convert.ToInt16(bActivo) + ") ";

            // Crear la instancia de la clase conexión
            clsConexion oConexion = new clsConexion();

            // Pasar el SQL y ejecutar
            oConexion.SQL = sSQL;
            if (oConexion.EjecutarSentencia())
            {
                // Liberar memoria y retornar
                oConexion = null;
                return true;
            }
            else
            {
                // Capturar el error, liberar y retornar
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }

        public bool Actualizar()
        {
            // Método que ejecuta la instrucción UPDATE
            //int iActivo;
            //if (bActivo) iActivo = 1;
            //else iActivo = 0;

            // Crear la instrucción SQL
            sSQL = " UPDATE tblNacionalidad " +
                   " SET    Nombre = '" + sNombre +"', Activo = " + Convert.ToInt16(bActivo) +
                   " WHERE  idNacionalidad = " + iCodigo;

            // Crear la instancia de la clase conexión
            clsConexion oConexion = new clsConexion();

            // Pasar el SQL y ejecutar
            oConexion.SQL = sSQL;
            if (oConexion.EjecutarSentencia())
            {
                // Liberar memoria y retornar
                oConexion = null;
                return true;
            }
            else
            {
                // Capturar el error, liberar y retornar
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }

        public bool Eliminar()
        {
            // Método que ejecuta la instrucción DELETE

            // Crear la instrucción SQL
            sSQL = " DELETE FROM tblNacionalidad " +
                   " WHERE idNacionalidad = " + iCodigo;

            // Crear la instancia de la clase conexión
            clsConexion oConexion = new clsConexion();

            // Pasar el SQL y ejecutar
            oConexion.SQL = sSQL;
            if (oConexion.EjecutarSentencia())
            {
                // Liberar memoria y retornar
                oConexion = null;
                return true;
            }
            else
            {
                // Capturar el error, liberar y retornar
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }

        public bool Consultar()
        {
            // Método que ejecuta la instrucción SELECT

            // Crear la instrucción SQL
            sSQL = " SELECT Nombre, Activo " +
                   " FROM tblNacionalidad " +
                   " WHERE idNacionalidad = " + iCodigo;

            // Crear el objeto conexión y pasar el SQL
            clsConexion oConexion = new clsConexion();
            oConexion.SQL = sSQL;
            if (oConexion.Consultar())
            {
                if (oConexion.Reader.HasRows)
                {
                    //Hay datos y se debe consultar
                    //Primero se debe leer la informaciòn
                    oConexion.Reader.Read();
                    //Recupero los datos
                    sNombre = oConexion.Reader.GetString(0);
                    bActivo = oConexion.Reader.GetBoolean(1);
                    //sNombre = Convert.ToString(oConexion.Reader.GetValue(0));
                    //Cerrar conexion, liberar y contestar
                    oConexion.CerrarConexion();
                    oConexion = null;
                    return true;
                }
                else
                {
                    sError = "No hay datos de nacionalidad para el código: " + iCodigo;
                    oConexion.CerrarConexion();
                    oConexion = null;
                    return false;
                }
            }
            else
            {
                sError = oConexion.Error;
                oConexion.CerrarConexion();
                oConexion = null;
                return false;
            }
        }
        #endregion
    }
}
