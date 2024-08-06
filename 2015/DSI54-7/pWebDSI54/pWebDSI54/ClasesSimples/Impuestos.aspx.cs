using System;
using libDSI54.ClasesSimples;

namespace pWebDSI54.ClasesSimples
{
    public partial class Impuestos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int iValorIngresos, iValorRetencion;
            iValorIngresos = Convert.ToInt32(txtIngresosAnuales.Text);
            iValorRetencion = Convert.ToInt32(txtRetencionFuente.Text);

            clsImpuesto oImpuesto = new clsImpuesto();

            oImpuesto.ingresoAnual = iValorIngresos;
            oImpuesto.retencionFuente = iValorRetencion;

            if (oImpuesto.calcularPagoImpuesto())
            {
                lblValorImpuesto.Text = "$ " + oImpuesto.valorImpuestoTeorico.ToString("###,###");
                if (oImpuesto.valorPagar > 0)
                {
                    lblTituloPagar.Text = "Valor a pagar:";
                    lblValorPagar.Text = "$ " + oImpuesto.valorPagar.ToString("###,###");
                    lblError.Text = "";
                }
                else
                {
                    lblTituloPagar.Text = "Valor a devolver:";
                    lblValorPagar.Text = "$ " + Math.Abs(oImpuesto.valorPagar).ToString("###,###");
                    lblError.Text = "";
                }
            }
            else
            {
                lblError.Text = "ERROR: " + oImpuesto.error;
                lblValorImpuesto.Text = "";
                lblTituloPagar.Text = "";
                lblValorPagar.Text = "";
            }

            oImpuesto = null;
        }
    }
}
