using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30c_Toisto_kertymä_tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Käyttäjä syöttää kierros määrän");
            int loops = int.Parse(Console.ReadLine());
            int sum = 0;
            // Summataan luvut 0:sta käyttäjän lukuun asti
            for (int i = 0; i < loops; i++)
            {
                // summataan, tarvitaan muuttuja
                int sum = 0;
                sum = sum + i;


            }

            //Console.Writeline($"{loops} kierrosta Kertymäksi saatiin: {sum}"); 









            Console.ReadKey();
        }
    }
}
