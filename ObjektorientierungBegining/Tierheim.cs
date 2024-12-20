using ObjektorientierungBegining;
using System;
using System.Collections.Generic;

namespace ObjektorientierungBeginnig
{
    public class Tierheim
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

        public double CalculateAverageAge()
        {
            if (Animal.AllAnimals.Count == 0)
            {
                Console.WriteLine("Das Tierheim hat keine Tiere, daher kann das Durchschnittsalter nicht berechnet werden.");
                return 0;
            }

            double averageAge = Animal.AllAnimals.Average(a => a.Age());
            Console.WriteLine($"Das Durchschnittsalter der Tiere im Tierheim beträgt {averageAge} Jahre.");
            return averageAge;
        }
    }
}