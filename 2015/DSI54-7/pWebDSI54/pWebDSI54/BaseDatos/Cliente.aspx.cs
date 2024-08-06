using System;
using libDSI54.BaseDatos;

namespace pWebDSI54.BaseDatos
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            string sDocumento;
            string sNombre;
            string sApellidos;
            string sDireccion;
            string sTelefono;
            string sEmail;
            
            sDocumento = txtDocumento.Text;
            sNombre = txtNombre.Text;
            sApellidos = txtApellidos.Text;
            sDireccion = txtDireccion.Text;
            sTelefono = txtTelefono.Text;
            sEmail = txtEmail.Text;

            clsCliente oCliente = new clsCliente();

            oCliente.Documento = sDocumento;
            oCliente.Nombre = sNombre;
            oCliente.Apellidos = sApellidos;
            oCliente.Direccion = sDireccion;
            oCliente.Telefono = sTelefono;
            oCliente.Email = sEmail;

            if (oCliente.Insertar())
            {
                lblError.Text = "Insertó";
            }
            else
            {
                lblError.Text = "ERROR: " + oCliente.Error;
            }

            oCliente = null;     
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            string sDocumento;

            sDocumento = txtDocumento.Text;

            clsCliente oCliente = new clsCliente();

            oCliente.Documento = sDocumento;

            if (oCliente.Consultar())
            {
                txtCodigo.Text = Convert.ToString(oCliente.CodigoCliente);
                txtNombre.Text = oCliente.Nombre;
                txtApellidos.Text = oCliente.Apellidos;
                txtDireccion.Text = oCliente.Direccion;
                txtTelefono.Text = oCliente.Telefono;
                txtEmail.Text = oCliente.Email;
                lblError.Text = "Consultó";
            }
            else
            {
                txtDocumento.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
                lblError.Text = "ERROR: " + oCliente.Error;
            }
            
            oCliente = null;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int iCodigo;
            string sDocumento;
            string sNombre;
            string sApellidos;
            string sDireccion;
            string sTelefono;
            string sEmail;

            sDocumento = txtDocumento.Text;
            sNombre = txtNombre.Text;
            sApellidos = txtApellidos.Text;
            sDireccion = txtDireccion.Text;
            sTelefono = txtTelefono.Text;
            sEmail = txtEmail.Text;
            iCodigo = Convert.ToInt32(txtCodigo.Text);

            clsCliente oCliente = new clsCliente();

            oCliente.Documento = sDocumento;
            oCliente.Nombre = sNombre;
            oCliente.Apellidos = sApellidos;
            oCliente.Direccion = sDireccion;
            oCliente.Telefono = sTelefono;
            oCliente.Email = sEmail;
            oCliente.CodigoCliente = iCodigo;

            if (oCliente.Actualizar())
            {
                lblError.Text = "Actualizó";
            }
            else
            {
                lblError.Text = "ERROR: " + oCliente.Error;
            }

            oCliente = null;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int iCodigo;

            iCodigo = Convert.ToInt32(txtCodigo.Text);

            clsCliente oCliente = new clsCliente();

            oCliente.CodigoCliente  = iCodigo;

            if (oCliente.Eliminar())
            {
                lblError.Text = "Eliminó";
            }
            else
            {
                lblError.Text = "ERROR: " + oCliente.Error;
            }

            oCliente = null;
        }
    }
}