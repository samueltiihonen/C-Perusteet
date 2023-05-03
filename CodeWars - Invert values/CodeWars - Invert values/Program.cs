using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars___Invert_values
{
    class Program
    {  
        
        public static int[] InvertValues(int[] input)
        {
            //Code it!
            // Silmukka, jossa suoritetaan alla oleva operaatio kaikille
            // Taulukon arvoille.
            // käänteinen arvo: arvo[i] = arvo[i] * -1;
            
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * -1;
            }

            return input;
        }
        
        
        
        
        
        
    }
}
