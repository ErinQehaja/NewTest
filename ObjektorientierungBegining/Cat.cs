using ObjektorientierungBegining;
using System.Xml.Linq;

public class Cat : Animal
{
    public Cat(string name, DateTime birthDate, string color) : base(name, birthDate, color)
    {
        SetLegs("Quadrupedier"); 
    }

    public override void gibTypischenLautVonDir()
    {
        Console.WriteLine($"Die {Name} macht 'Miau'.");
    }
}