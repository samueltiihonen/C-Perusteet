using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {






         // Uusi aihe: Ohjausrakenne - Control structure
         // 1. if - rakenne


         // if (ehto - condition) // lopputulos true / false
         // {start of the code block 



         // }

         // if - else
         // Joko suoritetaan if code block
         // Tai suoritetaan else code block 

         Console.WriteLine("before if);" +
         if ("moi" == "terve")
            { }






            // 3. if - else if - else
            // Rakenteessa voi olla myös muita vertailuja
            //ainoastaan yksi code block suoritetaan

            if (4.5 >= 5.5)
            {
                Console.WriteLine("inside else if");

            }
            else if (10 <= 10)
            { }

            // Vertailuoperaattorit - Comparison operators
            // Vertailujen lopputulos on totuusarvo
            // true / false
            //

            // == samat arvot
            // != eri arvot 
            // > vasen pienempi kuin oikea
            // < vasen isompi kuin oikea
            // <= vasen pienempi tai yhtä suuri kuin oikea
            // >= vasen isompi tai yhtä suuri kuin oikea






            // Loogiset operaattorit - Logical operators 
            // Voidaan yhdistää useampi vertailoperaatio

            // && molemmat totta -and- 
            // age >= agelimit && lenght == targetHeight

            // II toinen totta -or- ctrl+alt+< 
            // age >= agelimit II lenght == targetHeight

            // ! kääntää totuusarvon
            // bool accountDeleted = true; 
            // if (!accountDeleted = true 







            // 4. Silmukat - Loops 

            // while(condition)
            //{
            //    Execute done
            //    As long as condition == true
            //
            //}

            // kommentointi ctrl + k sitten ctrl  + c
            // poisto ctrl + k sitten ctrl + u
            while (true)
                //{
                //
                //    Console.write("moi");
                //{
                //{

            string input;
            while input != "exit")

                Console.Write("choose action: ");
            input = Console.ReadLine();
            Console.writeline($"executing action {input}");

            }
            }
        }
    }
}
