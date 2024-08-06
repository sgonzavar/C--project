using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Referenciar y Usar
using LibFiguras;

namespace WebPractica3
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        #region "Atributos"
        static int intFig;
        double dblDato, dblDato2, dblDato3, dblArea, dblPerim;
        #endregion

        #region "Metodos Personalizados"

        private void Mensaje(string Texto)
        {
            this.lblMsj.Text = Texto;
        }

        private void Limpiar()
        {
            this.txtRadio.Text = string.Empty;
            this.txtLadoA.Text = string.Empty;
            this.txtLadoB.Text = string.Empty;
            this.txtLadoC.Text = string.Empty;
            this.txtLado.Text = string.Empty;
        }

        private void LimpiarRptas()
        {
            this.lblArea.Text = string.Empty;
            this.lblPerim.Text = string.Empty;
            this.pnlRpta.Visible = false;
            Mensaje(string.Empty);
        }
        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                intFig = 1;
                this.txtRadio.Focus();
            }
        }

        protected void btnTerminar_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarRptas();
            this.rblFiguras.Focus();
        }

        protected void rblFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pnlCirculo.Visible = false;
            this.pnlTriangulo.Visible = false;
            this.pnlCuadrado.Visible = false;
            this.pnlRpta.Visible = false;

            Limpiar();
            LimpiarRptas();
            intFig = rblFiguras.SelectedIndex + 1;
            switch (this.rblFiguras.SelectedValue)
            {
                case  "opcCirc":
                    this.pnlCirculo.Visible = true;
                    this.txtRadio.Focus();
                    break;

                case "opcTriag":
                    this.pnlTriangulo.Visible = true;
                    this.txtLadoA.Focus();
                    break;

                case "opcCuad":
                    this.pnlCuadrado.Visible = true;
                    this.txtLado.Focus();
                    this.btnLimpiar.Visible = true;
                    break;
            }


        }









    }
}