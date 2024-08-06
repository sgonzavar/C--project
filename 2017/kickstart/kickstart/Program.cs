using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kickstart
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("GBus.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
                Console.WriteLine("The file could  be read:");
                Console.ReadKey();


            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        }

        private void cityBus()
        {
           while 
        }

        

    }

}
