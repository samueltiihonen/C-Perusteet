using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_C_String_Lämpötilan_seuranta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä päivän lämpötilat");

            //1.Luo taulukko ja lista arvoille.

           
            string[] measurementTimes = { "6:00", "12:00", "18:00", "24:00" };
            
            
            double[] temperaturesArray = new double[measurementTimes.Length]; // Taulukko
            List<double> temperaturesList = new List<double>(); // Lista

            //2.Lue silmukka, jossa käyttäjän arvo luetaan ja tallennetaan taulukkoon ja listaan. (Arvo luetaan vain kerran per kierros ja se tallennetaan sekä taulukkoon ja listaan)

            for (int i = 0; i < measurementTimes.Length; i++ )
            {
                Console.Write($"Syötä kello {measurementTimes[i]} lämpötila: ");
                double input = double.Parse(Console.ReadLine());
                temperaturesArray[i] = input; // Taulukko
                temperaturesList.Add(input); // lista
                
            }




            //3a.Ilmoita suurin, pienin ja keskilämpötila käyttämällä valmiita metodeja.
            Console.WriteLine($"Taulukon suurin lämpötila on: {temperaturesArray.Max()}");
            Console.WriteLine($"Taulukon pienin lämpötila on: {temperaturesArray.Min()}");
            Console.WriteLine($"Taulukon keskilämpötila on: {temperaturesArray.Average()}");

            Console.WriteLine($"Taulukon suurin lämpötila on: {temperaturesList.Max()}");
            Console.WriteLine($"Taulukon pienin lämpötila on: {temperaturesList.Min()}");
            Console.WriteLine($"Taulukon keskilämpötila on: {temperaturesList.Average()}");

            //3b.Suorita arvojen etsiminen omalla koodilla. (Kysy esim ChatGPT: How to find the smallest value in an array using for loop)

            
            // Algoritmi, termi koodille , joka suorittaa jonkin asian
            // Tässä algoritmi,joka laskee keskiarvon.
            int count = 0;
            double sum = 0;

            foreach (double temp in temperaturesArray)
            {
                sum += temp;
                count++;

            }

            Console.WriteLine($"Taulukon keskiarvo on: {sum / count}");

            // Tässä algoritmi, joka hakee listasta suurimman arvon.

            double value = 0; // Tässä arvosta lähdetään liikkeelle ja tallennetaan suurin arvo.

            for (int i = 0; i < temperaturesArray.Length; i++)
            {
                // Onko uusi arvo suurempi kuin vanha arvo
                if (temperaturesList[i] < valueMin)
                {
                    valueMin = temperaturesList[i]; // Otetaan talteen isompi arvo

                }


            }   Console.WriteLine($"Listan suurin arvo on: {valueMin}");
            
                // Algoritmi, joka hakee taulukosta pienimmän arvon



            
            
            
            .




            //4.Tulosta suurin, pienin ja keskilämpötila käyttäjälle










            
            Console.ReadKey();
        }
    }
}
