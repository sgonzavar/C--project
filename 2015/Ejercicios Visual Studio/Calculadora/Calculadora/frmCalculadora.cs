using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        Cálculos objCalculos = new Cálculos();

        public frmCalculadora()
        {
            InitializeComponent();
        }

        # region "Botones"

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("2");
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("3");
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("4");
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("5");
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("6");
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("7");
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("8");
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("9");
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar("000");
        }

        private void btnPunto_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = objCalculos.concatenar(",");
        }

        #endregion

        private void btnSuma_Click(object sender, EventArgs e)
        {
            objCalculos.Suma(txtDisplay.Text);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            objCalculos.Resta(txtDisplay.Text);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            objCalculos.Multiplicacion(txtDisplay.Text);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            objCalculos.Division(txtDisplay.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "" + objCalculos.Resultado(txtDisplay.Text);
        }

        private void btnClearn_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            objCalculos.Clear();
        }

       


    }
}
