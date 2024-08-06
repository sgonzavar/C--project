using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libImpuestos
{
    public class clsImpuesto
    {
        #region "Atributos"

        private Int32 i_IngresoAnual, i_RetencionFuente, i_PorcentajeImpuesto, i_ValorPagar, i_ValorImpuestoTeorico;
        private string s_Error;
        #endregion


        #region "Constructor"
        public clsImpuesto()
        {
            i_IngresoAnual = 0;
            i_RetencionFuente = -1;
            i_PorcentajeImpuesto = 0;
            i_ValorImpuestoTeorico = 0;
            i_ValorPagar = 0;
            s_Error = string.Empty;
        }

        #endregion


        #region "Propiedades"

        public Int32 ingresoAnual
        {
            get { return i_IngresoAnual; }
            set { i_IngresoAnual = value; }
        }

        public Int32 retencionFuente
        {
            get { return i_RetencionFuente; }
            set { i_RetencionFuente = value; }
        }

        public Int32 porcentajeImpuesto
        {
            get { return i_PorcentajeImpuesto; }
        }

        public Int32 valorPagar
        {
            get { return i_ValorPagar; }
        }

        public String error
        {
            get { return s_Error; }
        }

        #endregion

        #region "Metodos"

        public bool CalcularPagarImpuesto()
        {
            try
            {
                if (i_IngresoAnual < 30000000)
                {
                    i_PorcentajeImpuesto = 0;
                }
            }
            catch (Exception ex)
            {
                s_Error = ex.Message;
                return false;
            }
        }



        private bool CalcularImpuestoTeorico()
        {
            if (i_IngresoAnual < 30000000)
            {
                i_PorcentajeImpuesto = 0.0;
            }
            else
            {
                if (i_IngresoAnual < 5000000)
                {
                    i_PorcentajeImpuesto = 0.06;
                }
                else
                {
                    i_PorcentajeImpuesto = 0.12;
                }
            }
            i_ValorImpuestoTeorico = Convert.ToInt32(i_PorcentajeImpuesto*i_IngresoAnual);
            return true;
        }


        public CalcularPagoImpuesto()
        {
            if (Validar())
            {
                if (CalcularImpuestoTeorico())
                {
                    i_ValorPagar = i_ValorImpuestoTeorico - i_RetencionFuente;
                    return true;
                }
                else
                {

                }
            }


        private bool Validar()
        {
            if(i_IngresoAnual <= 0 )
            s_Error = "El Ingreso Anual Debe Ser Mayor Que 0";
            return false;
        }

    }

        #endregion


    
}
