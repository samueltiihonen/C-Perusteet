using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiot_Bensankulutus_2
{
    class trip
    {
        // Properties
        // Data class - luokkaa voi käyttää pelkästään tietorakenteena, ilman toimintoja(methods).
        public double Distance { get; set; }

        public double AverageConsuption { get; set; }

        public double FuelPrice { get; set; }

        private double privateProperty { get; set; } // Privaatti properties pienellä.

        // Constructors

        public trip(double distance, double averageConsuption, double fuelprice)
        {
            Distance = distance;
            AverageConsuption = averageConsuption;
            FuelPrice = fuelprice;
        }

        // Methods




    }
}
