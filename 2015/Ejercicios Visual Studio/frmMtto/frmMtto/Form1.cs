using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// referenciar y usar
using libreriaMtto;


namespace frmMtto
{
    public partial class frmMtto : Form
    {
        public frmMtto()
        {
            InitializeComponent();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarCombo()
        {
            this.cmbTipo.Items.Add(". ");
            this.cmbTipo.Items.Add(" Moto ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarCombo();
            this.cmbTipo.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cmbTipo.SelectedIndex = 0;
            this.txtManoObra.Text = "";
            this.txtMateriales.Text = "";
            

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                this.gpbApagar.Visible = false;
                Int32 _manoObra = Convert.ToInt32(this.txtManoObra.Text);
                Int32 _materiales = Convert.ToInt32(this.txtMateriales.Text);
                
                //instancia
                clsMantenimiento objmtto = new clsMantenimiento();
                objmtto.valorManoObra = _manoObra;
                objmtto.valorMateria = _materiales;
                
                //invocar metodo y tratamiento de error
                if (! objmtto.CalcularSubTotal())
                {
                    MessageBox.Show("Hubo Un Error, " + objmtto.error);
                    objmtto = null;
                    return;
                }

                if (!objmtto.CalcularIva())
                {
                    MessageBox.Show("Hubo Un Error, " + objmtto.error);
                    objmtto = null;
                    return;
                }

                if (!objmtto.CalcularTotal())
                {
                    MessageBox.Show("Hubo Un Error, " + objmtto.error);
                    objmtto = null;
                    return;
                }

                // recuperar info
                this.lblSubtotal.Text = objmtto.subTotal.ToString();
                this.lblIva.Text = objmtto.valorIva.ToString();
                this.lblTotal.Text = objmtto.total.ToString();
                objmtto = null;
                this.gpbApagar.Visible = true;               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex.Message);
            }
        }


       
    }
}
