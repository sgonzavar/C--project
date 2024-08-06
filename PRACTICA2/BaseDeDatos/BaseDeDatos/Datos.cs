using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BaseDeDatos
{
    public class Datos
    {
        public SqlConnection conectar(string nomBD)
        {
            SqlConnection conectar = new SqlConnection("Data Source=ALEJO-PC\\SQLEXPRESS;Initial Catalog=" + nomBD + ";Integrated Security=true;");
            //SqlConnection conectar = new SqlConnection("Data Source=localhost;Initial Catalog=" + nomBD + ";Integrated Security=SSPI;");
            try
            {
                conectar.Open();
                //MessageBox.Show("Se realizo la conexion...");
                return conectar;
            }
            catch (Exception ex)
            {
                try
                {
                     conectar = new SqlConnection("Data Source=localhost;Initial Catalog=" + nomBD + ";Integrated Security=SSPI;");
                      try
            {
                conectar.Open();
                //MessageBox.Show("Se realizo la conexion...");
                return conectar;
            }
            catch (Exception lex)
                      {
                          MessageBox.Show("Fallo la conexión, contacte servicio tecnico " + ex.ToString());
                          return null;
                      }

                }
                catch (Exception a)
                {
                    MessageBox.Show("Fallo la conexión, contacte servicio tecnico " + ex.ToString());
                return null;
                }
            }
        }

        public SqlDataReader consulta(string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta, contacte servicio tecnico " + ex.ToString());
                return null;
            }
        }

        public int operarar(string conSQL, SqlConnection conector)
        {
            int num = 0;

            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                num = comando.ExecuteNonQuery();
                return num;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Fallo la consulta, contacte servicio tecnico" + e.ToString());
                return num;
            }

        }

        public void cerrar(SqlConnection conector)
        {
            try
            {
                conector.Close();
            }
            catch (SqlException eq) { }
        }
    }
}
