using ObjektorientierungBegining;
using ObjektorientierungBeginnig;

class Program
{
    static void Main()
    {
        Console.WriteLine("Willkommen im Tierheim!");

        Tierheim meinTierheim = new Tierheim();

        Cat cat1 = new Cat("Kitty", new DateTime(2019, 5, 15), "schwarz");
        Cat cat2 = new Cat("Misty", new DateTime(2022, 8, 1), "grau");
        Dog dog1 = new Dog("Rex", new DateTime(2020, 3, 10), "braun");
        Dog dog2 = new Dog("Bella", new DateTime(2021, 7, 5), "weiß");

        meinTierheim.DisplayAllAnimals();
        Console.WriteLine($"Gesamtanzahl der Tiere: {meinTierheim.NumberOfAnimals}");
        Console.WriteLine($"Anzahl der Katzen: {meinTierheim.NumberOfCats}");
        Console.WriteLine($"Anzahl der Hunde: {meinTierheim.NumberOfDogs}");
    }
}