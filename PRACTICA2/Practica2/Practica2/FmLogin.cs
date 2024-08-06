using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BaseDeDatos;
namespace Practica2
{
    public partial class FmLogin : Form
    {
        string nomBD = "ALMACEN2016";
        Datos objcon = new Datos();
        SqlConnection a;
        SqlDataReader tabla;
        static string ESTADO = "";
        static string nombre = ""; 
 
        public FmLogin()
        {
            InitializeComponent();
        }

        private void FmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            a = objcon.conectar(nomBD);
            string conSQL = "select * from CLIENTE where NOMBRE= '" + TXusu.Text + "'";
            tabla = objcon.consulta(conSQL, a);

            try
            {

                if (tabla.Read())
                {
                    if (tabla["CLAVE"].ToString() == TXpss.Text)
                    {
                        if (tabla["NOMBRE"].ToString() == TXusu.Text)
                        {
                            ESTADO = tabla["ESTADO"].ToString();
                            if (ESTADO == "NO")
                            {
                                FmMaestro maestro = new FmMaestro();
                                maestro.Show();
                                nombre = tabla["NOMBRE"].ToString();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("El participante " + TXusu.Text + " ya jugó", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Datos erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Datos erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Datos erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {
            }
        }
        public string GetNom()
        {
            return nombre;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
