﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using libWebAppplication.ParametrosConexion.conexion;


namespace libWebAppplication.ParametrosConexion.Objetos
{
    public class Grid
    {
        #region "Constructor"
        public Grid()
        {
            strNombreTabla = "Tabla_Grid";
        }
        #endregion

        #region "Atributos"
        private string strNombreTabla;
        private string strSQL;
        private string strError;
        private GridView grdGenerico;
        #endregion

        #region "Propiedades"
        public GridView gridGenerico
        {
            get
            {
                return grdGenerico;
            }
            set
            {
                grdGenerico = value;
            }
        }

        public string NombreTabla
        {
            get
            {
                return strNombreTabla;
            }
            set
            {
                strNombreTabla = value;
            }
        }

        public string SQL
        {
            get
            {
                return strSQL;
            }
            set
            {
                strSQL = value;
            }
        }

        public string Error
        {
            get
            {
                return strError;
            }
        }
        #endregion

        #region "Metodos Publicos"
        public bool LlenarGridWeb()
        {
            if (grdGenerico == null)
            {
                strError = "No ha definido el grid que se va a llenar";
                return false;
            }
            if (strSQL == "")
            {
                strError = "Debe definir una instrucción SQL";
                return false;
            }

            Conexion objConexionBd = new Conexion();
            if (string.IsNullOrEmpty(strNombreTabla))
            {
                strNombreTabla = "Tabla";
            }
            objConexionBd.NombreTabla = strNombreTabla;
            objConexionBd.SQL = strSQL;

            if (objConexionBd.LlenarDataSet())
            {
                grdGenerico.DataSource = objConexionBd.DATASET.Tables[strNombreTabla];
                grdGenerico.DataBind();
                objConexionBd.CerrarConexion();
                objConexionBd = null;
                return true;
            }
            else
            {
                strError = objConexionBd.Error;
                objConexionBd.CerrarConexion();
                objConexionBd = null;
                return false;
            }
        }

        #endregion

    }
}
