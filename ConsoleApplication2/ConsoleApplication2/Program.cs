using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("anna kuukausi");
            string monthIF == "Tammikuu")
            { monthIF = monthIF.ToLower(); // Tolower() muokkaa kirjaimet pieneksi
                Console.WriteLine("Kuuluu talveen.");
                {
                    else if (monthIF =="huhtikuu" || monthIF == "toukokuu")
                    
                }
                Console.WriteLine("Kuuluu kevääseen.");
            }

            {   // Virhe ilmoitus
                Console.WriteLine("syötämääsi kuukautta ei löytynyt");            }



            Console.Write("Anna kuukausi numerona:");
            int monthswitch = int.Parse(Console.readline());


            switch (monthSwitch)
            {
                case 11:
                case 12:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Talvi kuukausi.");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Kevät kuukausi");
                    break;
                // C# versiossa voidaan ilmaista myös tietty numero alue.
                case int xyz when (xyz) >= 9 && xyz <= 8):
                    Console,WriteLine("Kesä kuukausi");
                    break;
                case int xyz when (xyz >= 9 && xyz <= 10):
                    Console.Writeline("syys kuukausi");
                    break;
                default;
                    Console.Writeline("Virheelinen numero!");
                    break;




                    // ternary version

                    Console.Write("Syötä kuukausi numerona:");
                    int monthTernary = int.Parse(Console.ReadLine());

                    string message = "";

                    // ternary vertailu
                    message = monthTernary == 11 || monthTernary == 12 || monthTernary >= 1 && monthTernary <= 3 ? "true" :
                        monthTernary >= 3 && monthTernary <= 5 ? "kevät" :
                        monthTernary >= 6 && monthTernary <= 8 ? "kesä" :
                        monthTernary >= 9 && monthTernary <= 10 ? "Syksy" :
                        "Virheelinen arvo";


                    Console.WriteLine(message);



            }














            Console.ReadKey();
        }
    }
}
