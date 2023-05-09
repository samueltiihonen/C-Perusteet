using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Is_he_gonna_survive
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static bool Hero(int bullets, int dragons)
        {
            // 4, 5 * 2
            // Tarvittavien luotien määrä on kaksi kertaa dragons
            //Testataan , onko bullets >= tarvittavien luotien määrä
            //Do Some Magic...
            return dragons * 2 <= bullets ? true : false; 
            
        }
    }   

}
