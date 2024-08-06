using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDesarrollo_6_8.ReglasNegocio.Clases;

namespace pWebDesarrollo_6_8.Reglas_Negocio
{
    public partial class Imprenta : System.Web.UI.Page
    {
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Int32 iCantidadLibros;

            iCantidadLibros = Convert.ToInt32(txtNumeroLibros.Text);

            clsImprenta oImprenta = new clsImprenta();
            oImprenta.Cantidad = iCantidadLibros;

            if (oImprenta.CalcularTotal())
            {
                lblSubtotal.Text = oImprenta.Subtotal.ToString("###,###");
                lblDescuento.Text = oImprenta.ValorDescuento.ToString("###,###");
                lblTotalPagar.Text = oImprenta.ValorTotal.ToString("###,###");
            }
            else
            {
                lblError.Text = oImprenta.Error;
            }
            oImprenta = null;
        }
    }
}