using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektorientierungBegining
{
    class Dog : Animal
    {
        public Dog(string name, DateTime birthDate, string color) : base(name, birthDate, color)
        {
            SetLegs("Quadrupedier");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Farbe: {Color}, Alter: {Age()} Jahre, Anzahl der Beine: {AnzahlBeine}";
        }

        public override void gibTypischenLautVonDir()
        {
            Console.WriteLine($"Der {Name} bellt 'Wuff'!");
        }
    }
}
