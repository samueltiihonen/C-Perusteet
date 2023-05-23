using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._5_Koe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä käyttäjän puhelin numero");
            string puhelinnumero = Console.ReadLine();

            if (OnHyvaksyttavassaMuodossa(puhelinnumero))
            {
                Console.WriteLine("Puhelin numero on hyväksyttävä");
            }
            else
            {
                Console.WriteLine("Puhelin numero ei ole hyväksyttävä");
            }

            Console.ReadLine();

            
               

            
            // Käyttäjä tunnus koulunverkkoon.


            {
                Console.WriteLine("Syötä opiskelijan etunimi");
                string etunimi = Console.ReadLine();

                Console.WriteLine("Syötä opiskelijan sukunimi");
                string sukunimi = Console.ReadLine();

                string kayttajatunnus = GeneroiOpiskelijatunnus(etunimi, sukunimi);

                Console.WriteLine("Opiskelijatunnus: " + kayttajatunnus);

                Console.ReadLine();
            }

            

                
            


            // Tuote laskuri


            List<Product> tuotteet = new List<Product>();

            Console.WriteLine("Syötä tuotteiden tiedot (lopeta tyhjällä rivillä):");
            while (true)
            {
                Console.WriteLine("Syötä tuotteen nimi:");
                string nimi = Console.ReadLine();
                if (string.IsNullOrEmpty(nimi))
                {
                    break;
                }

                Console.WriteLine("Syötä tuotteen hinta:");
                decimal hinta = decimal.Parse(Console.ReadLine());

                Product tuote = new Product(nimi, hinta);
                tuotteet.Add(tuote);
            }

            Console.WriteLine("Tuotteet ja niiden tiedot:");
            foreach (Product tuote in tuotteet)
            {
                Console.WriteLine("Nimi: " + tuote.Name);
                Console.WriteLine("Hinta: " + tuote.Price.ToString("C")); 

                decimal alennettuHinta = tuote.CalculateDiscountedPrice(20.00M); 
                Console.WriteLine("Alennettu hinta (20% alennus): " + alennettuHinta.ToString("C"));

                Console.WriteLine();






                // JavelinThrow luokan objekteja

                List<JavelinThrow> throws = new List<JavelinThrow>();


                throws.Add(new JavelinThrow(1, "Jussi", 60, 50));
                throws.Add(new JavelinThrow(2, "Julia", 55, 30));
                throws.Add(new JavelinThrow(3, "Erkki", 65, 10));


                foreach (JavelinThrow javelinThrow in throws)
                {
                    Console.WriteLine("Heitto ID: " + javelinThrow.Id);
                    Console.WriteLine("Urheilijan nimi: " + javelinThrow.AthleteName);
                    Console.WriteLine("Metrit: " + javelinThrow.Meters);
                    Console.WriteLine("Senttimetrit: " + javelinThrow.Centimeters);
                    Console.WriteLine();
                }

                Console.ReadLine();





















                Console.ReadKey();
        
        
        }


        static bool OnHyvaksyttavassaMuodossa(string puhelinnumero)
        {

            if (puhelinnumero.Length != 13)
            {
                Console.WriteLine("Puhelinnumerossa pitää olla 13 merkkiä");
                return false;
            }

            if (puhelinnumero.StartsWith("+358"))
            {
                Console.WriteLine("Puhelinnumeron pitää alkaa merkeillä \"+358\".");
                return false;
            }
        }


            // Opiskelin käyttäjätunnus koulun verkkoon

            static string GeneroiOpiskelijatunnus(string etunimi, string sukunimi);

            string etunimenLyhennys = etunimi.Length => 3 ? etunimi.Substring(0, 3) : etunimi;
            string sukunimenLyhennys = sukunimi.Length => 5 ? sukunimi.Substring(0, 5) : sukunimi;

            return sukunimenLyhennys + etunimenLyhennys;


        }
}
