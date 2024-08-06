using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//REferencia y usar.
using libFiguraGeometrica;


namespace LibFiguras
{
    public class clsCirculo : clsFiguraGeometrica // derivando de la clase abstracta
    {
        #region "Atributos"
             private double dblRadio;
        #endregion

        #region "Constructores"
             public clsCirculo()
             {
                 dblRadio = 0;
                 dblPerimetro = 0;
                 dblArea = 0;
                 strError = string.Empty;
             }  //sin sobrecarga

             public clsCirculo(double Radio, double Perimetro, double Area, string Error)
             {
                 dblRadio = Radio;
                 dblPerimetro = Perimetro;
                 dblArea = Area;
                 strError = Error;
             }

        #endregion

        #region "Propiedades"
             public double Radio
             {
                 set { dblRadio = value;} 
             }
        #endregion

        #region "Metodos Privados"
             private bool Validar()
             {
                 if (dblRadio <= 0)
                 {
                     strError = "Valor Del Radio No Valido";
                     return false;
                 }
                 return true;
             }
             
        #endregion

        #region "Metodos Publicos"

             public override bool HallarArea()
             {
                 try
                 {
                     if (!Validar())
                         return false;

                     dblArea = Math.PI * Math.Pow(dblRadio, 2.0);
                     return true;
                 }
                 catch (Exception ex)
                 {
                     strError = ex.Message;
                     return false;
                 }
             }

             public override bool HallarPerimetro()
             {
                 try
                 {
                     if (!Validar())
                         return false;

                     dblPerimetro = 2.0 * Math.PI * dblRadio;
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

    public class clsTriangulo : clsFiguraGeometrica // derivando de la clase abstracta
    {
        #region "Atributos"

        private double dblLadoA;
        private double dblLadoB;
        private double dblLadoC;

        #endregion

        #region "Constructores"
        
        public clsTriangulo()
        {
            dblLadoA = 0;
            dblLadoB = 0;
            dblLadoC = 0;
            dblPerimetro = 0;
            dblArea = 0;
            strError = string.Empty;
        }  //sin sobrecarga

        public clsTriangulo(double Lado1, double Lado2, double Lado3)
        {         
            dblLadoA = Lado1;
            dblLadoB = Lado2;
            dblLadoC = Lado3;
            dblPerimetro = 0;
            dblArea = 0;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"
        public double Lado1
        {
            set { dblLadoA = value; }
        }

        public double Lado2
        {
            set { dblLadoB = value; }
        }
        
        public double Lado3
        {
            set { dblLadoC = value; }
        }
        #endregion

        #region "Metodos Privados"
        private bool Validar()
        {
            if (dblLadoA <= 0)
            {
                strError = "Valor Del Lado A No Valido";
                return false;
            }

            if (dblLadoB <= 0)
            {
                strError = "Valor Del Lado B No Valido";
                return false;
            }

            if (dblLadoC <= 0)
            {
                strError = "Valor Del Lado C No Valido";
                return false;
            }

            if( (dblLadoA + dblLadoB <= dblLadoC) ||
                (dblLadoA + dblLadoC <= dblLadoB) ||
                (dblLadoB + dblLadoC <= dblLadoA) )
            {
                strError = "No Se Puede Constuir El Triangulo Con Dichos VAlores";
                return false;
            }
            return true;
        }
        #endregion

        #region "Metodos Publicos"

        public override bool HallarArea()
        {
            double dblsp;
            try
            {
                if (!Validar())
                    return false;

                dblsp = (dblLadoA + dblLadoB + dblLadoC ) / 2.0;
                dblArea = Math.Sqrt( dblsp * (dblsp - dblLadoA) *
                                             (dblsp - dblLadoB) *
                                             (dblsp - dblLadoC));
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        public override bool HallarPerimetro()
        {
            try
            {
                if (!Validar())
                    return false;

                dblPerimetro = dblLadoA + dblLadoB + dblLadoC;
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

    public class clsCuadrado : clsFiguraGeometrica // derivando de la clase abstracta
    {
        #region "Atributos"
        private double dblLado;     
        #endregion

        #region "Constructores"

        public clsCuadrado()
        {
            dblLado = 0;       
            dblPerimetro = 0;
            dblArea = 0;
            strError = string.Empty;
        }  //sin sobrecarga

        public clsCuadrado(double Lado)
        {
            dblLado = Lado;          
            dblPerimetro = 0;
            dblArea = 0;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"
        public double Lado
        {
            set { dblLado = value; }
        }  
        #endregion

        #region "Metodos Privados"
        private bool Validar()
        {
            if (dblLado <= 0)
            {
                strError = "Valor Del Lado  No Valido";
                return false;
            }
            return true;
        }
        #endregion

        #region "Metodos Publicos"

        public override bool HallarArea()
        {
            try
            {
                if (!Validar())
                    return false;
             
                dblArea = Math.Pow(dblLado, 2.0);
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        public override bool HallarPerimetro()
        {
            try
            {
                if (!Validar())
                    return false;

                dblPerimetro = 4.0 * dblLado;
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
