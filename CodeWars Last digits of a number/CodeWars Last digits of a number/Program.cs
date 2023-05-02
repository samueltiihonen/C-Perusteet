using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Last_digits_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            LastDigit(1, 1);
            LastDigit(123767, 4);
            LastDigit(0, 1);
            LastDigit(34625647867585, 10);
            LastDigit(1234, 0);
            LastDigit(24134, -4);
            LastDigit(1343, 5);
        }

        public static int[] LastDigit(long n, int d)
        {
            // Jos d on negatiivinen, palautetaan tyhjä taulukko
            if (d < 0)
            {
                return new int[] { };
            }


            // n == 123456
            // d == 4
            // return == 3, 4, 5, 6

            // Ensin n -> ToString(), jotta voidaan käsitellä numeroita yksi kerralaan. 123456 -> "123456"

            string asText = n.ToString();
            //Jos pyydetään enemmän numeroita kun luvussa on,
            // Päivitetään parametrin d pituus
            if (d > asText.Length)
            {
                d = asText.Length;
            }

            int[] result = new int[d];
            // Aloitetaan taulukon viimeisestä indeksistä
            int arrayIndex = result.Length - 1;

            // 12345678
            // 2
            // 8 - 2 6

            // Kopioidaan uudesta string muuttujasata arvot lopusta alkua kohti
            // Aloitetaan viimeisestä indeksistä 
            // Ja suoritetaan d(parametri) kertaa
            // Length == 6
            // d == 4
            // 6 - 4 == 2
            for (int i = asText.Length - 1; i >= asText.Length - d; i--)
            {
                result[arrayIndex] = int.Parse(asText[i].ToString());
                arrayIndex--;

            }

            return result;
        }
    }
}

