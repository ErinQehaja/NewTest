using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmiertest2
{
    public class Person
    {
        public string GenderPerson { get; set; }
        public DateTime DateOfBirth { get; }

        public Person(string gender, DateTime dateOfBirth)
        {
            GenderPerson = gender;
            DateOfBirth = dateOfBirth;
        }
    }
}
