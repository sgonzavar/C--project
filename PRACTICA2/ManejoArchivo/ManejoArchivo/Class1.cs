using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ManejoArchivo
{
    public class Archivo
    {
        static string dir;
        static string CodPremio;


        public List<string> listanom = new List<string>();
        public List<string> listaval = new List<string>();
        public List<string> listacod = new List<string>();
        public List<string> listacan = new List<string>();

        public string Getlnom()
        {
            return listanom[listanom.Count()];
        }



        public void Procesar(string nomarchivo)
        {
            StreamReader lector = new StreamReader(nomarchivo);
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
                int codigo = Convert.ToInt32(registro.Substring(0, pos)); ;
                listacod.Add(codigo.ToString());


                registro = registro.Substring(pos + 1);

                pos = registro.IndexOf(',');
                int cantidad = Convert.ToInt32(registro.Substring(0));
                listacan.Add(cantidad.ToString());



                registro = lector.ReadLine();
            }
            lector.Close();

        }

        public void Limpiar()
        {

            listanom.Clear();
            listaval.Clear();
            listacod.Clear();
            listacan.Clear();

        }
    }
}
