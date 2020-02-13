using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Comparables
{
    class Course : IComparable
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public Course(string name, int code) { Name = name; Code = code; }

        public int CompareTo(object obj)
        {
            return this.Code.CompareTo((obj as Course).Code);
        }
        public static IComparer SortByCourseName { get { return (IComparer)new CourseNameComparer(); } }
        public static IComparer SortByCourseCode { get { return (IComparer)new CourseCodeComparer(); } }
        public override string ToString()
        {
            return $"{Code} : {Name}";
        }
    }
}
