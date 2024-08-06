using System;


namespace pDesarrollo8_10.BaseDatos
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
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

            if(oCliente.Grabar())
            {
                lblRespuesta.Text = "Grabó";
            }
            else
            {
                lblRespuesta.Text = oCliente.Error;
            }
            oCliente = null;
                       
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 iIdCliente;
            string sDocumento;
            string sNombre;
            string sApellidos;
            string sDireccion;
            string sTelefono;
            string sEmail;

            iIdCliente = Convert.ToInt32(txtIdCliente.Text);
            clsCliente oCliente = new clsCliente();
            oCliente.CodigoCliente = iIdCliente;

            if (oCliente.Consultar())
            {
                txtDocumento.Text = oCliente.Documento;
                txtNombre.Text = oCliente.Nombre;
                txtApellidos.Text = oCliente.Apellidos;
                txtDireccion.Text = oCliente.Direccion;
                txtTelefono.Text = oCliente.Telefono;
                txtEmail.Text = oCliente.Email;
                lblRespuesta.Text = "Consultó";
            }
            else
            {
                txtDocumento.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
                lblRespuesta.Text = oCliente.Error;
            }
            
            
            oCliente = null;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int iCodigoCliente;
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
            iCodigoCliente = Convert.ToInt32(txtIdCliente.Text);


            clsCliente oCliente = new clsCliente();
            oCliente.Documento = sDocumento;
            oCliente.Nombre = sNombre;
            oCliente.Apellidos = sApellidos;
            oCliente.Direccion = sDireccion;
            oCliente.Telefono = sTelefono;
            oCliente.Email = sEmail;
            oCliente.CodigoCliente = iCodigoCliente;

            if (oCliente.Actualizar())
            {
                lblRespuesta.Text = "Actualizó";
            }
            else
            {
                lblRespuesta.Text = oCliente.Error;
            }
            oCliente = null;

            

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            Int32 iIdCliente;

            iIdCliente = Convert.ToInt32(txtIdCliente.Text);

            clsCliente oCliente = new clsCliente();
            oCliente.CodigoCliente  = iIdCliente;

            if (oCliente.Borrar())
            {
                lblRespuesta.Text = "Borró";
            }
            else
            {
                lblRespuesta.Text = oCliente.Error;
            }
            oCliente = null;
        }
    }
}