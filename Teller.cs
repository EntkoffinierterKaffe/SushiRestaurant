using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiRestaurant
{
    public class Teller : IGericht
    {
        public Teller(Rand rand)
        {
            Rand = rand;

            switch (Rand)
            {
                case (Rand.Blau):
                    Preis = 0.95;
                    break;
                case (Rand.Gelb):
                    Preis = 2.95;
                    break;
                case (Rand.Grau):
                    Preis = 4.95;
                    break;
                case (Rand.Grün):
                    Preis = 3.95;
                    break;
                case (Rand.Rot):
                    Preis = 1.95;
                    break;
                default:
                    Preis = 0;
                    break;
            }
        }

        public double Preis { get; set; }
        public Rand Rand { get; set; }
    }
}
