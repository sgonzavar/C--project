using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libWebAppplication.AtenderFormularios;

namespace WebApplication.Formularios
{
    public partial class WebAlmacen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }


        private void LlenarGrid()
        {
            ClsAlmacen oC = new ClsAlmacen();
            oC._GridAlmacen = GridView1;
            if (!oC.LlenarGrid())
            {
                lblError.Text = oC._Error;
            }

            oC = null;
        }


        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Formularios/WebPrincipal.aspx");
        }
    }
}