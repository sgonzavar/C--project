using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreriaMtto
{
    public class clsMantenimiento
    {

        #region "Atributos"

        //private double dPorcentajeIva;
        private Int32 iValorManoObra, iValorMaterial, iValorIva, iSubTotal, iTotal;
        private string sError;

        #endregion


        #region "Constructor"

        public clsMantenimiento()
        {
            iValorManoObra = 0;
            iValorMaterial = 0;
            iValorIva = 0;
            iSubTotal = 0;
            iTotal = 0;
            sError = string.Empty;
        }

        #endregion


        #region "Propiedades"

        public Int32 valorManoObra
        {
            get { return iValorManoObra; }
            set { iValorManoObra = value; }
        }

        public Int32 valorMateria
        {
            get { return iValorMaterial; }
            set { iValorMaterial = value; }
        }

        public Int32 valorIva
        {
            get { return iValorIva; }
        }

        public Int32 subTotal
        {
            get { return iSubTotal; }
        }

        public Int32 total
        {
            get { return iTotal; }
        }

        public string error
        {
            get { return sError; }
        }

        #endregion


        #region "Metodos Privados"

        private bool Validar()
        {
            if (iValorManoObra < 0)
            {
                sError = "Valor Mano Obra No Valido.";
                return false;
            }
            return true;
        }

        #endregion


        #region "Metodos Publicos"

        public bool CalcularSubTotal()
        {
            if (!Validar())
            {
                return false;
            }

            try
            {
                if (iValorMaterial == 0)
                {
                    iSubTotal = iValorManoObra;
                }
                else
                {
                    iSubTotal = iValorManoObra + iValorMaterial;
                }
                return true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                return false;
            }
        }

        public bool CalcularIva()
        {
            try
            {
                iValorIva = iSubTotal * 19 / 100;
                return true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                return false;
            }
        }

        public bool CalcularTotal()
        {
            try
            {
                iTotal = iSubTotal + iValorIva;
                return true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                return false;
            }
        }

        #endregion
    }
}
