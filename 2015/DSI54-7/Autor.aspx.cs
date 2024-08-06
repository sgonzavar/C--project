using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriasSW.BaseDatos;

namespace pWEBDesarrollo6_8.BaseDatos
{
    public partial class Autor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarComboNacionalidad();
            }
        }
        private void LlenarComboNacionalidad()
        {
            //Creo el objeto nacionalidad
            clsNacionalidad oNacionalidad = new clsNacionalidad();
            //Paso el combo vacío
            oNacionalidad.cboNacionalidad = cboNacionalidad;
            //Invoco el método
            if (!oNacionalidad.LlenarCombo())
            {
                //Captura el error
                lblError.Text = oNacionalidad.Error;
            }
            //Libera memoria
            oNacionalidad = null;
        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}