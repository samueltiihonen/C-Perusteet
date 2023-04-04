using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Toisto_kertymä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kysy käyttäjän laskettavien lukujen määrä");
            int numbersToSum = int.Parse(Console.ReadLine());
            double sum = 0; // luodaan summa muuttuja silmukan ulkopuolella, muuten muuttuja aina resetoituu.
            // k:4, 0, 1, 2, 3 => 4 kierrosta
            for(int i = 0; i < numbersToSum; i++)
            {
                Console.Write($"Anna luku {i}: ");
                sum = sum + int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"Summa on: { sum} ja summan keskiarvo on: { sum/numbersToSum}");
            











            Console.ReadKey();
        }
    }
}
