using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiot_Pinta_alat_ja_tilavuudet
{
    class Triangle
    {
    
        // Properties
        public double Height { get; set; }

        public double Base { get; set; }
        
        // Costructors

        public Triangle(double height, double baseParameter)
        {
            Height = height;
            Base = baseParameter;
        }

        // Methods 
        // Ei tarvitse static, koska tätä käytetään luokan objektista.
        // Esim: Triangle test = new Triangle(2, 5); - Luodaan objekti luokasta, nimeltä "test"
        // Console.WriteLine(test.Area()); - käytetään obkektin metodia.
        public double Area()
        {
            double result = 0;

            result = Base * Height / 2;

            return result; 
        }


        public double Perimeter()
        {
            // c = () 

            double result = 0;

            result = Height + Base + Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Height, 2));

            return result;
        }


    }
}
