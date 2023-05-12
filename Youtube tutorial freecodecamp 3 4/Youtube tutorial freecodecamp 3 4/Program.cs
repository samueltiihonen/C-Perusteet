using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_tutorial_freecodecamp_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Building a Guessing Game

            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            
            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }



            Console.ReadLine();


            // For Loops

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            
            
            Console.ReadLine();



            // Building an Exponent Method

            Console.WriteLine(GetPow(4, 3));
            Console.ReadLine();
            
            static int GetPow(int baseNum, int powNum)
            {
                int result = 1;

                for (int i = 0; i < powNum; i++)
                {
                    result = result * baseNum;
                }

                return result;


            }
            
            
            Console.ReadLine();





            // 2D Arrays

            int[,] numberGrid = {
                {1,2 },
                {3,4 },
                {5,6 }

            };
            int[,] myArray = new int[2, 3];
            
            Console.WriteLine(numberGrid[1,1]);

            
            
            Console.ReadLine();



            // Comments

            // This prints something out
            Console.WriteLine("Comments are fun");




            Console.ReadLine();



            // Exception Handling

            {

                try
                {
                    Console.Write("Enter a number: ");
                    int num1 = Convert.ToInt32 / Console.ReadLine());
                    Console.Write("Enter a another number: ");
                    int num2 = Convert.ToInt32 / Console.ReadLine());

                    Console.WriteLine(num1 / num2);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e) {
                    Console.WriteLine(e.Message);
                }

            }


            Console.ReadLine();




            // Classes & Objects

            {
                Book book1 = new Book();
                book1.title = "Harry Potter";
                book1.author = "JK Rowling";
                book1.pages = 400;

                Book book2 = new Book();
                book2.title = "Lord of the Rings";
                book2.author = "Tolkein";
                book2.pages = 700;
                
                Console.WriteLine(book1.title);


                Console.ReadLine()
            }

            
            
            
        }
    }
}
