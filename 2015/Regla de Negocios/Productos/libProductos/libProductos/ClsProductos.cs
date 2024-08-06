using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libReglaNegocio;

namespace libProductos
{
    public class ClsProductos
    {
        #region "Atributos"

        private int intCodigo;
        private double dblCantidad, dblValorUnitario, dblValorDescuento, dblValorAPagar;
        private string strError;

        #endregion

        #region "Constructor"

        public ClsProductos()
        {
            intCodigo = 0;
            dblCantidad = 0;
            dblValorAPagar = 0;
            dblValorDescuento = 0;
            dblValorUnitario = 0;
            strError = string.Empty;
        }

        #endregion

        #region "Propiedades"

        public int _Codigo
        {
            set { intCodigo = value; }
            get { return intCodigo; }
        }

        public double _valorUnitario
        {
            set { dblValorUnitario = value; }
        }

        public double _Cantidad
        {
            set { dblCantidad = value; }
        }

        public double _ValorDescuento
        {
            get { return dblValorDescuento; }
        }

        public double _ValorAPagar
        {
            get { return dblValorAPagar; }
        }

        public string _Error
        {
            get { return strError; }

        }

        #endregion

        #region "Metodos Privados"

        private bool Validar()
        {
            if (intCodigo <= 0)
            {
                strError = "Codigo Del Producto No Valido";
                return false;
            }

            if (dblValorUnitario < 0)
            {
                strError = "Valor Unitario No Valido";
                return false;
            }

            if (dblCantidad <= 0)
            {
                strError = "Caantidad No Valida";
                return false;
            }
            return true;
        }

        #endregion


        #region "Metodos Publicos"

        public bool Procesar()
        {
            double dblSubtotal = 0;
            try
            {
                if (!Validar())
                    return false;
                ClsDescuentoProd objRN = new ClsDescuentoProd();
                objRN._Codigo = intCodigo;

                if (!objRN.Cosnultar())
                {
                    strError = objRN._Error;
                    objRN = null;
                    return false;
                }
                dblSubtotal = dblValorUnitario * dblCantidad;
                dblValorDescuento = dblSubtotal * (objRN._Descuento / 100.0);
                dblValorAPagar = dblSubtotal - dblValorDescuento;
                objRN = null;
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
