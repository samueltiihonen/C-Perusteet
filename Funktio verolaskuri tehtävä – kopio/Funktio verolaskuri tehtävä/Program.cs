using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktio_verolaskuri_tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä bruttopalkka:");
            decimal grossSalary = decimal.Parse(Console.ReadLine());


            Console.Write("Syötä veroprosentti:");
            decimal taxPercentage = decimal.Parse(Console.ReadLine());


            Console.WriteLine($"Nettopalkka on: { netSalary(grossSalary, taxPercentage)}");

            Console.WriteLine(4)









            private static decimal netSalary (decimal grossSalary, decimal taxPercentage)
            {
                decimal result = 0;

                // Tässä välissä lasketaan lopputulos
                result = (grossSalary / 100) * (100 - taxPercentage);

                return result;


            }

        }
    }
}
