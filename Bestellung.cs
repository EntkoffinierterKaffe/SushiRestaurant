using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace SushiRestaurant
{
    public class Bestellung
    {
        public List<IGericht> Gerichte;

        public DateTime Zeitpunkt;

        public Bestellung(List<IGericht> gerichte, DateTime zeitpunkt)
        {
            Gerichte = gerichte;
            Zeitpunkt = zeitpunkt;
        }
    }
}
