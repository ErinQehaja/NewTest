using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmiertest2
{
    public class Student : Person
    {
        public string Class { get; set; }

        public Student(string gender, DateTime dateOfBirth, string schoolClass)
            : base(gender, dateOfBirth)
        {
            Class = schoolClass;
        }
    }
}