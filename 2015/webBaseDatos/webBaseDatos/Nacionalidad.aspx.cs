using System;
using libDesarrollo_6_8.BaseDatos;

namespace pWebDesarrollo_6_8.BaseDatos
{
    public partial class Nacionalidad : System.Web.UI.Page
    {
        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            string sNombre;
            bool bActivo;

            sNombre = txtNombre.Text;
            bActivo = chkActivo.Checked;

            clsNacionalidad oNacionalidad = new clsNacionalidad();
            oNacionalidad.Nombre = sNombre;
            oNacionalidad.Activo = bActivo;

            if (oNacionalidad.Grabar())
            {
                lblError.Text = "Se grabó la nacionalidad";
            }
            else
            {
                lblError.Text = oNacionalidad.Error;
            }
            oNacionalidad = null;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Int32 iCodigo;
            string sNombre;
            bool bActivo;

            iCodigo = Convert.ToInt32(txtCodigo.Text);
            sNombre = txtNombre.Text;
            bActivo = chkActivo.Checked;

            clsNacionalidad oNacionalidad = new clsNacionalidad();
            oNacionalidad.Nombre = sNombre;
            oNacionalidad.Activo = bActivo;
            oNacionalidad.Codigo = iCodigo;

            if (oNacionalidad.Actualizar())
            {
                lblError.Text = "Se actualizó la nacionalidad";
            }
            else
            {
                lblError.Text = oNacionalidad.Error;
            }
            oNacionalidad = null;
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            Int32 iCodigo;

            iCodigo = Convert.ToInt32(txtCodigo.Text);

            clsNacionalidad oNacionalidad = new clsNacionalidad();
            oNacionalidad.Codigo = iCodigo;

            if (oNacionalidad.Borrar())
            {
                lblError.Text = "Se eliminó la nacionalidad";
            }
            else
            {
                lblError.Text = oNacionalidad.Error;
            }
            oNacionalidad = null;
        }
    }
}