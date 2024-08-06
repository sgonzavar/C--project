namespace libDSI54.ClasesSimples
{
    public class clsPuntajeClavados
    {
        #region Constructor
        public clsPuntajeClavados()
        {
            dFactorCicloOlimpico = 0.2;
        }
        #endregion

        #region Atributos
        private double dPuntaje1;
        private double dPuntaje2;
        private double dPuntaje3;
        private double dGradoDificultad;
        private double dFactorCicloOlimpico;
        private bool bCicloOlimpico;
        private double dPromedioJueces;
        private double dPuntajeTotal;
        public string sError;
        #endregion

        #region Propiedades
        public double puntaje1
        {
            get { return dPuntaje1; }
            set { dPuntaje1 = value; }
        }
        public double puntaje2
        {
            get { return dPuntaje2; }
            set { dPuntaje2 = value; }
        }
        public double puntaje3
        {
            get { return dPuntaje3; }
            set { dPuntaje3 = value; }
        }
        public double gradoDificultad
        {
            get { return dGradoDificultad; }
            set { dGradoDificultad = value; }
        }
        public bool cicloOlimpico
        {
            get { return bCicloOlimpico; }
            set { bCicloOlimpico = value; }
        }
        public double puntajeTotal
        {
            get { return dPuntajeTotal; }
        }
        public string error
        {
            get { return sError; }
        }
        #endregion

        #region Metodos
        public double calcularPuntaje()
        {
            dPromedioJueces = (dPuntaje1 + dPuntaje2 + dPuntaje3) / 3;
            dPuntajeTotal = dPromedioJueces * dGradoDificultad;
            if (bCicloOlimpico)
            {
                dPuntajeTotal = dPuntajeTotal * (1 + dFactorCicloOlimpico);
            }
            return dPuntajeTotal;
        }
        #endregion
    }
}
