using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmiertest2
{
    public class School
    {
        public string Name { get; set; }
        public List<Student> Students { get; private set; }
        public List<Classroom> Classrooms { get; private set; }

        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
            Classrooms = new List<Classroom>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddClassroom(Classroom classroom)
        {
            Classrooms.Add(classroom);
        }

        public Classroom? GetClassroomForStudent(string studentClass)
        {
            return Classrooms.FirstOrDefault(c => c.Students.Any(s => s.Class == studentClass));
        }
    }
}
