using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libImprenta_RN.ReglaDeNegocio;



namespace WebAImprentaReglaNegocio
{
    public partial class frmImprenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Int32 cantidadhojas;

            cantidadhojas = Convert.ToInt32(this.txtCantidadH.Text);
            
            ClsImprenta objImprenta = new ClsImprenta();

            objImprenta._CantidadHojas = cantidadhojas;
            objImprenta._TipoImpresion = Convert.ToInt32(cmbImpresion.SelectedItem.Value);
            objImprenta._TipoPapel = Convert.ToInt32(cmbHojas.SelectedItem.Value);
            objImprenta._TipoPasta = Convert.ToInt32(cmbPasta.SelectedItem.Value);

            if (!objImprenta.calcularTotal())
            {
                lblError.Text = "Hubo un Error" + objImprenta._Error;
                objImprenta = null;
                return;
            }

            this.lblSubtotal.Text = objImprenta._SubTotal.ToString();
            this.lblTotal.Text = objImprenta._Total.ToString();

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtCantidadH.Text = "";
        }
    }
}