// See https://aka.ms/new-console-template for more information

using SushiRestaurant;

Console.WriteLine("Hello, World!");

List<IGericht> gerichte = new List<IGericht>()
{
    new Teller(Rand.Blau),
    new Teller(Rand.Blau),
    new Teller(Rand.Grau),
    new Teller(Rand.Grau),
    new Teller(Rand.Grün),
    new Teller(Rand.Grün),
    new Suppe(2.50)
};

Bestellung bestellung = new Bestellung(gerichte,
    new DateTime(25, 10, 10, 12, 0, 0));


Console.WriteLine(Kasse.Berechne(bestellung));


