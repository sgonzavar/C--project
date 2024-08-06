using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libAgencia
{
    public class ClsAgencia
    {
        #region" Atributos "


        private double dblValorServicio, dblvalorIva;
        private Int32 intAnos; 
        private double dblValorTotal, dblValorDescuento;
        private string strError;

        #endregion

        #region " Constructor "

        public ClsAgencia()
        {
            
            
            this.dblvalorIva = 0.0;
            this.dblValorServicio = 0.0;
            this.dblValorTotal = 0.0;
            this.strError = string.Empty;
        }
        #endregion

        #region " Propiedades "

       

        public double _Servicio
        {
            get { return dblValorServicio; }
            set { dblValorServicio = value; }
        }
 

        public double _Total
        {
            get { return dblValorTotal; }

        }

        public double _Iva
        {
            get { return dblvalorIva; }

        }

        public string _Error
        {
            get { return strError; }
        }

        #endregion

        #region " Metodos Privados "

        public bool validar()
        {
            if (dblValorServicio < 0)
            {
                strError = "La cantidad debe ser mayor a cero";
                return false;
            }
            return true;
        }

        #endregion

        #region "Metodos Publicos"
        public bool calcular()
        {
            if (!validar())
            {
                return false;
            }
            try
            {
                dblvalorIva = dblValorServicio * 0.16;
                dblValorTotal = dblValorServicio - dblValorDescuento + dblvalorIva;
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
