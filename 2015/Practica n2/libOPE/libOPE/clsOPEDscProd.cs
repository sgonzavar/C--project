using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referenciar y usar 
using LibRn;

namespace libOPE
{
    public class clsOPEDscProd
    {
        #region"Atributos"
        private int intCodigo;
        private double dblCant, dblVrUnit, dblVrDscto, dblVrAPagar;
        private string strError;
        #endregion

        #region"Constructor"
        public clsOPEDscProd()
        {
            intCodigo = 0;
            dblCant = 0;
            dblVrUnit = 0;
            dblVrDscto = 0;
            dblVrAPagar = 0;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"
        //Desde Form (los SET) y a RN(GET)

        public int Codigo
        {
            set { intCodigo = value; }
            get { return intCodigo; }
        }

        public double Vr_Unitario
        { set { dblVrUnit = value; } }

        public double Cantidad
        { set { dblCant = value; } }

        // Al formulario 

        public double VrDscto
        { get { return dblVrDscto; } }

        public double VrAPagar
        { get { return dblVrAPagar; } }

        public string Error
        { get { return strError; } }
        #endregion

        #region "Metodos Privados"
        private bool Validar()
        {
            if (intCodigo <= 0)
            {
                strError = " Codigo Del Producto No Valido ";
                return false;
            }

            if (dblVrUnit < 0)
            {
                strError = " Valor Unitario No Valido ";
                return false;
            }

            if (dblCant <= 0)
            {
                strError = " Cantidad No Valida ";
                return false;
            }
            return true;
        }

        #endregion

        #region "Metodos Publicos"
        public bool Procesar()
        {
            double dblSubTotal = 0;
            try
            {
                if (!Validar())
                    return false;
                clsRNDscProd objXX = new clsRNDscProd();
                objXX.Codigo = intCodigo;
                if (!objXX.Consultar())
                {
                    strError = objXX.Error;
                    objXX = null;
                    return false;
                }
                dblSubTotal = dblVrUnit * dblCant;
                dblVrDscto  = dblSubTotal * (objXX.PorcDscto / 100.0);
                dblVrAPagar = dblSubTotal - dblVrDscto;
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
