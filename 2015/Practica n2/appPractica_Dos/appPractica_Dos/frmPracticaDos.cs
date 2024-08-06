using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//REferenciar y usar
using libOPE;



namespace appPractica_Dos
{
    public partial class frmPracticaDos : Form
    {
        public frmPracticaDos()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        double dblVrUnit, dblCant, DblVrDscto, dblVrPagar;
        int intCod;
        DateTime dtmFecha;
        #endregion

        #region "Metodos Globales"
       
        private void Mensaje(string Texto)
        {
            MessageBox.Show(Texto, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpiar()
        {
            this.dtpFecha.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.cboProductos.SelectedIndex = 0;
            this.txtVr.Text = "0";
            this.txtCant.Text = string.Empty;
            this.lblVrDscto.Text = string.Empty;
            this.lblVrPagar.Text = string.Empty;
            this.cboProductos.Focus();
        }

        private void LlenarCombo()
        {
            try
            {
                this.cboProductos.Items.Add(" Seleccione Un Producto "); //Index = 0
                this.cboProductos.Items.Add(" Aguacate "); //Index = 1
                this.cboProductos.Items.Add(" Zanahoria "); //Index = 2
                this.cboProductos.Items.Add(" Papa Nevada "); //Index = 3
                this.cboProductos.Items.Add(" Cebolla Huevo "); //Index = 4
                this.cboProductos.Items.Add(" Tomate Aliño "); //Index = 5
                this.cboProductos.Items.Add(" Pera "); //Index = 6
                this.cboProductos.SelectedIndex = 0;
                intCod = 0;
            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }
        
            private void HallarVrUnit(int Codigo)
            {
                dblVrUnit = 0;
                switch ( Codigo )
                {
                    case 1: // Aguacate
                        dblVrUnit = 4200;
                        break;

                    case 2: // zanahoria
                        dblVrUnit = 2250;
                        break;

                    case 3: // papa nevada
                        dblVrUnit = 1800;
                        break;
                    
                    case 4: // Cebolla De huevo
                        dblVrUnit = 1300;
                        break;
                    
                    case 5: // Toamte De aliño
                        dblVrUnit = 2100;
                        break;

                case 6: // Pera
                        dblVrUnit = 3500;
                        break;

                    default :
                        break;          
                }
                this.txtVr.Text = ("" + dblVrUnit);
            }

          #endregion            

            private void frmPracticaDos_Load(object sender, EventArgs e)
            {
                this.dtpFecha.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                LlenarCombo();
            }

            private void btnTerminar_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                Limpiar();
            }


            private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
            {
                intCod = this.cboProductos.SelectedIndex;
                if (intCod <= 0)
                {
                    Mensaje("Seleccione Un Producto");
                    this.txtVr.Text = "0";
                    this.cboProductos.Focus();
                    return;
                }
                HallarVrUnit(intCod);
                this.txtCant.Focus();
               
                           
            }




            private void btnRegistrar_Click(object sender, EventArgs e)
            {
                try
                {
                    dtmFecha = this.dtpFecha.Value;
                    if (dtmFecha < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        Mensaje("Fecha No Valida, Anterior A La Actual");
                        this.dtpFecha.Focus();
                        return;
                    }
                    dblCant = Convert.ToDouble(this.txtCant.Text);

                    clsOPEDscProd objXX = new clsOPEDscProd();
                    objXX.Codigo = intCod;
                    objXX.Vr_Unitario = dblVrUnit;
                    objXX.Cantidad = dblCant;
                    if (!objXX.Procesar())
                    {
                        Mensaje(objXX.Error);
                        objXX = null;
                        return;
                    }
                    DblVrDscto = objXX.VrDscto;
                    dblVrPagar = objXX.VrAPagar;
                    objXX = null;
                    this.lblVrDscto.Text = string.Format("{0:#,##0.##}", DblVrDscto);
                    this.lblVrPagar.Text = string.Format("{0:$#,##0.00;($#,##0.00);Zero}", dblVrPagar);
                }
                catch (Exception ex) 
                {
                    Mensaje(ex.Message);
                }
            }

        }

    }











  

