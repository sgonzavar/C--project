using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAlgebraBasica
{
    public class AlgebraClase
    {
        #region "Atributos"

        private double N_Uno;
        private double N_Dos;
        private double resultado;
        private  string Error;

        #endregion

        #region "Constructor"
        public AlgebraClase()
        {
            N_Uno = 0;
            N_Dos = 0;
            resultado = 0;
            Error = string.Empty;

        }
        #endregion 





        #region "Propiedades"


        public double N_Uno
        { set { N_Uno = value; } }

        public double N_Dos
        { set { N_Dos = value; } }



        #endregion 

    }
}
