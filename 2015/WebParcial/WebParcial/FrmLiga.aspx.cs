using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libLigaNatacion;

namespace WebParcial
{
    public partial class FrmLiga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lblError.Text = "";
            this.lblResultado.Text = "";
            this.txtGradoDificultad.Text = "";
            this.txtj1.Text = "";
            this.txtj2.Text = "";
            this.txtj3.Text = "";
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double dblj1, dblj2, dblj3, dblGradoD;
            bool check;
            check = chkEventoOlimpico.Checked;

            try
            {

                dblj1 = Convert.ToDouble(this.txtj1.Text);
                dblj2 = Convert.ToDouble(this.txtj2.Text);
                dblj3 = Convert.ToDouble(this.txtj3.Text);
                dblGradoD = Convert.ToDouble(this.txtGradoDificultad.Text);

                ClsLiga objLiga = new ClsLiga();

                //Envio
                objLiga._Puntaje1 = dblj1;
                objLiga._Puntaje2 = dblj2;
                objLiga._Puntaje3 = dblj3;
                objLiga._GradoDificultad = dblGradoD;

                //Resultado
                if (!objLiga.Resultado(check))
                {
                    lblError.Text = "Hubo un Error" + objLiga._Error;
                    objLiga = null;
                    return;
                }

                this.lblResultado.Text = objLiga._Calificacion.ToString();
                objLiga = null;

            }
            catch (Exception ex)
            {
                lblError.Text = "Hubo Un Error, " + ex.Message; 
               
            }


        }
    }
}