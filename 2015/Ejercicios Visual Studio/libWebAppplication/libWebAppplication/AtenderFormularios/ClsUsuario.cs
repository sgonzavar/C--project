using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using libWebAppplication.ParametrosConexion.Objetos;
using libWebAppplication.ParametrosConexion.conexion;

namespace libWebAppplication.AtenderFormularios
{
    public class ClsUsuario
    {
        #region "Atributos"
        private string strIdUsuario, strNombre, strDireccion, strTelefono, strCargo;
        private string strCorreo, strClave, strConfimacionClave;
        private GridView grvUsuario;
        private string strSQL;
        private string strError;
        #endregion

        #region "Constructor"
        public ClsUsuario()
        {
            this.strIdUsuario = string.Empty;
            this.strNombre = string.Empty;
            this.strDireccion = string.Empty;
            this.strTelefono = string.Empty;
            this.strCargo = string.Empty;
            this.strCorreo = string.Empty;
            this.strClave = string.Empty;
            this.strConfimacionClave = string.Empty;
            this.strSQL = string.Empty;
            this.strError = string.Empty;
        }
        #endregion

        #region "Propiedades"

        public GridView _GridUsuario
        {
            set { grvUsuario = value; }
            get { return grvUsuario; }
        }

        public string _IdUsuario
        {
            set { strIdUsuario = value; }
            get { return strIdUsuario; }
        }

        public string _Nombre
        {
            set { strNombre = value; }
            get { return strNombre; }
        }

        public string _Direccion
        {
            set { strDireccion = value; }
            get { return strDireccion; }
        }

        public string _Telefono
        {
            set { strTelefono = value; }
            get { return strTelefono; }
        }

        public string _Cargo
        {
            set { strCargo = value; }
            get { return strCargo; }
        }

        public string _Correo
        {
            set { strCorreo = value; }
            get { return strCorreo; }
        }

        public string _Clave
        {
            set { strClave = value; }
            get { return strClave; }
        }

        public string _ConfirmacionClave
        {
            set { strConfimacionClave = value; }
            get { return strConfimacionClave; }
        }

        public string _Error
        {
            get { return strError; }
        }



        #endregion

        #region "MetodosPrivados"

        private bool Validar()
        {           
                if (strIdUsuario == null)
                {
                    strError = "Digitar IdUsuario.";
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

                if (strCargo == null)
                {
                    strError = "Digitar Cargo.";
                    return false;
                }

                if (strCorreo == null)
                {
                    strError = "Digitar Correo.";
                    return false;
                }

                if (strClave == null)
                {
                    strError = "Digitar Clave.";
                    return false;
                }

                if (strConfimacionClave == null)
                {
                    strError = "Digitar Confirmacion de Clave.";
                    return false;
                }
               return true;                     
        }

        #endregion

        #region "Metodos"

        public bool LlenarGrid()
        {
            if (grvUsuario == null)
            {
                strError = "No definió el grid del Usuario";
                return false;
            }
            strSQL = "Exec Usuario_Grid";

            Grid oGrid = new Grid();
            oGrid.gridGenerico = grvUsuario;
            oGrid.SQL = strSQL;

            if (oGrid.LlenarGridWeb())
            {
                grvUsuario = oGrid.gridGenerico;
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
                strSQL = "Usuario_Insert";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSQL;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_IdUsuario", System.Data.SqlDbType.VarChar, 50, strIdUsuario);
                oConexion.AgregarParametro("@pr_Nombre", System.Data.SqlDbType.VarChar, 50, strNombre);
                oConexion.AgregarParametro("@pr_Telefono", System.Data.SqlDbType.VarChar, 50, strTelefono);
                oConexion.AgregarParametro("@pr_Direccion", System.Data.SqlDbType.VarChar, 50, strDireccion);
                oConexion.AgregarParametro("@pr_Cargo", System.Data.SqlDbType.VarChar, 50, strCargo);
                oConexion.AgregarParametro("@pr_Correo", System.Data.SqlDbType.VarChar, 50, strCorreo);
                oConexion.AgregarParametro("@pr_Clave", System.Data.SqlDbType.VarChar, 50, strClave);
                oConexion.AgregarParametro("@pr_ConfirmacionClave", System.Data.SqlDbType.VarChar, 50, strConfimacionClave);
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
                strSQL = "Usuario_Update";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSQL;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_IdUsuario", System.Data.SqlDbType.VarChar, 50, strIdUsuario);
                oConexion.AgregarParametro("@pr_Nombre", System.Data.SqlDbType.VarChar, 50, strNombre);
                oConexion.AgregarParametro("@pr_Telefono", System.Data.SqlDbType.VarChar, 50, strTelefono);
                oConexion.AgregarParametro("@pr_Direccion", System.Data.SqlDbType.VarChar, 50, strDireccion);
                oConexion.AgregarParametro("@pr_Cargo", System.Data.SqlDbType.Date, 50, strCargo);
                oConexion.AgregarParametro("@pr_Correo", System.Data.SqlDbType.Int, 50, strCorreo);
                oConexion.AgregarParametro("@pr_Clave", System.Data.SqlDbType.VarChar, 50, strClave);
                oConexion.AgregarParametro("@pr_ConfirmacionClave", System.Data.SqlDbType.VarChar, 50, strConfimacionClave);
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
                strSQL = "Usuario_Delete";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSQL;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_idUsuario", System.Data.SqlDbType.VarChar, 50, strIdUsuario);
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
                strSQL = "Usuario_SelectXId";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSQL;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_idUsuario", System.Data.SqlDbType.VarChar, 50, strIdUsuario);
                if (oConexion.Consultar())
                {
                    if (oConexion.Reader.HasRows)
                    {
                        oConexion.Reader.Read();
                        strIdUsuario = oConexion.Reader.GetString(0);
                        strNombre = oConexion.Reader.GetString(1);
                        strDireccion = oConexion.Reader.GetString(2);
                        strTelefono = oConexion.Reader.GetString(3);
                        strCargo = oConexion.Reader.GetString(4);
                        strCorreo = oConexion.Reader.GetString(5);
                        strClave = oConexion.Reader.GetString(6);
                        strConfimacionClave = oConexion.Reader.GetString(7);
                        oConexion.CerrarConexion();
                        oConexion = null;
                        return true;
                    }
                    else
                    {
                        strError = "No hay datos para el Usuario con código: " + strIdUsuario;
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
