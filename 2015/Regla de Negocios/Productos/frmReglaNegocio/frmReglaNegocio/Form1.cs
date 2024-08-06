using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmReglaNegocio
{
    public partial class frmRN : Form
    {
        public frmRN()
        {
            InitializeComponent();
        }

        #region "Variables Globales"

        double dblValorUnitario, dblCantidad, dblValorDescuento, dblValorAPagar;
        int intCodigo;
        DateTime dtmFecha;

        #endregion


        #region "Metodos Globales"

        private void Mensaje(string Texto)
        {
            MessageBox.Show(Texto, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpiar()
        {
            this.dtpFecha.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.cmbProducto.SelectedIndex = 0;
            this.txtValor.Text = "0";
            this.txtCantidad.Text = string.Empty;
            this.lblDescuento.Text = string.Empty;
            this.lblValorPagar.Text = string.Empty;
            this.cmbProducto.Focus();
        }

        private void Llenarcombo()
        {
            try
            {
                this.cmbProducto.Items.Add("Seleccione Un Producto");
                this.cmbProducto.Items.Add("Aguacate");
                this.cmbProducto.Items.Add("Zanahoria");
                this.cmbProducto.Items.Add("Papa Nevada");
                this.cmbProducto.Items.Add("Cebolla Huevo"); 
                this.cmbProducto.Items.Add("Tomate Aliño");
                this.cmbProducto.Items.Add("Pera");
                this.cmbProducto.Items.Add("Mora");
                this.cmbProducto.SelectedIndex = 0;
                intCodigo = 0;
            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }
        
        #endregion

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void frmRN_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {

        }
    }
}
