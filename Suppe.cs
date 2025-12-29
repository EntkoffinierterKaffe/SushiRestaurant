using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiRestaurant
{
    public class Suppe : IGericht
    {
        public Suppe(double preis)
        {
            Preis = preis;
        }

        public double Preis { get; set; }
    }
}
