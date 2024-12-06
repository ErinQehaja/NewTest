using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjektorientierungBegining
{
    class Lebewesen
    {
        public DateTime BirthDate { get; }
        public string Name { get; }
        public string Color { get;}

        public Lebewesen(string name, DateTime birthDate, string color)
        {
            BirthDate = birthDate;
            Name = name;
            Color = color;
        }

        public int Age()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now < BirthDate.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
