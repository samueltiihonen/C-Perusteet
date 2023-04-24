using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiot_Bensankulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userEndsLoop = false;
            
            
            // List <(decimal, decimal, decimal)> test = new List<(decimal, decimal, decimal)>(); // Tuple
            List<decimal> userDistances = new List<decimal>();
            List<decimal> userAverageConsumption = new List<decimal>();
            List<decimal> userFuelPrice = new List<decimal>();
            // Kun käytetään useaa eri listaa tai taulua, täytyy hallita indeksien käyttö oikein eri listojen välillä.

            (decimal, decimal, decimal)[] rtips = new (decimal, decimal, decimal)[1];

            // Kohta 5, lisätään koko koodi silmukkaan
            while (userEndsloop == false)
            { 
                
            Console.Write("Syötä ajettu matka(km): ");
            decimal distance = decimal.Parse(Console.ReadLine());
                userDistances.Add(decimal.Parse(Console.ReadLine()));
            
            Console.Write("Syötä ajoneuvon keskikulutus(1/100km) :");
            decimal distance = distance = decimal.Parse(Console.ReadLine());
                userAverageConsumption.Add(AverageConsumption);
            
                
            Console.Write("Syötä polttoaineen hinta(€/1: ");
            decimal distance = decimal.Parse(Console.ReadLine());
                userFuelPrice.Add(userFuelPrice);

                trips[trips - 1] = (distance, userAverageConsumption, fuelPrice); 
                
                
                //decimal tripCost = carTripCostCalculator(distance, averageConsumption, fuelPrice);

                //Console.Writeline(); // Tyhjä rivi
                Console.Writeline($"Ajetun matkan hinta on: {tripCost} euroa.");
                Console.Writeline(); Tyhjä rivi


                Console.WriteLine("Calculate another trip? (y/n: ");
                string input = Console.ReadLine();

                if (input == "n") // Käyttäjä 
                {

                    userEndsLoop = true; // Kun tämä muuttuja on true, silmukka päättyy
                }
                else // Laajennetaan taulukko
                {
                    trips = expandArray(trips); // expandArray palauttaa uuden taulukon, joka on yhtä suurempi kuin 
                                                // Alkuperäinen taulukko, joka annetaan parametrinä
                }
                // käydään listat läpi ja tulostetaan matkojen hinnat.
                for (int i = 0; i < userDistances.Count; i++)

                    Console.WriteLine($"Matkan {i+1} hinta on :" +
                        $"{carTripCostCalculator(userDistances[i], userAverageConsumption[i],)}")
                
                
                
                
                
                // Parametrien yksiköt joko kommentoidaan tai lisätään parametrien nimiin.

                private static decimal carTripCostCalculator(decimal distanceInKilometers, decimal averageConsumption, decimal fuelCost)
            {
                decimal result = 0;


                result distanceInKilometers * averageConsumption * fuelCost / 100;
                
                return result;

                private static (decimal, decimal, decimal)[] expandArray((decimal, decimal, decimal)[] originalArray)
                    {
                        // Luodaan uusi taulukko, joka on yhtä suurempi kuin alkuperäinen taulukko
                        (decimal, decimal, decimal[] result = new decimal(decimal, decimal, decimal)[originalArray.Length + 1];

                         // kopioidaan arvot vanhasta taulukosta uuteen taulukkoon
                         
                    }

                    
                    
                    
                    
                    return newArray;

            }

        }
    }
}
