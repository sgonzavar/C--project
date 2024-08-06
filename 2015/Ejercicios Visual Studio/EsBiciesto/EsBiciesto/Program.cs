using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsBiciesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            DateTime fecha = DateTime.Now;
            string aux;

            if (fecha.Year == ano) aux = "Es";
            else if (fecha.Year < ano) aux = "Será";
            else aux = "Fue";

            do
            {
                Console.Write("Ingrese Año y Presione Enter: ");
                ano = Convert.ToInt32(Console.ReadLine());
                if (EsBiciesto(ano))
                {
                    Console.WriteLine("El Año {0}, {1} Biciesto ", ano, aux);
                }
                else
                {
                    Console.WriteLine("El Año {0}, No {1} Biciesto ", ano, aux);

                }
                Console.WriteLine("\nPresione Enter Para Continuar Evaluando Otro Año O Ctrl + C Para Terminar\n");
                Console.ReadKey();
            } while (true);
        }

        private static bool EsBiciesto(int ano)
        {
            if (ano % 4 == 0)
            {
                if (ano % 100 == 0)
                {
                    if (ano % 400 == 0)
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                }
                else 
                {
                    return true;
                }
            }
            else 
            {
                return false;
            }
        }
    }
}
