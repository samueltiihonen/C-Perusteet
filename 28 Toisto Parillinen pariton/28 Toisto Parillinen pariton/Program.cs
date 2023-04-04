using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Toisto_Parillinen_pariton
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. pyydetään käyttäjältä luku
            // 2. Luetaan ja tallenetaan luku muuttuujaan 

            //Console.Write("Syötä luku johon asti tulostetaan: ");
            //int number = int.Parse(Console.ReadLine());

            //// 3. luodaan silmukka, joka suoritetaan niin monta kertaa kuin 1 - käyttäjän luku on
            ////    -while, pitää miettiä jokin sopiva ehto
            ////    -jotta voidaan tulostaa numeroita 1 alkaen, tarvitaan muuttuja, joka on alussa 1

            //int i = 1; // iterointi: i++ => i == jne
            //// kysytään käyttäjältä halutaanko parillinen vai pariton 
            //Console.Write("parillinen / pariton");
            //string input = Console.ReadLine();

            //while (i <= number)
            //{
            //    // Lisätään ehto, joka tulostaa vain parittoman numeron
            //    if (i % 2 != 0 && input == "Pariton")

            //        Console.WriteLine(i);

            //    {
            //        else if (i % 2 == 0 && input == "parillinen")

            //            Console.writeline(i);

            //    }


            //    i++; // suoritetaan iteraatio jokaisella silmukan kierroksella


            //}

            // 4. silmukassa tulostetaan  numero 1 , jota iteroidaan joka kierros.

            string EVEN_TEXT = "Parillinen";
            string ODD_TEXT = "Pariton";

            Console.Write("Syötä luku johon asti tulostetaan: ");
            int number = int.Parse(Console.ReadLine());
            // while tarkistaa että käyttäjä syöttää hyväksyttävän arvon
            string input = ""; // Muuttuja luodaan ennen silmukkaa, jotta sitä voi käyttää ehdossa
            bool inputFalse = true;
            
            while (inputFalse == true) // Silmukka toistetaan, niin kauan kuin käyttäjän input on väärin
            {

            }

            Console.Write($"{EVEN_TEXT} / {ODD_TEXT}: ");

            input = Console.ReadLine();

            if (input == EVEN_TEXT)
            {


                inputFalse = false;

                else if (input == OOD_TEXT)

                    inputFalse = false; // kun tämä muuttuja on false, pysähtyy silmukka


                {   else if (input == OOD_TEXT)

                        inputFalse = false; // kun tämä muuttuja on false, pysähtyy silmukka

                }

                // Käyttäjän syöte tarkistetaan aiemmin
                int startingPoint = input == EVEN_TEXT ? 2 : 1;

                // Parillinen alkaa 2
                // Pariton alkaa 1


                for (int i = startingPoint; i <= number; i += 2)
                {
                    Console.Writeline(i);

                }

                Console.ReadKey();
            }
        }
    }
