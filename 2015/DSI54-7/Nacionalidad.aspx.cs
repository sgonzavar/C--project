using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDSI54.BaseDatos;

namespace pWebDSI54.BaseDatos
{
    public partial class Nacionalidad : System.Web.UI.Page
    {
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            clsNacionalidad oNacionalidad = new clsNacionalidad();
            oNacionalidad.nombre = txtNombre.Text;
            oNacionalidad.activo = chkActivo.Checked;
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
            clsNacionalidad oNacionalidad = new clsNacionalidad();
            oNacionalidad.codigo = Convert.ToInt32(txtCodigo.Text);
            oNacionalidad.nombre = txtNombre.Text;
            oNacionalidad.activo = chkActivo.Checked;
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
            Int32 iCodigo;
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
            Int32 iCodigo;
            iCodigo = Convert.ToInt32(txtCodigo.Text);
            clsNacionalidad oNacionalidad = new clsNacionalidad();
            oNacionalidad.codigo = iCodigo;
            if (oNacionalidad.Consultar())
            {
                txtNombre.Text = oNacionalidad.nombre;
                chkActivo.Checked = oNacionalidad.activo;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "ERROR: " + oNacionalidad.error;
                txtNombre.Text = "";
                chkActivo.Checked = false;
            }
            oNacionalidad = null;
        }
    }
}