using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuktio_Harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lisää tähän tiedostoon uusi metodi, joka ottaa vastaan parametrinä taulukon
            // int lukuja ja palauttaa taulukon keskiarvon
            {

                int[] someValues = new int[4];
                someValues[0] = 5;
                someValues[0] = 8;
                someValues[0] = 6;
                someValues[0] = 100;

                Console.WriteLine(average(someValues));


                //Pysäytetään sovellus lopussa.
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            
            
            
            
            
            
            }


            
            
            
            
            
            private static double average(int[] numbers)
            
            
            // Algoritmi, joka laskee keskiarvon
            int count = 0;
            double sum = 0;

            foreach (double temp in numbers)
            {
                sum += temp;
                count++;

            }        
                












        }
    }
}
