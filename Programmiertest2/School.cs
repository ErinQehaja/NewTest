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

        public int GetTotalStudents()
        {
            return Students.Count;
        }

        public int GetStudentsByGender(string gender)
        {
            return Students.Count(s => s.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase));
        }

        public int GetTotalClassrooms()
        {
            return Classrooms.Count;
        }

        public double GetAverageAge()
        {
            if (!Students.Any()) return 0;

            var today = DateTime.Today;
            return Students.Average(s => (today - s.DateOfBirth).TotalDays / 365.25);
        }

        public List<Classroom> GetClassroomsWithCynap()
        {
            return Classrooms.Where(c => c.HasCynap).ToList();
        }
    }
}
