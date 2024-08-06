using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using BaseDeDatos;
using ManejoArchivo;
namespace Practica2
{
    public partial class FmMaestro : Form
    {
        Datos objcon = new Datos();
        Archivo ar = new Archivo();
        FmLogin l = new FmLogin();
        public static string Dir = "null";
        string nomBD = "ALMACEN2016";
        SqlConnection a;
        SqlDataReader tabla;
        string nom;
        public FmMaestro()
        {
            InitializeComponent();
        }

        public string GetDir()
        {
            return Dir;
        }

        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = objcon.conectar(nomBD);
            string conSQL = "SELECT * FROM CLIENTE WHERE NOMBRE= '" + l.GetNom() + "'";
            tabla = objcon.consulta(conSQL, a);

            if (tabla.Read())
            {
                if (tabla["ESTADO"].ToString() == "NO")
                {
                    FmJugar j = new FmJugar();
                    j.Show();

                }
                else
                {
                    MessageBox.Show("El participante " + l.GetNom() + " ya jugó", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void finJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmFinJuego fj = new FmFinJuego();
            fj.Show();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            DialogResult rta = OpDialog.ShowDialog();
            if (rta == DialogResult.Cancel) return;
            TXarchivo.Text = OpDialog.FileName;
            BtnProcesar.Enabled = true;

            MessageBox.Show("Recuerde que debe darle click a 'Procesar' para poder ingresar al juego  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                ar.Procesar(TXarchivo.Text);
                accionesToolStripMenuItem.Enabled = true;
                BtnCargar.Enabled = false;

                Dir = TXarchivo.Text;
               

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al procesar el archivo...", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void FmMaestro_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Debe cargar primero el archivo y procesar el archivo para poder acceder al juego", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void logearseComoOtroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Close();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
