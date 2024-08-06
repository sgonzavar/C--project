using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libImprentaRN.ReglaDeNegocio;
using libImprentaRN;





namespace WebImprentaReglaN
{
    public partial class frmImprenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEjecutar_Click(object sender, EventArgs e)
        {
            Int32 pasta, papel, impresion, cantidad;
            try
            {
                //Captura de Info
                pasta = Convert.ToInt32( cmbPasta.SelectedValue);
                papel= Convert.ToInt32(cmbPapel.SelectedValue);
                impresion = Convert.ToInt32(cmbImpresion.SelectedValue);
                cantidad = Convert.ToInt32(txtCatidad.Text);

                //crear objeto
               

                //envio de info
               

                if (!objI.calcularTotal())
                {
                    lblError.Text = "Error 4004," + objI._Error;
                    objI = null;
                    return; 
                }
                //Recuparar Info

                this.lblDescuento.Text = objI._Descuento.ToString();
                this.lblTotalBruto.Text = objI._SubTotal.ToString();
                this.lblTotalNeto.Text = objI._Total.ToString(); 


            }
            catch (Exception ex)
            {

            }

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblTotalBruto.Text = "";
            lblTotalNeto.Text = "";
            lblError.Text = "";
            txtCatidad.Text = "";
            cmbImpresion.SelectedIndex = 0;
            cmbPapel.SelectedIndex = 0;
            cmbPasta.SelectedIndex = 0;
            txtCatidad.Focus();
        }
    }
}