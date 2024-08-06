using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDSI54.BaseDatos;


namespace pWebDSI54.BaseDatos
{
    public partial class frmAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarComboNacionalidad();
                LlenarGrid();
            }
        }

        private void LlenarComboNacionalidad()
        {
            //creo el objeto nacionalidad
            clsNacionalidad oNacionalidad = new clsNacionalidad();
            //paso el combo vacio
            oNacionalidad.Nacionalidad = cmbNacionalidad;
            //invoca el metodo
            if (!oNacionalidad.LenarCombo())
            {
                //captura el error
                lblError.Text = oNacionalidad.error;
            }
            lblCorrecto.Text = oNacionalidad._correcto;
            //libera memoria 
            oNacionalidad = null;

        }

        private void LlenarGrid()
        {
            ClsAutor oAutor = new ClsAutor();
            oAutor.grdAutor = grvAutor;
            if (!oAutor.LlenarGrid())
            {
                lblError.Text = oAutor.Error;
            }

            oAutor = null;

        }

        protected void btnActualizar_Click1(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            String strNombre, strApellidos;
            DateTime dtmechaNacimiento;
            Int32 intCodigoNacionalidad;

            strNombre = txtNombre.Text;
            strApellidos = txtApellido.Text;
            intCodigoNacionalidad = Convert.ToInt32( cmbNacionalidad.SelectedValue);

            
        }

        protected void btnEliminar_Click1(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}