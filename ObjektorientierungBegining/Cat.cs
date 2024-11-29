using ObjektorientierungBegining;
using System.Xml.Linq;

class Cat : Animal
{
    public Cat(string name, DateTime birthDate, string color) : base(name, birthDate, color)
    {
        SetLegs("Bipedalier"); 
    }

    public override string ToString()
    {
        return $"Name: {Name}, Farbe: {Color ?? "unbekannt"}, Alter: {Age()} Jahre, Anzahl der Beine: {AnzahlBeine}";
    }

    public override void gibTypischenLautVonDir()
    {
        Console.WriteLine("Die Katze macht 'Miau'.");
    }
}