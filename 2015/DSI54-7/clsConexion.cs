using System;
using System.Data.SqlClient; //Namespace para conectarse a base de datos de SQL Server
using System.Data; //Referencia para crear dataset
using System.Data.Odbc;//Para conectarse a otras bases de datos (Access, Excel, Oracle, DB2, MySQL, etc)
using System.Data.OleDb;//Para conectarse a otras bases de datos (Access, Excel, Oracle, DB2, MySQL, etc)

namespace libComunes.CapaDatos
{
    public class clsConexion
    {
        #region "Constructor"
            public clsConexion()
            {
                //Creamos el constructor de la clase conexiòn, donde creamos
                //las instancias de los objetos
                objConexionDB = new SqlConnection();
                objComando = new SqlCommand();
                objAdapter = new SqlDataAdapter();
                objDataSet = new DataSet();
                oParametro = new SqlParameter();
                strSQL = "";
                strNombreTabla = "TablaGenerica";
            }
        #endregion

        #region "Destructor"
            //El destructor se invoca cuando se destruye el objeto
            ~clsConexion()
            {
                //Elimina el dataset
                if (objDataSet != null)
                {
                    //Elimina el dataset
                    objDataSet = null;
                }
                //Cuando destruyen el objeto invoca el mètodo de cerrar conexion
                CerrarConexion();
            }
        #endregion

        #region "Atributos"
            //OleDbConnection OdbcConnection 
            private SqlConnection objConexionDB;//Permite realizar la conexión a la  base de datos
            //OleDbCommand  OdbcCommand     
            private SqlCommand objComando; //Permite ejecutar instrucciones SQL: DDL, DML, DCL
            private SqlDataReader objReader;//Permite capturar la información consultada en la base de datos
            private SqlDataAdapter objAdapter;//Permite llenar un dataset
            private SqlParameter oParametro;//Para ejecutar Stored Procedures
            private string strNombreTabla;//dataset
            private DataSet objDataSet;//Es una base de datos en memoria que contiene Tablas, relaciones y vistas
            private string strCadenaConexion;//Cadena de conexión para conectarse a la base de datos
            private string strSQL;//Instrucción SQL que se va a ejecutar
            private string strError;
        #endregion

        #region "Propiedades"
            public DataSet DATASET
            {
                get { return objDataSet; }
            }

            public SqlDataReader Reader
            {
                get
                {
                    return objReader;
                }
            }

            public string NombreTabla
            {
                get { return strNombreTabla; }
                set { strNombreTabla = value; }
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

        #region "Metodos"
            public bool EjecutarSentencia()
            {
                //Ejecuta instrucciones de acción: INSERT, UPDATE, DELETE
                //Validamos si el SQL existe
                if (string.IsNullOrEmpty(strSQL))
                {
                    //No definieron el sql, se debe abortar el proceso
                    strError = "No definió la instrucciòn SQL";
                    return false;
                }

                //Ejecuta las instrucciones sql de insercion, actualizaciòn y borrado a la base de 
                //datos, es decir, aquellas que no retornan datos
                //El primer paso es abrir la base de datos
                if (AbrirConexion())
                {
                    //Le asigna al comando las propiedades
                    try
                    {
                        if (objComando.Parameters.Count > 0)
                        {
                            objComando.CommandType = System.Data.CommandType.StoredProcedure;
                        }
                        else
                        {
                            objComando.CommandType = System.Data.CommandType.Text;
                        }
                        objComando.Connection = objConexionDB;
                        objComando.CommandText = strSQL;

                        //Ejecuta la sentencia, cierra la conexiòn y retorna verdadero
                        objComando.ExecuteNonQuery();
                        CerrarConexion();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        strError = ex.Message;
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            public bool Consultar()
            {
                //Ejecuta instrucciones de tipo SELECT y la guarda en el datareader
                //Validamos si el SQL existe
                if (string.IsNullOrEmpty(strSQL))
                {
                    //No definieron el sql, se debe abortar el proceso
                    strError = "No definió la instrucción SQL";
                    return false;
                }

                //Ejecuta las instrucciones sql de insercion, actualizaciòn y borrado a la base de 
                //datos, es decir, aquellas que no retornan datos
                //El primer paso es abrir la base de datos
                if (AbrirConexion())
                {
                    //Le asigna al comando las propiedades
                    try
                    {
                        if (objComando.Parameters.Count > 0)
                        {
                            objComando.CommandType = System.Data.CommandType.StoredProcedure;
                        }
                        else
                        {
                            objComando.CommandType = System.Data.CommandType.Text;
                        }
                        objComando.Connection = objConexionDB;
                        objComando.CommandText = strSQL;

                        //Ejecuta la sentencia, almacena los datos en un reader, 
                        //cierra la conexiòn y retorna verdadero
                        objReader = objComando.ExecuteReader();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        strError = ex.Message;
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            private bool GenerarCadenaConexion()
            {
                //Creamos la instancia del objeto parametros
                clsParametros objParametros = new clsParametros();

                if (objParametros.GenerarCadena())
                {
                    strCadenaConexion = objParametros.CadenaConexion;
                    objParametros = null;
                    return true;
                }
                else
                {
                    strError = objParametros.Error;
                    objParametros = null;
                    return false;
                }
            }

            private bool AbrirConexion()
            {
                //Validamos si la conexiòn està abierta
                if (objConexionDB.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                //Abre la conexiòn a la base de datos
                //Crea la cadena de conexiòn
                if (GenerarCadenaConexion())
                {
                    //Asigno la cadena de conexiòn y abro la conexiòn a la base de datos
                    objConexionDB.ConnectionString = strCadenaConexion;
                    try
                    {
                        objConexionDB.Open();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //Captura si hubo un error al tratar de abrir la base de datos
                        strError = ex.Message;
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            public void CerrarConexion()
            {
                try
                {
                    //Cierra la conexiòn si està abierta y si existe
                    if (objConexionDB != null)
                    {
                        //La conexiòn existe, reviso que no estè cerrada
                        if (objConexionDB.State != System.Data.ConnectionState.Closed)
                        {
                            objConexionDB.Close();
                        }
                        //Libero memoria
                        objConexionDB = null;
                    }

                    //Elimina el command
                    if (objComando != null)
                    {
                        objComando = null;
                    }

                    //Libera el dataadapter
                    if (objAdapter != null)
                    {
                        objAdapter = null;
                    }

                    return;
                }
                catch (Exception ex)
                {
                    strError = ex.Message;
                    return;
                }
            }

            public bool LlenarDataSet()
            {
                //Primero validamos que exista el SQL
                if (strSQL == "")
                {
                    strError = "No definiò el SQL";
                    return false;
                }
                //Se asegura que la tabla tenga datos
                if (strNombreTabla == "")
                {
                    strNombreTabla = "TablaGenerica";
                }
                //Abre la conexiòn a la base de datos
                if (AbrirConexion())
                {
                    try
                    {
                        //Define los paràmetros del objeto command
                        objComando.Connection = objConexionDB;
                        objComando.CommandText = strSQL;
                        objComando.CommandType = CommandType.Text;

                        //Defino las propiedades del objeto adapter y lleno el dataset
                        objAdapter.SelectCommand = objComando;
                        //Con el mètodo fill se llena el dataset
                        objAdapter.Fill(objDataSet, strNombreTabla);

                        //Cierro la conexiòn
                        CerrarConexion();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        strError = ex.Message;
                        CerrarConexion();
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            public bool AgregarParametro(string sNombreParametro, SqlDbType TipoDato, Int32 Tamano, object Valor)
            {
                try
                {
                    oParametro.ParameterName = sNombreParametro;
                    oParametro.SqlDbType = TipoDato;
                    oParametro.Value = Valor;
                    oParametro.Size = Tamano;
                    objComando.Parameters.Add(oParametro);
                    oParametro = new SqlParameter();
                    return (true);
                }
                catch (Exception ex)
                {
                    strError = ex.Message;
                    return (false);
                }
            }
        #endregion
    }
}
