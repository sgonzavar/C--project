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
    public class ClsAlmacen
    {
        #region "Atributos"

        private string strIdProducto, strNombre,  strNota;
        private Int32 intPrecio;
        private GridView grvAlmacen;
        private DropDownList dpnTipo;
        private string strError;
        private string strSQl;

        #endregion

        #region "Constructor"

        public ClsAlmacen()
        {
            strIdProducto = string.Empty;
            strNombre = string.Empty;        
            strNota = string.Empty;
            strError = string.Empty;
            strSQl = string.Empty;
            intPrecio = 0;
        }

        #endregion

        #region "Propiedades"

        public GridView _GridAlmacen
        {
            set { grvAlmacen = value; }
            get { return grvAlmacen; }
        }

        public DropDownList _DropAlmacen
        {
            set { dpnTipo = value; }
            get { return dpnTipo; }
        }

        public string _IdProducto
        {
            set { strIdProducto = value; }
            get { return strIdProducto; }

        }

        public string _Nombre
        {
            set { strNombre = value; }
            get { return strNombre; }

        }

        public string _Nota
        {
            set { strNota = value; }
            get { return strNota; }

        }

        public string _Error
        {           
            get { return strError; }
        }

        public Int32 _Precio
        {
            set { intPrecio = value; }
            get { return intPrecio; }
        }

        #endregion

        #region "Metodos Privados"

        private bool Validar()
        {
            if (strIdProducto == null)
            {
                strError = "Digitar id Producto.";
                return false;
            }

            if (strNombre == null)
            {
                strError = "Digitar Nombre.";
                return false;
            }

            if (strNota == null)
            {
                strError = "Digitar Nota.";
                return false;
            }

            if (intPrecio == 0)
            {
                strError = "Digitar Precio";
                return false;
            }
         
            return true;
        }
        #endregion

        #region "Metodos"

        public bool LenarCombo()
        {
           
            if (dpnTipo == null)
            {
                strError = "No Definio Tipo";
                return false;
            }
           
            strSQl = "Exec Tipo_LlenarCombo";         
            Combo oCombo = new Combo();          
            oCombo.cboGenericoWeb = dpnTipo;
            oCombo.SQL = strSQl;          
            oCombo.ColumnaTexto = "NOMBRE";       
            oCombo.ColumnaValor = "IDTIPO";
           
            if (oCombo.LlenarComboWeb())
            {
               
                dpnTipo = oCombo.cboGenericoWeb;
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
            if (grvAlmacen == null)
            {
                strError = "No definió el grid del Producto";
                return false;
            }
            strSQl = "Exec Almacen_Grid";

            Grid oGrid = new Grid();
            oGrid.gridGenerico = grvAlmacen;
            oGrid.SQL = strSQl;

            if (oGrid.LlenarGridWeb())
            {
                grvAlmacen = oGrid.gridGenerico;
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
                strSQl = "Almacen_Insert";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSQl;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_IdProducto", System.Data.SqlDbType.VarChar, 50, strIdProducto);
                oConexion.AgregarParametro("@pr_Nombre", System.Data.SqlDbType.VarChar, 50, strNombre);
                oConexion.AgregarParametro("@pr_Precio", System.Data.SqlDbType.Int, 50, intPrecio);
                oConexion.AgregarParametro("@pr_Nota", System.Data.SqlDbType.VarChar, 50, strNota);           
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
                strSQl = "Almacen_Update";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSQl;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_IdProducto", System.Data.SqlDbType.VarChar, 50, strIdProducto);
                oConexion.AgregarParametro("@pr_Nombre", System.Data.SqlDbType.VarChar, 50, strNombre);           
                oConexion.AgregarParametro("@pr_Precio", System.Data.SqlDbType.Int, 50, intPrecio);
                oConexion.AgregarParametro("@pr_Nota", System.Data.SqlDbType.VarChar, 50, strNota);
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
                strSQl = "Almacen_Delete";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSQl;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_IdProducto", System.Data.SqlDbType.VarChar, 50, strIdProducto);
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
                strSQl = "Almacen_SelectXId";
                Conexion oConexion = new Conexion();
                oConexion.SQL = strSQl;
                //Se pasan los paràmetros
                oConexion.AgregarParametro("@pr_IdProducto", System.Data.SqlDbType.VarChar, 50, strIdProducto);
                if (oConexion.Consultar())
                {
                    if (oConexion.Reader.HasRows)
                    {
                        oConexion.Reader.Read();
                        strIdProducto = oConexion.Reader.GetString(0);
                        strNombre = oConexion.Reader.GetString(1);
                        intPrecio = oConexion.Reader.GetInt32(2);
                        strNota = oConexion.Reader.GetString(3);

                        oConexion.CerrarConexion();
                        oConexion = null;
                        return true;
                    }
                    else
                    {
                        strError = "No hay datos para el Producto con código: " + strIdProducto;
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
