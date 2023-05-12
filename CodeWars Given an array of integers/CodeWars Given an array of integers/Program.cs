using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Given_an_array_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            public static int[] CountPositiveSumNegatives(int[] input)
            {
                
                // Jos taulukko "input" on tyhjä tai taulukko "input" on null
                // palautetaan tyhjä taulukko 
                if (input.Length == 0 || input == null)
                {
                    return new int[0];
                }
                  
                
                
                
                if(CountPositivesSumNegatives(new int[] {5, 3, 8, -5, -9, 3})
                    == new int[] {4, -99})
                
                
                // Kun verrataan objekteja "== vertailu", ainoastaan tarkistaa
                // viittaako muuttujat samaan objektiin muistissa.
                // Se ei tutki objektien sisältöä.
                
                    
                    
                    
                //Luodaan uusi taulukko, johon tallenetaan palautettavat arvot.
                int[] result = new int[2];
                
                
                // Lasketaan input-taulukosta positiivisien arvojen lukumäärä.
                // Jos silmukka toimii myös
                foreach (int number in input)
                {
                    // Tarkistetaan, että arvo on positiivinen
                    if(number > 0)
                    {
                        result[0]++;
                    }
                }

                for (int i = 0; i < input.Length; )
                {
                    if (input[i] > 0)
                    {
                        // Kasvatetaan positiivisien arvojen lukumäärän laskua
                        result[0]++;
                    }
                    else // Negatiiviset arvot 
                    {
                        result[1]+= number;
                    }








                }   
                

                
                
                    


                    return result;


                    Console.ReadKey();
            }



        }
    }
}
