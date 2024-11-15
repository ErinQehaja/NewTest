using System;

namespace ObjektorientierungBeginnig
{
    class Cat
    {
        private DateTime _birthDate;

        public string? Color { get; set; }

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

        public Cat(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Farbe: {Color ?? "unbekannt"}, Alter: {Age} Jahre";
        }
    }
}
