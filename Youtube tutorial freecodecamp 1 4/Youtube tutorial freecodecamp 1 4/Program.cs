using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_tutorial_freecodecamp_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Drawing a Shape
            Console.WriteLine("    /");
            Console.WriteLine("   /");
            Console.WriteLine("  /");
            Console.WriteLine(" /");

            Console.ReadLine();

            // Variables

            string characterName = "Tom";
            int characterAge;
            characterAge = 25;
            
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But he didn´t like being " + characterAge);

            Console.ReadLine();


            // Data types

            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = true;

            Console.WriteLine(false);
            
            Console.ReadLine();



            // Working With Strings

            string phrase = "Giraffe Academy" + " is cool";
            Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy")) );

            Console.ReadLine();


            // Working With Numbers

            Console.WriteLine( Math.);



            
            
            Console.ReadLine();



            // Getting User Input

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + "you are" + age);

            
            
            Console.ReadLine();



            // Building a Calculator

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("num1 + num2");


            Console.ReadLine();



            // Building a Mad Lib

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            
            Console.Write("Enter a plural noun:");
            pluralNoun =  Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity =  Console.ReadLine();


            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + "are blue");
            Console.WriteLine("i love " + celebrity);

            Console.ReadLine();
        }
    }
}
