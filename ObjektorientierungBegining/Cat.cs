using ObjektorientierungBegining;
using System.Xml.Linq;

class Cat : Animal
{
    private DateTime _birthDate;
    public string Color { get; set; }

    public int Age
    {
        get
        {
            int age = DateTime.Now.Year - _birthDate.Year;
            if (DateTime.Now < _birthDate.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }

    public Cat(string name, DateTime birthDate) : base(name)
    {
        _birthDate = birthDate;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Farbe: {Color ?? "unbekannt"}, Alter: {Age} Jahre";
    }
}