using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Cálculos
    {
        private string _Cadena;
        private double _Resultado;
        private bool _Suma, _Division, _Resta, _Multiplicacion;

        public Cálculos()
        {
            _Cadena = "";
        }

        private void apagaBanderas()
        {
            _Suma = false;
            _Resta = false;
            _Multiplicacion = false;
            _Division = false;
        }

        public String concatenar(string cadena)
        {
            _Cadena  +=  cadena;
            return _Cadena;
        }

        public void Suma(String cadena)
        {
            _Resultado = Convert.ToDouble(cadena);
            _Suma = true;
            _Cadena = "";
        }

        public void Resta(String cadena)
        {
            _Resultado = Convert.ToDouble(cadena);
            _Resta = true;
            _Cadena = "";
        }

        public void Multiplicacion(string cadena)
        {
            _Resultado = Convert.ToDouble(cadena);
            _Multiplicacion = true;
            _Cadena = "";
        }

        public void Division(string cadena)
        {
            _Resultado = Convert.ToDouble(cadena);
            _Division = true;
            _Cadena = "";
        }

        public void Clear()
        {
            _Cadena = "";
        }



        public double Resultado(string numero)
        {
            if (_Suma)
            {
                _Resultado += Convert.ToDouble(numero);
                //_Cadena = "";
            }
            else 
            {
                if (_Resta)
                {
                    _Resultado -= Convert.ToDouble(numero);
                    //_Cadena = "";
                }
                else
                {
                    if (_Multiplicacion)
                    {
                        _Resultado *= Convert.ToDouble(numero);
                        //_Cadena = "";
                    }
                    else 
                    {
                        if(_Division)
                            _Resultado /= Convert.ToDouble(numero);
                            //_Cadena = "";
                    }
                }
            }
            apagaBanderas();
            return _Resultado;
        }
    }
}
