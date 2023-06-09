﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34B_C_Vokaalit_taulukkoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Lue käyttäjältä sana talteen

            Console.Write("Syötä sana:");
            string userInput = Console.ReadLine();

            //2.Luo taulukko sanan vokaaleille

            // taulukon pituus täytyy määrittää, sitä luodessa 
            //Luodaan taulukon pituudeksi sama, kuin sanan pituus, silloin ainakin riittää tila

            // datatyyppi [] taulukonNimi = new datatyyppi[taulukon pituus];
            char[] vocalsInWord = new char[userInput.Length]; // Taulukko

            // List<datatyyppi> nimi = new List<datatyyppi>();
            List<char> vocaIsUsingList = new List<char>(); // Lista 
            // Lista on oletuksena tyhjä ja sen pituus/Count on 0
            // vocaIsUsingList[0] = 'n'; // Kaatuu, ArgumentOutOfRangeException, koska lista on tyhjä
            // Sen elementtejä ei voida vielä käyttää
            
            
            
            //3.Käy sanan merkit läpi silmukassa

            
            // foreach olisi toinen vaihtoehto, mutta siinä on hankala saada indeksi,
            // jota tarvitaan taulukossa

            // indeksi (int i = 0) alkaa arvosta 0, koska indeksit alkavat nollasta,
            //         indeksi muuttujaa käytetään taulukossa
            // silmukan ehtona on taulukon pituus / indeksien lukumäärä. Kun iteroitavan muuttuja i
            //          on taulukon indeksien ulkouolella, silmukka päättyy.
            //          Esim: "test" .Length == 4, jonka indeksit ovat 0, 1, 2, 3. Kun i saapuu arvoon 4,
            //          eli 4 < 4 ei ole enää totta, silmukka päättyy
            // Iterointi, i++
            //
            for (int i = 0; i < userInput.Length; i++)
            {
                // Kirjoitetaan merkit yksi kerrallaan, merkkiä voi käyttää syntaksilla
                // muuttujanNimi[indeksi]
                Console.WriteLine(userInput[i]);


                // 4. Tallenna merkki taulukkoon, jos se on vokaali.
                // Lisätään merkin tallennus ehdon sisälle, joka tarkistaa, että merkki on vokaali
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u' || userInput[i] == 'y' ||
                userInput[i] == 'ä' || userInput[i] == 'ö' ||)

                {
                    vocalsInWord[i] = userInput[i];
                    vocaIsUsingList.Add(userInput[i]); // Listaan lisätään elementti. 
                }
                
            
            }
 


            //5.Luo silmukka, jossa tulostetaan vokaalit taulukosta käyttäjälle.
            
            // for olisi toinen vaihtoehto
            foreach (char symbol in vocalsInWord)
            {
            
            // Ei tulosteta tyhjiä elementtejä
            // char taulukon oletusarvo on 0, jos symbol on muutakuin 0 (symbol != 0)
            // tulostetaan merkki
            if (symbol != 0)
            {
                Console.WriteLine(symbol);
            }

                {
                    
                // Myös foreach toimisi 
                for (int i = 0; i < vocaIsUsingList.Count; i++) // Lista
                    {

                        Console.WriteLine(Lista: " + vocaIsUsingList [i]); 
                    }
                
                
                }
            
            
            
            }





            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
