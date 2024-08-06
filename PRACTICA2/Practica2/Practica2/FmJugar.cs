using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using BaseDeDatos;
using ManejoArchivo;

namespace Practica2
{
    public partial class FmJugar : Form
    {
        List<string> listanom = new List<string>();
        List<string> listaval = new List<string>();
        List<string> listacod = new List<string>();
        List<string> listacan = new List<string>(); 
        int num = 0, ccarro = 0, cmoto = 0,ctele = 0, cmillo = 0, c500 = 0;
        int can , tot;
        bool HayPremios;
        Archivo ar = new Archivo();
        FmLogin l = new FmLogin();
        FmMaestro ma = new FmMaestro();
        string Nombre, Premio, Dir;

        string nomBD = "ALMACEN2016";
        Datos objcon = new Datos();
        SqlConnection a;
        SqlDataReader tabla;

        public FmJugar()
        {
            InitializeComponent();
        }
         private void BtnProcesar_Click(object sender, EventArgs e)
        {

        }

        private void FmJugar_Load(object sender, EventArgs e)
        {
            Nombre = l.GetNom();
          
            MessageBox.Show("Hola "+Nombre);
            ar.Procesar(ma.GetDir());
            int r = 0;
            while (r < ar.listanom.Count())
            {
               
                if (ar.listanom[r].ToString() == "CARRO")
                {
                    ccarro = Convert.ToInt32(ar.listacan[r]);
                }
                else if (ar.listanom[r].ToString() == "MOTO")
                {
                    cmoto = Convert.ToInt32(ar.listacan[r].ToString());
                }
                else if (ar.listanom[r].ToString() == "TELEVISOR")
                {
                    ctele = Convert.ToInt32(ar.listacan[r].ToString());
                }
                else if (ar.listanom[r].ToString() == "MILLON")
                {
                    cmillo = Convert.ToInt32(ar.listacan[r].ToString());
                }
                else if (ar.listanom[r].ToString() == "QUINIENTOS")
                {
                    c500 = Convert.ToInt32(ar.listacan[r].ToString());
                }
                r++;
            }
           
            
           
    

            LB500.Text = c500.ToString();
            LBcar.Text = ccarro.ToString();
            LBmillo.Text = cmillo.ToString();
            LBmoto.Text = cmoto.ToString();
            LBtele.Text = ctele.ToString();


         

            if (ccarro == 0)
            {
                LBcar.ForeColor = System.Drawing.Color.Gray;
                LBcarr.ForeColor = System.Drawing.Color.Gray;
                LBcarrr.ForeColor = System.Drawing.Color.Gray;

                LBcar.Font = new System.Drawing.Font(LBcar.Font, FontStyle.Strikeout);
                LBcarr.Font = new System.Drawing.Font(LBcarr.Font, FontStyle.Strikeout);
                LBcarrr.Font = new System.Drawing.Font(LBcarrr.Font, FontStyle.Strikeout); 
            }
            

            if (cmoto == 0)
            {
                LBmoto.ForeColor = System.Drawing.Color.Gray;
                LBmotoo.ForeColor = System.Drawing.Color.Gray;
                LBmotooo.ForeColor = System.Drawing.Color.Gray;

                LBmoto.Font = new System.Drawing.Font(LBmoto.Font, FontStyle.Strikeout);
                LBmotoo.Font = new System.Drawing.Font(LBmotoo.Font, FontStyle.Strikeout);
                LBmotooo.Font = new System.Drawing.Font(LBmotooo.Font, FontStyle.Strikeout); 



            }
            
            if (ctele == 0)
            {
                LBtele.ForeColor = System.Drawing.Color.Gray;
                LBtelee.ForeColor = System.Drawing.Color.Gray;
                LBteleee.ForeColor = System.Drawing.Color.Gray;

                LBtele.Font = new System.Drawing.Font(LBtele.Font, FontStyle.Strikeout);
                LBtelee.Font = new System.Drawing.Font(LBtelee.Font, FontStyle.Strikeout);
                LBteleee.Font = new System.Drawing.Font(LBteleee.Font, FontStyle.Strikeout);

            }
            

            if (cmillo == 0)
            {
                LBmillo.ForeColor = System.Drawing.Color.Gray;
                LBmilloo.ForeColor = System.Drawing.Color.Gray;
                LBmillooo.ForeColor = System.Drawing.Color.Gray;

                LBmillo.Font = new System.Drawing.Font(LBmillo.Font, FontStyle.Strikeout);
                LBmilloo.Font = new System.Drawing.Font(LBmilloo.Font, FontStyle.Strikeout);
                LBmillooo.Font = new System.Drawing.Font(LBmillooo.Font, FontStyle.Strikeout);


            }
           

            if (c500 == 0)
            {
                LB500.ForeColor = System.Drawing.Color.Gray;
                LB5000.ForeColor = System.Drawing.Color.Gray;
                LB50000.ForeColor = System.Drawing.Color.Gray;

                LB500.Font = new System.Drawing.Font(LB500.Font, FontStyle.Strikeout);
                LB5000.Font = new System.Drawing.Font(LB5000.Font, FontStyle.Strikeout);
                LB50000.Font = new System.Drawing.Font(LB50000.Font, FontStyle.Strikeout);


              

            }
            
        }
        public void GanaCarro()
        {
            FmGanaCarro gc = new FmGanaCarro();
            gc.Show();
          
        }
        public void Actualizar()
        {
            a = objcon.conectar(nomBD);
            string con = "UPDATE CLIENTE SET ESTADO= 'SI' WHERE NOMBRE = '" + Nombre + "'";


            int n = objcon.operarar(con, a);


            /*if (n > 0)
            {
                MessageBox.Show("Se han Actualizado " + n + " Registros");

            }
            else
            {
                MessageBox.Show("Se han Actualizado " + n + " Registros");
            }*/
            objcon.cerrar(a);


        }
        public void ValorSorteo(float valor)
        {
            a = objcon.conectar(nomBD);
            string conSQL1 = "UPDATE PREESTADISTICAS SET VALOR_SORTEO= VALOR_SORTEO +"+ valor +  "WHERE # = 1";
            string con2 = "INSERT INTO GANADORES VALUES (" + valor + ")";

            int n1 = objcon.operarar(conSQL1, a);
            int n2 = objcon.operarar(con2, a);

           /* if (n1 > 0)
            {
                MessageBox.Show("Se han Actualizado " + n1 + " Registros");

            }
            else
            {
                MessageBox.Show("Se han Actualizado " + n1 + " Registros");
            }
            if (n2 > 0)
            {
                MessageBox.Show("Se han Actualizado " + n1 + " Registros");

            }
            else
            {
                MessageBox.Show("Se han Actualizado " + n1 + " Registros");
            }*/

        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {

           Random obj = new Random();
           num = obj.Next(1, 11);

           MessageBox.Show("El numero Sacado es: " + num.ToString());
           if(num == 6)
           {
               Premio = "CARRO";             
               BuscarRemlazar();
               if (HayPremios)
               {
                   ValorSorteo(20000000);
                   FmGanaCarro c = new FmGanaCarro();
                   c.Show();
               }
           }
          else if (num == 7)
          {
              Premio = "MOTO";
              BuscarRemlazar();
              if (HayPremios)
              {
                  ValorSorteo(2500000);
                  FmGanaMoto m = new FmGanaMoto();
                  m.Show();
              }
          }
          else if (num == 8)
          {
              Premio = "TELEVISOR";
              BuscarRemlazar();
              if (HayPremios)
              {
                  ValorSorteo(1200000);
                  FmGanaTele t = new FmGanaTele();
                  t.Show();
              }
          }
          else if (num == 9)
          {
              Premio = "MILLON";
              BuscarRemlazar();
              if (HayPremios)
              {
                  ValorSorteo(1000000);
                  FmGanaMillo mi = new FmGanaMillo();
                  mi.Show();
              }
          }
          else if (num == 10)
          {
              Premio = "QUINIENTOS";
              BuscarRemlazar();
              if (HayPremios)
              {
                  ValorSorteo(500000);
                  FmGana500 q = new FmGana500();
                  q.Show();
              }
          }
           else
           {
               MessageBox.Show("Lo sentimos no has ganado nada", "No has ganado");
           }

           Actualizar();



           a = objcon.conectar(nomBD);
           string conSQL = "UPDATE PREESTADISTICAS SET CANTIDAD_JUEGOS_REALIZADOS= CANTIDAD_JUEGOS_REALIZADOS + 1 WHERE # = 1";


           int n = objcon.operarar(conSQL, a);


          /* if (n > 0)
           {
               MessageBox.Show("Se han Actualizado " + n + " Registros");

           }
           else
           {
               MessageBox.Show("Se han Actualizado " + n + " Registros");
           }*/
           objcon.cerrar(a);
           this.Close();
          
        }

         public void BuscarRemlazar()
        {
           
            StreamWriter escribir;
            escribir = File.CreateText("temp.txt");

            StreamReader lector = new StreamReader(ma.GetDir());
            string registro = lector.ReadLine();



            while (registro != null)
            {
                int pos = registro.IndexOf(',');
                string nombre = registro.Substring(0, pos);
                listanom.Add(nombre);

                registro = registro.Substring(pos + 1);

                pos = registro.IndexOf(',');
                double valor = Convert.ToDouble(registro.Substring(0, pos));
                listaval.Add(valor.ToString());

                registro = registro.Substring(pos + 1);

                pos = registro.IndexOf(',');
                int codigo = Convert.ToInt32(registro.Substring(0, pos));
                listacod.Add(codigo.ToString());

                registro = registro.Substring(pos + 1);

                pos = registro.IndexOf(',');
                int cantidad = Convert.ToInt32(registro.Substring(0));
                listacan.Add(cantidad.ToString());



                registro = lector.ReadLine();
            }
            lector.Close();

            for (int i = 0; i < listanom.Count; i++)
            {
                if (listanom[i] == Premio)
                {
                    
                    can = Convert.ToInt32(listacan[i]);
                    if (can > 0)
                    {
                        HayPremios = true;
                    }
                    else
                    {
                        HayPremios = false;
                    }
                    tot = can - 1;
                    escribir.WriteLine(listanom[i].ToString() + "," + listaval[i].ToString() + "," + listacod[i].ToString() + "," + tot.ToString());


                }
                else
                {
                    escribir.WriteLine(listanom[i].ToString() + "," + listaval[i].ToString() + "," + listacod[i].ToString() + "," + listacan[i].ToString());


                }

            }
            escribir.Close();

            if (HayPremios)
            {
                MessageBox.Show("¡Enhorabuea! has ganado el premio de " + Premio + "!", "¡Ganaste un premio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Delete(ma.GetDir());
                File.Move("temp.txt", ma.GetDir());

                a = objcon.conectar(nomBD);
                string conSQL = "UPDATE PREESTADISTICAS SET CANTIDAS_PREMIOS_ENTREGADOS= CANTIDAS_PREMIOS_ENTREGADOS + 1 WHERE # = 1";


                int n = objcon.operarar(conSQL, a);


                /*if (n > 0)
                {
                    MessageBox.Show("Se han Actualizado " + n + " Registros");

                }
                else
                {
                    MessageBox.Show("Se han Actualizado " + n + " Registros");
                }*/
                objcon.cerrar(a);

            }
            else
            {
                MessageBox.Show("Lo sentimos, el premio que gano ya esta agotado");
                File.Delete("temp.txt");

            }
            
            listacan.Clear();
            listacod.Clear();
            listanom.Clear();
            listaval.Clear();

        }
         private void BtnCargar_Click(object sender, EventArgs e)
         {

         }
        /* public void BuscarRemlazar()
         {

             StreamWriter escribir;
             escribir = File.CreateText("temp.txt");

             StreamReader lector = new StreamReader(ma.GetDir());
             string registro = lector.ReadLine();


             ar.Procesar(ma.GetDir());

             for (int i = 0; i < ar.listanom.Count; i++)
             {
                 if (ar.listanom[i] == Premio)
                 {

                     can = Convert.ToInt32(ar.listacan[i]);
                     if (can > 0)
                     {
                         HayPremios = true;
                     }
                     else
                     {
                         HayPremios = false;
                     }
                     tot = can - 1;
                     escribir.WriteLine(ar.listanom[i].ToString() + "," + ar.listaval[i].ToString() + "," + ar.listacod[i].ToString() + "," + tot.ToString());


                 }
                 else
                 {
                     escribir.WriteLine(ar.listanom[i].ToString() + "," + ar.listaval[i].ToString() + "," + ar.listacod[i].ToString() + "," + ar.listacan[i].ToString());


                 }

             }
             escribir.Close();

             if (HayPremios)
             {
                 File.Delete(ma.GetDir());
                 File.Move("temp.txt", ma.GetDir());

             }
             else
             {
                 MessageBox.Show("Lo sentimos, el premio q gano ya esta agotado");
                 File.Delete("temp.txt");

             }

             ar.listacan.Clear();
             ar.listacod.Clear();
             ar.listanom.Clear();
             ar.listaval.Clear();

         }
        */
        
         }
}

    

