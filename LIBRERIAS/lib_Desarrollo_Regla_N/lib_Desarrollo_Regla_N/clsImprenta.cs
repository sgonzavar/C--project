using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_Desarrollo_Regla_N;

namespace lib_Desarrollo_Regla_N.Clases
{
    public class clsImprenta
    {

        #region "Atributos"

        private Int32 intValorUnitario, intCantidad, intValorDescuento, intValortotal, intSubTotal;
        private double dblPorcentajeDescuento;
        private string stError;

        #endregion

        #region "Propiedades"

        public int _Cantidad
        {
            get { return intCantidad; }
            set { intCantidad = value; }
        }
        public int _ValorDescuento
        {
            get { return intValorDescuento; }
        }

        public int _ValorTotal
        {
            get { return intValortotal; }
        }

        public int _SubTotal
        {
            get { return intSubTotal; }
        }

        public string _Error
        {
            get { return stError; }
        }

        #endregion

        #region "Constructor"

        public clsImprenta()
        {
            intCantidad = 0;

        }

        #endregion

        #region "Metodos"

        public bool calcularTotal()
        {
            if (validar())
            {
                if (calcularPorcentajeDescuento())
                {
                    // se calcula los valores 
                    intSubTotal = intCantidad * intValorUnitario;
                    intValorDescuento = Convert.ToInt32(intSubTotal * dblPorcentajeDescuento);
                    intValortotal = intSubTotal - intValorDescuento;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }

        public bool calcularPorcentajeDescuento()
        {
            // invocar la regla de negocio
            Cls_RN_DESCUENTO_IMPRENTA oDescuento = new Cls_RN_DESCUENTO_IMPRENTA();

            oDescuento._CantidadLibros = intCantidad;
            if (oDescuento.calcularPorcentaje())
            {
                dblPorcentajeDescuento = oDescuento._PorsentajeDescuento;
                oDescuento = null;
                return true;
            }
            else
            {
                stError = oDescuento._Error;
                oDescuento = null;
                return false;
            }
        }

        public bool validar()
        {
            if (intCantidad < 0 || intCantidad > 500000)
            {
                stError = "Debe definir una cantidad Entre 1 y 500.000";
                return false;
            }
            return true;
        }


        #endregion

    }
}
