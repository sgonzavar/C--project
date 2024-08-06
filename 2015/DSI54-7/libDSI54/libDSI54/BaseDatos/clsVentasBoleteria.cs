using libCommon.CapaDatos;

namespace libDSI54.BaseDatos
{
    public class clsVentasBoleteria
    {
        #region Constructor
        public clsVentasBoleteria()
        {
            iCodigoVenta = 0;
            sCedula = "";
            sNombre = "";
            sLugar = "";
            iCantidad = -1;
            iValorBoleta = 0;
            iValorTotal = 0;
        }
        #endregion

        #region Atributos
        private int iCodigoVenta;
        private string sCedula;
        private string sNombre;
        private string sFecha;
        private string sLugar;
        private int iCantidad;
        private int iValorBoleta;
        private int iValorTotal;
        private string sSQL;
        private string sError;
        #endregion

        #region Propiedades
        public int CodigoVenta
        {
            get
            {
                return iCodigoVenta;
            }

            set
            {
                iCodigoVenta = value;
            }
        }

        public string Cedula
        {
            get
            {
                return sCedula;
            }

            set
            {
                sCedula = value;
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

        public string Fecha
        {
            get
            {
                return sFecha;
            }

            set
            {
                sFecha = value;
            }
        }

        public string Lugar
        {
            get
            {
                return sLugar;
            }

            set
            {
                sLugar = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return iCantidad;
            }

            set
            {
                iCantidad = value;
            }
        }

        public int ValorBoleta
        {
            get
            {
                return iValorBoleta;
            }

            set
            {
                iValorBoleta = value;
            }
        }

        public int ValorTotal
        {
            get
            {
                return iValorTotal;
            }

            set
            {
                iValorTotal = value;
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

        #region Metodos
        private bool ejecutarSentencia()
        {
            // Crear una instancia de la clase conexión
            clsConexion oConexion = new clsConexion();
            // Asignar la propiedad SQL
            oConexion.SQL = sSQL;
            if (oConexion.EjecutarSentencia())
            {
                // Termina: Liberar memoria y retornar
                oConexion = null;
                return true;
            }
            else
            {
                // Leer error, liberar memoria y retornar
                sError = oConexion.Error;
                oConexion = null;
                return false;
            }
        }

        public bool Insertar()
        {
            sSQL = " INSERT INTO tblVentasBoleteria " +
                   " (cedula_cliente, nombre_cliente, fecha_evento, " +
                   "  lugar_evento, cantidad_boletas, valor_boleta, valor_total) " +
                   " VALUES ('" + sCedula + "', '" + sNombre + "', '" + sFecha + "', " +
                   "         '" + sLugar + "', " + iCantidad + ", " + iValorBoleta + ", " + iValorTotal + ")";

            if (ejecutarSentencia())
                return true;
            else
                return false;
        }

        public bool Actualizar()
        {
            sSQL = " UPDATE tblVentasBoleteria " +
                   " SET cedula_cliente = '" + sCedula + "'," +
                   "     nombre_cliente = '" + sNombre + "'," +
                   "     fecha_evento = '" + sFecha + "'," +
                   "     lugar_evento = '" + sLugar + "'," +
                   "     cantidad_boletas = " + iCantidad + "," +
                   "     valor_boleta = " + iValorBoleta + "," +
                   "     valor_total = " + iValorTotal + "," +
                   " WHERE codigo_venta = " + iCodigoVenta;

            if (ejecutarSentencia())
                return true;
            else
                return false;
        }

        public bool Eliminar()
        {
            sSQL = " DELETE FROM tblVentasBoleteria " +
                   " WHERE codigo_venta = " + iCodigoVenta;

            if (ejecutarSentencia())
                return true;
            else
                return false;
        }

        public bool Consultar()
        {
            // Crear la consulta SQL
            sSQL = " SELECT cedula_cliente, nombre_cliente, fecha_evento, " +
                   "        lugar_evento, cantidad_boletas, valor_boleta, valor_total " +
                   " FROM tblVentasBoleteria " +
                   " WHERE codigo_venta = " + iCodigoVenta;

            // Instanciar el objeto conexion
            clsConexion oConexion = new clsConexion();

            // Cargar la instruccion SQL
            oConexion.SQL = sSQL;

            // Ejecutar el metodo consultar
            if (oConexion.Consultar())
            {
                // Consulta Exitosa, revisar si hay datos
                if (oConexion.Reader.HasRows)
                {
                    // Hay datos, leer con el metodo .Read()
                    oConexion.Reader.Read();

                    // Traer los valores del Reader a las variables
                    sCedula = oConexion.Reader.GetString(0);
                    sNombre = oConexion.Reader.GetString(1);
                    sFecha = oConexion.Reader.GetString(2);
                    sLugar = oConexion.Reader.GetString(3);
                    iCantidad = oConexion.Reader.GetInt32(4);
                    iValorBoleta = oConexion.Reader.GetInt32(5);
                    iValorTotal = oConexion.Reader.GetInt32(6);

                    // Cerrar conexion, liberar memoria y retornar
                    oConexion.CerrarConexion();
                    oConexion = null;
                    return true;
                }
                else
                {
                    // No hay datos, cerrar conexion, liberar y retornar
                    sError = "No hay datos con el código de venta";
                    oConexion.CerrarConexion();
                    oConexion = null;
                    return false;
                }
            }
            else
            {
                // Consulta fallida, capturar el error, cerrar conexion, liberar y retornar
                sError = "ERROR: " + oConexion.Error;
                oConexion.CerrarConexion();
                oConexion = null;
                return false;
            }
        }
        #endregion
    }
}
