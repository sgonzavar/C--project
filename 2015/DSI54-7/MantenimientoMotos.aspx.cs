using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDesarrollo_6_8.ClasesBasicas;

namespace pWEBDesarrollo_6_8.ClasesBasicas
{
    public partial class MantenimientoMotos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Int32 iManoObra, iRepuestos;

            iManoObra = Convert.ToInt32(txtManoObra.Text);
            iRepuestos = Convert.ToInt32(txtRepuestos.Text);
            //Creamos el objeto
            clsMantenimiento oMantenimiento = new clsMantenimiento();
            //Se pasan las propiedades de entrada del objeto
            oMantenimiento.ValorManoObra = iManoObra;
            oMantenimiento.ValorMateriales = iRepuestos;
            //Se invoca el métod de calcularTotal
            //Los metodos booleanos se ejecutan con la instruccion if
            if (oMantenimiento.CalcularTotal())
            {
                //Si es verdadero, se imprimen las respuestas
                lblSubtotal.Text = "$ " + oMantenimiento.Subtotal.ToString("###,###"); 
                lblIVA.Text = "$ " + oMantenimiento.ValorIVA.ToString("###,###");
                lblTotal.Text = "$ " + oMantenimiento.Total.ToString("###,###");
            }
            else
            {
                //Si es falso, se imprime el error
                lblError.Text = oMantenimiento.Error;
            }
            //Liberar memoria
            //Nombre del objeto = null;
            oMantenimiento = null;
        }
    }
}