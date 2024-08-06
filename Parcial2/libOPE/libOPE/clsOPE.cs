using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libRN;

namespace libOPE
{
    public class clsOPE
    {
        #region"Atributos"
        private string strCargo;
        private int intHoras, intHoraExtra;
        private double dblvalorHora, dblRetencion, dblRecargo , dblTotal, dblValorHoraExtra;
        private string strError;
        #endregion

        #region "Propiedades"

        public string cargo
        {
            set { strCargo = value; }
            get { return strCargo; }
        }

        public int  Hora
        { set { intHoras = value; } }

        // Al formulario 

        public double precioHoraExtra
        { get { return dblValorHoraExtra; } }

        public double recargo
        { get { return dblRecargo; } }

        public double retencion
        { get { return dblRetencion; } }

        public double total
        { get { return dblTotal; } }

        public string Error
        { get { return strError; } }
        #endregion

        #region "Metodos Privados"
        private bool Validar()
        {
            if (intHoras <= 0)
            {
                strError = " Horas No Validas ";
                return false;
            }
            return true;
        }

        #endregion


        #region "Metodos Publicos"
        public bool Procesar()
        {
            
            try
            {
                if (!Validar())
                    return false;
                clsRN objXX = new clsRN();
                objXX.Cargo.Equals(strCargo);
                if (!objXX.Consultar())
                {
                    strError = objXX.error;
                    objXX = null;
                    return false;
                }
                if (intHoras > 240)
                { 
                    intHoraExtra = intHoras - 240;
                    dblvalorHora = objXX.PrecioHora * 240;



                }
                



                          //dblSubTotal = dblVrUnit * dblCant;
                          //dblVrDscto = dblSubTotal * (objXX.PorcDscto / 100.0);
                          //dblVrAPagar = dblSubTotal - dblVrDscto;
                objXX = null;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion 



       

    }
}
