using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using libWebAppplication.ParametrosConexion.conexion;
using libWebAppplication.ParametrosConexion.Objetos;

namespace libWebAppplication.AtenderFormularios
{
    public class ClsCliente
    {
        #region "Atributos"

        private string strCedula, strNombre, strTelefono, strApellido;
        private string strCorreo, strDireccion;
        private DropDownList dpnTipoID, dpnCiudad;
        private GridView grvCliente;
        private string strError;
        private string strSql;

        #endregion

        #region "Constructor"

        public ClsCliente()
        {
            strCedula = string.Empty;
            strNombre = string.Empty;
            strTelefono = string.Empty;
            strApellido = string.Empty;
            strCorreo = string.Empty;
            strDireccion = string.Empty;
            strError = string.Empty;
            strSql = string.Empty;
        }

        #endregion
        
        #region "Propiedades"

        public GridView _GridCliente
        {
            set { grvCliente = value; }
            get { return grvCliente; }
        }

        public DropDownList _TipoId
        {
            set { dpnTipoID = value; }
            get { return dpnTipoID; }
        }

        public DropDownList _Ciudad
        {
            set { dpnCiudad = value; }
            get { return dpnCiudad; }
        }

        public string _Cedula
        {
            set { strCedula = value; }
            get { return strCedula; }
        }

        public string _Nombre
        {
            set { strNombre = value; }
            get { return strNombre; }
        }

        public string _Telefono
        {
            set { strTelefono = value; }
            get { return strTelefono; }
        }

        public string _Apellido
        {
            set { strApellido = value; }
            get { return strApellido; }
        }

        public string _Correo
        {
            set { strCorreo = value; }
            get { return strCorreo; }
        }

        public string _Direccion
        {
            set { strDireccion = value; }
            get { return strDireccion; }
        }

        public string _Error
        {          
            get { return strError; }
        }

        #endregion

        #region "Metodos Privados"

        private bool Validar()
        {
            if (strCedula == null)
            {
                strError = "Digitar Cedula.";
                return false;
            }

            if (strNombre == null)
            {
                strError = "Digitar Nombre.";
                return false;
            }

            if (strDireccion == null)
            {
                strError = "Digitar Direccion.";
                return false;
            }

            if (strTelefono == null)
            {
                strError = "Digitar Telefono.";
                return false;
            }

            if (strApellido == null)
            {
                strError = "Digitar Cargo.";
                return false;
            }

            if (strCorreo == null)
            {
                strError = "Digitar Correo.";
                return false;
            }
          
            return true;
        }

        #endregion

        #region "Metodos"

        public bool LenarComboCiudad()
        {

            if (dpnCiudad == null)
            {
                strError = "No Definio Ciudad";
                return false;
            }

            strSql = "Exec Ciudad_LlenarCombo";
            Combo oCombo = new Combo();
            oCombo.cboGenericoWeb = dpnCiudad;
            oCombo.SQL = strSql;
            oCombo.ColumnaTexto = "NOMBRE";
            oCombo.ColumnaValor = "IDCIUDAD";

            if (oCombo.LlenarComboWeb())
            {

                dpnCiudad = oCombo.cboGenericoWeb;
                oCombo = null;
                return true;

            }
            else
            {
                strError = oCombo.Error;
                oCombo = null;
                return false;
            }

        }

        public bool LenarComboTipoId()
        {

            if (dpnTipoID == null)
            {
                strError = "No Definio TipoId";
                return false;
            }

            strSql = "Exec TipoId_LlenarCombo";
            Combo oCombo = new Combo();
            oCombo.cboGenericoWeb = dpnTipoID;
            oCombo.SQL = strSql;
            oCombo.ColumnaTexto = "NOMBRE";
            oCombo.ColumnaValor = "ID";

            if (oCombo.LlenarComboWeb())
            {

                dpnTipoID = oCombo.cboGenericoWeb;
                oCombo = null;
                return true;

            }
            else
            {
                strError = oCombo.Error;
                oCombo = null;
                return false;
            }

        }

        public bool LlenarGrid()
        {
            if (grvCliente == null)
            {
                strError = "No definió el grid del Cliente";
                return false;
            }
            strSql = "Exec Cliente_Grid";

            Grid oGrid = new Grid();
            oGrid.gridGenerico = grvCliente;
            oGrid.SQL = strSql;

            if (oGrid.LlenarGridWeb())
            {
                grvCliente = oGrid.gridGenerico;
                oGrid = null;
                return true;
            }
            else
            {
                strError = oGrid.Error;
                oGrid = null;
                return false;
            }
        }


        public bool Insertar()
        {
            try
            {
                if (!Validar())
                    return false;
                //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
                strSql = "Cliente_Insert";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSql;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_Cedula", System.Data.SqlDbType.VarChar, 50, strCedula);
                oConexion.AgregarParametro("@pr_Nombre", System.Data.SqlDbType.VarChar, 50, strNombre);
                oConexion.AgregarParametro("@pr_Telefono", System.Data.SqlDbType.VarChar, 50, strTelefono);
                oConexion.AgregarParametro("@pr_Direccion", System.Data.SqlDbType.VarChar, 50, strDireccion);
                oConexion.AgregarParametro("@pr_Apellido", System.Data.SqlDbType.VarChar, 50, strApellido);
                oConexion.AgregarParametro("@pr_Correo", System.Data.SqlDbType.VarChar, 50, strCorreo);
                oConexion.AgregarParametro("@pr_Ciudad", System.Data.SqlDbType.VarChar, 50, dpnCiudad.SelectedValue);
                oConexion.AgregarParametro("@pr_Tipoid", System.Data.SqlDbType.VarChar, 50, dpnTipoID.SelectedValue);
                if (oConexion.EjecutarSentencia())
                {
                    oConexion = null;
                    return true;
                }
                else
                {
                    strError = oConexion.Error;
                    oConexion = null;
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        public bool Actualizar()
        {
            try
            {
                if (!Validar())
                    return false;
                //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
                strSql = "Cliente_Update";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSql;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_Cedula", System.Data.SqlDbType.VarChar, 50, strCedula);
                oConexion.AgregarParametro("@pr_Nombre", System.Data.SqlDbType.VarChar, 50, strNombre);
                oConexion.AgregarParametro("@pr_Telefono", System.Data.SqlDbType.VarChar, 50, strTelefono);
                oConexion.AgregarParametro("@pr_Direccion", System.Data.SqlDbType.VarChar, 50, strDireccion);
                oConexion.AgregarParametro("@pr_Apellido", System.Data.SqlDbType.VarChar, 50, strApellido);
                oConexion.AgregarParametro("@pr_Correo", System.Data.SqlDbType.VarChar, 50, strCorreo);
                if (oConexion.EjecutarSentencia())
                {
                    oConexion = null;
                    return true;
                }
                else
                {
                    strError = oConexion.Error;
                    oConexion = null;
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }

        }

        public bool Eliminar()
        {

            try
            {
                if (!Validar())
                    return false;
                //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
                strSql = "Cliente_Delete";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSql;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_Cedula", System.Data.SqlDbType.VarChar, 50, strCedula);
                if (oConexion.EjecutarSentencia())
                {
                    oConexion = null;
                    return true;
                }
                else
                {
                    strError = oConexion.Error;
                    oConexion = null;
                    return false;
                }

            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }

        }

        public bool Consultar()
        {
            try
            {
                //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
                strSql = "Cliente_SelectXId";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSql;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_Cedula", System.Data.SqlDbType.VarChar, 50, strCedula);
                if (oConexion.Consultar())
                {
                    if (oConexion.Reader.HasRows)
                    {
                        oConexion.Reader.Read();
                        strCedula = oConexion.Reader.GetString(0);
                        strNombre = oConexion.Reader.GetString(1);
                        strDireccion = oConexion.Reader.GetString(2);
                        strTelefono = oConexion.Reader.GetString(3);
                        strApellido = oConexion.Reader.GetString(4);
                        strCorreo = oConexion.Reader.GetString(5);
                        oConexion.CerrarConexion();
                        oConexion = null;
                        return true;
                    }
                    else
                    {
                        strError = "No hay datos para el Cliente con código: " + strCedula;
                        oConexion.CerrarConexion();
                        oConexion = null;
                        return false;
                    }
                }
                else
                {
                    strError = oConexion.Error;
                    oConexion = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        #endregion

    }
}
