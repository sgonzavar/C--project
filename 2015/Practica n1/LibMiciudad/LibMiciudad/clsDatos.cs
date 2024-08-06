using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMiCiudad
{
    public class clsDatos
    {

        #region "Atributos"

        private int intEst;
        private double dblVrD, dblE, dblA, dblT, dblVrCentavo;
        private double dblVrE, dblVrA, dblVrT, dblVrAP;
        private string strError;

        #endregion

        #region "Constructor"

        public clsDatos() 
        {
            intEst  = 0;
            dblVrD  = 0;
            dblE    = 0;
            dblA    = 0;
            dblT    = 0;
            dblVrCentavo = 0;
            dblVrE  = 0;
            dblVrA  = 0;
            dblVrT  = 0;
            dblVrAP = 0;
            strError = string.Empty;        
        }

        #endregion

        #region "propiedades"
         //Entrada
        public double VrDolar
        { set { dblVrD = value; } }

        public int Estrato 
        { set { intEst = value; } }

        public double Energia 
        { set { dblE = value; } }

        public double Agua 
        { set { dblA = value; } }

        public double Telefono 
        { set { dblT = value; } }

        //Salida
        public double VrEnergia
        { get { return dblVrE; } }

        public double VrAgua
        { get { return dblVrA; } }

        public double VrTelefono
        { get { return dblVrT; } }

        public double TotalApagar
        { get { return dblVrAP; } }

        public string Error
        { get { return strError; } }

        #endregion

        #region "metodos privados "

        private bool Validar()
        {
            if (intEst < 1 || intEst > 6)
            {
                strError = " Estrato No Valido ";
                return false;
            }

            if (dblVrD <= 0)
            {
                strError = " Valor Del Dolar No Validar ";
                return false;
            }

            if (dblE < 0)
            {
                strError = " Valor Del KW No Validar ";
                return false;
            }

            if (dblA < 0)
            {
                strError = " Valor Del Agua No Validar ";
                return false;
            }

            if (dblT < 0)
            {
                strError = " Valor Del Telefono No Validar ";
                return false;
            }

            return true;
        
        }


        #endregion

        #region "metodos publicos"

        public bool Facturar()
        {
            if (!Validar())
               return false;
            dblVrCentavo = dblVrD / 100;
            try
            {
                switch (intEst)
                {
                    case 1:
                    case 2:
                        dblVrE = dblE * 173 * dblVrCentavo;
                        dblVrA = dblA * 120 * dblVrCentavo;
                        dblVrT = dblT *   8 * dblVrCentavo; break;

                    case 3:
                    case 4:
                        dblVrE = dblE * 198 * dblVrCentavo;
                        dblVrA = dblA * 155 * dblVrCentavo;
                        dblVrT = dblT *  12 * dblVrCentavo; break;

                    default:
                        dblVrE = dblE * 235 * dblVrCentavo;
                        dblVrA = dblA * 180 * dblVrCentavo;
                        dblVrT = dblT *  17 * dblVrCentavo; break;
                }
                dblVrAP = dblVrE + dblVrA + dblVrT;
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
