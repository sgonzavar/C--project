using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeMeat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.lblMostrar.Text = (" Fecha: " + Fecha() + "  Minutos: " + cadena() + "\n" );  

        }

        private string Fecha()
        {
            DateTime dtmFecha;
            dtmFecha = Convert.ToDateTime(dtm.Text);
            return dtmFecha.ToShortDateString();
        }

        private string cadena()
        {          
            return minutos();
        }

        private string minutos()
        {
            //int Minutos, Hora;
            //Hora = Convert.ToInt32(txtHoraFinal.Text) - Convert.ToInt32(txtHoraInicial.Text);
            //Minutos = Hora * 60 + Convert.ToInt32(txtmintFinal.Text) - Convert.ToInt32(txtMinutInicial.Text);
            //Operarios(Minutos);
            //return Minutos.ToString();
        }

        private void Operarios(int Minutos)
        {
            double cantidad;
            //Convert.to
                
        }

        private void LlenarComboInicial()
        {
     
                this.cmbHoraI.Items.Add(" Seleccione Hora "); 
                this.cmbHoraI.Items.Add(" 00:00 "); //Index
                this.cmbHoraI.Items.Add(" 01:00 "); //Index 
                this.cmbHoraI.Items.Add(" 02:00 "); //Index 
                this.cmbHoraI.Items.Add(" 03:00 "); //Index 
                this.cmbHoraI.Items.Add(" 04:00 "); //Index 
                this.cmbHoraI.Items.Add(" 05:00 "); //Index 
                this.cmbHoraI.Items.Add(" 06:00 "); //Index 
                this.cmbHoraI.Items.Add(" 07:00 "); //Index 
                this.cmbHoraI.Items.Add(" 08:00 "); //Index 
                this.cmbHoraI.Items.Add(" 09:00 "); //Index
                this.cmbHoraI.Items.Add(" 10:00 "); //Index 
                this.cmbHoraI.Items.Add(" 11:00 "); //Index
                this.cmbHoraI.Items.Add(" 12:00 "); //Index 
                this.cmbHoraI.Items.Add(" 13:00 "); //Index 
                this.cmbHoraI.Items.Add(" 14:00 "); //Index 
                this.cmbHoraI.Items.Add(" 15:00 "); //Index 
                this.cmbHoraI.Items.Add(" 16:00 "); //Index 
                this.cmbHoraI.Items.Add(" 17:00 "); //Index 
                this.cmbHoraI.Items.Add(" 18:00 "); //Index 
                this.cmbHoraI.Items.Add(" 19:00 "); //Index 
                this.cmbHoraI.Items.Add(" 20:00 "); //Index
                this.cmbHoraI.Items.Add(" 21:00 "); //Index 
                this.cmbHoraI.Items.Add(" 22:00 "); //Index
                this.cmbHoraI.Items.Add(" 23:00 "); //Index 
                this.cmbHoraI.Items.Add(" 24:00 "); //Index
               
           
           
        }


        private void LlenarComboFinal()
        {

            this.cmbHoraF.Items.Add(" Seleccione Hora ");
            this.cmbHoraF.Items.Add(" 00:00 "); //Index
            this.cmbHoraF.Items.Add(" 01:00 "); //Index 
            this.cmbHoraF.Items.Add(" 02:00 "); //Index 
            this.cmbHoraF.Items.Add(" 03:00 "); //Index 
            this.cmbHoraF.Items.Add(" 04:00 "); //Index 
            this.cmbHoraF.Items.Add(" 05:00 "); //Index 
            this.cmbHoraF.Items.Add(" 06:00 "); //Index 
            this.cmbHoraF.Items.Add(" 07:00 "); //Index 
            this.cmbHoraF.Items.Add(" 08:00 "); //Index 
            this.cmbHoraF.Items.Add(" 09:00 "); //Index
            this.cmbHoraF.Items.Add(" 10:00 "); //Index 
            this.cmbHoraF.Items.Add(" 11:00 "); //Index
            this.cmbHoraF.Items.Add(" 12:00 "); //Index 
            this.cmbHoraF.Items.Add(" 13:00 "); //Index 
            this.cmbHoraF.Items.Add(" 14:00 "); //Index 
            this.cmbHoraF.Items.Add(" 15:00 "); //Index 
            this.cmbHoraF.Items.Add(" 16:00 "); //Index 
            this.cmbHoraF.Items.Add(" 17:00 "); //Index 
            this.cmbHoraF.Items.Add(" 18:00 "); //Index 
            this.cmbHoraF.Items.Add(" 19:00 "); //Index 
            this.cmbHoraF.Items.Add(" 20:00 "); //Index
            this.cmbHoraF.Items.Add(" 21:00 "); //Index 
            this.cmbHoraF.Items.Add(" 22:00 "); //Index
            this.cmbHoraF.Items.Add(" 23:00 "); //Index 
            this.cmbHoraF.Items.Add(" 24:00 "); //Index



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarComboInicial();
            LlenarComboFinal();
        }

        

        
    }
}
