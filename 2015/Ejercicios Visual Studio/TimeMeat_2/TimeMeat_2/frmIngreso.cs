using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeMeat_2
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        int  MinutosTotales, horaF, horaI;

        private void frmIngreso_Load(object sender, EventArgs e)
        {
            LlenarComboInicial();
            LlenarComboFinal();
        }

        private string Fecha()
        {
            DateTime dtmFecha;
            dtmFecha = Convert.ToDateTime(DtpFecha.Text);
            return dtmFecha.ToShortDateString();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string aux;
            Auxiliar();
            aux = MinutosTotales.ToString();
            this.lblMostrar.Text = (" Fecha: " + Fecha() + "  Minutos: " + aux + " C. Operarios: " + operarios() +  ".\n");  
        }


        private void Mensaje(string Texto)
        {
            MessageBox.Show(Texto, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HallarHoraInicial(int HoraI)
        {
            int Hora;
            Hora = 0;
            switch (HoraI)
            {
                case 1: // 
                    Hora = 1;
                    break;

                case 2: // 
                    Hora = 2;
                    break;

                case 3: //  
                    Hora = 3;
                    break;

                case 4: 
                    Hora = 4;
                    break;

                case 5: //   
                    Hora = 5;
                    break;

                case 6: // 
                    Hora = 6;
                    break;

                case 7: // 
                    Hora = 7;
                    break;

                case 8: // 
                    Hora = 8;
                    break;

                case 9: //  
                    Hora = 9;
                    break;

                case 10:
                    Hora = 10;
                    break;

                case 11: //   
                    Hora = 11;
                    break;

                case 12: // 
                    Hora = 12;
                    break;

                case 13: // 
                    Hora = 13;
                    break;

                case 14: // 
                    Hora = 14;
                    break;

                case 15: //  
                    Hora = 15;
                    break;

                case 16:
                    Hora = 16;
                    break;

                case 17: //   
                    Hora = 17;
                    break;

                case 18: // 
                    Hora = 18;
                    break;

                case 19: // 
                    Hora = 19;
                    break;

                case 20: // 
                    Hora = 20;
                    break;

                case 21: //  
                    Hora = 21;
                    break;

                case 22:
                    Hora = 22;
                    break;

                case 23: //   
                    Hora = 23;
                    break;

                case 24: // 
                    Hora = 24;
                    break;

                default:
                    break;
            }
             horaI = Hora;
            
        }

        private void HallarHoraFinal(int HoraF)
        {
            int Hora;
            Hora = 0;
            switch (HoraF)
            {
                case 1: // 
                    Hora = 1;
                    break;

                case 2: // 
                    Hora = 2;
                    break;

                case 3: //  
                    Hora = 3;
                    break;

                case 4:
                    Hora = 4;
                    break;

                case 5: //   
                    Hora = 5;
                    break;

                case 6: // 
                    Hora = 6;
                    break;

                case 7: // 
                    Hora = 7;
                    break;

                case 8: // 
                    Hora = 8;
                    break;

                case 9: //  
                    Hora = 9;
                    break;

                case 10:
                    Hora = 10;
                    break;

                case 11: //   
                    Hora = 11;
                    break;

                case 12: // 
                    Hora = 12;
                    break;

                case 13: // 
                    Hora = 13;
                    break;

                case 14: // 
                    Hora = 14;
                    break;

                case 15: //  
                    Hora = 15;
                    break;

                case 16:
                    Hora = 16;
                    break;

                case 17: //   
                    Hora = 17;
                    break;

                case 18: // 
                    Hora = 18;
                    break;

                case 19: // 
                    Hora = 19;
                    break;

                case 20: // 
                    Hora = 20;
                    break;

                case 21: //  
                    Hora = 21;
                    break;

                case 22:
                    Hora = 22;
                    break;

                case 23: //   
                    Hora = 23;
                    break;

                case 24: // 
                    Hora = 24;
                    break;

                default:
                    break;
            }
            horaF = Hora;

        }

        private void Auxiliar()
        {
            minutos(horaI, horaF);
        }

        private void LlenarComboInicial()
        {

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

        private void cmbHoraI_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intHora;
            intHora = this.cmbHoraI.SelectedIndex;
            if (intHora <= 0)
            {
                Mensaje("Seleccione Una Hora");              
                this.cmbHoraI.Focus();
                return;
            }
            HallarHoraInicial(intHora);      
        }

        private int minutos(int HoraInicial, int HoraFinal)
        {
            int  Hora;
            Hora = HoraFinal -HoraInicial;
            MinutosTotales = Hora * 60 + Convert.ToInt32(txtmintFinal.Text) - Convert.ToInt32(txtMinutInicial.Text);        
            return MinutosTotales;
        }

        private void cmbHoraF_SelectedIndexChanged(object sender, EventArgs e)
        {

            int intHora;
            intHora = this.cmbHoraF.SelectedIndex;
            if (intHora <= 0)
            {
                Mensaje("Seleccione Una Hora");
                this.cmbHoraF.Focus();
                return;
            }
            HallarHoraFinal(intHora); 

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio ini = new frmInicio();
            ini.Show();
        }

        private string operarios()
        {
            return Convert.ToString(txtOperarios.Text);
        }


       
    }
}
