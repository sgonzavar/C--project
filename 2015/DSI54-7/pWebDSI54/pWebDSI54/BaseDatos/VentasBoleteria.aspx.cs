using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDSI54.BaseDatos;

namespace pWebDSI54.BaseDatos
{
    public partial class VentasBoleteria : System.Web.UI.Page
    {
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            // Leer el codigo de la venta
            int iCodigoVenta;
            iCodigoVenta = Convert.ToInt32(txtCodigoVenta.Text);

            // Instanciar la clase
            clsVentasBoleteria oTicketSale = new clsVentasBoleteria();

            // Cargar el codigo de la venta
            oTicketSale.CodigoVenta = iCodigoVenta;

            // Ejecutar la consulta
            if (oTicketSale.Consultar())
            {
                txtCedula.Text = oTicketSale.Cedula;
                txtNombre.Text = oTicketSale.Nombre;
                txtFecha.Text = oTicketSale.Fecha;
                txtLugar.Text = oTicketSale.Lugar;
                txtCantidad.Text = Convert.ToString(oTicketSale.Cantidad);
                txtValorBoleta.Text = Convert.ToString(oTicketSale.ValorBoleta);
                lblValorTotal.Text = Convert.ToString(oTicketSale.ValorTotal);
                lblError.Text = "Consulta exitosa";
                lblError.ForeColor = System.Drawing.Color.ForestGreen;
            }
            else
            {
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtFecha.Text = "";
                txtLugar.Text = "";
                txtCantidad.Text = "";
                txtValorBoleta.Text = "";
                lblValorTotal.Text = "";
                lblError.Text = "ERROR: " + oTicketSale.Error;
                lblError.ForeColor = System.Drawing.Color.Red;
            }

            oTicketSale = null;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            string sCedula;
            string sNombre;
            string sFecha;
            string sLugar;
            int iCantidad;
            int iValorBoleta;
            int iValorTotal;

            sCedula = txtCedula.Text;
            sNombre = txtNombre.Text;
            sFecha = txtFecha.Text;
            sLugar = txtLugar.Text;
            iCantidad = Convert.ToInt32(txtCantidad.Text);
            iValorBoleta = Convert.ToInt32(txtValorBoleta.Text);
            iValorTotal = iCantidad * iValorBoleta;

            clsVentasBoleteria oTicketSale = new clsVentasBoleteria();

            oTicketSale.Cedula = sCedula;
            oTicketSale.Nombre = sNombre;
            oTicketSale.Fecha = sFecha;
            oTicketSale.Lugar = sLugar;
            oTicketSale.Cantidad = iCantidad;
            oTicketSale.ValorBoleta = iValorBoleta;
            oTicketSale.ValorTotal = iValorTotal;

            if (oTicketSale.Insertar())
            {
                lblError.Text = "Inserto";
                lblError.ForeColor = System.Drawing.Color.ForestGreen;
            }
            else
            {
                lblError.Text = "ERROR: " + oTicketSale.Error;
                lblError.ForeColor = System.Drawing.Color.Red;
            }

            oTicketSale = null;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}