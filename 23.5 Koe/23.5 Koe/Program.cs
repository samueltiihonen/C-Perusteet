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


            List<Product> products = new List<Product>();

            Console.WriteLine("Syötä tuotteiden tiedot (lopeta tyhjällä rivillä):");
            while (true)
            {
                Console.WriteLine("Syötä tuotteen nimi:");
                string nimi = Console.ReadLine();
                if (string.IsNullOrEmpty(nimi))
                {
                    break;
                }

                Random rng = new Random(4);

                Console.Write("Tuotteen hinta: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());

                Product product = price = new discountedPrice(20);
                Console.WriteLine("Price: {0}", price.decimalprice());

                {
                    Console.WriteLine("Tuotteet ja niiden tiedot:");
                    foreach (Product Product in products)
                    {
                        decimal discountedPrice = product.CalculateDiscountedPrice(20.0m);
                        Console.WriteLine($"Nimi: {product.Name}, Hinta: {product.Price}, Alennettu hinta (20%): {discountedPrice}");
                    }
                }




            }



            {















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





        } // Main

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
                return true;

            }

            return false;
        }


        // Opiskelin käyttäjätunnus koulun verkkoon

        static string GeneroiOpiskelijatunnus(string etunimi, string sukunimi)
        {


            string kayttajatunnus = "";

            if (sukunimi.Length >= 5)
            {
                kayttajatunnus += sukunimi.Substring(0, 5);
            }
            else
            {
                kayttajatunnus += sukunimi;
            }

            if (etunimi.Length >= 3)
            {
                kayttajatunnus += etunimi.Substring(0, 3);
            }
            else
            {
                kayttajatunnus += etunimi;
            }

            return kayttajatunnus;





















           












        }







    }

}