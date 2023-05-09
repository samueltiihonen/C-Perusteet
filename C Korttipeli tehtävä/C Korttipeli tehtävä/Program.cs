using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Korttipeli_tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lisätään koodi, joka generoi pakkaan kortit
            // Lisätään pakalle metodi, jolla nostetaan yksi kortti pakasta.
            // Pakan sekoitus metodi

            // Tässä on pelin kaikki kortit
            Deck deck = new Deck();
            // Tässä on pelaajan käsi
            Deck player1Deck = new Deck();
            Deck player2Deck = new Deck();

            deck.GenerateCards();
            deck.Shuffle();




            // Lisää sovellukseen toinen pelaaja 
            // Nosta molemmille pelaajille kortit
            player1Deck.Cards.Add(deck.Draw());
            player2Deck.Cards.Add(deck.Draw());

            // Ilmoita kumpi voitti
            if (player1Deck.Cards[0].Value > player2Deck.Cards[0].Value)
            {
                Console.WriteLine("Pelaaja yksi voitti!");
            }
            else if (player1Deck.Cards[0].Value < player2Deck.Cards[0].Value)
            {
                Console.WriteLine("Pelaaja kaksi voitti!");
            }
            else // Jos sama arvo, verrataan maat
            {
                if (player1Deck.Cards[0].Suite < player2Deck.Cards[0].Suite)
                {
                    Console.WriteLine("Pelaaja yksi voitti!");
                }
                else
                {
                    Console.WriteLine("Pelaaja kaksi voitti!");
                }




                // Isompi arvo voittaa
                // Ässä == 1
                // Tasapeli seuraavasti
                // Hearts > Diamonds > Clubs > Spades


                Console.ReadKey();
            }
        }
    }   }
