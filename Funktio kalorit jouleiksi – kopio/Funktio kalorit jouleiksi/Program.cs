using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktio_kalorit_jouleiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // while, joka toistuvasti pyytää muunnoksia 
            // käyttäjä valitsee j = 
            // 
            // 
            // 
            
            
            
            
            
            
            
            
            
            Console.Write("Syötä kalorit:");
            decimal calories = decimal.Parse(Console.ReadLine());

            Console.Write("Syötä joulet:");
            decimal joules = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"k => j== {caloriesToJoules(calories)}");
            Console.WriteLine($"j => k== {joulesToCalories(joules)}");
            
            Console.Write("Muuta kalorit jouleiksi:");
            decimal calories = decimal.Parse(Console.ReadLine());

            Console.Write("Muuta joulet kaloreiksi:");
            decimal calories = decimal.Parse(Console.ReadLine());









            private static decimal caloriesToJoules(decimal calories)
            {
                return calories * 4.184m;

            }

            private static decimal joulesToCalories(decimal calories)
            {
                return joules * 0,2390m;

            }





        }
    }
}
