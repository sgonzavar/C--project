using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libLigaNatacion
{
    public class ClsLiga
    {
        #region "Atributos"

        private double fltPuntaje1, fltPuntaje2, fltPuntaje3;
        private double fltGradoDificultad, fltCalificacion;
        private string strError;

        #endregion

        #region "Constructor"

        public  ClsLiga()
        {
            fltPuntaje1 = 0;
            fltPuntaje2 = 0;
            fltPuntaje3 = 0;
            fltGradoDificultad = 0;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"

        public double _Puntaje1
        {
            set { fltPuntaje1 = value; }
            get { return fltPuntaje1; }
        }

        public double _Puntaje2
        {
            set { fltPuntaje2 = value; }
            get { return fltPuntaje2; }
        }

        public double _Puntaje3
        {
            set { fltPuntaje3 = value; }
            get { return fltPuntaje3; }
        }

        public double _GradoDificultad
        {
            set { fltGradoDificultad = value; }
            get { return fltGradoDificultad; }
        }

        public double _Calificacion
        {           
            get { return fltCalificacion; }
        }

        public string _Error
        {
            get { return strError; }
        }

        #endregion

        #region "Metodos Privados"
        private bool Validar()
        {
            if (fltGradoDificultad <= 0.9 && fltGradoDificultad >= 4.1)
            {
                strError = "Digite Un Grado De Dificultad Correcto";
                return false;
            }

            if (fltPuntaje1 < 0 && fltPuntaje1 > 10)
            {
                strError = "Digite Una Calificacion Correcta";
                return false;
            }

            if (fltPuntaje2 < 0 && fltPuntaje2 > 10)
            {
                strError = "Digite Una Calificacion Correcta";
                return false;
            }

            if (fltPuntaje3 < 0 && fltPuntaje3 > 10)
            {
                strError = "Digite Una Calificacion Correcta";
                return false;
            }
            return true;
        }
        #endregion

        #region "Metodos Publicos"
        public bool Resultado(bool x)
        {
            try
            {
                if (!Validar())
                    return false;
                if (x == true)
                {

                    fltCalificacion = ((fltPuntaje1 + fltPuntaje2 + fltPuntaje3) / 3 * fltGradoDificultad) * 1.2;
                }
                else
                {
                    fltCalificacion = (fltPuntaje1 + fltPuntaje2 + fltPuntaje3) / 3 * fltGradoDificultad;
                }
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
