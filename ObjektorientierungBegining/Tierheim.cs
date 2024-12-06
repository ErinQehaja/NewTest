using ObjektorientierungBegining;
using System;
using System.Collections.Generic;

namespace ObjektorientierungBeginnig
{
    class Tierheim 
    {
        public void DisplayAllAnimals()
        {
            if (Animal.AllAnimals.Count == 0)
            {
                Console.WriteLine("Das Tierheim hat keine Tiere.");
                return;
            }

            Console.WriteLine("Im Tierheim befinden sich folgende Tiere:");
            foreach (var animal in Animal.AllAnimals)
            {
                Console.WriteLine($"Name: {animal.Name}, Farbe: {animal.Color}, Alter: {animal.Age()} Jahre, Beine: {animal.AnzahlBeine}");
            }
        }

        public int NumberOfAnimals => Animal.AllAnimals.Count;

        public int NumberOfCats => Animal.AllAnimals.Where(a => a.GetType() == typeof(Cat)).Count();

        public int NumberOfDogs => Animal.AllAnimals.Where(a => a.GetType() == typeof(Dog)).Count();
    }
}