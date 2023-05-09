using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktio_Tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {


            // 1. Funktio / Function
            // Funktio on keino kapsuloida tietty toiminnallisuus, jota voidaan käyttää uudelleen 
            // Eri kohdissa projektia.


            // Funktion / Metodi koodi tulee tiettyyn kohtaan tiedostoa
            // Funktio ja metodi ovat melkein samoja, erona on niiden sijainti.
            // Metodi on termi funktiolle, joka on osana luokkaa.


            // Olemme kirjoittaneet koodia luokkaan nimeltä "Program" ja sen funktioon / metodiin
            // "Main"

            // Funktion / Metodi koodi tulee tiettyyn kohtaan tiedostoa.


            // Kun lähdemme tekemään uutta metodia, se täytyy kirjoittaa samalle tasolle muiden 
            // Metodien/ funktioiden kanssa, luokan sisälle.

            // Tänne ei voi luoda uutta funktiota, koska olemme jo "Main" - funktion sisällä.
            // Metodiin luotiin "Main" - funktion alapuolelle

            // Täällä voidaan käyttää metodia

            // UUSITERMI:: olio / object
            // Olio on istanssi luokasta. Esimerkki: 
            // Oletuksena metodeja voi ainoastaan käyttää, kun luokasta on luotu objekti.
            // Nyt uutta "printText()"-metodia ei voida käyttää, ellei luoda luokasta "Program"
            // Uutta objektia.

            Program test = new Program(); // Luodaan tämän tiedoston "program" luokasta objecti
            test.printText("Hello", 123);
            test.printText("World", 321);

            // Poikkeuksena  staattinen metodi
            // Jos metodista luodaan staattinen, sitä ovi käyttää suoraan ilman objektia.

            // Esim:
            Console.WriteLine(""); // tämä on "Console"- luokan staattinen "WriteLine(); -metodi"
            // Program.multiplyNumbers(2, 10); // Viittaus "Program" luokkaan ei ole pakollinen
            // Koska olemme sen luokan sisällä.
            // Metodi palautettaa arvon, se pitää ottaa talteen.
            int fiveTimesThree = multiplyNumbers(5, 3);
            // Tai käytetään palautettavaa
                
                
                
                
                
                
            // Main function

            // Luodaan uusi metodi , muiden metodien ulkopuolelle, mutta luokan sisälle.

            // Näkyvyys [palautettavaDatatyyppi] [metodiNimi] ( [parametrit], pilkulla eroteltuna)

            private void printText(string message, int number)
            {

                //Private - näkyvyys tarkoittaa, että sitä ei voida käyttää luokan ulkopuolelta.
                // void - datatyyppi, ei palauta mitään.
                // parametrit - dataa, joka lähetetään funktioon.
                Console.WriteLine($"Text: {message}{number}");
            }

            // Luodaan staattinen metodi
            // Avainsana "static" tulee näkyvyyden ja palautettavan datatyypin väliin.
            // Tämä metodi ottaa vastaan kaksi int arvoa ja palauttaa niiden kerronnan tuloksen.
            
            public int multiplyNumbers (int number1, int number2)
            {
                // public - näkyy luokan ulkopuolelle 
                // static - tekee metodista staattisen (voi käyttää ilman objektia)
                // int - tämä metodi palauttaa int - arvon

                return number1 * number2; // Return avainsanalla palautetaan arvo.
            }
            
        } // Class Program 
    } // Nemespace 
}