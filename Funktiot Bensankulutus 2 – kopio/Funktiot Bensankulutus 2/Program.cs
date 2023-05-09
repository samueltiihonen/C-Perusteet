using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiot_Bensankulutus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //

            // Pyydetään arvot käyttäjältä 

            List<trip> trips = new List<trip>();

            bool userEndsLoop = false;

            while (userEndsLoop == false)
            {
                Console.Write("Syötä matkan nimi ");
                string name = Console.ReadLine();
                
                
                Console.Write("Syötä matka(km): ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write(" Syötä keskikulutus(17100km): ");
                double averageConsumption = double.Parse(Console.ReadLine());

                Console.Write("Syötä polttoaineenhinta(€/1: ");
                double fuelPrice = double.Parse(Console.ReadLine());

                trips.Add(new trip(name, distance, averageConsumption, fuelPrice));

                Console.Write("Syötetään uusi matka(y): ");
                string input = Console.ReadLine();

                if (input != "y")
                {
                    userEndsLoop = true;
                }
            }
                
                    foreach (trip t in trips)

                    {
                     // Lasku toimituksen voisi toteuttaa täällä käyttämällä objektien arvoja,
                    // Mutta yleensä luokan dataan liittyvät toiminallisuudet
                    // ovat osana itse luokkaa.
                     // double test = trip.AverageConsumption * t.fuelPrice * fuelPrice;
                    Console.WriteLine($"Matkan {t.Name} hinta on : {t.CalculateCost()}");
                    }
                
            
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(); 
        
        }           
        
        
                    
    }
}
