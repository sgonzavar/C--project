using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoZlu
{
    class ProductoPrecioFijo : Producto
    {
        #region "Atrivutos"
        private decimal dcmlPrecio;
        #endregion


        #region "Propiedades"
        public decimal Precio { get => dcmlPrecio; set => dcmlPrecio = value; }
        #endregion

        #region "Constructor"
        public ProductoPrecioFijo(string id, string descripcion, double tarifaIVA, decimal precio):
            base(id, descripcion, tarifaIVA)
        {
            this.dcmlPrecio = precio;
        }

        #endregion

        #region "Metodos Publicos"
        public override string ToString()
        {
            return String.Format(" Producto Precio Fijo: {0}\n\t" +
                "Precio............................: $ {1,12:N0}\n\t" +
                "Valor Iva.........................: $ {2,12:N0}\n\t" +
                "Valor Venta.......................: $ {3,12:N0}"
                , base.ToString(), dcmlPrecio, ObtenerValorIVA(), ObtenerValorVenta());
        }
        #endregion

        #region "Metodos Publicos"

        public override decimal ObtenerValorIVA()
        {
            return dcmlPrecio * (decimal)TarifaIVA;
        }

        public override decimal ObtenerValorVenta()
        {
            return dcmlPrecio + ObtenerValorIVA();

        }
        #endregion

    }
}
