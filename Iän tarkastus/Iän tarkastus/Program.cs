using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iän_tarkastus
{
    class Program
    {
        static void Main(string[] args)
        {

            
            bool(ageCorrect) = false;
            
            while (!ageCorrect)
            
                Console.Write("Syötä ikä:");
            int age = int.Parse(Console.ReadLine());
            int minage = 0;
            int maxage = 120;
            // Tarkistakaa että ikä on sopiva
            if (age >= 0 && age <= maxage)
            {
                ageCorrect = true;
                Console.WriteLine("Tallenus onnistui");
            }
            else
            {

            }

            Console.WriteLine($"Arvo ei ole hyväksyttävällä välillä  ({minage)-{maxage})");








        } // ctrl + a , ctrl + k , ctrl + d rivien sisennys
         Console.ReadKey();
        }
    }
}
