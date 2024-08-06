using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libDesarrollo_8_10.ReglasNegocio.Clases;

namespace pDesarrollo_6_8.ReglasNegocio
{
    public partial class Celulares : System.Web.UI.Page
    {
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Int32 iValorPlan;
            string sTipoEmpresa;

            sTipoEmpresa = cboTipoEmpresa.SelectedValue;
            iValorPlan = Convert.ToInt32(cboPlan.SelectedValue);

            clsCelulares oCelular = new clsCelulares();

            oCelular.TipoEmpresa = sTipoEmpresa;
            oCelular.ValorPlan = iValorPlan;
            if (oCelular.CalcularTotalMinutos())
            {
                lblMinutosAdicionales.Text = oCelular.CantidadMinutosAdicionales.ToString("###,###");
                lblMinutosPlan.Text = oCelular.CantidadMinutosPlan.ToString("###,###");
                lblTotalMinutos.Text = oCelular.CantidadMintutosTotales.ToString("###,###");
                lblPorcentajeIncremento.Text = (oCelular.PorcentajeIncremento * 100).ToString() + " %";
            }
            else
            {
                lblError.Text = oCelular.Error;
            }
            oCelular = null;
        }
    }
}