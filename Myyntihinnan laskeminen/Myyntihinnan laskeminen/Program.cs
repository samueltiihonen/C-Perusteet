using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myyntihinnan_laskeminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("syötä hinta: ");
            double price = double.Parse(Console.ReadLine());
            double discountedprice;

            if(price > 100)
            {
                discountedprice = price * 0.75;
            }
            else
            
            {
                discountedprice = price * 0.90;

                Console.WriteLine($"Alennettu hinta on {discountedprice} euroa");

            }
       
                















            Console.ReadKey();
        }
    }
}
