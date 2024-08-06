using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDSI54.ClasesSimples;

namespace pWebDSI54.ClasesSimples
{
    public partial class PuntajeClavados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            clsPuntajeClavados oPuntajeClavados = new clsPuntajeClavados();

            oPuntajeClavados.puntaje1 = Convert.ToDouble(txtPuntajeJuez1.Text);
            oPuntajeClavados.puntaje2 = Convert.ToDouble(txtPuntajeJuez2.Text);
            oPuntajeClavados.puntaje3 = Convert.ToDouble(txtPuntajeJuez3.Text);
            oPuntajeClavados.gradoDificultad = Convert.ToDouble(txtGradoDificultad.Text);
            oPuntajeClavados.cicloOlimpico = chkCicloOlimpico.Checked;

            lblPuntajeTotal.Text = oPuntajeClavados.calcularPuntaje().ToString();
        }
    }
}