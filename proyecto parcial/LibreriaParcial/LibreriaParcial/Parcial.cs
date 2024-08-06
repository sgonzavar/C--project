using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParcial
{
    public class Parcial
    {
         #region "Atributos"

        private double Nuno, Multiplicacion;
        private double Ndos, Suma, Resta, Division;
        private  string Error;

        #endregion

        #region "Constructor"
        public Parcial()
        {
            Nuno = 0;
            Ndos = 0;
            Multiplicacion = 0;
            Suma = 0;
            Resta = 0;
            Division = 0;
 
            Error = string.Empty;
        }
        #endregion 

        #region "Propiedades"
        public double NumeroUno
        { set { Nuno = value; } }

        public double NumeroDos
        { set { Ndos = value; } }

        public string MensajeError
        { get { return Error; } }

        public double Multi
        { get { return Multiplicacion; } }

        public double Sum
        { get { return Suma; } }

        public double Rest
        { get { return Resta; } }

        public double div
        { get { return Division; } }
        
        #endregion 

        #region "Metodos Publicos"

        public bool Operacion()
        {
            try
            {
                Multiplicacion = Nuno * Ndos;
                Suma = Nuno + Ndos;
                Resta = Nuno - Ndos;
                if (Nuno == 0)
                {
                    Division = 0;
                }
                else {
                    if (Ndos == 0)
                    {
                        Error = " ∞ ";
                    }
                    else 
                    {
                        Division = Nuno / Ndos;
                    }              
                }
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }   
        }

        #endregion




    }
}


