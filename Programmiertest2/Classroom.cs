﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmiertest2
{
    public class Classroom
    {
        public string NameRoom { get; set; }
        public double Size { get; set; } // Größe in Quadratmeter
        public int Capacity { get; set; } // Nummer der Sitze
        public bool HasCynap { get; set; }
        public List<Student> Students { get; private set; }

        public Classroom(string roomName, double size, int capacity, bool hasCynap)
        {
            NameRoom = roomName;
            Size = size;
            Capacity = capacity;
            HasCynap = hasCynap;
            Students = new List<Student>();
        }

        public bool AddStudent(Student student)
        {
            if (Students.Count >= Capacity)
            {
                return false; 
            }

            Students.Add(student);
            return true;
        }
    }
}
