using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libAgencia.Xml;
using libAgencia; 
namespace webAgencia
{
    public partial class FrmAgencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCal_Click(object sender, EventArgs e)
        {
            Int32 Anios;
            double Servicio;

            try
            {
                Anios = Convert.ToInt32(this.txtCantidadA.Text);
                Servicio = Convert.ToDouble(this.txtServicio.Text);
                ClsAgencia objAgencia = new ClsAgencia();
                cls_RN_Agencia obj = new cls_RN_Agencia();
                
                //Envio

                obj.CantidadAnos = Anios;
                objAgencia._Servicio = Servicio;

                if (!objAgencia.calcular())
                {
                    lblError.Text = "Hubo un Error " + objAgencia._Error; 
                    objAgencia = null;
                    return; 
                }

                this.lblDescuento.Text = obj.PorcentajeDescuento.ToString();
                this.lblIva.Text = objAgencia._Iva.ToString();
                this.lblPagar.Text = objAgencia._Total.ToString();
                this.lblVAntesDescuento.Text = Servicio.ToString();           

            }
            catch (Exception ex)
            {
                lblDescuento.Text = "Error" + ex.Message; 

            }
            

        }

        protected void btnLim_Click(object sender, EventArgs e)
        {

            this.lblDescuento.Text = "";
            this.lblError.Text = "";
            this.lblIva.Text = "";
            this.lblPagar.Text = "";
            this.lblVAntesDescuento.Text = ""; 
        }
    }
}