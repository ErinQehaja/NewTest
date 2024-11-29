using ObjektorientierungBegining;
using System.Xml.Linq;

class Cat : Animal
{
    public string Color { get; set; }

    public Cat(string name, DateTime birthDate) : base(name, birthDate)
    {
    }

    public override string ToString()
    {
        return $"Name: {Name}, Farbe: {Color ?? "unbekannt"}, Alter: {Age()} Jahre";
    }
}