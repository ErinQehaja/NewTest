using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektorientierungBegining
{
    class Animal : Lebewesen
    {
        public int AnzahlBeine { get; private set; }

        public static List<Animal> AllAnimals { get; } = new List<Animal>();

        public Animal(string name, DateTime birthDate, string color)
            : base(name, birthDate, color)
        {
            AllAnimals.Add(this);
        }

        public void SetLegs(string tier)
        {
            if (tier == "Bipedalier") AnzahlBeine = 2;
            else if (tier == "Quadrupedier") AnzahlBeine = 4;
            else if (tier == "Apodier") AnzahlBeine = 0;
        }

        public virtual void gibTypischenLautVonDir()
        {
            Console.WriteLine("Das Tier gibt keinen typischen Laut von sich.");
        }
    }
}