using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string aux;
            
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            do
            {
                a = PidaNumero("Ingrese Primer Numero.....:");
                b = PidaNumero("Ingrese Primer Numero.....:");


                c = a + b;
                Console.WriteLine("{0:N0} + {1:N0} = {2:N0}", a, b, c);
                Console.Write("\n\nDesea Continuar <s>i, <n>o....: ");
                aux = Console.ReadLine();
                Console.WriteLine("\n");
            } while (aux == "s" || aux == "S");
            Console.Write("Presione Enter Para Terminar");
            Console.ReadKey();


        }// main 

        static int PidaNumero(String mensaje)
        {
            string aux;
            int numero;
            bool error;
            do
            {
                numero = 0;
                Console.Write(mensaje);
                aux = Console.ReadLine();
                try
                {
                    numero = Convert.ToInt32(aux);
                    error = false;
                }
                catch (Exception)
                {
                    Console.Beep();
                    error = true;
                }
                if (error)
                {
                    Console.WriteLine("Debe Ingresar Caracteres Numerico");
                }

            } while (error);
            return numero;

        }//pidanumero

    }// clase
}// namespace