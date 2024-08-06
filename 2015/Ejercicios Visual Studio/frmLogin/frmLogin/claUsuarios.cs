using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace frmLogin
{
    class claUsuarios : clsConexion
    {
        private string User;
        private string Password;

        public claUsuarios()
        {
            User = string.Empty;
            Password = string.Empty;
            this.sql = string.Empty;
        }

        public string UserName
        {
            get { return User; }
            set { User = value; }
        }

        public string Pass
        {
            get { return Password; }
            set { Password = value; }
        }

        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"select Name, Password from Login where Name ='{0}' and  Password ='{1}'", this.User, this.Password);
            this.Command = new SqlCommand(this.sql, this.Connection);
            this.Connection.Open();

            SqlDataReader Reg = null;
            Reg = this.Command.ExecuteReader();

            if (Reg.Read())
            {
                Resultado = true;
                this.mensaje = "Bienvenido, Datos Correctos";
            }
            else 
            {
                this.mensaje = "Datos Incorrectos, Verifique Por Favor";
            }
            this.Connection.Close();
            return Resultado;

        }

    }
}
