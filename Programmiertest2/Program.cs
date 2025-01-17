using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programmiertest2;

namespace Programmiertest2
{
    public class Program
    {
        public static void Main()
        {
            School mySchool = new School("HTL Dornbirn");

            Classroom room1 = new Classroom("185", 50.0, 30, true);
            Classroom room2 = new Classroom("247", 60.0, 25, false);

            mySchool.AddClassroom(room1);
            mySchool.AddClassroom(room2);

            Student student1 = new Student("Male", new DateTime(2007, 4, 14), "1A");
            Student student2 = new Student("Female", new DateTime(2006, 6, 23), "2B");

            mySchool.AddStudent(student1);
            mySchool.AddStudent(student2);

            room1.AddStudent(student1);
            room2.AddStudent(student2);

            Console.WriteLine($"School Name: {mySchool.Name}\n");

            foreach (var classroom in mySchool.Classrooms)
            {
                Console.WriteLine($"Classroom: {classroom.RoomName}");
                Console.WriteLine($"Size: {classroom.Size} m^2");
                Console.WriteLine($"Capacity: {classroom.Capacity}");
                Console.WriteLine($"Has Cynap: {classroom.HasCynap}");
                Console.WriteLine("Students:");

                foreach (var student in classroom.Students)
                {
                    Console.WriteLine($"- {student.PersonGender}, Born: {student.DateOfBirth.ToShortDateString()}, Class: {student.Class}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Total Students: {mySchool.GetTotalStudents()}");
            Console.WriteLine($"Male Students: {mySchool.GetStudentsByGender("Male")}");
            Console.WriteLine($"Female Students: {mySchool.GetStudentsByGender("Female")}");
            Console.WriteLine($"Total Classrooms: {mySchool.GetTotalClassrooms()}");
            Console.WriteLine($"Average Age of Students: {mySchool.GetAverageAge():F2} years\n");

            Console.WriteLine("Classrooms with Cynap:");
            foreach (var room in mySchool.GetClassroomsWithCynap())
            {
                Console.WriteLine($"- {room.RoomName}");

                Console.WriteLine();
            }

            Console.WriteLine($"Total Classes: {mySchool.GetTotalClasses()}");

            Console.WriteLine("Classes with Student Count:");
            foreach (var kvp in mySchool.GetClassesWithStudentCount())
            {
                Console.WriteLine($"Class {kvp.Key}: {kvp.Value} students");
            }

            string className = "1A";
            Console.WriteLine($"Female Percentage in Class {className}: {mySchool.GetFemalePercentageInClass(className):F2}%");

            string roomName = "185";
            Console.WriteLine($"Can Class {className} fit in Room {roomName}?: {mySchool.CanClassFitInRoom(className, roomName)}");
        }
    }
}