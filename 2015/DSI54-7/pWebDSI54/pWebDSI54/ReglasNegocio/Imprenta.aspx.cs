using System;
using libDSI54.ReglasNegocio.Clases;

namespace pWebDSI54.ReglasNegocio
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            clsImprenta oImprenta = new clsImprenta();

            oImprenta.cantidadLibros = Convert.ToInt32(txtCantidadLibros.Text);

            if (oImprenta.calcularTotal())
            {
                lblSubtotal.Text = oImprenta.subtotal.ToString("###,###");
                lblDescuento.Text = oImprenta.valorDescuento.ToString("###,###");
                lblTotal.Text = oImprenta.total.ToString("###,###");
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "ERROR: " + oImprenta.error;
            }

            oImprenta = null;
        }
    }
}
