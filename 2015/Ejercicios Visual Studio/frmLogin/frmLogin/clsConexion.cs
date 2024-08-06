using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace frmLogin
{
    class clsConexion
    {
        public string cadenaConexion;
        protected string sql, mensaje;
        protected int resultado;
        protected SqlConnection Connection;
        protected SqlCommand Command;

        public clsConexion()
        {
            this.cadenaConexion = (@"Data Sourse = SANTIAGO-PC;Initial Catalog = EjercicioLogin; integrated security = true"); // crear cadena conexion
            this.Connection = new SqlConnection(this.cadenaConexion);// pasar la cadena y conectar
        }

        public string Mensaje
        {
            get { return mensaje; }
        }

    }
}
