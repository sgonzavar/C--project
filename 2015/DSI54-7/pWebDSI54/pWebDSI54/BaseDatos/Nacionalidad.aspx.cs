using System;
using libDSI54.BaseDatos;

namespace pWebDSI54.BaseDatos
{
    public partial class Nacionalidad : System.Web.UI.Page
    {
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            string sNombre;
            bool bActivo;

            sNombre = txtNombre.Text;
            bActivo = chkActivo.Checked;

            clsNacionalidad oNacionalidad = new clsNacionalidad();

            oNacionalidad.nombre = sNombre;
            oNacionalidad.activo = bActivo;

            if (oNacionalidad.Insertar())
            {
                lblError.Text = "Se insertó la nacionalidad";
            }
            else
            {
                lblError.Text = "ERROR: " + oNacionalidad.error;
            }

            oNacionalidad = null;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int iCodigo;
            string sNombre;
            bool bActivo;

            iCodigo = Convert.ToInt32(txtCodigo.Text);
            sNombre = txtNombre.Text;
            bActivo = chkActivo.Checked;

            clsNacionalidad oNacionalidad = new clsNacionalidad();

            oNacionalidad.codigo = iCodigo;
            oNacionalidad.nombre = sNombre;
            oNacionalidad.activo = bActivo;

            if (oNacionalidad.Actualizar())
            {
                lblError.Text = "Se actualizó la nacionalidad";
            }
            else
            {
                lblError.Text = "ERROR: " + oNacionalidad.error;
            }

            oNacionalidad = null;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int iCodigo;

            iCodigo = Convert.ToInt32(txtCodigo.Text);

            clsNacionalidad oNacionalidad = new clsNacionalidad();

            oNacionalidad.codigo = iCodigo;

            if (oNacionalidad.Eliminar())
            {
                lblError.Text = "Se eliminó la nacionalidad";
            }
            else
            {
                lblError.Text = "ERROR: " + oNacionalidad.error;
            }

            oNacionalidad = null;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int iCodigo;

            iCodigo = Convert.ToInt32(txtCodigo.Text);

            clsNacionalidad oNacionalidad = new clsNacionalidad();

            oNacionalidad.codigo = iCodigo;

            if (oNacionalidad.Consultar())
            {
                txtNombre.Text = oNacionalidad.nombre;
                chkActivo.Checked = oNacionalidad.activo;
                lblError.Text = "Se consultó la nacionalidad";
            }
            else
            {
                txtNombre.Text = "";
                chkActivo.Checked = false;
                lblError.Text = "ERROR: " + oNacionalidad.error;
            }

            oNacionalidad = null;
        }
    }
}