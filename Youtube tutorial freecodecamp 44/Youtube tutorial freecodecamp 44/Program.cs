using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_tutorial_freecodecamp_44
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Methods

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);


            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());


            
            
            
            Console.ReadLine();




            // Getters & Setters

            Movie avengers = new Movie(" The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie(" Shrek", "Adam Adamson", "PG");
            shrek.Rating = "Cat";
            Console.WriteLine(avengers.Rating);
            Console.ReadLine();



            // Static Class Attributes


            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.artist);
            
                
            Console.ReadLine();




            // Static Methods & Classes


           
            UsefulTools.SayHi("Mike");

            Console.ReadLine();


            // Inheritance

            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();






            Console.ReadLine();





        }
    }
}
