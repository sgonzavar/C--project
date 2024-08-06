using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libFiguraGeometrica
{
    public abstract class clsFiguraGeometrica
    {
        
        #region " Atributos " 
        protected double dblArea, dblPerimetro;
        protected string strError;
        #endregion


        #region " Propiedades "
        public double Area
        {
            get { return dblArea; }
        }

        public double Permimetro
        {
            get { return dblPerimetro; }
        }
        public string Error
        {
            get { return strError; }
        }

        #endregion


        #region " MetodosPublicos"
        public abstract bool HallarArea();
        public abstract bool HallarPerimetro();
        #endregion
    }
}
