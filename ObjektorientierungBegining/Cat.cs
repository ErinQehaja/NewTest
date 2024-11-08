using System;

namespace ObjektorientierungBeginnig
{
    class Cat
    {
        private string? _color;
        private DateTime _birthDate;

        public string? Color
        {
            get { return _color; }
            set
            {
                if (_color == value) return;
                _color = value;
            }
        }

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
    }
}