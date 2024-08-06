using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libCommon.CapaDatos;
using libCommon.CapaObjetos;
using System.Web.UI.WebControls;

namespace libDSI54.BaseDatos
{
    public class ClsAutor
    {

        #region 
        public ClsAutor()
        {
            iCodigo = 0;
            sNombre = "";
            sApellidos = "";
            iCodigoNacionalidad = 0;
        }
        #endregion
        #region Atributos
        private GridView ogrdAutor;
        private Int32 iCodigo;
        private string sNombre;
        private string sApellidos;
        private DateTime dFechaNacimiento;
        private Int32 iCodigoNacionalidad;
        private string sSQL;
        private string sError;
        #endregion
        #region Propiedades
        public GridView grdAutor
        {
            get { return ogrdAutor; }
            set { ogrdAutor = value; }
        }
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
        public string Apellidos
        {
            get { return sApellidos; }
            set { sApellidos = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return dFechaNacimiento; }
            set { dFechaNacimiento = value; }
        }
        public Int32 CodigoNacionalidad
        {
            get { return iCodigoNacionalidad; }
            set { iCodigoNacionalidad = value; }
        }
        public string Error
        {
            get { return sError; }
        }
        #endregion




        #region Metodos
        public bool LlenarGrid()
        {
            if (ogrdAutor == null)
            {
                sError = "No definió el grid del autor";
                return false;
            }
            sSQL = "Exec Autor_Grid";

            clsGrid oGrid = new clsGrid();
            oGrid.gridGenerico = ogrdAutor;
            oGrid.SQL = sSQL;

            if (oGrid.LlenarGridWeb())
            {
                ogrdAutor = oGrid.gridGenerico;
                oGrid = null;
                return true;
            }
            else
            {
                sError = oGrid.Error;
                oGrid = null;
                return false;
            }
        }

        public bool Insertar()
        {
            //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
            sSQL = "Autor_Insert";
            clsConexion oConexion = new clsConexion();
            oConexion.SQL = sSQL;
            //Se pasan los paràmetros
            oConexion.AgregarParametro("@pr_Nombre", System.Data.SqlDbType.VarChar, 50, sNombre);
            oConexion.AgregarParametro("@pr_Apellidos", System.Data.SqlDbType.VarChar, 50, sApellidos);
            oConexion.AgregarParametro("@pr_FechaNacimiento", System.Data.SqlDbType.Date, 4, dFechaNacimiento);
            oConexion.AgregarParametro("@pr_idNacionalidad", System.Data.SqlDbType.Int, 4, iCodigoNacionalidad);
            if (oConexion.EjecutarSentencia())
            {
                oConexion = null;
                return true;
            }
            else
            {
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }
        public bool Actualizar()
        {
            //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
            sSQL = "Autor_Update";
            clsConexion oConexion = new clsConexion();
            oConexion.SQL = sSQL;
            //Se pasan los paràmetros
            oConexion.AgregarParametro("@pr_idAutor", System.Data.SqlDbType.Int, 4, iCodigo);
            oConexion.AgregarParametro("@pr_Nombre", System.Data.SqlDbType.VarChar, 50, sNombre);
            oConexion.AgregarParametro("@pr_Apellidos", System.Data.SqlDbType.VarChar, 50, sApellidos);
            oConexion.AgregarParametro("@pr_FechaNacimiento", System.Data.SqlDbType.Date, 4, dFechaNacimiento);
            oConexion.AgregarParametro("@pr_idNacionalidad", System.Data.SqlDbType.Int, 4, iCodigoNacionalidad);
            if (oConexion.EjecutarSentencia())
            {
                oConexion = null;
                return true;
            }
            else
            {
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }
        public bool Eliminar()
        {
            //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
            sSQL = "Autor_Delete";
            clsConexion oConexion = new clsConexion();
            oConexion.SQL = sSQL;
            //Se pasan los paràmetros
            oConexion.AgregarParametro("@pr_idAutor", System.Data.SqlDbType.Int, 4, iCodigo);
            if (oConexion.EjecutarSentencia())
            {
                oConexion = null;
                return true;
            }
            else
            {
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }
        public bool Consultar()
        {
            //En el SQL, sólo se escribe el nombre del Procedimiento almacenado
            sSQL = "Autor_SelectXId";
            clsConexion oConexion = new clsConexion();
            oConexion.SQL = sSQL;
            //Se pasan los paràmetros
            oConexion.AgregarParametro("@pr_idAutor", System.Data.SqlDbType.Int, 4, iCodigo);
            if (oConexion.Consultar())
            {
                if (oConexion.Reader.HasRows)
                {
                    oConexion.Reader.Read();
                    sNombre = oConexion.Reader.GetString(0);
                    sApellidos = oConexion.Reader.GetString(1);
                    dFechaNacimiento = oConexion.Reader.GetDateTime(2);
                    iCodigoNacionalidad = oConexion.Reader.GetInt32(3);
                    oConexion.CerrarConexion();
                    oConexion = null;
                    return true;
                }
                else
                {
                    sError = "No hay datos para el autor con código: " + iCodigo;
                    oConexion.CerrarConexion();
                    oConexion = null;
                    return false;
                }
            }
            else
            {
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }
        #endregion

    }
}
