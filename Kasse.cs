using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SushiRestaurant
{
    public class Kasse
    {
        public static double Berechne(Bestellung bestellung)
        {
            int anzahlMittagsmenü = 0;
            double rechnung = 0f;

            SammleMittagsmenüs();
            BerechneMittagsMenüs();
            BerechneRestlicheGerichte();

            return rechnung;

            void SammleMittagsmenüs()
            {
                if (bestellung.Zeitpunkt.Hour < 11 || bestellung.Zeitpunkt.Hour > 17)
                {
                    return;
                }
                while (bestellung.Gerichte.Count(x => x is Teller) >= 4 && bestellung.Gerichte.Count(x => x is Suppe) >= 1)
                {
                    var teller = bestellung.Gerichte.Where(x => x is Teller).OrderBy(x => x.Preis).Reverse().Take(4).ToList();
                    var suppe = bestellung.Gerichte.Where(x => x is Suppe).FirstOrDefault();

                    foreach (var item in teller)
                    {
                        bestellung.Gerichte.Remove(item);
                    }

                    bestellung.Gerichte.Remove(suppe);

                    anzahlMittagsmenü += 1;
                }
            }

            void BerechneMittagsMenüs()
            {
                for(int i = 0; i < anzahlMittagsmenü; i++)
                {
                    rechnung += 8.50f;
                }
            }

            void BerechneRestlicheGerichte()
            {
                foreach (var tel in bestellung.Gerichte)
                {
                    if (tel is Teller tell)
                    {
                        rechnung += tell.Preis;
                    }
                    else
                    {
                        rechnung += 2.50;
                    }

                }
            }
        }

    }
}
    