using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Kaikkien_aiheiden_kertaus_Tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Number Guessing Game

            Random random = GenerateRandomNumber(13);
            int targetNumber = random.Next(1, 101);

            Console.WriteLine("Arvaa luku 1 ja 100 väliltä: ");
            bool guessCorrectly = false;

            while(!guessedCorrectly)
            {
                string userInput = Console.ReadLine();
                int userGuess;

                if (int. TryParse(userInput, out userGuess))
                
            }
         


            
            string userInput = Console.ReadLine();
            int userGuess = int.Parse(userInput);

            if (userGuess < targetNumber)
            {
                Console.WriteLine("Isompi!");
            }
            else if (userGuess > targetNumber)
            {
                Console.WriteLine("Pienempi!");
            }
            else
            {
                Console.WriteLine("Onneksi olkoon! Arvasit oikein!");
            }
            
            
            
            
            
            
            
            Console.ReadKey();

        }
    }
}
