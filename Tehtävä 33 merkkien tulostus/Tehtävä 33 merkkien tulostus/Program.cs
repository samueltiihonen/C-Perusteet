using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_33_merkkien_tulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esimerkki käyttäjän syötteestä: "Lattia A" "Seinä L"

            // merkki " - voidaan näyttää käyttäjälle kenoviivalla \ ennen "-merkkiä. ctrl+alt+?
            Console.Write("Syötä sana ja tulostus suunta (\"Lattia a\"): ");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            // inputsplit[0] == "terve"
            // inputsplit[1] == "L"

            // Tarvitaan valintarakenne, jolla tutkitaan tulostuksen suuntaa
            if (inputSplit[1] == "A") // Alusta
            {
                // Tätä ei periaatteessa tarvita
            }

            else if (inputSplit[1] == "L") // Lopusta
            {
                char[] chars = inputSplit[0].ToCharArray(); // "Testi" => [ 'T', 'e', 's', 't', 'i']
                Array.Reverse(chars);                       //  => [ 'i', 't', 's', 'e', 'T'] 
                string test = new string(chars);            // => "itseT"
                inputSplit[0] = test;                       // => Tallenetaan uusi "itseT" -string taulukon indeksiin 0
            }

            foreach (char jokinNimi in  inputSplit[0])
            {
                Console.WriteLine(jokinNimi);
            }



            
           
            
            
            
            


            








            Console.ReadKey();
        }
    }
}
