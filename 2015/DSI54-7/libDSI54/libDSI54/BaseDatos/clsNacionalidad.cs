using System;
using libCommon.CapaDatos;
using libCommon.CapaObjetos; //Referencia la capa de objetos
using System.Web.UI.WebControls; // se referencia system.web.ui.webControls para recibir el combo vacio 
//para eso hay que referenciar a system.web

     

namespace libDSI54.BaseDatos
{
    public class clsNacionalidad
    {
        #region Atributos
        private int iCodigo;
        private string sNombre;
        private bool bActivo;
        private DropDownList ocboNacionalidad;
        private string sSQL;
        private string sError, sCorrecto;
        #endregion

        #region Propiedades

        public DropDownList Nacionalidad
        {
            get { return ocboNacionalidad; }
            set { ocboNacionalidad = value; }
        }


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
        }

        public string _correcto
        {
            get { return sCorrecto; }
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
                    // Hay datos y se debe consultar
                    // 1. Leer la información
                    oConexion.Reader.Read();
                    // 2. Recuperar los datos
                    sNombre = oConexion.Reader.GetString(0);
                    bActivo = oConexion.Reader.GetBoolean(1);
                    //sNombre = Convert.ToString(oConexion.Reader.GetValue(0));
                    //bActivo = Convert.ToBoolean(oConexion.Reader.GetValue(1));
                    // 3. Cerrar conexión
                    oConexion.CerrarConexion();
                    // 4. Liberar memoria
                    oConexion = null;
                    // 5. Retornar
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

        public bool LenarCombo()
        {
            // se revisa si lllego el combo
            if (ocboNacionalidad == null)
            {
                sError = "No Definio Nacionalidad";
                return false;
            }
            sCorrecto = " Todo Funcionando, Correcto. ";
            sSQL = "Exec Nacionalidad_LlenarCombo";
            //se crea el objeto combo
            clsCombos oCombo = new clsCombos();
            //paso el combo vacio
            oCombo.cboGenericoWeb = ocboNacionalidad;
            oCombo.SQL = sSQL;
            // se pasa los nombres de las columnas de texto y valoe de las consultas sql
            oCombo.ColumnaTexto = "Nombre";
            //la columna valor es lo que se quiere almacenar
            oCombo.ColumnaValor = "idNacionalidad";
            //Se invoca el llenar combo
            if (oCombo.LlenarComboWeb())
            {
                // se captura el combo lleno 
                ocboNacionalidad = oCombo.cboGenericoWeb;
                oCombo = null;
                return true;

            }
            else
            {
                sError = oCombo.Error;
                oCombo = null;
                return false;
            }

            
            
             
        }
        #endregion
    }
}
