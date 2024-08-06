using System;
using libDSI54.ClasesSimples;

namespace pWebDSI54.ClasesSimples
{
    public partial class Mantenimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int iManoObra, iRepuestos;

            iManoObra = Convert.ToInt32(txtManoObra.Text);
            iRepuestos = Convert.ToInt32(txtRepuestos.Text);

            clsMantenimiento oMantenimiento = new clsMantenimiento();

            oMantenimiento.valorManoObra = iManoObra;
            oMantenimiento.valorMateriales = iRepuestos;

            if(oMantenimiento.calcularTotal())
            {
                lblSubtotal.Text = "$ " + oMantenimiento.subtotal.ToString("###,###");
                lblIVA.Text = "$ " + oMantenimiento.valorIVA.ToString("###,###");
                lblTotal.Text = "$ " + oMantenimiento.total.ToString("###,###");
            }
            else
            {
                //lblError.Text = oMantenimiento.error.ToString();
            }

            oMantenimiento = null;
        }
    }
}
