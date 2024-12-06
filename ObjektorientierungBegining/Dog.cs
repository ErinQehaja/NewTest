using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjektorientierungBegining;

public class Dog : Animal
    {
        public Dog(string name, DateTime birthDate, string color) : base(name, birthDate, color)
        {
            SetLegs("Quadrupedier");
        }

        public override void gibTypischenLautVonDir()
        {
            Console.WriteLine($"Der {Name} bellt 'Wuff'!");
        }
    }

