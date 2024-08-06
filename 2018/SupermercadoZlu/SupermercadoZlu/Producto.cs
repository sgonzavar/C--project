using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoZlu
{
    abstract class Producto
    {
        #region "Atrivutos"
        private string strId;
        private string strDescripcion;
        private double dblTarifaIVA;
        #endregion


        #region "Propiedades"
        public string Id { get => strId; set => strId = value; }
        public string Descripcion { get => strDescripcion; set => strDescripcion = value; }
        public double TarifaIVA { get => dblTarifaIVA; set => dblTarifaIVA = value; }
        #endregion

        #region "Constructor"
        public Producto(string id, string descripcion, double tarifaIVA)
        {
            this.strId = id;
            this.strDescripcion = descripcion;
            this.dblTarifaIVA = tarifaIVA;
        }

        #endregion

        #region "Metodos Publicos"
        public override string ToString()
        {
            return String.Format("{0} {1}\n\tTarifa Iva............................: {2:P} "
                , strId, strDescripcion, dblTarifaIVA);
        }
        #endregion

        #region "Metodos Publicos"
        public abstract decimal ObtenerValorIVA();
        public abstract decimal ObtenerValorVenta();
        #endregion
        
    }
}
