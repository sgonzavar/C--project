using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libDesarrollo_6_8.ReglasNegocio.ReglasNegocio;

namespace libDesarrollo_6_8.ReglasNegocio.Clases
{
    public class clsImprenta
    {
        #region Constructor
        public clsImprenta()
        {
            iCantidad = 0;
            iValorUnitario = 12500;
        }
        #endregion
        #region Atributos
        private Int32 iValorUnitario;//privado
        private Int32 iCantidad;//LyE
        private double dPorcentaje;
        private Int32 iValorDescuento;
        private Int32 iValorTotal;
        private Int32 iSubtotal;
        private double dPorcentajeDescuento;//priv
        private string sError;
        #endregion

        #region Propiedades
        public int ValorUnitario
        {
            get
            {
                return iValorUnitario;
            }

            set
            {
                iValorUnitario = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return iCantidad;
            }

            set
            {
                iCantidad = value;
            }
        }

        public double Porcentaje
        {
            get
            {
                return dPorcentaje;
            }

            set
            {
                dPorcentaje = value;
            }
        }

        public int ValorDescuento
        {
            get
            {
                return iValorDescuento;
            }

            set
            {
                iValorDescuento = value;
            }
        }

        public int ValorTotal
        {
            get
            {
                return iValorTotal;
            }

            set
            {
                iValorTotal = value;
            }
        }

        public int Subtotal
        {
            get
            {
                return iSubtotal;
            }

            set
            {
                iSubtotal = value;
            }
        }

        public double PorcentajeDescuento
        {
            get
            {
                return dPorcentajeDescuento;
            }

            set
            {
                dPorcentajeDescuento = value;
            }
        }

        public string Error
        {
            get
            {
                return sError;
            }

            set
            {
                sError = value;
            }
        }

        

        #endregion

        #region Metodos
        public bool CalcularTotal()
        {
            if (Validar())
            {
                if (CalcularPorcentajeDescuento())
                {
                    //se calculan los valores
                    iSubtotal = iCantidad * iValorUnitario;
                    iValorDescuento = Convert.ToInt32(iSubtotal * dPorcentajeDescuento);
                    iValorTotal = iSubtotal - iValorDescuento;
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
        }//end calculartotal

        private  bool CalcularPorcentajeDescuento()
        {
            //Invoca la regla de negocio
            cls_RN_DescuentoImprenta oDescuento = new cls_RN_DescuentoImprenta();
            oDescuento.CantidadLibros = iCantidad;
            if (oDescuento.CalcularPorcentaje())
            {
                //lee la respuesta
                dPorcentajeDescuento = oDescuento.PorcentajeDescuento;
                //liberar memoria
                oDescuento = null;
            //retorna
            return true;
            }
            else
            {
                //lee el error, libera y retorna
                sError = oDescuento.Error;
                oDescuento = null;
                return false;
            }
        }

        private bool Validar()
        {
            if (iCantidad <= 0 || iCantidad > 500000)
            {
                sError = "Debe definir una cantidad ente 1 y 500.000";
                return false;
            }
            return true;
        }
        #endregion
    }//end class
}//end namespace
