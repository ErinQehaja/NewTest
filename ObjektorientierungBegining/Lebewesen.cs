using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektorientierungBegining
{
    class Lebewesen
    {
        public DateTime BirthDate { get; }

        public Lebewesen(DateTime birthDate)
        {
            BirthDate = birthDate;
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
