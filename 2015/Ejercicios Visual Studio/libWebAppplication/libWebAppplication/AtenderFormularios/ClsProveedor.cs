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
    public class ClsProveedor
    {
        #region "Atributos"

        private string strCedula, strNombre, strTelefono, strCorreo;
        private GridView grvProveedor;
        private string strError;
        private string strSqL;

        #endregion

        #region "Constructor"

        public ClsProveedor()
        {
            strCedula = string.Empty;
            strNombre = string.Empty;
            strTelefono = string.Empty;
            strCorreo = string.Empty;
            strError = string.Empty;
        }

        #endregion

        #region "Propiedades"

        public GridView _GridProveedor
        {
            set { grvProveedor = value; }
            get { return grvProveedor; }
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

        public string _Correo
        {
            set { strCorreo = value; }
            get { return strCorreo; }
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

          
            if (strTelefono == null)
            {
                strError = "Digitar Telefono.";
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

        public bool LlenarGrid()
        {
            if (grvProveedor == null)
            {
                strError = "No definió el grid del Proveedor";
                return false;
            }
            strSqL = "Exec Proveedor_Grid";

            Grid oGrid = new Grid();
            oGrid.gridGenerico = grvProveedor;
            oGrid.SQL = strSqL;

            if (oGrid.LlenarGridWeb())
            {
                grvProveedor = oGrid.gridGenerico;
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
                strSqL = "Proveedor_Insert";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSqL;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_Cedula", System.Data.SqlDbType.VarChar, 50, strCedula);
                oConexion.AgregarParametro("@pr_Nombre", System.Data.SqlDbType.VarChar, 50, strNombre);
                oConexion.AgregarParametro("@pr_Telefono", System.Data.SqlDbType.VarChar, 50, strTelefono);
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

        public bool Actualizar()
        {
            try
            {
                if (!Validar())
                    return false;
                //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
                strSqL = "Proveedor_Update";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSqL;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_Cedula", System.Data.SqlDbType.VarChar, 50, strCedula);
                oConexion.AgregarParametro("@pr_Nombre", System.Data.SqlDbType.VarChar, 50, strNombre);
                oConexion.AgregarParametro("@pr_Telefono", System.Data.SqlDbType.VarChar, 50, strTelefono);
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
                strSqL = "Proveedor_Delete";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSqL;
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
                if (!Validar())
                    return false;
                //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
                strSqL = "Proveedor_SelectXId";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSqL;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_Cedula", System.Data.SqlDbType.VarChar, 50, strCedula);
                if (oConexion.Consultar())
                {
                    if (oConexion.Reader.HasRows)
                    {
                        oConexion.Reader.Read();
                        strCedula = oConexion.Reader.GetString(0);
                        strNombre = oConexion.Reader.GetString(1);
                        strTelefono = oConexion.Reader.GetString(2);
                        strCorreo = oConexion.Reader.GetString(3);
                        oConexion.CerrarConexion();
                        oConexion = null;
                        return true;
                    }
                    else
                    {
                        strError = "No hay datos para el Proveedor con código: " + strCedula;
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
                return true;

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
