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
    public partial class FmFinJuego : Form
    {
        FmLogin l = new FmLogin();
        FmMaestro ma = new FmMaestro();        
        string nomBD = "ALMACEN2016";      
        Datos objcon = new Datos();
        SqlConnection a;
        SqlDataReader tabla;
        SqlDataReader tabla1;
        double promganadores, acmganadores;
        int sumganadores;
        public FmFinJuego()
        {
            InitializeComponent();
        }

        private void FmFinJuego_Load(object sender, EventArgs e)
        {
            a = objcon.conectar(nomBD);
            string conSQL = "SELECT * FROM PREESTADISTICAS WHERE # = 1";
            tabla = objcon.consulta(conSQL, a);

            if (tabla.Read())
            {
                LBcanj.Text = tabla["CANTIDAD_JUEGOS_REALIZADOS"].ToString();
                LBcanpre.Text = tabla["CANTIDAS_PREMIOS_ENTREGADOS"].ToString();
                LBval.Text = tabla["VALOR_SORTEO"].ToString();

                LBpg.Text = LBcanpre.Text + "/" + LBcanj.Text;
               

                a = objcon.conectar(nomBD);
                string con1 = "SELECT * FROM GANADORES";
                tabla1 = objcon.consulta(con1, a);
                    while (tabla1.Read())
                    {
                        acmganadores = acmganadores + Convert.ToDouble(tabla1["VALOR_GANADO"].ToString());
                        sumganadores++;
                    }
                    tabla1.Close();
                    promganadores = acmganadores / sumganadores;
                    LBpgj.Text = promganadores.ToString();

                    double val;
                    val = Convert.ToDouble(LBval.Text);
                    if (val <= 40000000 && sumganadores <= 15)
                    {
                        LBsorteo.Text = "!El sorteo a sido exitoso!, se ha invertido: " + val.ToString() + "$ Y han habido " + sumganadores.ToString() + " Ganadores";
                        LBsorteo.ForeColor = System.Drawing.Color.Blue;
                    }else if(val <= 40000000 && sumganadores > 15)
                    {
                        LBsorteo.Text =  "Se ha invertido: " + val.ToString() + "$ Y han habido " + sumganadores.ToString() + " Ganadores";
                        LBsorteo.ForeColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        LBsorteo.Text = "El sorteo no ha sido exitoso, Se ha invertido: " + val.ToString() + "$ Y han habido " + sumganadores.ToString() + " Ganadores";
                        LBsorteo.ForeColor = System.Drawing.Color.Red;
                    }


            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tabla.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
