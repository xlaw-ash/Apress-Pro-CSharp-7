using System;
using System.Collections.Generic;
using System.Text;

namespace LINQueries
{
    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int roll, string name, int grade) { RollNumber = roll; Name = name; Grade = grade; }
    }
}
