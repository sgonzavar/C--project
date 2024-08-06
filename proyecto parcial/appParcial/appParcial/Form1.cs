using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaParcial;




namespace appParcial
{
    public partial class frmParcial : Form
    {
        public frmParcial()
        {
            InitializeComponent();
        }


        #region "Metodos Personalizados"
        private void Limpiar()
        {
            this.txtNumero_uno.Text = "";
            this.txtNumero_Dos.Text = "";
            this.lblDivision.Text = "";
            this.lblMultiplicacion.Text = "";
            this.lblResta.Text = "";
            this.lblsuma.Text = "";
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double n1, n2;
            try
            {
                n1= Convert.ToDouble(this.txtNumero_uno.Text);
                n2= Convert.ToDouble(this.txtNumero_Dos.Text);
                //instanciar
                Parcial objparcial = new Parcial();

                objparcial.NumeroUno = n1;
                objparcial.NumeroDos = n2;

                if (!objparcial.Operacion()) 
                {
                    MessageBox.Show("Hubo Un Error, " + objparcial.MensajeError);
                    objparcial = null;
                    return;
                }

                this.lblDivision.Text = objparcial.div.ToString();
                this.lblMultiplicacion.Text = objparcial.Multi.ToString();
                this.lblResta.Text = objparcial.Rest.ToString();
                this.lblsuma.Text = objparcial.Sum.ToString();
                objparcial = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex.Message);
            }
        }

       
    }
}
