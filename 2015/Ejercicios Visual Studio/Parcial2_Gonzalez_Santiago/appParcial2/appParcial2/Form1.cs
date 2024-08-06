using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtHorasTrabajadas.Text = string.Empty;
            this.txtCargo.Text = string.Empty;
            this.lblCantidadHorasExtra.Text = string.Empty;
            this.lblValorDeHorasExtra.Text = string.Empty;
            this.lblValorRetencion.Text = string.Empty;
            this.lblValorTotalAPagar.Text = string.Empty;
        }

        
    }
}
