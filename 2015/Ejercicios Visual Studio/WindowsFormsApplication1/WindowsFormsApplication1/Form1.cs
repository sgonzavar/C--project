using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarCombo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (this.comboBox1.SelectedIndex == 1)
            {
                int suma = Convert.ToInt32(txtnumero1.Text) + Convert.ToInt32(txtnumero2.Text);
                txtTotal.Text = suma.ToString();
            }
            else
            {
                if (this.comboBox1.SelectedIndex == 2)
                {
                    int resta = Convert.ToInt32(txtnumero1.Text) - Convert.ToInt32(txtnumero2.Text);
                    txtTotal.Text = resta.ToString();
                }
                else
                {
                    if (this.comboBox1.SelectedIndex == 3)
                    {
                        int multiplicacion = Convert.ToInt32(txtnumero1.Text) * Convert.ToInt32(txtnumero2.Text);
                        txtTotal.Text = multiplicacion.ToString();
                    }
                    else
                    {
                        if (this.comboBox1.SelectedIndex == 4)
                        {
                            if (Convert.ToInt32(txtnumero2.Text) == 0)
                            {
                                txtTotal.Text = "Infinito";
                            }
                            else 
                            {
                                int division = Convert.ToInt32(txtnumero1.Text) / Convert.ToInt32(txtnumero2.Text);
                                txtTotal.Text = division.ToString();
                            }                         
                        }
                    }
                }

            }
        }

        private void LlenarCombo()
        {
            for (int intI = 0; intI <= 4; intI++)
            {
                this.comboBox1.Items.Add(intI);
                this.comboBox1.SelectedIndex = 0;
            }
        }
    }  
}
