using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektorientierungBegining
{
    class Animal : Lebewesen
    {
        public string Name { get; }

        public Animal(string name, DateTime birthDate) : base(birthDate)
        {
            Name = name;
        }
    }
}