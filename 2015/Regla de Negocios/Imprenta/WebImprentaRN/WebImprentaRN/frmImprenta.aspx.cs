using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libImprentaRN.ReglaDeNegocio;
using libImprentaRN;

namespace WebImprentaRN
{
    public partial class frmImprenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Int32 pasta, papel, impresion, cantidad;
            try
            {
                //Captura de Info
                pasta = Convert.ToInt32(cmbPasta.SelectedValue);
                papel = Convert.ToInt32(cmbPapel.SelectedValue);
                impresion = Convert.ToInt32(cmbImpresion.SelectedValue);
                cantidad = Convert.ToInt32(txtCantidad.Text);            

                //crear objeto
                ClsImprenta objI = new ClsImprenta();
                ClsLecturaXML objX = new ClsLecturaXML();


                //envio de info
                objI._Cantidad = cantidad;
                objX._CantidadCopia = cantidad;
                objI._Pasta = pasta;
                objI._Papel = papel;
                objI._Imprecion = impresion;



                if (!objI.calcularTotal())
                {
                    lblError.Text = "Error 4004," + objI._Error;
                    objI = null;
                    return;
                }
                //Recuparar Info

                this.lblSubtotal.Text = "$" + objI._SubTotal.ToString();
                this.lblDescuento.Text = "$" + objI._ValorDescuento.ToString();
                this.lblTotal.Text = "$" + objI._ValorTotal.ToString();
                


            }
            catch (Exception ex)
            {

            }


        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblDescuento.Text = "";
            lblError.Text = "";
            lblSubtotal.Text = "";
            lblTotal.Text = "";
            txtCantidad.Text = "";
            txtCantidad.Focus();
            cmbImpresion.SelectedIndex = 0;
            cmbPapel.SelectedIndex = 0;
            cmbPasta.SelectedIndex = 0;
 
        }
    }
}