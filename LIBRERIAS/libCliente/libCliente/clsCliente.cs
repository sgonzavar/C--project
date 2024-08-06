using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libComunes.CapaDatos;

namespace libDesarrollo_8_10.BaseDatos
{
    public class clsCliente
    {
        #region"constructor"
        public clsCliente()
        {
            iCodigoCliente = 0;
            sDocumento = "";
            sNombre = "";
            sApellidos = "";
            sDireccion = "";
            sTelefono = "";
            sEmail = "";
        }
        #endregion

        #region"atributos"
        private Int32 iCodigoCliente;
        private string sDocumento;
        private string sNombre;
        private string sApellidos;
        private string sDireccion;
        private string sTelefono;
        private string sEmail;
        private string sSQL;
        private string sError;


        #endregion
        #region"Propiedades"

        public int CodigoCliente
        {
            get
            {
                return iCodigoCliente;
            }

            set
            {
                iCodigoCliente = value;
            }
        }
      
        public string Documento
        {
            get
            {
                return sDocumento;
            }

            set
            {
                sDocumento = value;
            }
        }

        public string Nombre
        {
            get
            {
                return sNombre;
            }

            set
            {
                sNombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return sApellidos;
            }

            set
            {
                sApellidos = value;
            }
        }

        public string Direccion
        {
            get
            {
                return sDireccion;
            }

            set
            {
                sDireccion = value;
            }
        }
        public string Telefono
        {
            get
            {
                return sTelefono;
            }

            set
            {
                sTelefono = value;
            }
        }


        public string Email
        {
            get
            {
                return sEmail;
            }

            set
            {
                sEmail = value;
            }
        }

        public string Error
        {
            get
            {
                return sError;
            }

        }

        #endregion


        #region"Metodos"

        public bool Grabar()
        {
            //Método para insertar una categoría
            //Se define la instrucción SQL
            sSQL = " INSERT INTO tblCliente(Documento, Nombre, Apellidos, Direccion, Telefono, email)"
                + "VALUES( '" + sDocumento + "', '" + sNombre + "', '" + sApellidos + "',
                '" + sDireccion + "', '" + sTelefono + "', '" + sEmail + "')"; 

            if (EjecutarSentencia())
                return true;
            else
                return false;
        }
        public bool Actualizar()
        {
            sSQL = " UPDATE tblCliente " +
                "set Documento = '" + sDocumento + "', " +
                    " Nombre"
                
                ;

            if (EjecutarSentencia())
                return true;
            else
                return false;
        }

        public bool Borrar()
        {
            //Método para insertar una categoría
            //Se define la instrucción SQL
            sSQL = " DELETE from tblCliente " +
                " where idCliente = " + iCodigoCliente;  

            if (EjecutarSentencia())
                return true;
            else
                return false;
        }

        public bool EjecutarSentencia()
        {
            //Se crea una instancia de la clase conexión
            clsConexion oConexion = new clsConexion();
            //Se asigna la propiedad SQL
            oConexion.SQL = sSQL;
            if (oConexion.EjecutarSentencia())
            {
                //Termina: Libera memoria y retorna
                oConexion = null;
                return true;
            }
            else
            {
                //Lee error, libera memoria y retorna
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }
        public bool Consultar()
        {
            //permite consultar la informacuib de ka base de datos
            sSQL = "   ";

            clsConexion oConexion = new clsConexion();
            oConexion.SQL = sSQL;

            if (oConexion.Consultar())
            {
                //Consulta Exitosa, se debe de revisar si hay datos
                if (oConexion.Reader.HasRows)
                {
                    //Hay datos, hay que leer con el metodo .Read()
                    oConexion.Reader.Read();
                    
                    oConexion.CerrarConexion();
                    oConexion = null;
                    return true;
                }
                else
                {
                    //No hay datos
                    sError = "No hay datos para el código";
                    oConexion.CerrarConexion();
                    oConexion = null;
                    return false;
                }

            }
            else
            {
                //Falla la consulta
                sError = oConexion.Error;
                oConexion.CerrarConexion();
                oConexion = null;
                return false;
            }
        }

        #endregion
    }
}
