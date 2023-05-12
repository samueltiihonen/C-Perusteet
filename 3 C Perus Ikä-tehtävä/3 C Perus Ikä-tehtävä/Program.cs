using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_C_Perus_Ikä_tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikäsi");
            string userInput = Console.ReadLine();
            int userAge = int.Parse(userInput);

            Console.WriteLine($"Olet {userAge} vuotta!");








            Console.ReadKey();
        }
    }
}
