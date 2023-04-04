using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Tähtien_tulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. pyydetään käyttäjältä numero ja tallennetaan mmuuttujaan 
            Console.Write("Syötä numero:");
            int number = int.Parse(Console.ReadLine());


            Console.Write("Syötä merkki: ");
            char symbol = char.Parse(Console.ReadLine());
            
            // 2. Lisätään silmukka, joka suoritetaan käyttäjän syöttämän numeron verran
            // Tulostetaan yksi tähti, toistetaan käyttäjän syöttämän numeron verran
            // while / do while
            // for 
            // foreach

            
            // jos numero = 5 ja i = 0, 1, 2, 3, 4, 5, => suoritetaan 5 kertaa
            for(int i = 0; i < number; i++)
            
            {
                Console.WriteLine(symbol);
            }


            









            Console.ReadKey();
        }
    }
}
