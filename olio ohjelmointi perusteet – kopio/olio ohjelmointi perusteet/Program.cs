using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ohjelmointi_perusteet
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Funktio / Function
            // Funktio on keino kapsuloida tietty toiminnallisuus, jota voidaan käyttää uudelleen 
            // Eri kohdissa projektia.


            // 2. Luokka / Class 

            // Olio- ohjelmoinnin pohjimmainen idea on jakaa sovellus pieniin kokonaisuuksiin (luokkiin / olioihin)
            // Idea on jakaa laaja ongelma, pieniin osiin.
            // Sovelluksissa on pääsääntöisesti kahta asiaa: 1. Data (Property) 2. Toiminallisuus (Method) 
            // Kuokkien idea on yhdistää oleellinen data ja toiminallisuus yhteen pakettiin.



            // TODO: Luokan lisäämisen omaan tiedostoon



            // luokan luomisen sijainti, samalle tasolle muiden luokkien kanssa.
            // tässä tiedostossa "program" luokan kanssa samalle tasolle. 

            // Luodaan luokasta objekteja
            person personA = new Person();
            personA.Age = 30;
            personA.Name "Juho";

            person personB = new Person(25, "Matti", 1.8, new List <Pet>());
            
            

            Person personC = new Person(35, "Jesse", 175.8, new List <Pet>());
            
            
            
            // TODO: vakue type
            



            // Class - Avainsana
            // Test - Oma luoakan nimi, isolla kirjaimella

            class person // luokkien idea on mallintaa jotakin todellista asiaa. Tiettyyn pisteeseen saakka.
        {
            // 2a. Constructor
            // 2b Property
            // kirjoita prop and sen  jälkeen sarkain kaksi kertaa
            // Propertyn syntaksi: [Näkyvyys] [datatyyppi] [nimi] [get ja set]
            // [get ja set] get määrittää kuinka arvo luetaan ja set määrittää kuinka arvo tallenetaan

            public int Age { get; set; }

            public string name { get; set; }

            public double Lenght { get; set; 
            
            public
            public List <Pet> Pets { get; set; }

            // 2b. Constructor
            // Erityis metodi, jolla tallenetaan objektiin oletusarvoja.
            // [Näkyvyys]
            // [nimi], jonka täytyy olla täysin sama kuin luokan nimi
            
            public person() // Constructoria voi olla 
            
            
            public Person(int age, string name, double lenght, List<Pet> pets)
            {
                Age = age;
                Name = name;
                Lenght = lenght;
                Pets = pets;
            }

            // 2c. Metodi / Method
            // Toiminnallisuus
            
            // Metodi palauttaa matkan pituuden uuden ja vanhan sijainnin välillä. 
            public double Walk(Location newlocation)
            {
                double result = CurrentLocation.CoordinateX - newLocation.CoordinateX;

                CurrentLocation = newLocation; // Päivitetään uusi sijainti
                
                return result;
            }

            public class Pet
            {
                public string Name { get; set; }

                public int Age { get;  set; }

        }       public class Location
            {
                public int CoodinateX { get; set; }
            }










        }
    }
}
