using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._3.itsenäinen_tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä leveys (metreinä):");
            double leveys = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Syötä korkeus (metreinä):");
            double korkeus = Convert.ToDouble(Console.ReadLine());

            double pintaAla = leveys * korkeus;

            Console.WriteLine("Pinta-ala: " + pintaAla + " neliömetriä");


            Console.ReadKey();

        }
    }
}
