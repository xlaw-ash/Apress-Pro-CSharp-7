using System;

namespace Comparables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
                "----------------\n" +
                "Fun With Cloning\n" +
                "----------------\n"
            );

            // Add courses
            Course math = new Course("Math", 101);
            Course english = new Course("English", 102);
            Course science = new Course("Science", 103);
            Course history = new Course("History", 104);
            Course computers = new Course("Computers", 105);
            Course[] courses = new Course[] { math, science, computers, history, english };
            Console.WriteLine("Unsorted");
            foreach (Course course in courses) { Console.WriteLine(course.ToString()); }
            
            // How to sort these courses according to course code?
            // Use IComparable interface
            Console.WriteLine("Sorted");
            Array.Sort(courses);
            foreach (Course course in courses) { Console.WriteLine(course.ToString()); }

            // Suppose I want to implement using both name and code.
            // Use IComparer interface with a helper class. IComparer cannot be used for the class which you want to sort.
            Console.WriteLine("Sort by Name");
            Array.Sort(courses, new CourseNameComparer());
            foreach (Course course in courses) { Console.WriteLine(course.ToString()); }

            // Instead of passing new Comparer in Sort method, add a property in course to make sorting easier to understand.
            Console.WriteLine("Sort by Code");
            Array.Sort(courses, Course.SortByCourseCode);
            foreach (Course course in courses) { Console.WriteLine(course.ToString()); }
            Console.WriteLine("Sort by Name");
            Array.Sort(courses, Course.SortByCourseName);
            foreach (Course course in courses) { Console.WriteLine(course.ToString()); }

            Console.WriteLine
            (
                "\n--------------" +
                "\nEnd of Program" +
                "\n--------------"
            );
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
