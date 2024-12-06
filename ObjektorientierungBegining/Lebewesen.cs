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
        private DateTime _birthDate { get; }
        public string Name { get; }
        public string Color { get; }

        public Lebewesen(string name, DateTime birthDate, string color)
        {
            _birthDate = birthDate;
            Name = name;
            Color = color;
        }

        public int Age()
        {
            int age = DateTime.Now.Year - _birthDate.Year;
            if (DateTime.Now < _birthDate.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
