using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Referenciar y usar
using LibMiCiudad;

namespace appPractica1
{
    public partial class frmMiCiudad : Form
    {
        public frmMiCiudad()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        int intI;

        #endregion

        #region "Metodos Personalizados"
        private void LlenarCombo() 
        {
            for (intI = 1; intI <= 6; intI ++)
            {
                this.cmbEstrato.Items.Add(intI);
                this.cmbEstrato.SelectedIndex = 0;
            }
        }

        private void Limpiar()
        {
            this.cmbEstrato.SelectedIndex = 0;
            this.gpbApagar.Visible = false;
            this.txtKw.Text = string.Empty;
            this.txtM3.Text = string.Empty;
            this.txtImpulsosT.Text = string.Empty;
            this.cmbEstrato.Focus();  // le da foco a el combo box
 
        }

        #endregion




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMiCiudad_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            double dblDolar, dblKw, dblM3, dblImpulso;
            int intEstrato;
            this.gpbApagar.Visible = false;
          

            try
            {
                this.gpbApagar.Visible = false;
                //Capturar Inofmacion;
                dblDolar = Convert.ToDouble(this.txtValorDolar.Text);
                dblKw = Convert.ToDouble(this.txtKw.Text);
                dblM3 = Convert.ToDouble(this.txtM3.Text);
                dblImpulso = Convert.ToDouble(this.txtImpulsosT.Text);
                intEstrato = Convert.ToInt16 ( this.cmbEstrato.SelectedItem);
               
                // instanciar la clase, crear el objeto.
                clsDatos objxx = new clsDatos();

                //enviar info al objeto, utilizando las propiedades de entrada
                objxx.VrDolar = dblDolar;
                objxx.Energia = dblKw;
                objxx.Agua = dblM3;
                objxx.Telefono = dblImpulso;
                objxx.Estrato = intEstrato;

                //invocar el metodo publico y realiza el tratamiento del error
                if (!objxx.Facturar()) 
                {
                    MessageBox.Show("Hubo Un Error " + objxx.Error);
                    objxx = null;  // liberar memoria 
                    return;  //se sale del metodo
                }

                //recuperar info desde el objeto, utilizando las propiedades de salida
                this.lblEnergia.Text =  objxx.VrEnergia.ToString();
                this.lblAgua.Text = objxx.VrAgua.ToString();
                this.lblTelefono.Text = objxx.VrTelefono.ToString();
                this.lblTotalApagar.Text = objxx.TotalApagar.ToString();
                objxx = null;  // liberar memoria
                this.gpbApagar.Visible = true;


            }
            catch (Exception ex) 
            {
                MessageBox.Show(" Error " + ex.Message);
            }


        }

       




        
      
    }
}
