using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libWebAppplication.ParametrosConexion.conexion;

namespace libWebAppplication.AtenderFormularios
{
    public class ClsLogin
    {
        #region "Atributos"

        private string strUsuario, strClave;
        private string strError, strSql;

        #endregion

        #region "Constructor"

        public ClsLogin()
        {
            strClave = string.Empty;
            strUsuario = string.Empty;
            strError = string.Empty;
        }

        #endregion

        #region "Propiedades"

        public string _Usuario
        {
            set { strUsuario = value; }
            get { return strUsuario; }
        }

        public string _Clave
        {
            set { strClave = value; }
            get { return strClave; }
        }

        public string _Error
        {
            get { return strError; }
        }

        #endregion

        #region "Metodos Privados"

        private bool Validar()
        {
            if (strUsuario == null)
            {
                strError = "Digite Usuario";
                return false;
            }

            if (strClave == null)
            {
                strError = "Digite Clave";
                return false;
            }
            return true;
        }

        #endregion


        #region "Metodos"

        public bool Consultar()
        {
            try
            {
                if (!Validar())
                    return false;
                //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
                strSql = "Login_SelectXUI";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSql;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_Usuario", System.Data.SqlDbType.VarChar, 50, strUsuario);
                oConexion.AgregarParametro("@pr_Clave", System.Data.SqlDbType.VarChar, 50, strClave);

                if (oConexion.Consultar())
                {
                    if (oConexion.Reader.HasRows)
                    {
                        oConexion.Reader.Read();
                        strUsuario = oConexion.Reader.GetString(0);
                        strClave = oConexion.Reader.GetString(1);
                        oConexion.CerrarConexion();
                        oConexion = null;
                        return true;
                    }
                    else
                    {
                        strError = "No hay datos para el Usuario  " + strUsuario;
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